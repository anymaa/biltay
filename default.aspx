<%@ Page Language="cs" AutoEventWireup="false" Inherits="BaseClasses.Web.UI.GenericPage" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Import NameSpace="BaseClasses.Configuration" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Default Page</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<BaseClasses:BasePageSettings id="PageSettings" runat="server" LoginRequired=""></BaseClasses:BasePageSettings>
<%
	if ((this.Request.ServerVariables["SERVER_PORT"] == "80") &&
	    ("" + ApplicationSettings.Current.GetAppSetting(ApplicationSettings.ConfigurationKey.WebServer)).ToLower().StartsWith("https:") 
	)
	{
	}
	else
	{
	    Response.Redirect(ApplicationSettings.Current.DefaultPageUrl);
	}
%>
		</form>
	</body>
</HTML>
