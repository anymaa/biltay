namespace KumePortali.UI.Controls.SignIn_Control
{

	#region "Section 1: Place your customizations here."
		public class SignInControl : BaseSignInControl
		{
		}
	#endregion

	#region "Section 2: Do not modify this section."
		public class BaseSignInControl : System.Web.UI.Control
		{
	#region " Constants "
			const int INVALID_USER_INFO = -2147467259;
	#endregion

	#region " Protected Properties"

			protected string ERR_INVALID_LOGIN_INFO
			{
				get
				{
                    return ((BaseApplicationPage)(this.Page)).GetResourceValue("Err:InvalidLoginInfo", "KumePortali");
				}
				
			}

			protected string ERR_INTERNAL_ERROR
			{
				get
				{
                    return ((BaseApplicationPage)(this.Page)).GetResourceValue("Err:InternalErrorLogin", "KumePortali");
				}
				
			}

			protected string LOGIN_MSG
			{
				get
				{
                    return ((BaseApplicationPage)(this.Page)).GetResourceValue("Txt:LoginMsg", "KumePortali");
				}
				
			}

			protected string LOGIN_MSG_SESSION_INVALID
			{
				get
				{
                    return ((BaseApplicationPage)(this.Page)).GetResourceValue("Txt:LoginMsgSessionInvalid", "KumePortali");
				}
				
			}


	#endregion 

			
	#region " Events "
			public delegate void LoginSucceededHandler(object sender, System.EventArgs e);
			public event LoginSucceededHandler LoginSucceeded;

			public delegate void LoginFailedHandler(object sender, System.EventArgs e);
			public event LoginFailedHandler LoginFailed;
	#endregion

	#region " Public Properties "
            protected string _successURL;
			public string SuccessURL
			{
				get
				{
					return this._successURL;
				}
				set
				{
					this._successURL = value;
				}
			}
			protected string _successURLParm;

			public string SuccessURLParam
			{
				get
				{
					return this._successURLParm;
				}
				set
				{
					this._successURLParm = value;
				}
			}

			public System.Web.UI.WebControls.TextBox UserName
			{
				get
				{
					return ((System.Web.UI.WebControls.TextBox)(this.FindControl("UserName")));
				}
			}

			public System.Web.UI.WebControls.TextBox Password
			{
				get
				{
					return ((System.Web.UI.WebControls.TextBox)(this.FindControl("Password")));
				}
			}

			public System.Web.UI.WebControls.Label LoginMsg
			{
				get
				{
					return ((System.Web.UI.WebControls.Label)(this.FindControl("LoginMsg")));
				}
			}
	#endregion

	#region " Login Methods "
			public virtual void Login(string redirectUrl)
			{
				this.SuccessURL = redirectUrl;
				Login(true);
			}

			public virtual void Login(bool bRedirectOnSuccess)
			{
				string strUserName = this.UserName.Text;
				string strPassword = this.Password.Text;
                if (((this.Password.Text == "**********") || (this.Password.Text.Trim() == "")))
                {
                    SignInState state = new SignInState();
                    strPassword = state.LoginPassword;
                }
				string errMessage = "";
				string clientIPAddress = this.Page.Request.ServerVariables["REMOTE_ADDR"] + " (HTML)";
				bool bSuccess = false;
				try
				{
                    bSuccess = ((BaseApplicationPage)(this.Page)).CurrentSecurity.SetLoginInfo(strUserName, strPassword, ref errMessage);
				}
				catch (System.Threading.ThreadAbortException ex)
				{
					throw ex;
				}
				catch (System.Exception e)
				{
					ProcessLoginFailed(ERR_INTERNAL_ERROR + " " + e.Message, "");
				}
				if ((bSuccess))
				{
					if (LoginSucceeded != null)
					{
						LoginSucceeded(this, new System.EventArgs());
					}
					if (bRedirectOnSuccess)
					{
						RedirectOnSuccess();
					}
				}
				else
				{
					if ((errMessage != null) && (errMessage != ""))
					{
						ProcessLoginFailed(errMessage, strUserName);
					}
					else
					{
						ProcessLoginFailed(ERR_INVALID_LOGIN_INFO, strUserName);
					}
				}
			}

			protected virtual void RedirectOnSuccess()
			{
				if (this.SuccessURL != null && this.SuccessURL.Trim().Length > 0)
				{
					this.Page.Response.Redirect(this.SuccessURL);
				}
				else
				{
					((BaseClasses.Web.UI.BasePage)(this.Page)).RedirectBack(true);
				}
			}

			private void Reset()
			{
			}

			protected virtual void ProcessLoginFailed(string message, string userName)
			{
				if (LoginFailed != null)
				{
					LoginFailed(this, new System.EventArgs());
				}
				string url;
				url = BaseClasses.Configuration.ApplicationSettings.Current.SignInPageUrl + "?message=" + this.Page.Server.UrlEncode(message);
                if ((this.SuccessURLParam != null) && (this.SuccessURLParam.Trim().Length > 0))
				{
					url += "&" + this.SuccessURLParam + "=" + this.SuccessURL;
				}
				if (userName.Trim().Length > 0)
				{
					url = url + "&UserName=" + userName.Trim();
				}
				url = url + "&mode=yes";
				((BaseApplicationPage)(this.Page)).SystemUtils.shouldRollBackTransaction = true;
				((BaseClasses.Web.UI.BasePage)(this.Page)).RemoveCurrentRequestFromSessionNavigationHistory();
                BaseClasses.Utils.NetUtils.SetCookie(BaseClasses.Utils.NetUtils.CookieAutoLogin(), "False");
                System.Web.SessionState.HttpSessionState Session = System.Web.HttpContext.Current.Session;
                Session.Abandon(); 
				this.Page.Response.Redirect(url);
				this.Page.Response.End();
			}

	#endregion

	#region " Misc Methods "
			protected override void LoadViewState(object savedState)
			{
				base.LoadViewState(savedState);
				this.SuccessURL = System.Convert.ToString(this.ViewState["SuccessURL"]);
				this.SuccessURLParam = System.Convert.ToString(this.ViewState["SuccessURLParam"]);
			}

			protected override object SaveViewState()
			{
				this.ViewState["SuccessURL"] = this.SuccessURL;
				this.ViewState["SuccessURLParam"] = this.SuccessURLParam;
				return base.SaveViewState();
			}

			protected override void OnDataBinding(System.EventArgs e)
			{
				base.OnDataBinding(e);
				string strMessage = this.Page.Request.QueryString["Message"];
				if (strMessage != null) 
				{
					strMessage = strMessage.Replace("<br>", "");
					strMessage = this.Page.Server.HtmlEncode(strMessage);
				}
            			
				this.UserName.Text = this.Page.Request.QueryString["UserName"];
				if (this.UserName.Text != null) 
				{
					this.UserName.Text = this.Page.Server.HtmlEncode(this.UserName.Text);
				}

				if (this.SuccessURLParam != null && this.SuccessURLParam.Trim().Length > 0)
				{
					this.SuccessURL = this.Page.Request.QueryString[this.SuccessURLParam.Trim()];
					if (this.SuccessURL != null)
					{
						this.SuccessURL = this.SuccessURL.Trim();
						this.SuccessURL = this.Page.Server.HtmlEncode(this.SuccessURL);
					}
				}
				if (strMessage != null)
				{
					LoginMsg.Text = strMessage;
				}
				else if (this.SuccessURL != null && this.SuccessURL != "")
				{
					LoginMsg.Text = LOGIN_MSG_SESSION_INVALID;
				}
				else
				{
					LoginMsg.Text = LOGIN_MSG;
				}
			}
	#endregion
			
		}
	#endregion
     
}