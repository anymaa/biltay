using System;
using System.Web.UI.WebControls;
using System.ComponentModel;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Web.UI.WebControls;
using KumePortali.Business;
using KumePortali.Data;
        
namespace KumePortali.UI
{

#region Code customizations
    // Each page class is defined in a hierarchy sub-classed from the
    // Page class of Microsoft .NET Framework. The hierarchy is as follows:
    //
    //    System.Web.UI.Page   (Microsoft .NET Framework class)
    //     BaseClasses.Web.UI.BasePage    (Base Classes.  Source code included)
    //      BaseApplicationPage    (Application wide BasePage class.  You can make app wide page customizations here.)
    //        ShowOrder_DetailsTablePage    (Code-behind class. Created once. Never overwritten)
    //
    // All code customizations can be done in the code-behind class.  Since the
    // code-behind class is created once, and never overwritten, you can be
    // assured that all of your customizations are preserved.
    //
    // The code-behind class is the lowest class in the hierarchy.  This
    // means that can can override any functionality provided by any
    // of the parent classes.
    //
    // The BaseApplicationPage class (defined in <AppFolder>\Shared\BaseApplicationPage.vb)
    // allows you to modify the behavior of the System.Web.UI.Page
    // or BaseClasses.Web.UI.BasePage across the entire application.
    //
    // The table and record controls included in this control will have their code behind classes
    // generated in <AppFolder>\App_Code\${ControlSafeClassDirectory}\ShowOrder_DetailsTablePage.Controls.vb
    // Customizations made to these table and record controls will be added to this class.
#endregion
    // Code-behind class for the SignIn_Control user control.

    partial class SignIn_Control : BaseApplicationUserControl
    {

#region "Section 1: Place your customizations here."

        public SignIn_Control()
        {
            this.Load += new EventHandler(Page_Load);
        }

        // LoadData reads database data and assigns it to UI controls.
        // Customize by adding code before or after the call to LoadData_Base()
        // or replace the call to LoadData_Base().
        public void LoadData()
        {
            LoadData_Base();
        }

        // Write out override methods for the page events
#endregion

#region "Section 2: Do not modify this section."
        //signInState is a class to store values of cookies in the session state. It is used by SignIn_Control, 
        //SignOut.ascx.vb(cs) and SignIn_Control.Controls.vb(cs)
        SignInState signInState;
        // Handles MyBase.Load.  If you need to, you can add additional Load handlers in Section 1.
        // Read database data and put into the UI controls.
        protected virtual void Page_Load(object sender, System.EventArgs e)
        {
            //  Load data only when displaying the page for the first time
            this.signInState = new SignInState();
            this.EventHandlersInit();
            if (!this.IsPostBack)
            {
                this.CookieInit();
                //  Read the data for all controls on the page.
                //  To change the behavior, override the DataBind method for the individual
                //  record or table UI controls.
                this.LoadData();
            }
        }

        //  Load data from database into UI controls. 
        //  Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        //  the individual table and record controls to customize.
        public void LoadData_Base()
        {
            try
            {
                //  Load data only when displaying the page for the first time
                if (!this.IsPostBack)
                {
                    //  Must start a transaction before performing database operations
                    DbUtils.StartTransaction();
                    //  Load data for each record and table UI control.
                    //  Ordering is important because child controls get 
                    //  their parent ids from their parent UI controls.
                }
            }
            catch (Exception ex)
            {
                //  An error has occured so display an error message.
                MiscUtils.RegisterJScriptAlert(this, "Page_Load_Error_Message", ex.Message);
            }
            finally
            {
                if (!this.IsPostBack)
                {
                    //  End database transaction
                    DbUtils.EndTransaction();
                }
            }
        }

        public virtual void Login(string redirectUrl)
        {
            this.SignInControl.Login(redirectUrl);
        }

        // Performs the login
        public virtual void Login(bool bRedirectOnSuccess)
        {
            this.SignInControl.Login(bRedirectOnSuccess);
        }

        // Sets cookies when login succeeded
        private void MySetCookie(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            Crypto CheckCrypto = new Crypto(Crypto.Providers.DES);
            string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
            if (this.signInState.IsUNToRemember)
            {
                string uNameEncrypted = CheckCrypto.Encrypt(this.UserName.Text, key, System.Text.Encoding.Unicode, false);
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieUserName(), uNameEncrypted);
            }
            else
            {
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieUserName(), "");
            }
            if (this.signInState.IsPassToRemember)
            {
                if (((this.Password.Text != "**********") && (this.Password.Text.Trim() != "")))
                {
                    this.signInState.Password = this.Password.Text;
                }
                string passwordEncrypted = CheckCrypto.Encrypt(this.signInState.Password, key, System.Text.Encoding.Unicode, false);
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookiePassword(), passwordEncrypted);
            }
            else
            {
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookiePassword(), "");
            }
            BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberName(), this.signInState.IsUNToRemember.ToString());
            BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberPassword(), this.signInState.IsPassToRemember.ToString());
            this.signInState.IsAutoLogin = true;
        }

        // Resets AutoLogin when login failed
        private void ResetAutoLogin(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            this.signInState.IsAutoLogin = false;
            if (!this.signInState.IsUNToRemember)
            {
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieUserName(), "");
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberName(), this.signInState.IsUNToRemember.ToString());
            }
            if (!this.signInState.IsPassToRemember)
            {
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookiePassword(), "");
                BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberPassword(), this.signInState.IsPassToRemember.ToString());
            }
        }

        //sets names to their current values before page loads. Need to do that because checkboxes trigger PostBack event and 
        //values of textboxes would not be remembered otherwise
        private void SignIn_Control_PreRender(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            if (this.signInState.IsUNToRemember)
            {
                if ((this.signInState.UserName.Trim() != ""))
                {
                    this.CheckBoxUN.Checked = this.signInState.IsUNToRemember;
                    this.UserName.Text = this.signInState.UserName;
                }
            }
            if ((this.signInState.Password.Trim() != ""))
            {
                this.CheckBoxPass.Checked = this.signInState.IsPassToRemember;
                if (((this.Password.Text != "**********")
                            && (this.Password.Text.Trim() != "")))
                {
                    this.signInState.Password = this.Password.Text;
                }
                else
                {
                    this.Password.Text = this.signInState.Password;
                }
                this.signInState.LoginPassword = this.signInState.Password;
                Password.Attributes.Add("value", "**********");
            }
            else if ((this.Password.Text.Trim() == ""))
            {
                Password.Attributes.Add("value", "");
                this.signInState.LoginPassword = "";
            }
            else
            {
                this.signInState.LoginPassword = "";
            }
            
        }

        public void CheckBoxUN_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            if ((this.CheckBoxUN.Checked == true))
            {
                this.signInState.IsUNToRemember = true;
                if ((this.Password.Text != "**********"))
                {
                    this.signInState.Password = this.Password.Text;
                }
            }
            else
            {
                this.signInState.IsUNToRemember = false;
                this.signInState.UserName = "";
                if (((this.Password.Text != "**********")
                            && (this.Password.Text.Trim() != "")))
                {
                    this.signInState.Password = this.Password.Text;
                }
            }
        }

        public void CheckBoxPass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            if ((this.CheckBoxPass.Checked == true))
            {
                this.signInState.IsPassToRemember = true;
                if ((this.Password.Text != "**********"))
                {
                    this.signInState.Password = this.Password.Text;
                }
            }
            else
            {
                this.signInState.IsPassToRemember = false;
                if (((this.Password.Text != "**********")
                            && (this.Password.Text.Trim() != "")))
                {
                    this.signInState.Password = this.Password.Text;
                }
            }
        }

        private void CheckBoxAutoLogin_CheckedChanged(object sender, System.EventArgs e)
        {
            string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
            bool isAutoLogin = this.CheckBoxAutoLogin.Checked;
            BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieAutoLogin(), isAutoLogin.ToString());
        }

        private void EventHandlersInit()
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            this.SignInControl.LoginSucceeded += MySetCookie;
            this.SignInControl.LoginFailed += ResetAutoLogin;
            this.CheckBoxUN.CheckedChanged += new EventHandler(CheckBoxUN_CheckedChanged);
            this.CheckBoxPass.CheckedChanged += new EventHandler(CheckBoxPass_CheckedChanged);
            this.CheckBoxAutoLogin.CheckedChanged += new EventHandler(CheckBoxAutoLogin_CheckedChanged);
            this.SignInControl.PreRender += new EventHandler(SignIn_Control_PreRender);
            this.Unload += new EventHandler(OnCloseWindow);
        }

        //CookieInit initializes all cookie values.
        private void CookieInit()
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }

            this.UserName.TabIndex = 1;
            this.Password.TabIndex = 2;
            this.CheckBoxUN.TabIndex = 3;
            this.CheckBoxPass.TabIndex = 4;
            this.CheckBoxAutoLogin.TabIndex = 5;
            this.CheckBoxPass.AutoPostBack = true;
            this.CheckBoxUN.AutoPostBack = true;

            Crypto CheckCrypto = new Crypto(Crypto.Providers.DES);
            string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;

            //isCancelled is set to true when cancel button is pressed
            this.signInState.IsCancelled = false;
            this.signInState.UserName = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieUserName());

            //OriginalUserName and other Original... members of signInState keep original values which are used when 
            //Cancel button is pressed to set all cookies to their original values. That is necessary to do because
            //cookie are being modified when checkboxes are triggered.
            this.signInState.OriginalUserName = this.signInState.UserName;
            if ((!(this.signInState.UserName == null)
                        && (this.signInState.UserName.Trim() != "")))
            {
                this.signInState.UserName = CheckCrypto.Decrypt(this.signInState.UserName, key, System.Text.Encoding.Unicode, false);
            }
            else
            {
                this.signInState.UserName = "";
            }
            this.signInState.Password = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookiePassword());
            this.signInState.OriginalPassword = this.signInState.Password;
            if ((!(this.signInState.Password == null)
                        && (this.signInState.Password.Trim() != "")))
            {
                this.signInState.Password = CheckCrypto.Decrypt(this.signInState.Password, key, System.Text.Encoding.Unicode, false);
            }
            else
            {
                this.signInState.Password = "";
            }
            string rUser = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieRememberName());
            this.signInState.OriginalRememberUser = rUser;

            //Need to check if check boxes are set to visible in Application Generation Options. If not - do not show them and
            //set to false their values
            if ((BaseClasses.Configuration.ApplicationSettings.Current.ShowRememberUserCheckBox.ToLower() == "false"))
            {
                this.CheckBoxUN.Visible = false;
                this.CheckBoxUN.Enabled = false;
                this.CheckBoxUNLbl.Visible = false;
                this.CheckBoxUNLbl.Enabled = false;
                this.signInState.IsUNToRemember = false;
            }
            else
            {              
                if ((!(rUser == null)
                        && (rUser.ToLower() == "true")))
                {
                    this.signInState.IsUNToRemember = true;
                }
                else
                {
                    this.signInState.IsUNToRemember = false;
                }
            }
            
            
            string rPassword = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieRememberPassword());
            this.signInState.OriginalRememberPassword = rPassword;
            if ((BaseClasses.Configuration.ApplicationSettings.Current.ShowRememberPasswordCheckBox.ToLower() == "false"))
            {
                this.CheckBoxPass.Enabled = false;
                this.CheckBoxPass.Visible = false;
                this.CheckBoxPassLbl.Visible = false;
                this.CheckBoxPassLbl.Enabled = false;
                this.signInState.IsPassToRemember = false;
            }
            else
            {          
                if ((!(rPassword == null)
                            && (rPassword.ToLower() == "true")))
                {
                    this.signInState.IsPassToRemember = true;
                }
                else
                {
                    this.signInState.IsPassToRemember = false;
                }
            }
            
            if (this.signInState.IsUNToRemember)
            {
                if ((this.signInState.UserName.Trim() != ""))
                {
                    this.CheckBoxUN.Checked = this.signInState.IsUNToRemember;
                    this.UserName.Text = this.signInState.UserName;
                }
            }
            if ((this.signInState.Password.Trim() != ""))
            {
                this.CheckBoxPass.Checked = this.signInState.IsPassToRemember;
                if (((this.Password.Text != "**********")
                            && (this.Password.Text.Trim() != "")))
                {
                    this.signInState.Password = this.Password.Text;
                }
                else
                {
                    this.Password.Text = this.signInState.Password;
                }
                this.signInState.LoginPassword = this.signInState.Password;
                Password.Attributes.Add("value", "**********");
            }
            else if ((this.Password.Text.Trim() == ""))
            {
                Password.Attributes.Add("value", "");
                this.signInState.LoginPassword = "";
            }
            else
            {
                this.signInState.LoginPassword = "";
            }
           
            string isAutoLogin = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieAutoLogin());
            if ((BaseClasses.Configuration.ApplicationSettings.Current.ShowAutoSignInCheckBox.ToLower() == "false"))
            {
                this.CheckBoxAutoLogin.Visible = false;
                this.CheckBoxAutoLoginLbl.Visible = false;
                this.CheckBoxAutoLoginLbl.Enabled = false;
                this.CheckBoxAutoLogin.Enabled = false;
                this.signInState.IsAutoLogin = false;
            }
            // Get value of automatically login cookie, if not set AND security used is Active Directory, than use
            //default value which is True to allow user be automatically signed in with his current credentials
            if (((isAutoLogin == null)
                        || (isAutoLogin == "")))
            {
                switch (BaseClasses.Configuration.ApplicationSettings.Current.AuthenticationType)
                {
                    case BaseClasses.Configuration.SecurityConstants.ActiveDirectorySecurity:
                        BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieAutoLogin(), "True");
                        isAutoLogin = "True";
                        break;
                    case BaseClasses.Configuration.SecurityConstants.ProprietorySecurity:
                        BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieAutoLogin(), "False");
                        isAutoLogin = "False";
                        break;
                    case BaseClasses.Configuration.SecurityConstants.None:
                        BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieAutoLogin(), "False");
                        isAutoLogin = "False";
                        break;
                }
            }
            if (((isAutoLogin.ToLower() == "true")
                        && this.signInState.IsAutoLogin))
            {
                this.CheckBoxAutoLogin.Checked = true;
                if ((!this.signInState.IsUNToRemember
                            || !this.signInState.IsPassToRemember))
                {
                    this.UserName.Text = "";
                    Password.Attributes.Add("value", "");
                    this.signInState.LoginPassword = "";
                }
                this.Login(true);
            }
            else
            {
                this.CheckBoxAutoLogin.Checked = false;
            }            
        }

        public void OnCloseWindow(object sender, System.EventArgs e)
        {
            if (this.signInState == null) { this.signInState = new SignInState(); }
            //Check if Cancel button clicked. If not and any "remember" box is unchecked, clear content
            if (!this.signInState.IsCancelled)
            {
                if (!this.signInState.IsUNToRemember)
                {
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberName(), Boolean.FalseString);
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieUserName(), "");
                }
                if (!this.signInState.IsPassToRemember)
                {
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieRememberPassword(), Boolean.FalseString);
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookiePassword(), "");
                }
            }
        }

#endregion

    }
}