<html>
 <head>
  <title>SQL Server Connection Test Results</title>
   <script src="OnlineHelp.js" language="javascript" type="text/javascript"></script>
</head>

<link rel="stylesheet" rev="stylesheet" type="text/css" href="TestConfiguration.css">

<%@ Page Language="vb" AutoEventWireup="false"  Debug="true" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
	<script language="VB" runat="server">
	    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

			'=============================================================================================
			' CHANGE ONLY THE FOLLOWING SIX STRINGS
			'=============================================================================================
			Dim ServerName As String =		"(local)"
	        Dim DatabaseName As String =	"Northwind"
	        Dim Trusted As String =			"no"				' "yes" if using Windows Authentication
	        Dim UserId As String =			"sa"
	        Dim Password As String =		""
	        Dim SQLQuery As String =		"SELECT TOP 5 * FROM "
	        Dim TableName As String = 		"Customer"
			'=============================================================================================
			'=============================================================================================

			If Request.QueryString("server") <> "" Then
				ServerName = Request.QueryString("server")
			End If

			If Request.QueryString("database") <> "" Then
				DatabaseName = Request.QueryString("database")
			End If

			If Request.QueryString("trusted") <> "" Then
				Trusted = Request.QueryString("trusted")
			End If

			If Request.QueryString("user") <> "" Then
				UserId = Request.QueryString("user")
			End If

			If Request.QueryString("password") <> "" Then
				Password = Request.QueryString("password")
			End If

			If Request.QueryString("table") <> "" Then
				TableName = "[" & Request.QueryString("table") & "]"
			End If

			SQLQuery += TableName

			ServerNameLabel.Text = ServerName
			DatabaseNameLabel.Text = DatabaseName
			TableNameLabel.Text = TableName

			' EVERYTHING BELOW SHOULD WORK AS IS WITHOUT ANY CHANGES

	        ' Use a string variable to hold the ConnectionString.
			Dim connectString As String = "Provider=SQLOLEDB;" & _
						"Data Source=" & ServerName & ";" & _
						"Database=" & DatabaseName & ";" & _
						"Trusted_Connection=" & Trusted & ";" & _
						"User Id=" & UserId & ";" & _
						"Password=" & Password & ";"

	        ' Create an OleDbConnection object,
	        ' and then pass in the ConnectionString to the constructor.
	        Dim cn As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection(connectString)

	        'Open the connection.
	        cn.Open()

	        ' Create an OleDbCommand object.
	        ' Notice that this line passes in the SQL statement and the OleDbConnection object.
	        Dim cmd As System.Data.OleDb.OleDbCommand = New System.Data.OleDb.OleDbCommand(SQLQuery, cn)

	        ' Send the CommandText to the connection, and then build an OleDbDataReader.
	        ' Note: The OleDbDataReader is forward-only.
	        Dim reader As System.Data.OleDb.OleDbDataReader = cmd.ExecuteReader()

	        ' Loop through the resultant data selection and add the data value
	        ' for each respective column in the table.
	        Dim r As Integer
	        For r = 1 to 5
				If (reader.Read()) Then
					Dim row As TableRow = New TableRow
					Dim cell As TableCell

					cell = New TableCell
					cell.Text = "<b>" & r & "</b>"
					row.Cells.Add(cell)

					Dim c As Integer
					For c = 0 To reader.FieldCount-1
						cell = New TableCell
						cell.Text = reader(c).ToString()
						row.Cells.Add(cell)
					Next c

					'Add the new row to the table.
					DisplayTable.Rows.Add(row)
	            End If

	        Next r

	        Result.Text = "Test Successful!"

	        ' Close the reader and the related connection.
	        reader.Close()
	        cn.Close()
	    End Sub

	</script>

<body MS_POSITIONING="GridLayout" link="#0000FF" vlink="#0000FF" alink="#0000FF">

<form id="Form1" method="post" runat="server">

<table cellpadding=3, cellspacing=0 border=0>
 <tr>
  <td class="page_heading">
	<b><asp:label id="Result" runat="server" Text="Test Failed"/></b><br><br>
  </td>
 </tr>
 <tr>
  <td>
	Check to make sure up to five rows of data are displayed from your Microsoft SQL Server database.
  </td>
 </tr>
 <tr>
  <td>
	Server name: <asp:Label Id="ServerNameLabel" runat="server"/><br>
	Database name: <asp:Label Id="DatabaseNameLabel" runat="server"/><br>
	Database Table: <asp:Label Id="TableNameLabel" runat="server"/>
	<br><br>
  </td>
 </tr>

 <tr>
  <td>
	<asp:Table id="DisplayTable" runat="server" CellSpacing=0 CellPadding=3
			GridLines="Both"
    		BorderStyle="Solid"
			BorderWidth="1"></asp:Table>
  </td>
 </tr>
 <tr>
  <td>
	<input type=button value="Close Window" onClick="javascript:window.close();">
  </td>
 </tr>
</table>

</form>

</body>

</html>