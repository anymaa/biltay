<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="SelectFileToImport.aspx.cs" Inherits="KumePortali.UI.SelectFileToImport" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>SelectFileToImport</title>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/BaseStyles.css"/>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/Styles.css"/>
     <base target="_self" />
    </head>
    <body id="Body1" runat="server" class="pBack">
    <form id="Form1" method="post" runat="server"><BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
        <BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
        <script language="JavaScript" type="text/javascript">clearRTL()</script>
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
				<table class="dv" cellpadding="0" cellspacing="0" border="0">
					<tr>
						<td class="dBody" style="width:100%; height:100%">			
							<table>
							<tr>
								<td><asp:Label runat="server" id="InfoLabel">
		</asp:Label></td>
								
							</tr>
							<tr><td><INPUT type="file" id="InputFile" name="InputFile" runat="server" size="80" /></td><td></td></tr>
							
							</table>
							<table>
							<tr>
								
								<td><KumePortali:ThemeButton runat="server" id="NextButton" Button-Text="&lt;%# GetResourceValue(&quot;Import:Next&quot;, &quot;KumePortali&quot;) %>" Button-ToolTip="&lt;%# GetResourceValue(&quot;Import:Next&quot;, &quot;KumePortali&quot;) %>">
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
