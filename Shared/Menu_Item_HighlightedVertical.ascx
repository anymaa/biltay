<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu_Item_HighlightedVertical.ascx.cs" Inherits="KumePortali.UI.Menu_Item_HighlightedVertical" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvoTL"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
	<td class="mvoT"><img src="../Images/space.gif" height="5" width="2" alt=""/></td>
	<td class="mvoTR"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvoL"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
	<td class="mvoC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" CssClass="menu">

</asp:LinkButton></td>
	<td class="mvoR"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvoBL"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
	<td class="mvoB"><img src="../Images/space.gif" height="3" width="2" alt=""/></td>
	<td class="mvoBR"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
 </tr>
