<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>  <body>
			<h1>Persons</h1>
			<table border="1">
				<tr style="font-size: 15pt"> 
					<td><b>First Name </b></td>
					<td><b>Last Name </b></td> 
					<td><b>Id</b></td> 
					<td><b>Password</b></td> 
					<td><b>Work</b></td> 
					<td><b>Cell</b></td>
					<td><b>Category</b></td>
				</tr>
				<xsl:for-each select="Persons/Person">
					<xsl:sort select="Name" />
					<tr style="font-size: 10pt; font-family: verdana">
					<xsl:for-each select="Name">
						<td><xsl:value-of select="First"/>&#160;</td>
						<td><xsl:value-of select="Last"/>&#160;</td>									
					</xsl:for-each>
					<xsl:for-each select="Credential">
						<td><xsl:value-of select="Id"/>&#160;</td>
						<td><xsl:value-of select="Password"/>&#160;</td>
					</xsl:for-each>
					<xsl:for-each select="Phone">
						<td><xsl:value-of select="Work"/>&#160;</td>
						<td><xsl:value-of select="Cell"/>&#160;</td>
					</xsl:for-each>
						<td><xsl:value-of select="Category"/>&#160;</td>
					</tr>
				</xsl:for-each>
			</table>
		</body> </html>
	</xsl:template>
</xsl:stylesheet>