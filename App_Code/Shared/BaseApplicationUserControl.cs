using System;
using System.Web.UI;
using System.Collections;
using BaseClasses.Data;
using BaseClasses.Utils;

namespace KumePortali.UI
{
    public class BaseApplicationUserControl : BaseClasses.Web.UI.BaseUserControl
    {
        private bool _modifyRedirectUrlInProgress = false;

        public BaseApplicationUserControl()
        {
            this.PreRender += new EventHandler(Control_ClearControls_PreRender);
            this.Unload += new EventHandler(Control_SaveControls_Unload);
        }

        public virtual string ModifyRedirectUrl(string redirectUrl, string redirectArgument, bool bEncrypt)
        {
            const string PREFIX_NO_ENCODE = "NoUrlEncode:";
            if ((_modifyRedirectUrlInProgress))
            {
                return null;
            }
            else
            {
                _modifyRedirectUrlInProgress = true;
            }

            string finalRedirectUrl = redirectUrl;
            string finalRedirectArgument = redirectArgument;
            if ((finalRedirectUrl == null || finalRedirectUrl.Length == 0))
            {
                return "";
            }
            else if ((finalRedirectUrl.IndexOf('{') < 0))
            {
                return finalRedirectUrl;
            }
            else
            {
                if (redirectArgument != null && redirectArgument.Length > 0)
                {
                    string[] arguments = redirectArgument.Split(',');
                    for (int i = 0; i <= (arguments.Length - 1); i++)
                    {
                        finalRedirectUrl = finalRedirectUrl.Replace("{" + i.ToString() + "}", "{" + arguments[i] + "}");
                    }
                    finalRedirectArgument = "";
                }

                ArrayList controlList = GetAllRecordAndTableControls();
                if (controlList.Count == 0)
                {
                    return finalRedirectUrl;
                }

                Hashtable controlIdList = new Hashtable();
                foreach (Control control in controlList)
                {
                    controlIdList.Add(control.UniqueID, control);
                }
                ArrayList forwardTo = new ArrayList();
                string remainingUrl = finalRedirectUrl;
                while ((remainingUrl.IndexOf('{') > 0) & (remainingUrl.IndexOf('}') > 0) & (remainingUrl.IndexOf('{') < remainingUrl.IndexOf('}')))
                {
                    int leftIndex = remainingUrl.IndexOf('{');
                    int rightIndex = remainingUrl.IndexOf('}');
                    string expression = remainingUrl.Substring(leftIndex + 1, rightIndex - leftIndex - 1);
                    remainingUrl = remainingUrl.Substring(rightIndex + 1);
                    string prefix = null;
                    if ((expression.IndexOf(":") > 0))
                    {
                        prefix = expression.Substring(0, expression.IndexOf(":"));
                    }
                    if ((prefix != null) && (prefix.Length > 0) && (!((StringUtils.InvariantLCase(prefix) == StringUtils.InvariantLCase(PREFIX_NO_ENCODE)))) && (!(BaseRecord.IsKnownExpressionPrefix(prefix))))
                    {
                        if ((controlIdList.Contains(prefix)) & (!(forwardTo.Contains(prefix))))
                        {
                            forwardTo.Add(prefix);
                        }
                    }
                }
                
                foreach (string containerId in forwardTo)
                {
                    Control ctl = ((Control)(controlIdList[containerId]));
                    if (ctl != null)
                    {
                        if (ctl is BaseApplicationRecordControl)
                        {
                            finalRedirectUrl = ((BaseApplicationRecordControl)(ctl)).ModifyRedirectUrl(finalRedirectUrl, finalRedirectArgument,bEncrypt);
                        }
                        else if (ctl is BaseApplicationTableControl)
                        {
                            finalRedirectUrl = ((BaseApplicationTableControl)(ctl)).ModifyRedirectUrl(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                    }
                }

                foreach (Control control in controlList)
                {
                    if ((forwardTo.IndexOf(control.ID) < 0))
                    {
                        if (control is BaseApplicationRecordControl)
                        {
                            finalRedirectUrl = ((BaseApplicationRecordControl)(control)).ModifyRedirectUrl(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                        else if (control is BaseApplicationTableControl)
                        {
                            finalRedirectUrl = ((BaseApplicationTableControl)(control)).ModifyRedirectUrl(finalRedirectUrl, finalRedirectArgument, bEncrypt);
                        }
                    }
                }
            }
            _modifyRedirectUrlInProgress = false;
            return finalRedirectUrl;
        }

        private ArrayList GetAllRecordAndTableControls()
        {
            ArrayList controlList = new ArrayList();
            GetAllRecordAndTableControls(this, controlList);
            return controlList;
        }

        private void GetAllRecordAndTableControls(Control ctl, ArrayList controlList)
        {
            if (ctl == null)
            {
                return;
            }
            if (ctl is BaseApplicationRecordControl || ctl is BaseApplicationTableControl)
            {
                controlList.Add(ctl);
            }

            foreach (Control nextCtl in ctl.Controls)
            {
                GetAllRecordAndTableControls(nextCtl, controlList);
            }
        }

		public string GetResourceValue(string keyVal, string appName) 
		{ 
			object resObj = GetGlobalResourceObject(appName, keyVal); 
			try 
			{
				if (!(resObj == null)) 
				{ 
					return resObj.ToString();  
				} 
				return ""; 
			}
			catch(Exception ) 
			{
				return ""; 
			}
			
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
            if (value == null || value.Length == 0)
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