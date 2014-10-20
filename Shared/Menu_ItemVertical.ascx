<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu_ItemVertical.ascx.cs" Inherits="KumePortali.UI.Menu_ItemVertical" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvTL"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
	<td class="mvT"><img src="../Images/space.gif" height="5" width="2" alt=""/></td>
	<td class="mvTR"><img src="../Images/space.gif" height="5" width="5" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvL"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
	<td class="mvC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" CssClass="menu">

</asp:LinkButton></td>
	<td class="mvR"><img src="../Images/space.gif" height="14" width="5" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="mvBL"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
	<td class="mvB"><img src="../Images/space.gif" height="3" width="2" alt=""/></td>
	<td class="mvBR"><img src="../Images/space.gif" height="3" width="5" alt=""/></td>
 </tr>
