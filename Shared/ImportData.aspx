<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ImportData.aspx.cs" Inherits="KumePortali.UI.ImportData" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>ImportData</title>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/BaseStyles.css"/>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/Styles.css"/>
     <base target="_self" />
    </head>
    <body id="Body1" runat="server" class="pBack">
    <form id="Form1" method="post" runat="server"><BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
        <BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
        <script language="JavaScript" type="text/javascript">clearRTL()</script>
        <script language='javascript' type='text/javascript'>function CloseWindow(msg){alert(msg);window.opener.__doPostBack('ChildWindowPostBack', ''); window.opener.focus();window.close();}</script>
		<asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" />
		
        <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
		  <table  cellpadding="0" cellspacing="0" border="0"><tr>
			<td class="pcTL"></td>
			<td class="pcT"></td>
			<td class="pcTR"></td>
		  </tr>
		  <tr>
			<td class="pcL"></td>
			<td class="pcC">
				<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr>
					<td class="dh">
						<table cellpadding="0" cellspacing="0" width="100%" border="0">
						
					<tr>
						<td class="dBody" style="width:100%; height:100%">			
							<table>
							<tr>
							<td>Select and assign the data columns you wish to import.
							</td>
							</tr>
							    <tr>
									<td><asp:checkbox id="ImportFirstRowCheckBox" runat="server" Text=""/>&nbsp;&nbsp;
									<!--<asp:label id="HeaderLabel" runat="server" text="Check here if you would like the first row of the selected CSV file to be imported to the database."/>&nbsp;-->
									<!--<asp:Label runat="server" id="FirstRowCheckBoxLabel">
		</asp:Label></td>-->
									
								</td></tr>
								<tr><td>
										<asp:Table id="DisplayTable" runat="server" CellSpacing=0 CellPadding=3	GridLines="Both" BorderStyle="Solid" BorderWidth="1" CssClass="ttc">
										</asp:Table>
									</td>
								</tr>
								
								<!--<tr>
								<td>
									<asp:label id="Label2" runat="server" text="Select if you would like to update the existing records based on :" />&nbsp;
									<asp:DropDownList ID="ColumnsList" runat="server" CssClass="fili"/>
								</td>
								</tr>-->
								
							</table>
							<table>
								<tr>
									<td><KumePortali:ThemeButton runat="server" id="PreviousButton" Button-Text="&lt;%# GetResourceValue(&quot;Import:Previous&quot;, &quot;KumePortali&quot;) %>" Button-ToolTip="&lt;%# GetResourceValue(&quot;Import:Previous&quot;, &quot;KumePortali&quot;) %>">
		</KumePortali:ThemeButton></td>
									
									<td><KumePortali:ThemeButton runat="server" id="ImportButton" Button-Text="&lt;%# GetResourceValue(&quot;Import:Import&quot;, &quot;KumePortali&quot;) %>" Button-ToolTip="&lt;%# GetResourceValue(&quot;Import:Import&quot;, &quot;KumePortali&quot;) %>">
		</KumePortali:ThemeButton></td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		  	<td class="pcR"></td>
		  </tr>
		  <tr>
		  	<td class="pcBL"></td>
		  	<td class="pcB"></td>
		  	<td class="pcBR"></td>
		  </tr>
		  </table>
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary></form>
    </body>
</html>
