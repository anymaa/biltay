
<html>
 <head>
  <title>Oracle Connection Test</title>
  <script src="OnlineHelp.js" language="javascript" type="text/javascript"></script>
  <script language="javascript">
   <!--
	function DoTest4() {
		if (document.getElementById('TrustedConnection_0').checked) trusted = "yes"
		else trusted = "no"

		url = "Test4Do.aspx?server=" + document.forms[0]['ServerName'].value +
          		"&database="+ document.forms[0]['DatabaseName'].value +
          		"&trusted=" + trusted +
          		"&user=" + document.forms[0]['UserName'].value +
          		"&password=" + document.forms[0]['Password'].value +
          		"&table=" + document.forms[0]['TableName'].value
		newwindow = window.open(url,'name','height=500,width=650,left=100,top=100,scrollbars=yes,resizable=yes');
		if (window.focus) {newwindow.focus()}
		return false;
	}
	-->
  </script>

 </head>
<link rel="stylesheet" rev="stylesheet" type="text/css" href="TestConfiguration.css">

<body link="#0000FF" vlink="#0000FF" alink="#0000FF">
<form id="Form1" method="post" runat="server">


<table cellpadding=3, cellspacing=0 border=0 width=640>
 <tr>
  <td class="page_heading">
   Oracle Connection Test
  </td>
 </tr>
 <tr>
  <td>
   This test is to ensure that your application can connect to an Oracle database.
   <p>
   Please provide the Oracle net service Name, schema name, whether to use Windows Authentication, user name, password and the name of a table.
   <p>
  </td>
 </tr>
 <tr>
  <td>
   <table>
    <tr>
     <td width=140 style="text-align:right">Server Name</td>
     <td width=200><asp:textbox id="ServerName" runat="server" Text="" CssClass="description_node"/></td>
     <td width=300>Oracle Net Service Name.</td>
    </tr>
    <tr>
     <td style="text-align:right">Schema Name</td>
     <td><asp:textbox id="DatabaseName" runat="server" Text="Northwind" CssClass="description_node"/></td>
     <td>If schema name is a reserved word or contains spaces, it must be enclosed in quotes and is case-sensitive.</td>
    </tr>
    <tr>
     <td style="text-align:right;">Trusted Connection</td>
     <td>
     	<asp:RadioButtonList id="TrustedConnection" runat="server">
            <asp:ListItem Value="yes">Windows Authentication</asp:ListItem>
            <asp:ListItem Value="no" selected="True">Oracle user name/password</asp:ListItem>
         </asp:RadioButtonList>
	 </td>
     <td></td>
    </tr>
    <tr>
     <td style="text-align:right">User Name</td>
     <td><asp:textbox id="UserName" runat="server" Text="" CssClass="description_node"/></td>
     <td>When using Oracle user name/password.</td>
    </tr>
    <tr>
     <td style="text-align:right">Password</td>
     <td><asp:textbox id="Password" runat="server" TextMode="Password" CssClass="description_node"/></td>
     <td>When using Oracle user name/password.</td>
    </tr>
    <tr>
     <td style="text-align:right">Table Name</td>
     <td><asp:textbox id="TableName" runat="server" Text="Products" CssClass="description_node"/></td>
     <td>(e.g., Products).  First 5 rows will be displayed from this table.   If table name is a reserved word or contains spaces, it must be enclosed in quotes and is case-sensitive.</td>
    </tr>
   </table>
  </td>
 </tr>
 <tr>
  <td>
   <input type="submit" value="Run Oracle Connection Test Now" onClick="return DoTest4();" />
  </td>
 </tr>
</table>

</form>
<form name="gsr" method="GET" action="http://search.ironspeed.com/search" target="_blank">

<table cellpadding=3, cellspacing=0 border=0 width=600>
 <tr>
  <td>
   <ul>
    <li>
     <b>Test Successful?</b>
     <br>
     You have completed these tests.  <a href="../default.aspx" target="_blank">Run your application</a> now
     and if you continue to have problems, <a href="http://www.ironspeed.com/Support1/Case/AddCaseFromDesigner.aspx" target="_blank">submit a support case</a>.  Please include a screen shot of the error message.
    </li>
    <li>
     <b>Errors?  Is it one of these?</b>
      <br>
      <a href="#" onclick="ShowHelp('Part_VI/_OraOLEDB_Oracle_provider_is_not_registered.htm');return false;">OraOLEDB.Oracle' provider is not registered</a><br>
      <a href="#" onclick="ShowHelp('Part_VI/System_Data_OracleClient_requires_Oracle_client_software.htm');return false;">System.Data.OracleClient requires Oracle client software version 8.1.7 or greater</a><br>
      <a href="#" onclick="ShowHelp('Part_VI/ORA_12154_TNS_could_not_resolve_service_name.htm');return false;">ORA-12154: TNS:could not resolve service name</a><br>
    </li>
    <li>
     <b>Can't find your error message?</b><br>
      <a href="#" onclick="ShowHelp('Part_VI/Application_Runs_But_No_Data_is_Displayed.htm#Application_Runs_But_No');return false;">Lookup additional error messages...</a>
      <br><br>
      Search our knowledge base:
		<!-- Search -->
			<input type="text" name="q" size="25" maxlength="255" value="" class="description_node"/>
			<input type="submit" name="btnI" value="Search"/>
			<input type="hidden" name="site" value="c1">
			<input type="hidden" name="output" value="xml_no_dtd">
			<input type="hidden" name="client" value="c1">
			<input type="hidden" name="restrict" value="AllHelp">
			<input type="hidden" name="proxystylesheet" value="http://www.ironspeed.com/search/kbstyle.xsl">
		<!-- End Search -->
    </li>
    <li>
     <b>Still having problems?</b>
     <br>
     <a href="http://www.ironspeed.com/Support1/Case/AddCaseFromDesigner.aspx" target="_blank">Submit a Support Case</a>.  Please include a screen shot of the error message.
    </li>
   </ul>
  </td>
 </tr>

</table>

</form>


</body>

</html>