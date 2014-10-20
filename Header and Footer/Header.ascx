<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="KumePortali" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Header.ascx.cs" Inherits="KumePortali.UI.Header" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>

<table cellspacing="0" cellpadding="0" border="0" width="100%">
 <tr>
	<td>
      <table border="0" cellpadding="0" cellspacing="0">
       <tr>
        <td>
         <table cellspacing="0" cellpadding="0" border="0" width="100%">
          <tr>
          <td>
           <asp:HyperLink runat="server" id="_SkipNavigationLinks" CssClass="skipNavigationLinks" NavigateURL="#StartOfPageContent" Text="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;KumePortali&quot;) %>" ToolTip="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;KumePortali&quot;) %>">

</asp:HyperLink>
          </td>
          </tr>
         </table>
        </td>
       </tr>
       <tr>
       <td class="logoBG"><asp:Image runat="server" id="_PageHeader__Logo" ImageURL="../Images/esaclogo.jpg" AlternateText="" style="border-width:0px;">

</asp:Image> </td>
       </tr>
      </table>
     </td> 
	<td style="width:100%;"></td>
	<td style="text-align:right; vertical-align:top;">
		<table border="0" cellpadding="0" cellspacing="0" width="100%">
			<tr>
				<td style="width:100%;"></td>
				<td><asp:Image runat="server" id="_LeftImage" Enabled="false" Height="23" ImageURL="../Images/SignInBarL.gif" Width="36" AlternateText="">

</asp:Image></td>
				<td><asp:ImageButton runat="server" id="_SignInBarSetLanguageButton" border="0" CausesValidation="False" CommandName="ShowSignInBarSetLanguageButton" ImageURL="../Images/SignInBarSetLanguage.gif" name="SignInBarSetLanguageButton" onmouseout="this.src='../Images/SignInBarSetLanguage.gif';" onmouseover="this.src='../Images/SignInBarSetLanguageOver.gif';" PostBackUrl="../Language/SetLanguagePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Txt:SetLanguage&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

</asp:ImageButton></td>
				<td><asp:Image runat="server" id="_Divider1" Enabled="false" ImageURL="../Images/SignInBarDivider.gif" AlternateText="">

</asp:Image></td>
				<td class="signInBar"><asp:LinkButton runat="server" id="_SignIn" CausesValidation="False" CommandName="ShowSignIn">

</asp:LinkButton></td>
				<td><asp:ImageButton runat="server" id="_SIOImage" CausesValidation="False" CommandName="ShowSIOImage" ImageURL="../Images/SignInBarSignIn.gif" AlternateText="">

</asp:ImageButton></td>
				<td><asp:Image runat="server" id="_Divider2" Enabled="false" ImageURL="../Images/SignInBarDivider.gif" AlternateText="">

</asp:Image></td>
                <td><a href="javascript:printPage();" ><asp:Image runat="server" id="_SignInBarPrintButton" border="0" CausesValidation="False" CommandName="ShowSignInBarPrintButton" ImageURL="../Images/SignInBarPrint.gif" name="SignInBarPrintButton" onmouseout="this.src='../Images/SignInBarPrint.gif';" onmouseover="this.src='../Images/SignInBarPrintOver.gif';" ToolTip="&lt;%# GetResourceValue(&quot;Txt:PrintPage&quot;, &quot;KumePortali&quot;) %>" AlternateText="">

</asp:Image></a></td>
				<td><asp:Image runat="server" id="_Divider3" Enabled="false" ImageURL="../Images/SignInBarDivider.gif" AlternateText="">

</asp:Image></td>
			</tr>
		</table>
		<table border="0" cellpadding="0" cellspacing="0" width="100%">
			<tr>
				<td class="signInBarStatus"><asp:Label runat="server" id="_UserStatusLbl" CommandName="ShowUserStatusLbl" Width="300">
</asp:Label></td>
			</tr>
		</table></td>
 </tr>
</table>
