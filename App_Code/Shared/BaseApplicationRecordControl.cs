using System;
using System.Web.UI;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;

namespace KumePortali.UI
{
    public class BaseApplicationRecordControl : System.Web.UI.Control
    {
        public BaseApplicationRecordControl()
        {
            this.PreRender += new EventHandler(Control_ClearControls_PreRender);
            this.Unload += new EventHandler(Control_SaveControls_Unload);
        }

        public virtual string ModifyRedirectUrl(string redirectUrl, string redirectArgument, bool bEncrypt)
        {
            throw new Exception("This function should be implemented by inherited record control class.");
        }

        public virtual string ModifyRedirectUrl(string redirectUrl, string redirectArgument, IRecord rec, bool bEncrypt)
        {
            const string PREFIX_NO_ENCODE = "NoUrlEncode:";
            string finalRedirectUrl = redirectUrl;
            string finalRedirectArgument = redirectArgument;
            if ((finalRedirectUrl == null || finalRedirectUrl.Length == 0))
            {
                return finalRedirectUrl;
            }
            else if ((finalRedirectUrl.IndexOf('{') < 0))
            {
                return finalRedirectUrl;
            }
            else
            {
                if (finalRedirectArgument != null && finalRedirectArgument.Length > 0)
                {
                    string[] arguments = finalRedirectArgument.Split(',');
                    for (int i = 0; i <= (arguments.Length - 1); i++)
                    {
                        finalRedirectUrl = finalRedirectUrl.Replace("{" + i.ToString() + "}", "{" + arguments[i] + "}");
                    }
                    finalRedirectArgument = "";
                }
                string remainingUrl = finalRedirectUrl;
                while ((remainingUrl.IndexOf('{') > 0) & (remainingUrl.IndexOf('}') > 0) & (remainingUrl.IndexOf('{') < remainingUrl.IndexOf('}')))
                {
                    int leftIndex = remainingUrl.IndexOf('{');
                    int rightIndex = remainingUrl.IndexOf('}');
                    string expression = remainingUrl.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
                    string origExpression = expression;
                    remainingUrl = remainingUrl.Substring(rightIndex + 1);
                    bool skip = false;
                    bool returnEmptyStringOnFail = false;
                    string prefix = null;
                    if ((expression.IndexOf(":") > 0))
                    {
                        prefix = expression.Substring(0, expression.IndexOf(":"));
                    }
                    if ((prefix != null) && (prefix.Length > 0) && (!((StringUtils.InvariantLCase(prefix) == StringUtils.InvariantLCase(PREFIX_NO_ENCODE)))) && (!(BaseRecord.IsKnownExpressionPrefix(prefix))))
                    {
                       // Remove the ASCX Prefix
                        string IdString = this.ID;
                        if (IdString.StartsWith("_"))
                        {
                            IdString = IdString.Remove(0, 1);
                        }
                        if ((prefix == IdString))
                        {
                            returnEmptyStringOnFail = true;
                            expression = expression.Substring(expression.IndexOf(":") + 1);
                        }
                        else
                        {
                            skip = true;
                        }
                    }
                    if ((!(skip)))
                    {
                        bool bUrlEncode = true;
                        if ((StringUtils.InvariantLCase(expression).StartsWith(StringUtils.InvariantLCase(PREFIX_NO_ENCODE))))
                        {
                            bUrlEncode = false;
                            expression = expression.Substring(PREFIX_NO_ENCODE.Length);
                        }
                        object result = null;
                        try
                        {
                            if (rec != null)
                            {
                                result = rec.EvaluateExpression(expression);
                            }
                        }
                        catch (Exception )
                        {
                        }
                        if (result != null)
                        {
                            result = result.ToString();
                        }
                        if (result == null)
                        {
                            if ((!(returnEmptyStringOnFail)))
                            {
                                return finalRedirectUrl;
                            }
                            else
                            {
                                result = string.Empty;
                            }
                        }
                        if ((bUrlEncode))
                        {
                            result = System.Web.HttpUtility.UrlEncode(((string)(result)));
                            if (result == null)
                            {
                                result = string.Empty;
                            }
                        }
                        if(bEncrypt) {
                            if(result!= null) {
                                result = ((BaseApplicationPage)(this.Page)).Encrypt((string)result);
                            }
                        }
                        finalRedirectUrl = finalRedirectUrl.Replace("{" + origExpression + "}", ((string)(result)));
                    }
                }
            }
            return finalRedirectUrl;
        }

        protected void Control_SaveControls_Unload(object sender, EventArgs e)
        {
            if (((BaseApplicationPage)(this.Page)).ShouldSaveControlsToSession)
            {
                this.SaveControlsToSession();
            }
        }

        protected virtual void SaveControlsToSession()
        {
        }

        protected void Control_ClearControls_PreRender(object sender, EventArgs e)
        {
            this.ClearControlsFromSession();
        }

        protected virtual void ClearControlsFromSession()
        {
        }

        public void SaveToSession(Control control, string value)
        {
            SaveToSession(control.UniqueID, value);
        }

        public string GetFromSession(Control control, string defaultValue)
        {
            return GetFromSession(control.UniqueID, defaultValue);
        }

        public string GetFromSession(Control control)
        {
            return GetFromSession(control.UniqueID, null);
        }

        public void RemoveFromSession(Control control)
        {
            RemoveFromSession(control.UniqueID);
        }

        public bool InSession(Control control)
        {
            return InSession(control.UniqueID);
        }

        public void SaveToSession(Control control, string variable, string value)
        {
            SaveToSession(control.UniqueID + variable, value);
        }

        public string GetFromSession(Control control, string variable, string defaultValue)
        {
            return GetFromSession(control.UniqueID + variable, defaultValue);
        }

        public void RemoveFromSession(Control control, string variable)
        {
            RemoveFromSession(control.UniqueID + variable);
        }

        public bool InSession(Control control, string variable)
        {
            return InSession(control.UniqueID + variable);
        }

        public void SaveToSession(string name, string value)
        {
            this.Page.Session[GetValueKey(name)] = value;
        }

        public string GetFromSession(string name, string defaultValue)
        {
            string value = ((string)(this.Page.Session[GetValueKey(name)]));
            if (value == null || value.Trim() == "")
            {
                value = defaultValue;
            }
            return value;
        }

        public string GetFromSession(string name)
        {
            return GetFromSession(name, null);
        }

        public void RemoveFromSession(string name)
        {
            this.Page.Session.Remove(GetValueKey(name));
        }

        public bool InSession(string name)
        {
            return (!(this.Page.Session[GetValueKey(name)] == null));
        }

        public string GetValueKey(string name)
        {
            return this.Page.Session.SessionID + this.Page.AppRelativeVirtualPath + name;
        }
    }
}