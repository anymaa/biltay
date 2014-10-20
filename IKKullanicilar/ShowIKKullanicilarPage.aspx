<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.ShowIKKullanicilarPage" %>

<%@ Register Tagprefix="KumePortali" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="KumePortali" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ShowIKKullanicilarPage.aspx.cs" Culture="tr-TR" Inherits="KumePortali.UI.ShowIKKullanicilarPage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="KumePortali" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="KumePortali" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title><asp:Literal runat="server" id="PageTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Show&quot;, &quot;KumePortali&quot;),&quot; IK Kullanicilar&quot;) %>">
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
                    <KumePortali:Menu runat="server" id="MenuV" HiliteSettings="IKKullanicilarMenuItem">
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
<asp:UpdateProgress runat="server" id="IKKullanicilarRecordControlUpdateProgress" AssociatedUpdatePanelID="IKKullanicilarRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif" alt="">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="IKKullanicilarRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<KumePortali:IKKullanicilarRecordControl runat="server" id="IKKullanicilarRecordControl">
														
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
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="IKKullanicilarTitle" Text="Show IK Kullanicilar">
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
            <td class="fls"><asp:Literal runat="server" id="AdiLabel" Text="Adı">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="Adi">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="SoyadiLabel" Text="Soyadı">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="Soyadi">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="EpostaLabel" Text="e-Posta">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="Eposta">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="GSMLabel" Text="GSM">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="GSM">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="FirmaIDLabel" Text="Firma Adı">
														</asp:Literal></td>
            <td class="dfv"><asp:LinkButton runat="server" id="FirmaID" CausesValidation="False" CommandName="Redirect" RedirectURL="../MIYSAHesaplar/ShowMIYSAHesaplarPage.aspx?MIYSAHesaplar={IKKullanicilarRecordControl:FK:FK_IKKullanicilar_Firma}">
														</asp:LinkButton></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="UnvanIDLabel" Text="Unvanı">
														</asp:Literal></td>
            <td class="dfv"><asp:LinkButton runat="server" id="UnvanID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKUnvanlar/ShowIKUnvanlarPage.aspx?IKUnvanlar={IKKullanicilarRecordControl:FK:FK_IKKullanicilar_IKUnvanlar}">
														</asp:LinkButton></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="YetkiTurIDLabel" Text="Yetki Türü">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="YetkiTurID">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="HesapIDLabel" Text="Hesap ID">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="HesapID">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="TCKimlikNoLabel" Text="TC Kimlik No">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="TCKimlikNo">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="IsTelefonuLabel" Text="İş Telefonu">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="IsTelefonu">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="KullaniciAdiLabel" Text="Kullanici Adi">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="KullaniciAdi">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="OlusturmaTarihiLabel" Text="Oluşturma Tarihi">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="OlusturmaTarihi">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="OlusturanIDLabel" Text="Oluşturan">
														</asp:Literal></td>
            <td class="dfv"><asp:LinkButton runat="server" id="OlusturanID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarRecordControl:FK:FK_IKKullanicilar_IKKullanicilar}">
														</asp:LinkButton></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="DuzenlenmeTarihiLabel" Text="Duzenlenme Tarihi">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="DuzenlenmeTarihi">
														</asp:Literal></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="DuzenleyenIDLabel" Text="Duzenleyen ID">
														</asp:Literal></td>
            <td class="dfv"><asp:LinkButton runat="server" id="DuzenleyenID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarRecordControl:FK:FK_IKKullanicilar_IKKullanicilar1}">
														</asp:LinkButton></td>
            </tr>
            <tr>
            <td class="fls"><asp:Literal runat="server" id="AktifPasifLabel" Text="Aktif Pasif">
														</asp:Literal></td>
            <td class="dfv"><asp:Literal runat="server" id="AktifPasif">
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
 
											</KumePortali:IKKullanicilarRecordControl>
											</ContentTemplate>
										</asp:UpdatePanel>
									
    <asp:TabContainer runat="server" id="IKKullanicilarTabContainer">
											
    <asp:TabPanel runat="server" id="HaberlerTabPanel" HeaderText="Haberler">
																<ContentTemplate>
    <table>
    <tr>
    <td>
<asp:UpdateProgress runat="server" id="HaberlerTableControlUpdateProgress" AssociatedUpdatePanelID="HaberlerTableControlUpdatePanel">
																									<ProgressTemplate>
																										<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
																										</div>
																										<div style=" position:absolute; padding:30px;">
																											<img src="../Images/updating.gif" alt="">
																										</div>
																									</ProgressTemplate>
																								</asp:UpdateProgress>
																								<asp:UpdatePanel runat="server" id="HaberlerTableControlUpdatePanel" UpdateMode="Conditional">

																									<ContentTemplate>
																										<KumePortali:HaberlerTableControl runat="server" id="HaberlerTableControl">
																													
    <!-- Begin Table Panel.html -->

    <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr>
    <td class="dhtrc">
        <table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td class="dhtrct"><asp:Label runat="server" id="HaberlerTotalItems">
																													</asp:Label></td>
        </tr>
        </table>
    </td>
    </tr><tr>
        <td class="dBody">
        <table id="CollapsibleRegion" style="display:;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td>
        <table id="FilterRegion" cellpadding="0" cellspacing="3" border="0"></table>
        <div class="spacer"></div>
        <!-- Category Area -->
        <table cellspacing="0" cellpadding="0" border="0" width="100%">
        <tr>
        <td>
            <table cellspacing="0" cellpadding="0" border="0" width="100%">
            <tr>
            <td>
            <table cellpadding="0" cellspacing="0" border="0"><tr>
            <!-- Pagination Area -->
            <td class="pr" colspan="100">
            <table id="PaginationRegion" cellspacing="0" cellpadding="0" border="0">
            <tr>
            <td><img src="../Images/paginationRowEdgeL.gif" alt=""/></td>
            <td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt=""/></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerNewButton" CausesValidation="false" CommandName="Redirect" Consumers="page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../Haberler/AddHaberlerPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																														</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerDeleteButton" CausesValidation="false" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="HaberlerTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																														</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerExportExcelButton" CausesValidation="false" CommandName="ExportDataExcel" Consumers="HaberlerTableControl" ImageURL="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																														</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerRefreshButton" CausesValidation="false" CommandName="ResetData" Consumers="HaberlerTableControl" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																														</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerResetButton" CausesValidation="false" CommandName="ResetFilters" Consumers="HaberlerTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																														</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt=""/></td>
            <td class="pra"><KumePortali:Pagination runat="server" id="HaberlerPagination">
																													</KumePortali:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt=""/></td>
            </tr>
            </table>
            </td>
            </tr><!--Table View Area -->
            <tr>
            <td class="tre">
            <table cellspacing="0" cellpadding="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)">
            <!-- This is the table's header row -->
            
            <div id="AJAXUpdateHeaderRow">
            <tr class="tch">
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th><th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="HaberlerToggleAll" onclick="toggleAllCheckboxes(this);">

																														</asp:CheckBox></th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberBaslikLabel1" Text="Haber Baslik" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberBaslikENLabel" Text="Haber Baslik EN" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberOnYaziLabel" Text="Haber On Yazi" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberOnYaziENLabel" Text="Haber On Yazi EN" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:Literal runat="server" id="HaberIcerikLabel" Text="Haber Icerik">
																														</asp:Literal>
            </th>
            <th class="thc" scope="col"><asp:Literal runat="server" id="HaberIcerikENLabel" Text="Haber Icerik EN">
																														</asp:Literal>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberAktifLabel" Text="Haber Aktif" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="YetkiIDLabel" Text="Yetki ID" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OlusturmaTarihiLabel1" Text="Olusturma Tarihi" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="DuzenlenmeTarihiLabel1" Text="Duzenlenme Tarihi" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="DuzenleyenIDLabel2" Text="Duzenleyen ID" CausesValidation="False">
																														</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="AktifPasifLabel1" Text="Aktif Pasif" CausesValidation="False">
																														</asp:LinkButton>
            </th></tr>
            </div>
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="HaberlerTableControlRepeater">
																															<ITEMTEMPLATE>
																																	<KumePortali:HaberlerTableControlRow runat="server" id="HaberlerTableControlRow">
																																			
            <div id="AJAXUpdateRecordRow">
            <tr>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../Haberler/ShowHaberlerPage.aspx?Haberler={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																			</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../Haberler/EditHaberlerPage.aspx?Haberler={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																			</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="HaberlerTableControlRow" CssClass="button_link" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																			</asp:ImageButton></td>
                <td class="ticwb" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="HaberlerRecordRowSelection">

																																			</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberBaslik">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberBaslikEN">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberOnYazi">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberOnYaziEN">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberIcerik">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberIcerikEN">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberAktif">
																																			</asp:Literal></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="YetkiID">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="OlusturmaTarihi1">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="DuzenlenmeTarihi1">
																																			</asp:Literal></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="DuzenleyenID1" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={HaberlerTableControlRow:FK:FK_Haberler_IKKullanicilar1}">
																																			</asp:LinkButton></td>
            <td class="ttc" ><asp:Literal runat="server" id="AktifPasif1">
																																			</asp:Literal></td>
            </tr>
            </div>
            
																																	</KumePortali:HaberlerTableControlRow>
																															</ITEMTEMPLATE>
																													</asp:Repeater>
            </table>
        </td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
</tr>
</table>
<!-- End Table Panel.html -->

																										</KumePortali:HaberlerTableControl>

																									</ContentTemplate>
																									<Triggers>
																										<asp:PostBackTrigger ControlID="HaberlerExportExcelButton"/>
																									</Triggers>
																								</asp:UpdatePanel>
																							
    </td>
    </tr>
    </table>
    
																								</ContentTemplate></asp:TabPanel>
																							
    <asp:TabPanel runat="server" id="HaberlerTabPanel1" HeaderText="Haberler">
																												<ContentTemplate>
    <table>
    <tr>
    <td>
<asp:UpdateProgress runat="server" id="HaberlerTableControl1UpdateProgress" AssociatedUpdatePanelID="HaberlerTableControl1UpdatePanel">
																																					<ProgressTemplate>
																																						<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
																																						</div>
																																						<div style=" position:absolute; padding:30px;">
																																							<img src="../Images/updating.gif" alt="">
																																						</div>
																																					</ProgressTemplate>
																																				</asp:UpdateProgress>
																																				<asp:UpdatePanel runat="server" id="HaberlerTableControl1UpdatePanel" UpdateMode="Conditional">

																																					<ContentTemplate>
																																						<KumePortali:HaberlerTableControl1 runat="server" id="HaberlerTableControl1">
																																									
    <!-- Begin Table Panel.html -->

    <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr>
    <td class="dhtrc">
        <table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td class="dhtrct"><asp:Label runat="server" id="HaberlerTotalItems1">
																																									</asp:Label></td>
        </tr>
        </table>
    </td>
    </tr><tr>
        <td class="dBody">
        <table id="CollapsibleRegion" style="display:;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td>
        <table id="FilterRegion" cellpadding="0" cellspacing="3" border="0"></table>
        <div class="spacer"></div>
        <!-- Category Area -->
        <table cellspacing="0" cellpadding="0" border="0" width="100%">
        <tr>
        <td>
            <table cellspacing="0" cellpadding="0" border="0" width="100%">
            <tr>
            <td>
            <table cellpadding="0" cellspacing="0" border="0"><tr>
            <!-- Pagination Area -->
            <td class="pr" colspan="100">
            <table id="PaginationRegion" cellspacing="0" cellpadding="0" border="0">
            <tr>
            <td><img src="../Images/paginationRowEdgeL.gif" alt=""/></td>
            <td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt=""/></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerNewButton1" CausesValidation="false" CommandName="Redirect" Consumers="page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../Haberler/AddHaberlerPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																										</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerDeleteButton1" CausesValidation="false" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="HaberlerTableControl1" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																										</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerExportExcelButton1" CausesValidation="false" CommandName="ExportDataExcel" Consumers="HaberlerTableControl1" ImageURL="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																										</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerRefreshButton1" CausesValidation="false" CommandName="ResetData" Consumers="HaberlerTableControl1" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																										</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="HaberlerResetButton1" CausesValidation="false" CommandName="ResetFilters" Consumers="HaberlerTableControl1" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																										</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt=""/></td>
            <td class="pra"><KumePortali:Pagination runat="server" id="HaberlerPagination1">
																																									</KumePortali:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt=""/></td>
            </tr>
            </table>
            </td>
            </tr><!--Table View Area -->
            <tr>
            <td class="tre">
            <table cellspacing="0" cellpadding="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)">
            <!-- This is the table's header row -->
            
            <div id="AJAXUpdateHeaderRow">
            <tr class="tch">
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th><th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="HaberlerToggleAll1" onclick="toggleAllCheckboxes(this);">

																																										</asp:CheckBox></th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberBaslikLabel3" Text="Haber Baslik" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberBaslikENLabel1" Text="Haber Baslik EN" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberOnYaziLabel1" Text="Haber On Yazi" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberOnYaziENLabel1" Text="Haber On Yazi EN" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:Literal runat="server" id="HaberIcerikLabel1" Text="Haber Icerik">
																																										</asp:Literal>
            </th>
            <th class="thc" scope="col"><asp:Literal runat="server" id="HaberIcerikENLabel1" Text="Haber Icerik EN">
																																										</asp:Literal>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HaberAktifLabel1" Text="Haber Aktif" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="YetkiIDLabel1" Text="Yetki ID" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OlusturmaTarihiLabel2" Text="Olusturma Tarihi" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OlusturanIDLabel3" Text="Olusturan ID" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="DuzenlenmeTarihiLabel2" Text="Duzenlenme Tarihi" CausesValidation="False">
																																										</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="AktifPasifLabel2" Text="Aktif Pasif" CausesValidation="False">
																																										</asp:LinkButton>
            </th></tr>
            </div>
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="HaberlerTableControl1Repeater">
																																											<ITEMTEMPLATE>
																																													<KumePortali:HaberlerTableControl1Row runat="server" id="HaberlerTableControl1Row">
																																															
            <div id="AJAXUpdateRecordRow">
            <tr>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowViewButton1" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../Haberler/ShowHaberlerPage.aspx?Haberler={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																															</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowEditButton1" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../Haberler/EditHaberlerPage.aspx?Haberler={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																															</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HaberlerRowDeleteButton1" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="HaberlerTableControl1Row" CssClass="button_link" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

																																															</asp:ImageButton></td>
                <td class="ticwb" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="HaberlerRecordRowSelection1">

																																															</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberBaslik1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberBaslikEN1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberOnYazi1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberOnYaziEN1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberIcerik1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberIcerikEN1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="HaberAktif1">
																																															</asp:Literal></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="YetkiID1">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="OlusturmaTarihi2">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="OlusturanID2" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={HaberlerTableControl1Row:FK:FK_Haberler_IKKullanicilar}">
																																															</asp:LinkButton></td>
            <td class="ttc" ><asp:Literal runat="server" id="DuzenlenmeTarihi2">
																																															</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="AktifPasif2">
																																															</asp:Literal></td>
            </tr>
            </div>
            
																																													</KumePortali:HaberlerTableControl1Row>
																																											</ITEMTEMPLATE>
																																									</asp:Repeater>
            </table>
        </td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
</tr>
</table>
<!-- End Table Panel.html -->

																																						</KumePortali:HaberlerTableControl1>

																																					</ContentTemplate>
																																					<Triggers>
																																						<asp:PostBackTrigger ControlID="HaberlerExportExcelButton1"/>
																																					</Triggers>
																																				</asp:UpdatePanel>
																																			
    </td>
    </tr>
    </table>
    
																																				</ContentTemplate></asp:TabPanel>

																																</asp:TabContainer>
                                    
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
