<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu_Item_Highlighted.ascx.cs" Inherits="KumePortali.UI.Menu_Item_Highlighted" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<table cellpadding="0" cellspacing="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
 <tr>
	<td class="moTL"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
	<td class="moT"><img src="../Images/space.gif" height="5" width="2" alt=""/></td>
	<td class="moTR"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
 </tr>
 <tr>
	<td class="moL"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
	<td class="moC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" CssClass="menu">

</asp:LinkButton></td>
	<td class="moR"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
 </tr>
 <tr>
	<td class="moBL"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
	<td class="moB"><img src="../Images/space.gif" height="3" width="2" alt=""/></td>
	<td class="moBR"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
 </tr>
</table>
