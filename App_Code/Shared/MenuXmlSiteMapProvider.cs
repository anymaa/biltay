using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BaseClasses.Utils;
using BaseClasses.Configuration;

namespace KumePortali.UI 
{

	/// <summary>
	/// Summary description for MenuXmlSiteMapProvider
	/// This integrates site map provider with role based security.
	/// </summary>


	public class MenuXmlSiteMapProvider : XmlSiteMapProvider
	{
	    
	    // Check the logged in user against the role asigned for the current menu.
	    // Returns true if logged user belongs to the role. If not then false is returned.
        public override bool IsAccessibleToUser(HttpContext context, SiteMapNode node)
        {
            if (node.Roles.Count == 0)
            {
                return true;
            }
            else
            {
                return BaseClasses.Utils.SecurityControls.IsUserInRole(context, node.Roles);
            }
        }
	}
}