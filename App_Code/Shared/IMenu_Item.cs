﻿
using Microsoft.VisualBasic;
  
namespace KumePortali.UI
{

  

    public interface IMenu_Item {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
            

#endregion

    }

  
}
  