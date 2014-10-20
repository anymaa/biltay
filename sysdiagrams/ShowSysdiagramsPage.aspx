<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ShowSysdiagramsPage.aspx.cs" Culture="tr-TR" Inherits="KumePortali.UI.ShowSysdiagramsPage" %>
<%@ Register Tagprefix="KumePortali" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="KumePortali" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="KumePortali" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.ShowSysdiagramsPage" %>

<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title><asp:Literal runat="server" id="PageTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Show&quot;, &quot;KumePortali&quot;),&quot; Sysdiagrams&quot;) %>">
</asp:Literal></title>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/BaseStyles.css"/>
    </head>
    <body id="Body1" runat="server" class="pBack">
    <form id="Form1" method="post" runat="server"><BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
        <BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
        <script language="JavaScript" type="text/javascript">clearRTL()</script>
		<asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" EnableScriptGlobalization="True" EnableScriptLocalization="True" />
		
        <table cellspacing="0" cellpadding="0" border="0" height="100%" width="100%">
        <tr>
        <td class="pAlign">
        <table cellspacing="0" cellpadding="0" border="0" class="pbTable">
            <tr>
            <td class="pbTL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbT"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbTR"><img src="../Images/space.gif" alt=""/></td>
            </tr>
            <tr>
            <td class="pbL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbC">
            <table cellspacing="0" cellpadding="0" border="0" class="pcTable">
            <tr>
                <td class="pcT" colspan="2">
                <table cellspacing="0" cellpadding="0" border="0" width="100%">
                <tr>
                <td>
                </td>
            </tr>
            </table>
            <table cellspacing="0" cellpadding="0" border="0" width="100%">
            <tr>
            <td><KumePortali:Header runat="server" id="PageHeader">
		</KumePortali:Header></td>
            </tr>
            </table>
            </td>
            <td class="pcTR"></td>
            </tr>
            <tr>
                <td class="pcL">
                    <KumePortali:Menu runat="server" id="MenuV" HiliteSettings="SysdiagramsMenuItem">
		</KumePortali:Menu></td>
                <td class="pcC">
                <table cellspacing="0" cellpadding="0" border="0" width="100%" height="100%">
                <tr>
                <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr>
                        <td class="pContent">
                            <a name="StartOfPageContent"></a>
<asp:UpdateProgress runat="server" id="SysdiagramsRecordControlUpdateProgress" AssociatedUpdatePanelID="SysdiagramsRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif" alt="">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="SysdiagramsRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<KumePortali:SysdiagramsRecordControl runat="server" id="SysdiagramsRecordControl">
														
<!-- Begin Record Panel.html -->

 <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SaveButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("CancelButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("OKButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SaveNNewButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("EditButton$_Button")) %>

    <table class="dv" cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td class="dh">
    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td class="dhel"><img src="../Images/space.gif" alt=""/></td><td class="dhb">
    <table cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="SysdiagramsTitle" Text="Show Sysdiagrams">
														</asp:Literal></td>
    </tr>
    </table>
    </td>
    <td class="dher"><img src="../Images/space.gif" alt=""/></td>
    </tr>
    </table>
    </td>
    </tr><tr>
        <td>
        <table class="dBody" id="CollapsibleRegion" style="display:;" cellpadding="0" cellspacing="0" border="0" width="100%">
        <tr>
        <td>
        <table id="FilterRegion" cellpadding="0" cellspacing="3" border="0"></table>
    <div class="spacer"></div></td>
    </tr>
    <tr><td>
    <table cellpadding="0" cellspacing="3" border="0">
            <tr>
            <td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="name">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="principal_idLabel" Text="Principal ID">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="principal_id">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="versionLabel" Text="Version">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="version">
														</asp:Literal></td>
            </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("OKButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("CancelButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SaveButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SaveNNewButton$_Button")) %>
 <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("EditButton$_Button")) %>
 <!-- End Record Panel.html -->
 
											</KumePortali:SysdiagramsRecordControl>
											</ContentTemplate>
										</asp:UpdatePanel>
									
                                    
                                    <table cellpadding="0" cellspacing="0" border="0" id="Table1">
                                        <tr>
                                        <td class="recordPanelButtonsAlignment">
                                        <table cellpadding="0" cellspacing="0" border="0">
                                        <tr>
                                        <td><KumePortali:ThemeButton runat="server" id="OKButton" Button-CausesValidation="false" Button-CommandName="Redirect" Button-RedirectURL="Back" Button-Text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;KumePortali&quot;) %>">
										</KumePortali:ThemeButton></td>
                                        <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
                                        <td></td>
                                        <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
                                        <td></td>
                                        <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
                                        <td></td>
                                        <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
                                        <td></td>
                                        <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
                                        </tr>
                                        </table>
                                        </td>
                                        </tr>
                                    </table>
                                    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                        </td>
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
                <td class="pcB">
                <KumePortali:Footer runat="server" id="PageFooter">
									</KumePortali:Footer></td>
                <td class="pcBR"></td>
            </tr>
            </table>
            </td>
            <td class="pbR"><img src="../Images/space.gif" alt=""/></td>
            </tr>
            <tr>
            <td class="pbBL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbB"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbBR"><img src="../Images/space.gif" alt=""/></td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary></form>
    </body>
</html>
