<%@ Page Language="cs" AutoEventWireup="true" EnableEventValidation="false" CodeFile="LargeListSelector.aspx.cs" Inherits="KumePortali.UI.LargeListSelector" %>
<%@ Register Tagprefix="KumePortali" TagName="Pagination" Src="Pagination.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.LargeListSelector" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="KumePortali" TagName="ThemeButton" Src="ThemeButton.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/BaseStyles.css"/>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/Styles.css" />
  </head>
  <body id="Body1" runat="server">
	<form id="Form1" method="post" runat="server">
          <BaseClasses:BasePageSettings id="PageSettings" runat="server" />
          		<asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" />

	    <asp:UpdateProgress runat="server" id="ItemsTableControlUpdateProgress" AssociatedUpdatePanelID="ItemsTableControlUpdatePanel">
		<ProgressTemplate>
			<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
			</div>
			<div style=" position:absolute; padding:30px;">
				<img src="../Images/updating.gif">
			</div>
		</ProgressTemplate>
	     </asp:UpdateProgress>
	     	<p>
	     <asp:UpdatePanel runat="server" id="ItemsTableControlUpdatePanel" UpdateMode="Conditional">

		<ContentTemplate>    
<KumePortali:ItemsTable runat="server" id="ItemsTable">
			
	<table border="0" cellspacing="0" cellpadding="0">
		<tr>
			<td colspan="2">
<!-- BEGIN Search -->
<table>
 <tr>
  <td>
   <table>
    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("ItemsTable$SearchButton")) %>
    <tr>
     <td class="filter_area">
      Starts with
     </td>
     <td class="dfv">
      <asp:TextBox runat="server" id="StartsWith" CssClass="Search_Input" Columns=50 />
      <asp:AutoCompleteExtender id="StartsWithAutoCompleteExtender" runat="server" TargetControlID="StartsWith" ServiceMethod="GetAutoCompletionList_StartsWith" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem" CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
		</asp:AutoCompleteExtender>
     </td>
    </tr>
    <tr>
     <td class="filter_area">
      Contains
     </td>
     <td class="dfv">
      <asp:TextBox runat="server" id="Contains" CssClass="Search_Input" Columns=50 />
      <asp:AutoCompleteExtender id="ContainsAutoCompleteExtender" runat="server" TargetControlID="Contains" ServiceMethod="GetAutoCompletionList_Contains" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem" CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
		</asp:AutoCompleteExtender>
     </td>
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("ItemsTable$SearchButton")) %>
   </table>
  </td>
  <td style="vertical-align:middle;">
   <KumePortali:ThemeButton runat="server" id="SearchButton" Button-CausesValidation="False" Button-CommandName="Search" Button-Text="<%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;KumePortali&quot;) %>">
			</KumePortali:ThemeButton>
  </td>
 </tr>
</table>
<!-- END Search -->
			</td>
		</tr>
		<tr>
			<td colspan="2" align="center">
<!-- BEGIN Pagination -->
<table cellpadding="0" cellspacing="0" border="0">
<tr>
<td class="pagination_row">
<table cellpadding="0" cellspacing="0" border="0">
 <tr>
  <td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td>
  <td class="pagination_area" style="width:100%;">
	<KumePortali:Pagination runat="server" id="Pagination"></KumePortali:Pagination>
  </td>
  <td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td>
 </tr>
</table>
</td>
</tr>
</table>
<!-- END Pagination -->
		</td>
		</tr>
		<asp:Repeater runat="server" id="Row1">
					<ITEMTEMPLATE>
							<KumePortali:ItemsTableRecordControl runat="server" id="ItemsTableRecordControl">
									
			<tr>
				<td class="header_cell" style="text-align:center;">
					<div class="column_header"><asp:Label runat="server" ID="ValueText" Visible="false"></asp:Label><asp:LinkButton runat="server" id="SelectButton" CausesValidation="False" Text="Select"></asp:LinkButton></div>
				</td>
				<td class="table_cell">
					<asp:Label runat="server" id="ItemText"></asp:Label>
				</td>
			</tr>
		
							</KumePortali:ItemsTableRecordControl>
					</ITEMTEMPLATE>
			</asp:Repeater>
	</table>

</KumePortali:ItemsTable>
</ContentTemplate>
</asp:UpdatePanel>
 </form>
  </body>
</html>