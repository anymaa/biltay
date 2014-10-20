<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.ShowSysdiagramsTablePage" %>

<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="KumePortali" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="KumePortali" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ShowSysdiagramsTablePage.aspx.cs" Culture="tr-TR" Inherits="KumePortali.UI.ShowSysdiagramsTablePage" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="KumePortali" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="KumePortali" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
<asp:UpdateProgress runat="server" id="SysdiagramsTableControlUpdateProgress" AssociatedUpdatePanelID="SysdiagramsTableControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif" alt="">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="SysdiagramsTableControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<KumePortali:SysdiagramsTableControl runat="server" id="SysdiagramsTableControl">
														
    <!-- Begin Table Panel.html -->

    <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr>
    <td class="dh">
    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td class="dhel"><img src="../Images/space.gif" alt=""/></td><td class="dht" valign="middle"><asp:Literal runat="server" id="SysdiagramsTitle" Text="Sysdiagrams">
														</asp:Literal></td>
    <td class="dhtrc">
        <table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td class="dhtrct"><%# GetResourceValue("Txt:TotalItems", "KumePortali") %>&nbsp;<asp:Label runat="server" id="SysdiagramsTotalItems">
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
        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SysdiagramsTableControl$SysdiagramsSearchButton")) %>
        <asp:TextBox runat="server" id="SysdiagramsSearchArea" CaseSensitive="false" Columns="50" CssClass="Search_Input" Fields="name">
															</asp:TextBox>
		<asp:AutoCompleteExtender id="SysdiagramsSearchAreaAutoCompleteExtender" runat="server" TargetControlID="SysdiagramsSearchArea" ServiceMethod="GetAutoCompletionList_SysdiagramsSearchArea" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
		</asp:AutoCompleteExtender>
		
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SysdiagramsTableControl$SysdiagramsSearchButton")) %>
        </td>
        <td class="filbc"><KumePortali:ThemeButton runat="server" id="SysdiagramsSearchButton" Button-CausesValidation="False" Button-CommandName="Search" Button-Text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;KumePortali&quot;) %>">
		</KumePortali:ThemeButton></td>
    </tr>
    
            <tr>
            <td></td>
            <td></td>
            <td rowspan="100" class="filbc"><KumePortali:ThemeButton runat="server" id="SysdiagramsFilterButton" Button-CausesValidation="False" Button-CommandName="Search" Button-Text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;KumePortali&quot;) %>">
		</KumePortali:ThemeButton></td> 
            </tr>
            
            <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SysdiagramsTableControl$SysdiagramsFilterButton")) %>
                <tr>
                <td class="fila"><asp:Literal runat="server" id="nameLabel" Text="Name">
		</asp:Literal></td><td><asp:DropDownList runat="server" id="nameFilter" CssClass="Filter_Input" MaxDisplayedValues="500" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
		</asp:DropDownList></td></tr>
                <tr>
                <td class="fila"><asp:Literal runat="server" id="principal_idLabel" Text="Principal ID">
		</asp:Literal></td>
                <td><asp:TextBox runat="server" id="principal_idFromFilter" Columns="30" CssClass="Filter_Input">
		</asp:TextBox><span class="rft"><asp:Label runat="server" id="principal_idRangeFilterText" Text="-">
		</asp:Label></span><asp:TextBox runat="server" id="principal_idToFilter" Columns="30" CssClass="Filter_Input">
		</asp:TextBox></td></tr>
            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SysdiagramsTableControl$SysdiagramsFilterButton")) %>
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
            <td class="prbbc"><asp:ImageButton runat="server" id="SysdiagramsNewButton" CausesValidation="false" CommandName="Redirect" Consumers="page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../sysdiagrams/AddSysdiagramsPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="SysdiagramsDeleteButton" CausesValidation="false" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="SysdiagramsTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="SysdiagramsExportExcelButton" CausesValidation="false" CommandName="ExportDataExcel" Consumers="SysdiagramsTableControl" ImageURL="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="SysdiagramsRefreshButton" CausesValidation="false" CommandName="ResetData" Consumers="SysdiagramsTableControl" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="SysdiagramsResetButton" CausesValidation="false" CommandName="ResetFilters" Consumers="SysdiagramsTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

		</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt=""/></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt=""/></td>
            <td class="pra"><KumePortali:Pagination runat="server" id="SysdiagramsPagination">
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
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th><th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="SysdiagramsToggleAll" onclick="toggleAllCheckboxes(this);">

		</asp:CheckBox></th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="nameLabel1" Text="Name" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="principal_idLabel1" Text="Principal ID" CausesValidation="False">
		</asp:LinkButton>
            </th>
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="versionLabel" Text="Version" CausesValidation="False">
		</asp:LinkButton>
            </th></tr>
            </div>
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="SysdiagramsTableControlRepeater">
			<ITEMTEMPLATE>
					<KumePortali:SysdiagramsTableControlRow runat="server" id="SysdiagramsTableControlRow">
							
            <div id="AJAXUpdateRecordRow">
            <tr>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="SysdiagramsRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../sysdiagrams/ShowSysdiagramsPage.aspx?Sysdiagrams={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="SysdiagramsRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../sysdiagrams/EditSysdiagramsPage.aspx?Sysdiagrams={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticnb" scope="row"><asp:ImageButton runat="server" id="SysdiagramsRowDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;KumePortali&quot;) %>" Consumers="SysdiagramsTableControlRow" CssClass="button_link" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

							</asp:ImageButton></td>
                <td class="ticwb" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="SysdiagramsRecordRowSelection">

							</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="name">
							</asp:Literal></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="principal_id">
							</asp:Literal></td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="version">
							</asp:Literal></td>
            </tr>
            </div>
            
					</KumePortali:SysdiagramsTableControlRow>
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

</KumePortali:SysdiagramsTableControl>

</ContentTemplate>
<Triggers>
	<asp:PostBackTrigger ControlID="SysdiagramsExportExcelButton"/>
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
