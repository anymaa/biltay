using KumePortali.Business;
namespace KumePortali.UI
{
    public class SignInConstants
    {
        public const string UserName = "SIS_UserName";
        public const string Password = "SIS_Password";
        public const string OriginalUserName = "SIS_OriginalUserName";
        public const string OriginalPassword = "SIS_OriginalPassword";
        public const string OriginalRememberUser = "SIS_OriginalRememberUser";
        public const string OriginalRememberPassword = "SIS_OriginalRememberPassword";
        public const string IsUNToRemember = "SIS_IsUNToRemember";
        public const string IsPassToRemember = "SIS_IsPassToRemember";
        public const string IsCancelled = "SIS_IsCancelled";
        public const string IsAutoLogin = "SIS_IsAutoLogin";
        public const string LoginPassword = "SIS_LoginPassword";
    }
    //this class remembers state of different values at SignIn/SignOut stage in Session
    public class SignInState
    {
        private System.Web.SessionState.HttpSessionState Session;

        public SignInState()
        {
            this.Session = System.Web.HttpContext.Current.Session;
        }
        
        public string UserName
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.UserName]));
                if ((s == null))
                {
                    return "";
                }
                return s;
            }
            set
            {
                this.Session[SignInConstants.UserName] = value;
            }
        }

        public string Password
        {
            get
            {
                Business.Crypto CheckCrypto = new Business.Crypto(Crypto.Providers.DES);
                string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
                string s = ((string)(this.Session[SignInConstants.Password]));
                if (((s == null)
                            || (s.Trim() == "")))
                {
                    return "";
                }
                return CheckCrypto.Decrypt(s, key, System.Text.Encoding.Unicode, false);
            }
            set
            {
                Crypto CheckCrypto = new Crypto(Crypto.Providers.DES);
                string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
                this.Session[SignInConstants.Password] = CheckCrypto.Encrypt(value, key, System.Text.Encoding.Unicode, false);
            }
        }

        public string LoginPassword
        {
            get
            {
                Crypto CheckCrypto = new Crypto(Crypto.Providers.DES);
                string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
                string s = ((string)(this.Session[SignInConstants.LoginPassword]));
                if (((s == null)
                            || (s.Trim() == "")))
                {
                    return "";
                }
                return CheckCrypto.Decrypt(s, key, System.Text.Encoding.Unicode, false);
            }
            set
            {
                Crypto CheckCrypto = new Crypto(Crypto.Providers.DES);
                string key = BaseClasses.Configuration.ApplicationSettings.Current.CookieEncryptionKey;
                this.Session[SignInConstants.LoginPassword] = CheckCrypto.Encrypt(value, key, System.Text.Encoding.Unicode, false);
            }
        }

        public string OriginalUserName
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.OriginalUserName]));
                if ((s == null))
                {
                    return "";
                }
                return s;
            }
            set
            {
                this.Session[SignInConstants.OriginalUserName] = value;
            }
        }

        public string OriginalPassword
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.OriginalPassword]));
                if ((s == null))
                {
                    return "";
                }
                return s;
            }
            set
            {
                this.Session[SignInConstants.OriginalPassword] = value;
            }
        }

        public string OriginalRememberUser
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.OriginalRememberUser]));
                if ((s == null))
                {
                    return "";
                }
                return s;
            }
            set
            {
                this.Session[SignInConstants.OriginalRememberUser] = value;
            }
        }

        public string OriginalRememberPassword
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.OriginalRememberPassword]));
                if ((s == null))
                {
                    return "";
                }
                return s;
            }
            set
            {
                this.Session[SignInConstants.OriginalRememberPassword] = value;
            }
        }

        public bool IsUNToRemember
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.IsUNToRemember]));
                if ((s == null))
                {
                    return false;
                }
                return bool.Parse(s);
            }
            set
            {
                this.Session[SignInConstants.IsUNToRemember] = value.ToString();
            }
        }

        public bool IsPassToRemember
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.IsPassToRemember]));
                if ((s == null))
                {
                    return false;
                }
                return bool.Parse(s);
            }
            set
            {
                this.Session[SignInConstants.IsPassToRemember] = value.ToString();
            }
        }

        public bool IsCancelled
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.IsCancelled]));
                if ((s == null))
                {
                    return false;
                }
                return bool.Parse(s);
            }
            set
            {
                this.Session[SignInConstants.IsCancelled] = value.ToString();
            }
        }

        public bool IsAutoLogin
        {
            get
            {
                string s = ((string)(this.Session[SignInConstants.IsAutoLogin]));
                if ((s == null))
                {
                    return true;
                }
                return bool.Parse(s);
            }
            set
            {
                this.Session[SignInConstants.IsAutoLogin] = value.ToString();
            }
        }
    }
}

