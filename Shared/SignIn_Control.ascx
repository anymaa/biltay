<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SignIn_Control.ascx.cs" Inherits="KumePortali.UI.SignIn_Control" %>
<%@ Register Tagprefix="KumePortali" Namespace="KumePortali.UI.Controls.SignIn_Control" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>

<KumePortali:SignInControl id="SignInControl" runat="server">
<table class="edit_label" cellspacing="1" cellpadding="1" border="0" align="center">
	<tbody>
		<tr>
			<td colspan="4" class="edit_label">
				<br />
				<asp:Label id="LoginMsg" runat="server" />
			</td>
		</tr>
		<tr>
			<td colspan="4" height="5"></td>
		</tr>
		<tr>
			<td class="field_label"><asp:Label id="UsernameLbl" runat="server" Text='<%# GetResourceValue("Txt:UserName", "KumePortali")%>'/>&nbsp;</td>
			<td class="field_value">
				<asp:TextBox id="UserName" class="field_input" runat="server" Text="">
				</asp:TextBox>
				<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your user name." ControlToValidate="UserName" Display="None"></asp:RequiredFieldValidator>
			</td>
			<td class="CheckBox"><asp:CheckBox ID="CheckBoxUN" runat="server" /></td>
			<td class="field_label"><asp:Label ID="CheckBoxUNLbl" runat="server" Text='<%# GetResourceValue("Txt:RememberUN", "KumePortali")%>' /></td>
		</tr>
		<tr>
			<td class="field_label"><asp:Label id="PasswordLbl" runat="server" Text='<%# GetResourceValue("Txt:Password", "KumePortali")%>'/>&nbsp;</td>
			<td class="field_value">
				<asp:TextBox id="Password" class="field_input" runat="server" TextMode="Password"></asp:TextBox>
				<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your password." ControlToValidate="Password" Display="None"></asp:RequiredFieldValidator>
			</td>
			<td class="CheckBox"><asp:CheckBox ID="CheckBoxPass" runat="server" /></td>
			<td class="field_label"><asp:Label ID="CheckBoxPassLbl" runat="server" Text='<%# GetResourceValue("Txt:RememberPassword", "KumePortali")%>' /></td>
		</tr>
				<tr>
		<td></td><td></td>
		<td class="CheckBox"><asp:CheckBox ID="CheckBoxAutoLogin" runat="server" /></td>
			<td class="field_label"><asp:Label ID="CheckBoxAutoLoginLbl" runat="server" Text='<%# GetResourceValue("Txt:AutoLogin", "KumePortali")%>' /></td>
		</tr>
	</tbody>
</table>
</KumePortali:SignInControl>