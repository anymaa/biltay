<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.ShowIKKullanicilarTablePage" %>

<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="KumePortali" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="KumePortali" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ShowIKKullanicilarTablePage.aspx.cs" Culture="tr-TR" Inherits="KumePortali.UI.ShowIKKullanicilarTablePage" %>
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
<asp:UpdateProgress runat="server" id="IKKullanicilarTableControlUpdateProgress" AssociatedUpdatePanelID="IKKullanicilarTableControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif" alt="">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="IKKullanicilarTableControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<KumePortali:IKKullanicilarTableControl runat="server" id="IKKullanicilarTableControl">
														
    <!-- Begin Table Panel.html -->

    <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr>
    <td class="dh">
    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td class="dhel"><img src="../Images/space.gif" alt=""/></td><td class="dht" valign="middle"><asp:Literal runat="server" id="IKKullanicilarTitle" Text="IK Kullanicilar">
														</asp:Literal></td>
    <td class="dhtrc">
        <table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td class="dhtrct"><%# GetResourceValue("Txt:TotalItems", "KumePortali") %>&nbsp;<asp:Label runat="server" id="IKKullanicilarTotalItems">
														</asp:Label></td>
        </tr>
        </table>
    </td>
    <td class="dher"><img src="../Images/space.gif" alt=""/></td>
    </tr>
    </table>
    </td>
    </tr><tr>
        <td class="dBody">
        <table id="CollapsibleRegion" style="display:;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td>
        <table id="FilterRegion" cellpadding="0" cellspacing="3" border="0">
    
    <!-- Search & Filter Area -->
    <tr>
        <td class="fila"><%# GetResourceValue("Txt:SearchFor", "KumePortali") %></td>
        <td>
        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("IKKullanicilarTableControl$IKKullanicilarSearchButton")) %>
        <asp:TextBox runat="server" id="IKKullanicilarSearchArea" CaseSensitive="false" Columns="50" CssClass="Search_Input" Fields="Adi,Soyadi">
															</asp:TextBox>
		<asp:AutoCompleteExtender id="IKKullanicilarSearchAreaAutoCompleteExtender" runat="server" TargetControlID="IKKullanicilarSearchArea" ServiceMethod="GetAutoCompletionList_IKKullanicilarSearchArea" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
		</asp:AutoCompleteExtender>
		
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("IKKullanicilarTableControl$IKKullanicilarSearchButton")) %>
        </td>
        <td class="filbc"><KumePortali:ThemeButton runat="server" id="IKKullanicilarSearchButton" Button-CausesValidation="False" Button-CommandName="Search" Button-Text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;KumePortali&quot;) %>">
		</KumePortali:ThemeButton></td>
    </tr>
    
            <tr>
            <td></td>
            <td></td>
            <td rowspan="100" class="filbc"></td> 
            </tr>
            
            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("IKKullanicilarTableControl$IKKullanicilarFilterButton")) %>
                <tr>
                <td class="fila"><asp:Literal runat="server" id="UnvanIDLabel" Text="Unvanı">
		</asp:Literal></td><td><asp:DropDownList runat="server" id="UnvanIDFilter" CssClass="Filter_Input" MaxDisplayedValues="500" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
		</asp:DropDownList></td></tr>
                <tr>
                <td class="fila"><asp:Literal runat="server" id="FirmaIDLabel" Text="Firma Adı">
		</asp:Literal></td><td><asp:DropDownList runat="server" id="FirmaIDFilter" CssClass="Filter_Input" MaxDisplayedValues="500" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
		</asp:DropDownList></td></tr>
            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("IKKullanicilarTableControl$IKKullanicilarFilterButton")) %>
            </table>
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
            <td class="prbbc"><asp:ImageButton runat="server" id="IKKullanicilarNewButton" CausesValidation="false" CommandName="Redirect" Consumers="page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../IKKullanicilar/AddIKKullanicilarPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="IKKullanicilarDeleteButton" CausesValidation="false" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="IKKullanicilarTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="IKKullanicilarExportExcelButton" CausesValidation="false" CommandName="ExportDataExcel" Consumers="IKKullanicilarTableControl" ImageURL="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="IKKullanicilarRefreshButton" CausesValidation="false" CommandName="ResetData" Consumers="IKKullanicilarTableControl" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="IKKullanicilarResetButton" CausesValidation="false" CommandName="ResetFilters" Consumers="IKKullanicilarTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt=""/></td>
            <td class="pra"><KumePortali:Pagination runat="server" id="IKKullanicilarPagination">
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
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th><th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="IKKullanicilarToggleAll" onclick="toggleAllCheckboxes(this);">

		</asp:CheckBox></th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="AdiLabel" Text="Adı" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="SoyadiLabel" Text="Soyadı" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="EpostaLabel" Text="e-Posta" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="GSMLabel" Text="GSM" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="FirmaIDLabel1" Text="Firma Adı" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="UnvanIDLabel1" Text="Unvanı" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="YetkiTurIDLabel" Text="Yetki Türü" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="HesapIDLabel" Text="Hesap ID" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="TCKimlikNoLabel" Text="TC Kimlik No" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="IsTelefonuLabel" Text="İş Telefonu" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="KullaniciAdiLabel" Text="Kullanici Adi" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OlusturmaTarihiLabel" Text="Oluşturma Tarihi" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OlusturanIDLabel" Text="Oluşturan" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="DuzenlenmeTarihiLabel" Text="Duzenlenme Tarihi" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="DuzenleyenIDLabel" Text="Duzenleyen ID" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="AktifPasifLabel" Text="Aktif Pasif" CausesValidation="False">
		</asp:LinkButton>
            </th></tr>
            </div>
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="IKKullanicilarTableControlRepeater">
			<ITEMTEMPLATE>
					<KumePortali:IKKullanicilarTableControlRow runat="server" id="IKKullanicilarTableControlRow">
							
            <div id="AJAXUpdateRecordRow">
            <tr>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="IKKullanicilarRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="IKKullanicilarRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../IKKullanicilar/EditIKKullanicilarPage.aspx?IKKullanicilar={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="IKKullanicilarRowDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="IKKullanicilarTableControlRow" CssClass="button_link" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticwb" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="IKKullanicilarRecordRowSelection">

							</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="Adi">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="Soyadi">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="Eposta">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="GSM">
							</asp:Literal></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="FirmaID" CausesValidation="False" CommandName="Redirect" RedirectURL="../MIYSAHesaplar/ShowMIYSAHesaplarPage.aspx?MIYSAHesaplar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_Firma}">
							</asp:LinkButton></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="UnvanID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKUnvanlar/ShowIKUnvanlarPage.aspx?IKUnvanlar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKUnvanlar}">
							</asp:LinkButton></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="YetkiTurID">
							</asp:Literal></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="HesapID">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="TCKimlikNo">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="IsTelefonu">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="KullaniciAdi">
							</asp:Literal></td>
            <td class="ttc" ><asp:Literal runat="server" id="OlusturmaTarihi">
							</asp:Literal></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="OlusturanID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKKullanicilar}">
							</asp:LinkButton></td>
            <td class="ttc" ><asp:Literal runat="server" id="DuzenlenmeTarihi">
							</asp:Literal></td>
            <td class="ttc" ><asp:LinkButton runat="server" id="DuzenleyenID" CausesValidation="False" CommandName="Redirect" RedirectURL="../IKKullanicilar/ShowIKKullanicilarPage.aspx?IKKullanicilar={IKKullanicilarTableControlRow:FK:FK_IKKullanicilar_IKKullanicilar1}">
							</asp:LinkButton></td>
            <td class="ttc" ><asp:Literal runat="server" id="AktifPasif">
							</asp:Literal></td>
            </tr>
            </div>
            
					</KumePortali:IKKullanicilarTableControlRow>
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

</KumePortali:IKKullanicilarTableControl>

</ContentTemplate>
<Triggers>
	<asp:PostBackTrigger ControlID="IKKullanicilarExportExcelButton"/>
</Triggers>
</asp:UpdatePanel>
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
