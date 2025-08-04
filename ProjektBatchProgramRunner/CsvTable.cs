using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


public class CsvTable<T> : IList<T> where T : class, new()
{
    private readonly string filePath;
    private readonly char delimiter;
    private readonly List<T> data;

    public CsvTable(string filePath, char delimiter = ';')
    {
        this.filePath = filePath;
        this.delimiter = delimiter;
        if (File.Exists(filePath)) Load();
    }

    private void Load()
    {
        
        var lines = File.ReadAllLines(filePath);
        if (lines.Length == 0) return;
        string[] headers = lines[0].Split(delimiter);
        PropertyInfo[] props = typeof(T).GetProperties();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(delimiter);
            T obj = new T();
            for (int j = 0; j < headers.Length; j++)
            {
                var prop = props.FirstOrDefault(p => p.Name.Equals(headers[j], StringComparison.OrdinalIgnoreCase));
                if (prop != null && j < values.Length)
                {
                    object value = Convert.ChangeType(values[j], prop.PropertyType);
                    prop.SetValue(obj, value);
                }
            }
            data.Add(obj);
        }
    }

    public void Save()
    {
        var props = typeof(T).GetProperties();
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(string.Join(delimiter, props.Select(p => p.Name)));
        foreach (var record in data)
        {
            var vals = props.Select(p => p.GetValue(record, null)?.ToString() ?? "");
            writer.WriteLine(string.Join(delimiter, vals));
        }
    }

    // IList<T> Implementierung
    public int Count => data.Count;
    public bool IsReadOnly => false;
    public T this[int index] { get => data[index]; set => data[index] = value; }
    public void Add(T item) => data.Add(item);
    public void Clear() => data.Clear();
    public bool Contains(T item) => data.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => data.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => data.GetEnumerator();
    public int IndexOf(T item) => data.IndexOf(item);
    public void Insert(int index, T item) => data.Insert(index, item);
    public bool Remove(T item) => data.Remove(item);
    public void RemoveAt(int index) => data.RemoveAt(index);
    IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
}
