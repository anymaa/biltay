<!--
Test Failed.

We tested whether you can execute a very simple ASPX page containing
a Response.Write statement.

If you see this text displayed in your browser window, it means that
this test has failed.  Go back to the previous window and look at
possible fixes for this problem.
-->
<%@ Page Language="cs" AutoEventWireup="false"  Debug="true" %>

<html>
 <head>
  <title>Run ASPX Test Results</title>
  <script src="OnlineHelp.js" language="javascript" type="text/javascript"></script>
 </head>

<link rel="stylesheet" rev="stylesheet" type="text/css" href="TestConfiguration.css">

<body link="#0000FF" vlink="#0000FF" alink="#0000FF">

<table cellpadding=3, cellspacing=0 border=0 width=600>
 <tr>
  <td>
  <%
   Response.Write("Testing Microsoft .NET Framework...");
  %>
  <br><br>
  </td>
 </tr>
 <tr>
  <td class="page_heading">
  <%
   if (Request.Browser.Type.StartsWith("IE")) {
   	   // Internet Explorer
	   if ((Request.Browser.ClrVersion.ToString().StartsWith("2.0.50727") 
	        || Request.Browser.ClrVersion.ToString().StartsWith("3.0.4506") || Request.Browser.ClrVersion.ToString().StartsWith("3.5.21022")) &&
		  ((Request.Browser.MajorVersion >= 5 && Request.Browser.MinorVersion >= 5) ||
		   Request.Browser.MajorVersion >= 6)) {
		   Response.Write("Test Successful!");
		   Response.Write("<br><br>The primary version of the Microsoft .NET Framework installed on your system is " +
					Request.Browser.ClrVersion.ToString());
	   } else {
	       Response.Write("<span class=\"description_node\">");
		   Response.Write("<font color=\"red\"><b>Test Failed.</b></font><br><br>");
		   if (!Request.Browser.ClrVersion.ToString().StartsWith("2.0.50727") 
		        && !Request.Browser.ClrVersion.ToString().StartsWith("3.0.4506") && !Request.Browser.ClrVersion.ToString().StartsWith("3.5.21022") ) {
			   Response.Write("The primary version of the Microsoft .NET Framework installed on your system is " +
					Request.Browser.ClrVersion.ToString() +
					".<br><br>Applications created with Iron Speed Designer currently require either " +
					"Microsoft .NET Framework 2.0 (2.0.50727), or<br>" +
					"Microsoft .NET Framework 3.0 (3.0.4506), or<br>" +
					"Microsoft .NET Framework 3.5 (3.5.21022).");
		   }
		   if (!((Request.Browser.MajorVersion >= 5 && Request.Browser.MinorVersion >= 5) ||
				 Request.Browser.MajorVersion >= 6)) {
				Response.Write("The version of the browser you are using is." + Request.Browser.Version + "<br>");
		   }
		   Response.Write("</span>");
	   }
	} else {
		// Firefox, Netscape or some other browser.
		Response.Write("Test Successful!");
        Response.Write("<br><br><span class=\"description_node\">");
        Response.Write("It seems you are using a browser other than Microsoft Internet Explorer.<br>");
        Response.Write("It seems you can run .NET applications, but we could not test your specific version of Microsoft .NET Framework.<br>");
        Response.Write("If you encounter problems, please try the Version Check utility on the previous page.<br>");
  	    Response.Write("</span>");

	}
  %>
  <br><br>
  </td>
 </tr>
 <tr>
  <td>
	.NET Framework Version (Client): <%=Request.Browser.ClrVersion%>
	<br>
	Browser Version: <%=Request.Browser.Version%>
	<br>
	Operating System: <%=Request.Browser.Platform%>
	<br>
	Browser String: <%=Request.ServerVariables["http_user_agent"]%>
	<br>
	Browser Language: <%=Request.ServerVariables["http_accept_language"]%>
	<br>
	Browser Type: <%=Request.Browser.Type %>
	<br>
	Browser Beta: <%=Request.Browser.Beta%>
	<br>
	Supports ActiveX controls: <%=Request.Browser.ActiveXControls %>
	<br>
	Supports Cookies: <%=Request.Browser.Cookies%>
	<br>
	Supports Frames: <%=Request.Browser.Frames%>
	<br>
	Supports HTML Tables: <%=Request.Browser.Tables%>
	<br>
	Supports Java Applets: <%=Request.Browser.JavaApplets%>
	<br>
	Supports Java Scripts: <%=Request.Browser.EcmaScriptVersion%>
	<br>
	Supports MS DOM Version: <%=Request.Browser.MSDomVersion%>
	<br><br>
  </td>
 </tr>
 <tr>
  <td>
	<input type=button value="Close Window" onClick="javascript:window.close();">
  </td>
 </tr>
</table>

</body>

</html>