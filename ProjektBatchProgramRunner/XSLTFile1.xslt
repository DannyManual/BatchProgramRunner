<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

  <!-- Wurzelelement transformieren -->
  <xsl:template match="/NewDataSet">
    <html>
      <head>
        <title>Template List</title>
        <style>
          table { border-collapse: collapse; }
          td, th { border: 1px solid #aaa; padding: 4px; }
        </style>
      </head>
      <body>
        <h1>Templates</h1>
        <xsl:for-each select="dtCommandTemplates">
          <h2>
            <xsl:value-of select="@Name"/>
          </h2>
          <table>
            <tr>
              <th>Parameter</th>
              <th>Wert</th>
            </tr>
            <xsl:for-each select="dtAssignedParams">
              <tr>
                <td>
                  <xsl:value-of select="Param"/>
                </td>
                <td>
                  <xsl:value-of select="Value"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>

