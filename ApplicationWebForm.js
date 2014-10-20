//<script>

/*
 * Sets the focus on the first element that should "reasonably" receive it
 */
function Fev_FocusOnFirstFocusableFormElement()
{
    for (i = 0; i < document.forms.length; i++)
    {
        if (Fev_FocusOnDefaultElement(document.forms[i])) return;
        //if (Fev_FocusOnFirstFocusableElement(document.forms[i])) return;
    }
}

/*
 * Sets the focus on the first element that is able to receive it
 */
function Fev_FocusOnFirstFocusableElement(objForm)
{
    if (objForm && (objForm != null))
    {
        for (i = 0; i < objForm.length; i++)
        {
            var objElement = objForm.elements[i];
            if (Fev_IsFocusableElement(objElement))
            {
                objElement.focus();
                return true;
            }
        }
    }
    return false;
}

/*
 * Sets the focus on the first element that should "reasonably" receive it
 */
function Fev_FocusOnDefaultElement(objForm)
{
    if (objForm && (objForm != null))
    {
        for (i = 0; i < objForm.length; i++)
        {
            var objElement = objForm.elements[i];
            if (Fev_IsFocusableElement(objElement))
            {
                var strType = Fev_GetElementType(objElement);
                //we know (strType != null) because it was checked within Fev_IsFocusableElement().
                if (strType.toLowerCase().indexOf("select") == 0)
                {
                    //NOTE: SELECT tags are ignored (they interfere with mousewheel scrolling when they have focus)
                }
                else
                {
                	// if object and all it's parents are visible...
					if (Fev_IsElementVisible(objElement))
	                {
	                	objElement.focus();
	                	return true;
	                }
                }
            }
        }
    }
    return false;
}

/*
 * returns true if the element can receive focus
 */
function Fev_IsFocusableElement(objElement)
{
    if (objElement && 
        (objElement != null) && 
        Fev_IsElementEnabled(objElement) && 
        Fev_IsElementVisible(objElement) && 
        Fev_IsElementEditable(objElement) )
    {
        var strType = Fev_GetElementType(objElement);
        if (strType != null)
        {
            if ((strType == "text") || (strType == "textarea") || (strType.toString().charAt(0) == "s"))
            {
                return true;
            }
        }
    }
    return false;
}

/*
 * returns true if the element is enabled
 */
function Fev_IsElementEnabled(objElement)
{
    if (objElement && (objElement != null))
    {
        if (!(objElement.disabled == false))
        {
            return false;
        }
        return true;
    }
    return false;
}

/*
 * returns true if the element's content is editable by the user
 */
function Fev_IsElementEditable(objElement)
{
    if (objElement && (objElement != null))
    {
        if (objElement.readOnly)
        {
            return false;
        }
        if ((!objElement.isContentEditable) && (typeof(objElement.isContentEditable) != 'undefined'))
        {
            return false;
        }
        return true;
    }
    return false;
}

/*
 * returns true if the element is visible to the user
 */
function Fev_IsElementVisible(objElement)
{
    if (objElement && (objElement != null))
    {
        if (objElement.style && (objElement.style != null))
        {
            if (objElement.style.display && (objElement.style.display.toLowerCase() == 'none'))
            {
                return false;
            }
            if (objElement.style.visibility && (objElement.style.visibility.toLowerCase() == 'hidden'))
            {
                return false;
            }
            /*
            if (objElement.style.visibility && (objElement.style.visibility.toLowerCase() == 'inherit'))
            {
                var objParentElement = Fev_GetParentElement(objElement);
                if (objParentElement && (objParentElement != null) && (!Fev_IsElementVisible(objParentElement)))
                {
                    return false;
                }
            }
            */
        }
        
        var objParentElement = Fev_GetParentElement(objElement);
        if (objParentElement && (objParentElement != null))
        {
            return Fev_IsElementVisible(objParentElement);
        }
		else
		{
	        return true;
        }
    }
    return false;
}

/*
 * returns true if the element responds directly to Enter key presses
 * return true for:
 *     Textarea, Select/Dropdown, Input Buttons (Submit/Button/Image/Reset),
 *     A tags
 * return false for everything else, including:
 *     Input type=[Radio/Checkbox/Text/Password/File]
 *     IMG tags
 */
function Fev_IsElementUsesEnterKey(objElement)
{
    if (objElement && (objElement != null))
    {
        var strType = Fev_GetElementType(objElement);
        if (strType != null) strType = strType.toLowerCase();
        switch (strType)
        {
            case "textarea":
            case "select":
            case "submit":
            case "button":
            case "image":
            case "reset":
                return true;
                break;
            case "radio":
            case "checkbox":
            case "text":
            case "password":
            case "file":
            case "select-multiple":
            case "select-single":
                return false;
                break;
            default: 
                break;
        }

        var strTagName = Fev_GetElementTagName(objElement);
        if (strTagName != null) strTagName = strTagName.toLowerCase();
        switch (strTagName)
        {
            case "textarea":
            case "select":
            case "a":
                return true;
                break;
            case "img":
            case "input":
            default:
                break;
        }
    }
    return false;
}

function Fev_GetParentElement(objElement)
{
    if (objElement && (objElement != null))
    {
        if (objElement.parentNode && (objElement.parentNode != null))
        {
            return objElement.parentNode;
        }
        if (objElement.parentElement && (objElement.parentElement != null))
        {
            return objElement.parentElement;
        }
    }
    return null;
}

function Fev_GetElementType(objElement)
{
    if (objElement && (objElement != null))
    {
        if (objElement.type)
        {
            return objElement.type;
        }
    }
    return null;
}

function Fev_GetElementTagName(objElement)
{
    if (objElement && (objElement != null))
    {
        if (objElement.tagName)
        {
            return objElement.tagName;
        }
    }
    return null;
}

function Fev_GetEventSourceElement(objEvent)
{
    if (objEvent && (objEvent != null))
    {
    	// if IE...
        if (objEvent.srcElement)
        {
            return objEvent.srcElement;
        }
        // if Firefox...
        else if (objEvent.target)
        {
            return objEvent.target;
        }
    }
    return null;
}

function Fev_IsEnterKeyPressed(bIgnoreTextAreaEvents)
{
    if (window.event)
    {
        var e = window.event;
        var bIsEnterKeyPress = ((e.keyCode == 13) && (e.type == 'keypress'));
        if (bIsEnterKeyPress)
        {
            if (bIgnoreTextAreaEvents && (bIgnoreTextAreaEvents == true))
            {
                var strType = Fev_GetElementType(Fev_GetEventSourceElement(e));
                if (strType != null) strType = strType.toLowerCase();
                if (strType == "textarea")
                {
                    return false;
                }
            }
            return true;
        }
    }
    return false;
}

function Fev_IsFormSubmitKeyPress(event)
{
    // for IE...
    if (window.event)
    {
        var e = window.event;
        var bIsEnterKeyPress = ((e.keyCode == 13) && (e.type == 'keypress'));
        if (bIsEnterKeyPress)
        {
            var eventSrc = Fev_GetEventSourceElement(e);
            if (!Fev_IsElementUsesEnterKey(eventSrc))
            {
                return true;
            }
        }
    }
    // for Netscape/Firefox
    else if (event.which)
    {
        var bIsEnterKeyPress = (event.which == 13);
        if (bIsEnterKeyPress)
        {
            var eventSrc = Fev_GetEventSourceElement(event);
            if (!Fev_IsElementUsesEnterKey(eventSrc))
            {
                return true;
            }
        }
    }
    
    return false;
}

/**************************************************************************************
 *  Function    : getHRefName()                                                       *
 *  Description : We need to get the name of button used in the <a href tag.  For     *
 *                example, if the href tag = __doPostBack('Menu1$Button') then we     *
 *        need to return Menu1$Button.                        *
 *  Parameters  : anElement: anElement whose HRef value is retrieved and          *
 *        and parsed.                                 *
 **************************************************************************************/
function getHRefName(anElement)
{
    var anHRef = anElement.href;
    
    var startpos = anHRef.indexOf("doPostBack('");
    if (startpos >= 0) {
        startpos = startpos + "doPostBack('".length;
    } else {
        if (navigator.appName == "Netscape") {
            startpos = anHRef.indexOf('DoPostBackWithOptions(new WebForm_PostBackOptions("');
            startpos = startpos + 'DoPostBackWithOptions(new WebForm_PostBackOptions("'.length;
        }
        else { // IE
            startpos = anHRef.indexOf('DoPostBackWithOptions(new%20WebForm_PostBackOptions("');
            startpos = startpos + 'DoPostBackWithOptions(new%20WebForm_PostBackOptions("'.length;
        }
    }
    
    var endpos = anHRef.indexOf("',");
    if (endpos < 0) endpos = anHRef.indexOf('",'); 
    

    anHRef = anHRef.substring(startpos, endpos);
    
    return anHRef;
}

/**************************************************************************************
 *  Function    : clickLinkButtonText()                                               *
 *  Description : onclick event handler for HTML table/row shell surrounding button   *
 *                    text link.  Locates the anchor in the center table cell and     *
 *                    invokes Fev_ClickButton (passing it the anchor's button id) to  *
 *                    simulate a physical clicking of the button text link.           *
 *  Parameters  : pButtonTableOrRowNode, html table/row shell receiving the onclick   *
 *                    event, and which surrounds the button text link to be clicked   *
 *                event, browser-generated onclick event object                       *
 *  Assumptions : Only "button" and "menu item" HTML table/row shells will call this  *
 *                    function.                                                       *
 *  ISD Feature : "Button/Menu Item Image Edges Clickable"                            *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function clickLinkButtonText(pButtonTableOrRowNode, event)
{
    // make sure to cancel bubbling of clicks.
    if (!event) return;
    event.cancelBubble = true;
    if (event.stopPropagation) event.stopPropagation();

    // also check to make sure the target was not the inner area.   
    // target is used by Firefox, srcElement is used by IE
    if (event.target && event.target.toString().toLowerCase().indexOf("dopostback") > -1) return;
    if (event.srcElement && event.srcElement.toString().toLowerCase().indexOf("dopostback") > -1) return;

    var lAnchorNodeArray = pButtonTableOrRowNode.getElementsByTagName("a");
    
    // if "button", "horizontal menu item", "vertical menu item middle row" clicked...
    if ((lAnchorNodeArray != null) && (lAnchorNodeArray.length == 1))
    {
        Fev_ClickButton(lAnchorNodeArray.item(0).id, event);
    }
    else // if "vertical menu item upper/lower row" clicked...
    {
        var lParentTableNode = pButtonTableOrRowNode.parentNode;
        var lChildrenNodeArray = lParentTableNode.getElementsByTagName("tr");
        // alert("clickLinkButtonText(lChildrenNodeArray.length=" + lChildrenNodeArray.length + ")");
        
        if (lChildrenNodeArray != null)
        {
            var lClickedRowFound = false;
            var lCurrentRowItemNumber = 1; // ignore vertical menu edge top row

            // locate the clicked row (this will either be one row above or below
            //     the row containing the vertical menu item to be clicked); terminate search
            //     before vertical menu edge bottom row
            while ((lClickedRowFound == false) && (lCurrentRowItemNumber < lChildrenNodeArray.length-1))
            {
                if (lChildrenNodeArray.item(lCurrentRowItemNumber) != pButtonTableOrRowNode)
                {
                    lCurrentRowItemNumber++;
                }
                else
                {
                    // alert("clickLinkButtonText(lCurrentRowItemNumber=" + lCurrentRowItemNumber + ")");
                    lClickedRowFound = true;
                }
            }
        
            if (lClickedRowFound == true)
            {
                // if row above first vertical menu item was clicked...
                if (lCurrentRowItemNumber == 1)
                {
                    // vertical menu item to be clicked must be below clicked row
                    lAnchorNodeArray = lChildrenNodeArray.item(lCurrentRowItemNumber +1).getElementsByTagName("a");
                    // if row above vertical menu item was clicked...
                    if ((lAnchorNodeArray != null) && (lAnchorNodeArray.length == 1))
                    {
                        Fev_ClickButton(lAnchorNodeArray.item(0).id, event);
                    }
                }
                // if row below last vertical menu item was clicked...
                else if (lCurrentRowItemNumber == (lChildrenNodeArray.length-2))
                {
                    // vertical menu item to be clicked must be above clicked row
                    lAnchorNodeArray = lChildrenNodeArray.item(lCurrentRowItemNumber -1).getElementsByTagName("a");
                    ((lAnchorNodeArray != null) && (lAnchorNodeArray.length == 1))
                    {
                        Fev_ClickButton(lAnchorNodeArray.item(0).id, event);
                    }
                }
                // if row of any other vertical menu item was clicked...
                else
                {
                    lAnchorNodeArray = lChildrenNodeArray.item(lCurrentRowItemNumber +1).getElementsByTagName("a");
                    // if row above vertical menu item was clicked...
                    if ((lAnchorNodeArray != null) && (lAnchorNodeArray.length == 1))
                    {
                        Fev_ClickButton(lAnchorNodeArray.item(0).id, event);
                    }
                    // if row below vertical menu item was clicked...
                    else
                    {
                        lAnchorNodeArray = lChildrenNodeArray.item(lCurrentRowItemNumber -1).getElementsByTagName("a");
                        ((lAnchorNodeArray != null) && (lAnchorNodeArray.length == 1))
                        {
                            Fev_ClickButton(lAnchorNodeArray.item(0).id, event);
                        }
                    }
                }
            }
        }
    }
}


function Fev_ClickButton(buttonId, event)
{
    // make sure to cancel bubbling of clicks.
    if (!event) return;
    event.cancelBubble = true;
    if (event.stopPropagation) event.stopPropagation();

    var buttonIdWithUnderscores = buttonId;

    var button = document.getElementById(buttonId);
    
    // If button is null, then try replacing $ with _ and look again.
    if (button == null)
    {
        while (buttonIdWithUnderscores.indexOf("$") != -1)
        {
             buttonIdWithUnderscores = buttonIdWithUnderscores.replace("$", "_");
        }

        button = document.getElementById(buttonIdWithUnderscores);
    }

    // Still nothing?  Try appending _Button
    if (button == null)
    {
        button = document.getElementById(buttonIdWithUnderscores + '_Button');
    }

    // Still nothing?  Try appending __Button
    if (button == null)
    {
        button = document.getElementById(buttonIdWithUnderscores + '__Button');
    }

    if (button)
    {
        // var anHRef = getHRefName(button);
        // if (anHRef)
        // {

            var nav = navigator.appName;
            if (nav.toUpperCase().indexOf(('Microsoft').toUpperCase()) >= 0)
            {
                button.click();             
            }
            else
            {
                var anHRef;
                // retrieve the entire href, stripping out (if any) the preceding "javascript:" string
                if (button.href.toLowerCase().indexOf("javascript:") >= 0)
                {
                    anHRef = button.href.substring("javascript:".length,button.href.length);
                }
                else
                {
                    anHRef = button.href;
                }
                // convert all HTML-encoded quotes into true quotes
                anHRef = anHRef.replace("&quot;",'"');

				// call the javascript built-in function to execute the href string (in effect, this is analogous
				//     to IE's button.click(), but without having to do the complicated parsing of the href string
				//     to decide between regular "doPostBack"s and "doPostBackWithOptions"s)
                eval(anHRef);
                
                /*
                if (DoesButtonUsePostbackWithOptions(button)) 

                {
                    WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions(buttonId, "", true, "", "", false, true));
                }
                else
                {
                    __doPostBack(anHRef, "");
                }                
				*/                
            }
          
            return true;
        // }
    }
    return false;
}

// returns true if the href uses PostBackWithOptions.
function DoesButtonUsePostbackWithOptions(anElement)

{
    var anHRef = anElement.href;
    var startpos = anHRef.indexOf('PostBackWithOptions');
    if (startpos >= 0) 
    {
        return true;
    }
    return false;
}
//Sets the value or selection of the form element, independent of the element's type.
function Fev_SetFormControlValue(objElement, strValue)
{
    var strTagName = Fev_GetElementTagName(objElement);
    if (strTagName != null) strTagName = strTagName.toLowerCase();
    switch (strTagName)
    {
        case "textarea":
            objElement.value = strValue;
            return true;
            break;
        case "select":
            var currentIndex = objElement.selectedIndex;
            objElement.value = strValue;
            if (objElement.selectedIndex < 0)
            {
                objElement.selectedIndex = currentIndex;
                return false;
            }
            return true;
            break;
        case "input":
            switch (objElement.type.toLowerCase())
            {
                case "text":
                case "password":
                case "hidden":
                    objElement.value = strValue;
                    return true;
                    break;
                case "file":
                    //can't programatically set the value of file controls
                    return false;
                case "checkbox":
                    if ((strValue == null) || (strValue == ''))
                    {
                        objElement.checked = false;
                        return true;
                        break;
                    }
                    else if (strValue == objElement.value)
                    {
                        objElement.checked = true;
                        return true;
                        break;
                    }
                    else
                    {
                        //the specified value matches niether the checked nor unchecked state
                        //objElement.checked = true;
                        //objElement.value = strValue;
                        //return true;
                        break;
                    }
                case "radio":
                    if (strValue == null)
                    {
                        //uncheck all radio buttons in the group
                        objElement.checked = true;
                        objElement.checked = false;
                        return true;
                        break;
                    }
                    else if (strValue == objElement.value)
                    {
                        objElement.checked = true;
                        return true;
                        break;
                    }
                    else
                    {
                        var f = objElement.form;
                        var allRadioButtonsInGroup = f.elements(objElement.name)
                        for (i = 0; i < allRadioButtonsInGroup.length; i++)
                        {
                            var rb = allRadioButtonsInGroup[i];
                            if (strValue == rb.value)
                            {
                                rb.checked = true;
                                return true;
                            }
                        }
                        //the specified value matches the checked state of none of the radio buttons
                        //objElement.checked = true;
                        //objElement.checked = false;
                        //return true;
                        break;
                    }
                default:
                    break;
            }
        default:
            break;
    }
    return false;
}

//Inserts the value into a list element, independent of the element's type.
function Fev_ReplaceLastListControlOption(objListElement, strValue, strText)
{
    var strTagName = Fev_GetElementTagName(objListElement);
    if (strTagName != null) strTagName = strTagName.toLowerCase();
    switch (strTagName)
    {
        case "select":
            var objOption = objListElement.options[objListElement.options.length-1];
            objOption.value = strValue;
            objOption.text = strText;
            //objOption.innerText = strText;
            return true;
            break;
        default:
            break;
    }
    return false;
}

function Fev_HandleFormSubmitKeyPress(buttonId, event)
{
    if (Fev_IsFormSubmitKeyPress(event))
    {
        if (Fev_ClickButton(buttonId, event))
        {
            event.cancelBubble = false;
            return true;
        }
    }
    return false;
}


/**************************************************************************************
 *  Function    : refreshFixedHeaderRows()                                            *
 *  Description : Upon expand/collapse of record/table panels, forces a repositioning *
 *                    of any scrolling table's "fixed" header row (to it proper       *
 *                    location above/relative to the rest of the shifted table rows.  *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function refreshFixedHeaderRows()
{
	var lHeaderRowNodesArray = document.getElementsByTagName("thead");
	for (var i=0; i<lHeaderRowNodesArray.length; i++)
	{
		var lHeaderRowNode = lHeaderRowNodesArray.item(i);
		if (lHeaderRowNode.className == "fixedHeader")
		{
			lHeaderRowNode.style.position = "absolute";
			lHeaderRowNode.style.position = "relative";
		}
	}
}


/**************************************************************************************
 *  Function    : toggleExpandCollapse()                                              *
 *  Description : Toggles the expanding and collapsing of the content region of       *
 *                    record and table panels; also swaps the "expand/collapse" icon, *
 *                    and "total records" count based upon the current                *
 *                    expand/collapse state.                                          *
 *  Parameters  : anchorNode, <a> tag node which is clicked upon to initiate toggling *
 *                    of expand/collapse                                              *
 *  Assumptions : The region which is expanded/collapsed is the table (with HTML      *
 *                    id, "CollapsibleRegion") within the sibling (row) of the table  *
 *                    row which contains the anchorNode.                              *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function toggleExpandCollapse(anchorNode)
{
    var collapsibleNode = anchorNode;
        
	// traverse up node tree until the parent table which contains the "dialog_header" and the "collapsible region" is found
    while (true)
    {
    	collapsibleNode = collapsibleNode.parentNode;
    	if ( (collapsibleNode != null) &&
    		 (collapsibleNode.tagName == "TABLE") &&
    		 ((collapsibleNode.className == "dialog_view") || (collapsibleNode.className == "dv"))
    	   )
    	{
			break;
    	}
    }
    
    // traverse down node tree to "collapsible region"    
    var childNodesArray = collapsibleNode.getElementsByTagName("TABLE"); 
    for (var i=0; i<childNodesArray.length; i++)
    {
    	if (childNodesArray.item(i).id == "CollapsibleRegion")
    	{
    		collapsibleNode = childNodesArray.item(i);
   			break; 		
    	}
    }
    
    // make sure this node is a collapsible region before collapsing
    if ((collapsibleNode != null) && (collapsibleNode.id == "CollapsibleRegion") && (collapsibleNode.tagName == "TABLE"))
    {
        collapsibleNode.style.display = (collapsibleNode.style.display == "") ? "none" : "";

		// reposition any scrolling tables' "fixed header" row
        refreshFixedHeaderRows();        
    }
    
    // traverse to image node (note that for both Netscape and IE, this is the first child of anchor tag)
    var imageNode = anchorNode.childNodes.item(0);

    // make sure this node contains the expand/collapse image before swapping icon
    if ((imageNode.id == "ExpandCollapseIcon") && (imageNode.tagName == "IMG"))
    {
        // show appropriate icon for current expand/collapse state
        imageNode.src = (collapsibleNode.style.display == "") ? "../Images/DialogHeaderIconCollapse.gif" : "../Images/DialogHeaderIconExpand.gif";
        
        // show appropriate tool tip for current expand/collapse state (for section 508 compliance)
        // imageNode.alt = (collapsibleNode.style.display == "") ? "Collapse panel" : "Expand panel";
        // imageNode.title = (collapsibleNode.style.display == "") ? "Collapse panel" : "Expand panel";
    }
    
    
	// traverse up node tree until the parent table which contains the "dialog_header" and the "collapsible region" is found
    var totalRecordsNode = anchorNode;

	while (true)
    {
    	totalRecordsNode = totalRecordsNode.parentNode;
	   	if ( (totalRecordsNode != null) &&
    		 (totalRecordsNode.tagName == "TD") &&
    		 ((totalRecordsNode.className == "dialog_header") || (totalRecordsNode.className == "dh"))
    	   )
    	{
    		break;
    	}
    }
    
    // traverse down node tree to "collapsible region total records"    
    var childNodesArray = totalRecordsNode.getElementsByTagName("TABLE"); 
    for (var i=0; i<childNodesArray.length; i++)
    {
    	if (childNodesArray.item(i).id == "CollapsibleRegionTotalRecords")
    	{
    		totalRecordsNode = childNodesArray.item(i);
   			break; 		
    	}
    }
    
    // make sure this node contains the total records count before toggling
    if ((totalRecordsNode != null) && (totalRecordsNode.id == "CollapsibleRegionTotalRecords") && (totalRecordsNode.tagName == "TABLE"))
    {
        // show total records count if panel in collapsed state
        totalRecordsNode.style.display = (totalRecordsNode.style.display == "") ? "none" : "";
    }   
    
    return false;
}


/**************************************************************************************
 *  Function    : toggleRegions()                                                     *
 *  Description : Cycles between "hiding filter", "hiding filters and pagination",    *
 *                    "hiding all" (including table data), and "showing all" regions. *
 *  Parameters  : aRegionName, html id of the region to be collapsed                  *
 *  ISD Feature : "Show/Hide Filter/Pagination"                                       *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function toggleRegions(aAnchorNode)
{
	var lToggleRegionIconNode = aAnchorNode.childNodes.item(0);

	if (lToggleRegionIconNode.id == "ToggleRegionIcon")
	{
		if (lToggleRegionIconNode.src.indexOf("ToggleHideFilters") != -1)
		{
			lToggleRegionIconNode.src = lToggleRegionIconNode.src.replace("ToggleHideFilters","ToggleHidePagination");
			// lToggleRegionIconNode.alt = "Hide Pagination";
			
			var lFilterRegionNode = getRegion(aAnchorNode, "FilterRegion");
			if (lFilterRegionNode != null)
			{
				lFilterRegionNode.style.display = "none";
			}
			var lCategoryRegionNode = getRegion(aAnchorNode, "CategoryRegion");
			if (lCategoryRegionNode != null)
			{
				lCategoryRegionNode.style.display = "none";
			}
		}
		else if (lToggleRegionIconNode.src.indexOf("ToggleHidePagination") != -1)
		{
			lToggleRegionIconNode.src = lToggleRegionIconNode.src.replace("ToggleHidePagination","ToggleHideAll");
			// lToggleRegionIconNode.alt = "Hide All";

			var lPaginationRegionNode = getRegion(aAnchorNode, "PaginationRegion");
			var lTotalRecordsRegionNode = getRegion(aAnchorNode, "CollapsibleRegionTotalRecords");
			if ((lPaginationRegionNode != null) && (lTotalRecordsRegionNode != null))
			{
				lPaginationRegionNode.style.display = "none";
				lTotalRecordsRegionNode.style.display = "";
			}
		}
		else if (lToggleRegionIconNode.src.indexOf("ToggleHideAll") != -1)
		{
			lToggleRegionIconNode.src = lToggleRegionIconNode.src.replace("ToggleHideAll","ToggleShowAll");
			// lToggleRegionIconNode.alt = "Show All";

			var lCollapsibleRegionNode = getRegion(aAnchorNode, "CollapsibleRegion");
			if (lCollapsibleRegionNode != null)
			{
				lCollapsibleRegionNode.style.display = "none";
			}
		}
		else if (lToggleRegionIconNode.src.indexOf("ToggleShowAll") != -1)
		{
			lToggleRegionIconNode.src = lToggleRegionIconNode.src.replace("ToggleShowAll","ToggleHideFilters");
			// lToggleRegionIconNode.alt = "Hide Filters";

			var lCollapsibleRegionNode= getRegion(aAnchorNode, "CollapsibleRegion");
			if (lCollapsibleRegionNode != null)
			{
				lCollapsibleRegionNode.style.display = "";
			}
			var lFilterRegionNode = getRegion(aAnchorNode, "FilterRegion");
			if (lFilterRegionNode != null)
			{
				lFilterRegionNode.style.display = "";
			}
			var lCategoryRegionNode = getRegion(aAnchorNode, "CategoryRegion");
			if (lCategoryRegionNode != null)
			{
				lCategoryRegionNode.style.display = "";
			}
			var lPaginationRegionNode = getRegion(aAnchorNode, "PaginationRegion");
			if (lPaginationRegionNode != null)
			{
				lPaginationRegionNode.style.display = "";
			}
			var lTotalRecordsRegionNode = getRegion(aAnchorNode, "CollapsibleRegionTotalRecords");
			if (lTotalRecordsRegionNode != null)
			{
				lTotalRecordsRegionNode.style.display = "none";
			}
		}

		// reposition any scrolling tables' "fixed header" row
        refreshFixedHeaderRows();        		
	}
}


/**************************************************************************************
 *  Function    : getRegion()                                                         *
 *  Description : Retrieves a reference to the specified collapsible region           *
 *                   associated with the table containing the specified anchor node.  *
 *  Parameters  : aAnchorNode, toggle regions button which has been clicked           *
 *                aRegionName, region to be collapsed                                 *
 *  ISD Feature : "Show/Hide Filter/Pagination"                                       *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function getRegion(aAnchorNode, aRegionName)
{
	var rRegionNode = null;
	var lMainTableNode = aAnchorNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode;
	// alert("getRegion(lMainTableNode.nodeName=" + lMainTableNode.nodeName + ",lMainTableNode.className=" + lMainTableNode.className + ")");
	var lContainedTableNodesArray = lMainTableNode.getElementsByTagName("table");
	
	// alert("getRegion(lContainedTableNodesArray.length=" + lContainedTableNodesArray.length + ")");
	for (var i=0;i<lContainedTableNodesArray.length;i++)
	{
		if (lContainedTableNodesArray[i].id == aRegionName)
		{
			// alert("getRegion(lContainedTableNodesArray[" + i + "].id=" + lContainedTableNodesArray[i].id + ")");
			rRegionNode = lContainedTableNodesArray[i];
			break;
		}
	}
	
	// alert("getRegion(rRegionNodeIsNull=" + (rRegionNode == null) + ")");
	return(rRegionNode);
}


/**************************************************************************************
 *  Function    : adjustPageSize()                                                    *
 *  Description : onkeyup event handler to increment/decrement page size value within *
 *                    specified lower and upper bounds.                               *
 *  Parameters  : aPageSizeTextboxNode, table cell containing page size textbox       *
 *                    which caught the onkeyup event)                                 *
 *                event, onkeyup event                                                *
 *                aLowerBound, lower bound for the page size value                    *
 *                aUpperBound, upper bound for the page size value                    *
 *  ISD Feature : "Increment/Decrement Numerical Fields"                              *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function adjustPageSize(aPageSizeTextboxNode, aKeyCode, aLowerBound, aUpperBound)
{
    // if (justDoIt == true)
	// {
		// myAlert("adjustPage(event.which=" + event.which + ",event.keyCode=" + event.keyCode + ")");
		
		if (aPageSizeTextboxNode != null)
		{
			var lWhichCode = aKeyCode;
			
			// if up arrow, or plus key...
			if ((lWhichCode == 38) || (lWhichCode == 107))
			{
				// strip "+" character if it has been appended to page size value
				while ((lWhichCode == 107) && (aPageSizeTextboxNode.value.charAt(aPageSizeTextboxNode.value.length-1) == "+"))
				{
					aPageSizeTextboxNode.value = (aPageSizeTextboxNode.value).substring(0,aPageSizeTextboxNode.value.length-1);
				}
				
				// if page size not initialized or contains invalid characters...
				if ((aPageSizeTextboxNode.value == "") || (isNaN(aPageSizeTextboxNode.value)))
				{
					// set initial value as "1"
					aPageSizeTextboxNode.value = 10;
				}
				else
				{
					// upper bounds check
					if (aPageSizeTextboxNode.value < aUpperBound)
					{
						aPageSizeTextboxNode.value = new Number(aPageSizeTextboxNode.value) + 1;
					}
				}
			}
			// else if down arrow, or minus key...
			else if ((lWhichCode == 40) || (lWhichCode == 109))
			{
				// strip "-" character if it has been appended to page size value
				while ((lWhichCode == 109) && (aPageSizeTextboxNode.value.charAt(aPageSizeTextboxNode.value.length-1) == "-"))
				{
					aPageSizeTextboxNode.value = (aPageSizeTextboxNode.value).substring(0,aPageSizeTextboxNode.value.length-1);
				}
				
				// if page size not initialized or contains invalid characters...
				if ((aPageSizeTextboxNode.value == "") || (isNaN(aPageSizeTextboxNode.value)))
				{
					// set initial value as "1"
					aPageSizeTextboxNode.value = 10;
				}
				else {
					// lower bounds check
					if (aPageSizeTextboxNode.value > aLowerBound)
					{
						aPageSizeTextboxNode.value = new Number(aPageSizeTextboxNode.value) - 1;
					}
				}
			}
		}
	// }
}


/**************************************************************************************
 *  Function    : adjustCurrency()                                                    *
 *  Description : onkeyup event handler to increment/decrement currency.              *
 *  Parameters  : aInputTextbox, html textbox containing the currency value to be     *
 *                    incremented/decremented                                         *
 *                aCurrencySymbol, the currency symbol which prepended to the         *
 *                    actual currency value                                           *
 *                aCurrencyDecimalSeparator, the symbol which divides the "whole"     *
 *                    portion of the currency from the "fractional" part              *
 *				  aIsCurrencySeparatorAtEnd, boolean indicating whether currency      *
 *                    symbol trails or precedes currency value                        *
 *  ISD Feature : "Increment/Decrement Numerical Fields"                              *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function adjustCurrency(aInputTextbox, aKeyCode, aCurrencySymbol, aCurrencyDecimalSeparator, aIsCurrencySeparatorAtEnd)
{
    // if (justDoIt == true)
	// {
		// var lWhichCode = event.keyCode;
		var lWhichCode = aKeyCode;
		
		// if up arrow, or plus key...
		if ((lWhichCode == 38) || (lWhichCode == 107) || (lWhichCode == 40) || (lWhichCode == 109))
		{
			if ((aCurrencySymbol != "") && (aCurrencyDecimalSeparator != ""))
			{
				// strip "+" character if it has been appended to currency value
				while ((lWhichCode == 107) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "+"))
				{
					aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
				}

				// strip "-" character if it has been appended to currency value
				while ((lWhichCode == 109) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "-"))
				{
					aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
				}
					
				// if currency value not initialized...
				if (aInputTextbox.value == "")
				{
					if (aIsCurrencySeparatorAtEnd.indexOf("False") != -1)
					{
						// set initial value (with leading currency symbol)
						aInputTextbox.value = aCurrencySymbol + "1" + aCurrencyDecimalSeparator + "00";
					}
					else
					{
						// set initial value (with trailing currency symbol)
						aInputTextbox.value = "1" + aCurrencyDecimalSeparator + "00" + aCurrencySymbol;
					}
				}
				else
				{
					if ((aInputTextbox.value).indexOf(aCurrencyDecimalSeparator) == -1)
					{
						aInputTextbox.value = aInputTextbox.value + aCurrencyDecimalSeparator + "00";
					}

					var lCurrencyArray = (aInputTextbox.value).replace(aCurrencySymbol,"").split(aCurrencyDecimalSeparator);
					
					var lCurrencyWhole = null;
					var lParenthesesRepresentationOfNegativeValue = false;
					// account for "parentheses" representation of negative value
					if ((aInputTextbox.value.indexOf("(") == 0) && (aInputTextbox.value.indexOf(")") == aInputTextbox.value.length-1))
					{
						lParenthesesRepresentationOfNegativeValue = true;
						lCurrencyArray[0] = "-" + lCurrencyArray[0];
					}
					
					if ((lWhichCode == 38) || (lWhichCode == 107))
					{
						lCurrencyWhole = new Number(lCurrencyArray[0].replace(/[^0-9,-]/g,"")) + 1;
					}
					// ((lWhichCode == 40) || (lWhichCode == 109))
					else
					{
						lCurrencyWhole = new Number(lCurrencyArray[0].replace(/[^0-9,-]/g,"")) - 1;
					}
					
					lCurrencyArray[1] = lCurrencyArray[1].replace(/[^0-9]/g,"")
					if (lCurrencyArray[1].length == 1)
					{
						lCurrencyArray[1] = lCurrencyArray[1] + "0";
					}
					
					var lCurrencyFraction = new Number(lCurrencyArray[1]);
					
					if ((lCurrencyFraction < 10) && (lCurrencyFraction >= 0))
					{
						lCurrencyFraction = "0" + lCurrencyFraction;
					}
					
					if (lCurrencyWhole >= 0)
					{
						if (aIsCurrencySeparatorAtEnd.indexOf("False") != -1)
						{						
							aInputTextbox.value = aCurrencySymbol + lCurrencyWhole + aCurrencyDecimalSeparator + lCurrencyFraction;
						}
						else
						{
							aInputTextbox.value = lCurrencyWhole + aCurrencyDecimalSeparator + lCurrencyFraction + aCurrencySymbol;
						}
					}
					else
					{
						if (aIsCurrencySeparatorAtEnd.indexOf("False") != -1)
						{			
							if (lParenthesesRepresentationOfNegativeValue == false)
							{			
								aInputTextbox.value = "-" + aCurrencySymbol + Math.abs(lCurrencyWhole) + aCurrencyDecimalSeparator + lCurrencyFraction;
							}
							else
							{
								aInputTextbox.value = "(" + aCurrencySymbol + Math.abs(lCurrencyWhole) + aCurrencyDecimalSeparator + lCurrencyFraction + ")";
							}
						}
						else
						{
							if (lParenthesesRepresentationOfNegativeValue == false)
							{			
								aInputTextbox.value = "-" + Math.abs(lCurrencyWhole) + aCurrencyDecimalSeparator + lCurrencyFraction + aCurrencySymbol;
							}
							else
							{
								aInputTextbox.value = "(" + Math.abs(lCurrencyWhole) + aCurrencyDecimalSeparator + lCurrencyFraction + aCurrencySymbol + ")";
							}						
						}
					}
				}
			}
		}
	// }
}



/**************************************************************************************
 *  Function    : adjustInteger()                                                     *
 *  Description : onkeyup event handler to increment/decrement integer fields.        *
 *  Parameters  : aInputTextbox, html textbox containing the integer value to be      *
 *                    incremented/decremented                                         *
 *  ISD Feature : "Increment/Decrement Numerical Fields"                              *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function adjustInteger(aInputTextbox, aKeyCode)
{
    // if (justDoIt == true)
	// {
		// var lWhichCode = event.keyCode;
		var lWhichCode = aKeyCode;
		
		// if up arrow, or plus key...
		if ((lWhichCode == 38) || (lWhichCode == 107))
		{
			// strip "+" character if it has been appended to integer value
			while ((lWhichCode == 107) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "+"))
			{
				aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
			}
				
			// if currency value not initialized or contains invalid characters...
			if ((aInputTextbox.value == "") || (isNaN(aInputTextbox.value)))
			{
				// set initial value
				aInputTextbox.value = "1";
			}
			else
			{
				// myAlert("adjustInteger(aInputTextbox.value=" + aInputTextbox.value + ")");
				aInputTextbox.value = new Number(aInputTextbox.value) + 1;
			}
		}
		// if down arrow, or minus key...
		else if ((lWhichCode == 40) || (lWhichCode == 109))
		{
			// strip "-" character if it has been appended to integer value
			while ((lWhichCode == 109) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "-"))

			{
				aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
			}
	
			// if currency value not initialized or contains invalid characters...
			if ((aInputTextbox.value == "") || (isNaN(aInputTextbox.value)))
			{
				// set initial value
				aInputTextbox.value = "1";
			}
			else
			{
				// myAlert("adjustInteger(aInputTextbox.value=" + aInputTextbox.value + ")");
				aInputTextbox.value = new Number(aInputTextbox.value) - 1;
			}
		}
	// }
}


/**************************************************************************************
 *  Function    : createNewDate()                                                     *
 *  Description : Create and return a new date object based on the value in the       *
 *                    specified textbox and the current date pattern.                 *
 *  Parameters  : aInputTextbox, textbox containing the current date to be            *
 *                    incremented/decremented                                         *
 *  Assumptions : parseDatePattern() has already been called, so that the format      *
 *                    of the date is known.                                           *
 *  ISD Feature : "Increment/Decrement Numerical Fields"                              *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function createNewDate(aInputTextbox)
{
	// myAlert("createNewDate(aInputTextbox.value=" + aInputTextbox.value + ")");
	
	var rNewDate = new Date();
	var lDateStringArray;
	
	if (gDateSeparator1 == gDateSeparator2)
	{
		lDateStringArray = (aInputTextbox.value).split(gDateSeparator1);
	}
	else // (gDateSeparator1 != gDateSeparator2)
	{
		var lTempArray1 = (aInputTextbox.value).split(gDateSeparator1);
		var lDatePortion1 = lTempArray1[0];
		var lTempArray2 = lTempArray1[1].split(gDateSeparator2);
		var lDatePortion2 = lTempArray2[0];
		if (lTempArray2.length == 1)
		{
			lDateStringArray = new Array(lDatePortion1, lDatePortion2);
		}
		else if (lTempArray2.length > 1)
		{
			lDateStringArray = new Array(lDatePortion1, lDatePortion2, lTempArray2[1]);
		}
	}
	
	if (gDatePatternArray != null)
	{
		if ((gDatePatternArray.length == 3) &&
		    (gDatePatternArray[0].charAt(0) == "m") &&
		    (gDatePatternArray[1].charAt(0) == "d") &&
		    (gDatePatternArray[2].charAt(0) == "y")) {
				rNewDate.setTime(Date.parse(aInputTextbox.value));
		}
		else {   
			for (var i=0; i<(gDatePatternArray.length); i++) {
				switch(gDatePatternArray[i].charAt(0)) {
					case "m":
						// alert("createNewDate(lDateStringArrayM[" + i + "]=" + lDateStringArray[i] + ")");
						// alert("createNewDate(lDateStringArrayM[" + i + "]-1=" + lDateStringArray[i]-1 + ")");
						rNewDate.setMonth(lDateStringArray[i]-1);
						break;
					case "d":
						// myAlert("createNewDate(lDateStringArrayD[" + i + "]=" + lDateStringArray[i] + ")");
						rNewDate.setDate(lDateStringArray[i]);
						break;
					case "y":
						// myAlert("createNewDate(lDateStringArrayY[" + i + "]=" + lDateStringArray[i] + ")");
						// if year string is only two characters long...
						if (lDateStringArray[i].length == 2)
						{
							// prepend default century
							rNewDate.setYear("20" + lDateStringArray[i]);
						}
						else
						{
							rNewDate.setYear(lDateStringArray[i]);
						}
						break;
				}
			}
		}
	}

	return (rNewDate);
}


/**************************************************************************************
 *  Function    : displayDate()                                                       *
 *  Description : Display a date in the specified textbox.                            *
 *  Parameters  : aInputTextbox, textbox into which to display date                   *
 *                aDate, date to be displayed in specified textbox                    *
 *  Assumptions : parseDatePattern() has already been called, so that the display     *
 *                    format of the date is known.                                    *
 *  ISD Feature : "Increment/Decrement Numerical Fields"                              *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function displayDate(aInputTextbox, aDate)
{
	aInputTextbox.value = "";
	
	if (gDatePatternArray != null)
	{
		for (var i=0; i<(gDatePatternArray.length); i++) {
			switch(gDatePatternArray[i].charAt(0)) {
				case "m":
					// month pattern is two characters long, but the current month is
					//     only a single digit...
					if ((gDatePatternArray[i].length == 2) && (aDate.getMonth() < 9))
					{
						// prepend a "0" to month string
						aInputTextbox.value += "0" + new String(aDate.getMonth()+1);
					}
					else
					{
						aInputTextbox.value += new String(aDate.getMonth()+1);
					}
					break;
				case "d":
					aInputTextbox.value += aDate.getDate();
					break;
				case "y":
					var lDateYearString = new String(aDate.getFullYear());
					// if (lDateYearString.length < 4)
					if (aDate.getFullYear() < 1000)
					{
						// correct browser bug which returns "1xx" for the year "20xx"
						aDate.setFullYear(aDate.getFullYear() + 1900);
					}
					aInputTextbox.value += aDate.getFullYear();
					break;
			}
			
			// post-pend date separator except for last portion of date
			if (i == 0) {
				aInputTextbox.value += gDateSeparator1;
			}
			else if ((i == 1) && (gDateDayPosition != 0)) {
				aInputTextbox.value += gDateSeparator2;
			}
		}
	}
}


/**************************************************************************************
 *  Function    : printPage()                                                         *
 *  Description : Invokes the system's print program (to print the current page).     *
 *  ISD Feature : "Print Page"                                                        *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function printPage()
{
    // if (justDoIt == true)
	// {
		window.print();
	// }
}


/**************************************************************************************
 *  Function    : emailPage()                                                         *
 *  Description : Invokes the system's default e-mail client to send an e-mail with   *
 *                    the current URL in the body of the message.                     *
 *  ISD Feature : "E-mail Page"                                                       *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function emailPage()
{
    // if (justDoIt == true)
	// {
		var lMailStr;
		lMailStr = "mailto:?body=" + location.href; 
		location.href = lMailStr;
	// }
}


/**************************************************************************************
 *  Description : Global variables used by the following functions:                   * 
 *                    moveToNextTableRow()                                            *
 *                    moveToPreviousTableRow()                                        *
 *                    moveToThisTableRow()                                            *
 *                    updateCurrentTableAndIndex()                                    *
 *                    highlightTableRow()                                             *
 *                    clickEditButtonOfTableRowInFocus()                              *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
var justDoIt = true;
var currentTable = null;
var currentRow = null;
var currentRowIndex = 0;

/**************************************************************************************
 *  Function    : captureUpDownKey()                                                  *
 *  Description : Captures an "up/down arrow" and "enter" keyboard event, and calls   *
 *                    the respective function to process the event.                   *
 *  Parameters  : pTableInFocus, html table receiving the keyboard event              *
 *                event, browser-generated event object                               *
 *  Assumptions : Only table panels will call this function.                          *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function captureUpDownKey(pTableInFocus, event) {

    // capture current scroll position for "maintain position in tables" feature 
    setCurrentBrowserCoordinates();
    
    if (justDoIt == true) {
        // if focus is not on a drop-down list, nor the page size entry field (otherwise
        // drop-down list navigation via up/down/enter keypress takes precedence)    
        if ((event.srcElement == null) || ((event.srcElement.nodeName != "SELECT") && ((event.srcElement.id).indexOf("PageSize") == -1))) {
        
            if (event.keyCode) {
            
                // if key down...
                if (event.keyCode == 40) {
                    event.returnValue = false;
                    event.cancel = true;
				    event.cancelBubble = true;
				    if (event.stopPropagation) event.stopPropagation();
                    moveToNextTableRow(pTableInFocus);
                }
                // if key up...
                else if (event.keyCode == 38) {
                    event.returnValue = false;
                    event.cancel = true;
				    event.cancelBubble = true;
				    if (event.stopPropagation) event.stopPropagation();
                    moveToPreviousTableRow(pTableInFocus);
                }
                // if enter key...
                else if (event.keyCode == 13) {
                    if (clickEditButtonOfTableRowInFocus() == true) {
                        event.returnValue = false;
                        event.cancel = true;
	 				    event.cancelBubble = true;
					    if (event.stopPropagation) event.stopPropagation();
                   }
                    // else let event bubble up to "enter key capture" code for the above column filter button
                }
            }
        }
    }
}

/**************************************************************************************
 *  Function    : captureEnterKeyInScrollingTable()                                   *
 *  Description : Captures an "enter" keyboard event, and calls the respective        *
 *                    function to process the event.                                  *
 *  Parameters  : pTableInFocus, html table receiving the keyboard event              *
 *                event, browser-generated event object                               *
 *  Assumptions : Only scrolling table panels will call this function.                *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function captureEnterKeyInScrollingTable(pTableInFocus, event) {

    // capture current scroll position for "maintain position in tables" feature 
    setCurrentBrowserCoordinates();
    
    if (justDoIt == true) {
            
        // for IE...
        if (event.keyCode) {
            // if enter key...
            if (event.keyCode == 13) {
                if (clickEditButtonOfTableRowInFocus() == true) {
                    event.returnValue = false;
                    event.cancel = true;
				    event.cancelBubble = true;
				    if (event.stopPropagation) event.stopPropagation();
                }
                /* else let event bubble up to "enter key capture" code for the above column filter button */
            }
            // if key down...
            else if (event.keyCode == 40) {
                event.returnValue = false;
                event.cancel = true;
			    event.cancelBubble = true;
			    if (event.stopPropagation) event.stopPropagation();
                // ignore because up/down keypress functionality is not supported in scrolling tables
            }
            // if key up...
            else if (event.keyCode == 38) {
                event.returnValue = false;
                event.cancel = true;
			    event.cancelBubble = true;
			    if (event.stopPropagation) event.stopPropagation();
                // ignore because up/down keypress functionality is not supported in scrolling tables
            }
        }
        // if Netscape/Firefox...
        else if (event.which) {
        
            // if enter key...
            if (event.which == 13) {
                if (clickEditButtonOfTableRowInFocus() == true) {
                    event.returnValue = false;
                    event.cancel = true;
				    event.cancelBubble = true;
				    if (event.stopPropagation) event.stopPropagation();
                }
                /* else let event bubble up to "enter key capture" code for the above column filter button */
            }
            // if key down...
            else if (event.which == 40) {
                event.returnValue = false;
                event.cancel = true;
 			    event.cancelBubble = true;
			    if (event.stopPropagation) event.stopPropagation();
               // ignore because up/down keypress functionality is not supported in scrolling tables
            }
            // if key up...
            else if (event.which == 38) {
                event.returnValue = false;
                event.cancel = true;
			    event.cancelBubble = true;
			    if (event.stopPropagation) event.stopPropagation();
                // ignore because up/down keypress functionality is not supported in scrolling tables
            }
        }
    }
}

/**************************************************************************************
 *  Function    : moveToNextTableRow()                                                *
 *  Description : Upon "down arrow" keypress, disables "up/down arrow navigation"     *
 *                    highlight color on the current table row, and enables same on   *
 *                    the next table row.                                             *
 *  Parameters  : pTableInFocus, html table receiving the "down arrow" keyboard event *
 *  Assumptions : None.                                                               *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function moveToNextTableRow(pTableInFocus) {
    var tableInFocus;
    var tableRows;
    var maxRowIndex;
    var tableCells;
 
    if (justDoIt == true) {  
     
        if (pTableInFocus != null) {
        
            // if focus is still within same table...
            if (currentTable == pTableInFocus)
            {                    
	            // determine the number of rows (including "header row") in this table
			    var maxRowIndex = getNumberOfTableRows(pTableInFocus);

                if (maxRowIndex > 0)
                {                    
                    // if current row is not the last row of this table...
                    if ((currentRowIndex >= 0) && (currentRowIndex < maxRowIndex-1)) {
                    
                        if (tableRowHighlightable(getTableRow(currentRowIndex+1)) == true) {

                            // unhighlight the current row
                            unhighlightTableRow(currentRow);
                        
                            // make previous row of this table the current row
                            currentRowIndex++;
        
                            // highlight the (new) current row
                            highlightTableRow(getTableRow(currentRowIndex));
                        }   
                    }
                }
            }
            else {
                // make this new table in focus the current table
                currentTable = pTableInFocus;

                moveToNextTableRow(currentTable);
            }
        }
    }
}

/**************************************************************************************
 *  Function    : moveToPreviousTableRow()                                            *
 *  Description : Upon "up arrow" keypress, disables the "up/down arrow navigation"   *
 *                    highlight color on the current table row, and enables same on   *
 *                    the previous table row.                                         *
 *  Parameters  : pTableInFocus, html table receiving the "down arrow" keyboard event *
 *  Assumptions : None.                                                               *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function moveToPreviousTableRow(pTableInFocus) {

    if (justDoIt == true)
    {
        if (pTableInFocus != null)
        {
            // if focus is still within same table...
            if (currentTable == pTableInFocus)
            {
	            // determine the number of rows (including "header row") in this table
			    var maxRowIndex = getNumberOfTableRows(pTableInFocus);
 
                if (maxRowIndex > 0)
                {                    
                    // if current row is not the first row of this table...
                    if ((currentRowIndex > 1) && (currentRowIndex < maxRowIndex))
                    {                    
                        if (tableRowHighlightable(getTableRow(currentRowIndex-1)) == true)
                        {    
                            // unhighlight the current row
                            unhighlightTableRow(currentRow);
                        
                            // make previous row of this table the current row
                            currentRowIndex--;
        
                            // highlight the (new) current row
                            highlightTableRow(getTableRow(currentRowIndex));
                        }   
                    }
                }
            }
            else {
                // make this new table in focus the current table
                currentTable = pTableInFocus;

                moveToPreviousTableRow(currentTable);
            }
        }
    }
}

/**************************************************************************************
 *  Function    : moveToThisTableRow()                                                *
 *  Description : Upon "radio button select", disables the "up/down arrow navigation" *
 *                    highlight color on the current table row, and enables same on   *
 *                    the newly selected table row.                                   *
 *  Parameters  : pTableCell, "radio button" table cell selected                      *
 *  Assumptions : Only "radio button" table cells will call this function.            *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function moveToThisTableRow(pTableCell) {
    // capture current scroll position for "maintain position in tables" feature 
    setCurrentBrowserCoordinates();
    
    if (justDoIt == true) {

        if (pTableCell != null) {

            var tableRow = pTableCell.parentNode;
            
            if (tableRowHighlightable(tableRow) == true) {
            
                var iconCellContents = tableRow.getElementsByTagName("input");
                
                for (var i=(iconCellContents.length-1); i>=0; i--)
                {
                	if (iconCellContents.item(i).type == "checkbox")
                	{
                		iconCellContents.item(i).focus();
                		break;
                	}
                }
                
                // if current row highlighted...
                if (currentTable != null)
                {
                    unhighlightTableRow(currentRow);
                }
        
                // determine current table and index resulting from focus change
                updateCurrentTableAndIndex(tableRow);
                
                // highlight (new) current table row
                highlightTableRow(tableRow);
            }
        }
    }
}


/**************************************************************************************
 *  Function    : getTableRow()                                                       *
 *  Description : Retrieve the table row specified by pTableRowIndex in the "current" *
 *                    table.                                                          *
 *  Parameters  : pTableRowIndex, index of table row to retrieve                      *
 *  Assumptions : Global "currentTable" points to a valid table.                      *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function getTableRow(pTableRowIndex)
{
	var rTableRow = null;
	
    if (justDoIt == true)
    {
		if (currentTable != null)
		{
			var lTableRows = currentTable.getElementsByTagName("tr");
			var lTableRowIndex = 1;
			
			// if there are enough rows in the current table...
			if (pTableRowIndex < lTableRows.length)
			{
				// while table row not found...
				for (var i=1; i<lTableRows.length; i++)
				{
					// if table row is part of main table (i.e., not a nested table row)...
					if (lTableRows.item(i).parentNode.parentNode == currentTable)
					{
						// if this is the specified table row index...
						if (lTableRowIndex == pTableRowIndex)
						{
							// save a reference to this row
							rTableRow = lTableRows.item(i);
							break;
						}
						// else move on to the next table row in main table
						else
						{
							lTableRowIndex++;
						}
					}
				}
			}
		}
	}
	
	// alert("getTableRow(rTableIsNull=" + (rTableRow == null) + ",currentRowIndex=" + currentRowIndex + ",pTableRowIndex=" + pTableRowIndex + ")");
	return rTableRow;
}


/**************************************************************************************
 *  Function    : getNumberOfTableRows()                                              *
 *  Description : Returns the number of table rows in the specified main table.       *
 *  Parameters  : pTable, reference to table whose row count is to be returned        *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function getNumberOfTableRows(pTable)
{
	var rNumberOfTableRows = 0;
	
    if (justDoIt == true)
    {
		if (pTable != null)
		{
			var lTableRows = pTable.getElementsByTagName("tr");
			
			for (var i=0; i<lTableRows.length; i++)
			{
				// if table row is part of main table (i.e., not a nested table row)...
				if (lTableRows.item(i).parentNode.parentNode == currentTable)
				{
					rNumberOfTableRows++;
				}
			}
		}
	}
	
	// alert("getNumberOfTableRows(rNumberOfTableRows=" + rNumberOfTableRows + ")");
	return rNumberOfTableRows;
}


/**************************************************************************************
 *  Function    : updateCurrentTableAndIndex()                                        *
 *  Description : Updates the global variables, currentTable and currentRowIndex,     *
 *                    indicating the new table and row in focus.                      *
 *  Parameters  : pTableRow, new table row in focus                                   *
 *  Assumptions : pTableRow is a row in the current table.                            *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function updateCurrentTableAndIndex(pTableRow) {
    var tableRows;
    var maxTableIndex;

    if (justDoIt == true) {
    
    	// update current table
        currentTable = pTableRow.parentNode;
        currentRowIndex = 0;

		var lTableRows = currentTable.getElementsByTagName("tr");
		var lTableRowIndex = 1;
		
		for (var i=1; i<lTableRows.length; i++)
		{
			// if table row is part of main table (i.e., not a nested table row)...
            if (lTableRows.item(i).parentNode == currentTable)
			{
				// if current table row found
				if (lTableRows.item(i) == pTableRow)
				{
					// update current table row index
	                currentRowIndex = lTableRowIndex;
	                break;
	            }
				// else move on to the next table row in main table
				else
				{
					lTableRowIndex++;
				}
			}
		}
        
        // alert("updateCurrentTableAndIndex(currentRowIndex=" + currentRowIndex + ")"); 
    }
}

/**************************************************************************************
 *  Function    : unhighlightTableRow()                                               *
 *  Description : For the specified table row, deselects the "radio button", and      *
 *                    disables the "up/down arrow navigation" highlight color on its  *
 *                    table cells.                                                    *
 *  Parameters  : pTableRow, table row to be unhighlighted                            *
 *  Assumptions : The second table cell in row contains "radio button"; all           *
 *                    subsequent cells are data cells.                                *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function unhighlightTableRow(pTableRow) {

    var iconCellContents = null;

    if (justDoIt == true) {

        if (pTableRow != null) {

            iconCellContents = pTableRow.getElementsByTagName("input");

            var lCheckboxPresent = false;
            var lCheckboxChecked = false;
            if (iconCellContents != null)
            {
            	for (var i=(iconCellContents.length-1); i>=0; i--)
            	{
            		if (iconCellContents.item(i).type == "checkbox")
            		{
            			lCheckboxPresent = true;
            			if (iconCellContents.item(i).checked == true)
            			{
            				lCheckboxChecked = true;
            			}
            			break;
            		}
            	}
            }
            
            if (lCheckboxPresent)
            {
	            if (lCheckboxChecked) {
	                // unhighlight row
	                tableCells = pTableRow.getElementsByTagName("td");
	                for (var i=0; i<tableCells.length; i++) {
	                	if (tableCells.item(i).parentNode == pTableRow)
	                	{
		                    if ((tableCells.item(i).className == "tic") ||
		                    	(tableCells.item(i).className == "tich") ||
				(tableCells.item(i).className == "icon_cell") ||
		                    	(tableCells.item(i).className == "icon_cell_highlighted")) {
		                        tableCells.item(i).className = "tics";
		                    }
		                    else if ((tableCells.item(i).className == "ticnb") ||
		                    	(tableCells.item(i).className == "tichnb")) {
		                        tableCells.item(i).className = "ticsnb";
		                    }			
		                    else if ((tableCells.item(i).className == "ticwb") ||
		                    	(tableCells.item(i).className == "tichwb")) {
		                        tableCells.item(i).className = "ticswb";
		                    }
			      else if ((tableCells.item(i).className == "ttc") ||
		                    		 (tableCells.item(i).className == "ttch") ||
		                    		 (tableCells.item(i).className == "table_cell") ||
		                    		 (tableCells.item(i).className == "table_cell_highlighted")) {
		                        tableCells.item(i).className = "ttcs";
		                    }
		                    else if ((tableCells.item(i).className == "tice") ||
		                    		 (tableCells.item(i).className == "tiche")) {
		                        tableCells.item(i).className = "ticse";
		                    }
	    	                // alert("unhighlightTableRow(unhighlightingCheckedRow... currentRowIndex=" + currentRowIndex + ")");
		                }
	                }
	            }
	            else {
	                // unhighlight row
	                tableCells = pTableRow.getElementsByTagName("td");
	                for (var i=0; i<tableCells.length; i++) {
	                	if (tableCells.item(i).parentNode == pTableRow)
	                	{
		                    if ((tableCells.item(i).className == "tics") ||
		                    	(tableCells.item(i).className == "tich") ||
		                    	(tableCells.item(i).className == "icon_cell_selected") ||
		                    	(tableCells.item(i).className == "icon_cell_highlighted")) {
		                        tableCells.item(i).className = "tic";
		                    }
		                    else if ((tableCells.item(i).className == "ticsnb") ||
		                    	(tableCells.item(i).className == "tichnb")) {
		                        tableCells.item(i).className = "ticnb";
		                    }	
		                    else if ((tableCells.item(i).className == "ticswb") ||
		                    	(tableCells.item(i).className == "tichwb")) {
		                        tableCells.item(i).className = "ticwb";
		                    }	
		                    else if ((tableCells.item(i).className == "ttcs") ||
		                    		 (tableCells.item(i).className == "ttch") ||
		                    		 (tableCells.item(i).className == "table_cell_selected") ||
		                    		 (tableCells.item(i).className == "table_cell_highlighted")) {
		                        tableCells.item(i).className = "ttc";
		                    }
		                    else if ((tableCells.item(i).className == "ticse") ||
		                    		 (tableCells.item(i).className == "tiche")) {
		                        tableCells.item(i).className = "tice";
		                    }
	    	                // alert("unhighlightTableRow(unhighlightingUncheckedRow... currentRowIndex=" + currentRowIndex + ")");
		                }
	                }
	            
	            }
	            
	            // alert("unhighlightTableRow(currentRowIndex=" + currentRowIndex + ")");
	        }
	        // otherwise, disable table row unhighlighting
        }
    }
}


/**************************************************************************************
 *  Function    : highlightTableRow()                                                 *
 *  Description : For the specified table row, selects the "radio button", and        *
 *                    enables the "up/down arrow navigation" highlight color on its   *
 *                    table cells.                                                    *
 *  Parameters  : pTableRow, table row to be highlighted                              *
 *  Assumptions : The second table cell in row contains "radio button"; all           *
 *                    subsequent cells are data cells.                                *
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function highlightTableRow(pTableRow) {

    var iconCellContents = null;
    
    if (justDoIt == true) {

        if (pTableRow != null) {

            iconCellContents = pTableRow.getElementsByTagName("input");
            
            var lCheckboxPresent = false;
            if (iconCellContents != null)
            {
            	for (var i=(iconCellContents.length-1); i>=0; i--)
            	{
            		if (iconCellContents.item(i).type == "checkbox")
            		{
            			lCheckboxPresent = true;
            			iconCellContents.item(i).focus();
            			break;
            		}
            	}
            }
            
            if (lCheckboxPresent)
            {
	            // highlight row
	            tableCells = pTableRow.getElementsByTagName("td");
	            for (var i=0; i<tableCells.length; i++) {
	            	if (tableCells.item(i).parentNode == pTableRow)
	            	{
		                if ((tableCells.item(i).className == "tic") ||
		                	(tableCells.item(i).className == "tics") ||
		                	(tableCells.item(i).className == "icon_cell") ||
		                	(tableCells.item(i).className == "icon_cell_selected")){
		                    tableCells.item(i).className = "tich";
		                }
		                else if ((tableCells.item(i).className == "ticnb") ||
		                    	(tableCells.item(i).className == "ticsnb")) {
		                        tableCells.item(i).className = "tichnb";
		                }	
		                else if ((tableCells.item(i).className == "ticwb") ||
		                    	(tableCells.item(i).className == "ticswb")) {
		                        tableCells.item(i).className = "tichwb";
		                }	
		                else if ((tableCells.item(i).className == "ttc") ||
		                		 (tableCells.item(i).className == "ttcs") ||
		                		 (tableCells.item(i).className == "table_cell") ||
		                		 (tableCells.item(i).className == "table_cell_selected")) {
		                    tableCells.item(i).className = "ttch";
		                }
		                else if ((tableCells.item(i).className == "tice") ||
		                		 (tableCells.item(i).className == "ticse")) {
		                    tableCells.item(i).className = "tiche";
		                }
		                
		                // save reference to current highlighted row
		                currentRow = pTableRow;
		            }
	            }
            
	            // alert("highlightTableRow(currentRowIndex=" + currentRowIndex + ",currentRowIsNull=" + (currentRow == null) + ")");
	        }
        }
    }
}

/**************************************************************************************
 *  Function    : tableRowHighlightable()                                             *
 *  Description : Returns whether the table row contains icon cells.                  *
 *  Parameters  : None.                                                               *
 *  Assumptions : None.                                                               *                 
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function tableRowHighlightable(pTableRow) {

    var rTableRowHighlightable = false;
    var iconCellContents = null;
    var headerCellContents = null;
    var tableRows = null;
    
    // select table row's radio button
    iconCellContents = pTableRow.getElementsByTagName("input");

    var lCheckboxNode = null;
    if (iconCellContents != null)
    {
    	for (var i=(iconCellContents.length-1); i>=0; i--)
    	{
    		if (iconCellContents.item(i).type == "checkbox")
    		{
    			lCheckboxNode = iconCellContents.item(i);
    			break;
    		}
    	}
    }
    
    if (lCheckboxNode != null)
    {
        // make sure there is an icon cell in this row
        if ((lCheckboxNode.parentNode.className == "tic") ||
        	(lCheckboxNode.parentNode.className == "ticnb") ||
        	(lCheckboxNode.parentNode.className == "ticwb") ||
        	(lCheckboxNode.parentNode.className == "tics") ||
        	(lCheckboxNode.parentNode.className == "ticsnb") ||
        	(lCheckboxNode.parentNode.className == "ticswb") ||
        	(lCheckboxNode.parentNode.className == "icon_cell") ||
        	(lCheckboxNode.parentNode.className == "icon_cell_selected") ||
        	(lCheckboxNode.parentNode.className == "tice") ||
        	(lCheckboxNode.parentNode.className == "ticse")) {
            rTableRowHighlightable = true;
        }
    }
    
    return(rTableRowHighlightable);
}

/**************************************************************************************
 *  Function    : clickEditButtonOfTableRowInFocus()                                  *
 *  Description : Invokes the edit record page of the selected record (in focus table *
 *                    row) by programmatically clicking the record's edit button.     *
 *  Parameters  : None.                                                               *
 *  Assumptions : The edit button is contained in the first cell of the table row in  *
 *                    focus.                                                          *                 
 *  ISD Feature : "Up/Down Arrow Keypress Navigation"                                 *
 *  Authors     : Samson Wong & Cocosoft B.V.                                         *
 **************************************************************************************/
function clickEditButtonOfTableRowInFocus() {
    var iconCellContents = null;
    var rTableRowClickable = false;

    if (justDoIt == true) {
    
        if (currentTable != null) {
        
            if (currentRow != null) {
            
                iconCellContents = currentRow.getElementsByTagName("input");
                
		    	for (var i=0; i<iconCellContents.length; i++)
		    	{
		    		// alert("clickEditButtonOfTableRowInFocus(iconCellContents.item(" + i + ").id=" + iconCellContents.item(i).id + ")");
		    		if (iconCellContents.item(i).id.indexOf("EditButton") != -1)
		    		{
		    			iconCellContents.item(i).click();
	                    rTableRowClickable = true;
		    			break;
		    		}
		    	}
            }
        }
    }
    
    return(rTableRowClickable);
}


/**************************************************************************************
 *  Function    : toggleAllCheckboxes()                                               *
 *  Description : Checks/unchecks all "icon cell" checkboxes (and highlights/         *
 *                    unhighlights their corresponding rows) if the "select all"      *
 *                    checkbox is checked/unchecked.                                  *
 *  Parameters  : aMainCheckboxNode, reference to "select all" checkbox.              *
 *  Assumptions : This onclick event handler should only be used by the "select all"  *
 *                    checkbox.                                                       *
 *  ISD Feature : "Select All Checkbox"                                               *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function toggleAllCheckboxes(aMainCheckboxNode) {
    var lIsScrollingTable = false;
    var lTableNode = aMainCheckboxNode.parentNode.parentNode.parentNode;    
    
    if (lTableNode.nodeName == "THEAD") {
        lIsScrollingTable = true;
        lTableNode = lTableNode.parentNode;
    }
        
    var lInputArray = lTableNode.getElementsByTagName("input");
    
    if (lInputArray[0].checked == true) {

        for (i=1; i<lInputArray.length; i++) {
            // alert("toggleAllCheckboxes(checking " + lInputArray[i].name + ")");
            
            if ((lInputArray[i].parentNode.parentNode.parentNode == lTableNode) || (lInputArray[i].parentNode.parentNode.parentNode.parentNode == lTableNode)) {
	            lInputArray[i].checked = true;
	            if (lIsScrollingTable == false) {
	                selectTableRow(lInputArray[i].parentNode.parentNode);
	            }
	        }
        }
    }
    else {

        for (i=1; i<lInputArray.length; i++) {
            // alert("toggleAllCheckboxes(unchecking " + lInputArray[i].name + ")");

            if ((lInputArray[i].parentNode.parentNode.parentNode == lTableNode) || (lInputArray[i].parentNode.parentNode.parentNode.parentNode == lTableNode)) {
	           lInputArray[i].checked = false;
	            if (lIsScrollingTable == false) {
	                unselectTableRow(lInputArray[i].parentNode.parentNode);
	            }
	        }
        }
    }
}


/**************************************************************************************
 *  Function    : unselectTableRow()                                                  *
 *  Description : Disables "select" highlight color on the specified table row.       *
 *  Parameters  : aTableRow, reference to table row whose "select" highlight color is *
 *                    to be disabled.                                                 *
 *  ISD Feature : "Select All Checkbox"                                               *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function unselectTableRow(aTableRow) {

    if (justDoIt == true) {

        if (aTableRow != null) {

            // unselect row
            tableCells = aTableRow.getElementsByTagName("td");
            for (var i=0; i<tableCells.length; i++) {
            
            	// if table row cell in main table (i.e., not a nested table row cell)...
            	if (tableCells.item(i).parentNode == aTableRow)
            	{
	                if ((tableCells.item(i).className == "tics") ||
	                	(tableCells.item(i).className == "icon_cell_selected")) {
	                    tableCells.item(i).className = "tic";
	                }
		  else if (tableCells.item(i).className == "ticsnb") {
		                        tableCells.item(i).className = "ticnb";
		  }	
		  else if (tableCells.item(i).className == "ticswb") {
		                        tableCells.item(i).className = "ticwb";
		  }		                
		  else if ((tableCells.item(i).className == "ttcs") ||
	                		 (tableCells.item(i).className == "table_cell_selected")) {
	                    tableCells.item(i).className = "ttc";
	                }
	                else if (tableCells.item(i).className == "ticse") {
	                    tableCells.item(i).className = "tice";
	                }
	                // alert("unselectTableRow(unselecting... tableCells.item(" + i + ").nodeName=" + tableCells.item(i).nodeName + ")");
	            }
            }
        }
    }
}


/**************************************************************************************
 *  Function    : selectTableRow()                                                    *
 *  Description : Enables "select" highlight color on the specified table row.        *
 *  Parameters  : aTableRow, reference to table row whose "select" highlight color is *
 *                    to be enabled.                                                  *
 *  ISD Feature : "Select All Checkbox"                                               *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function selectTableRow(aTableRow) {

    if (justDoIt == true) {

        if (aTableRow != null) {

            // select row
            tableCells = aTableRow.getElementsByTagName("td");
            for (var i=0; i<tableCells.length; i++) {

	           	// if table row cell in main table (i.e., not a nested table row cell)...
            	if (tableCells.item(i).parentNode == aTableRow)
            	{
	                if ((tableCells.item(i).className == "tic") ||
	                	(tableCells.item(i).className == "icon_cell")) {
	                    tableCells.item(i).className = "tics";
	                }
		  else if (tableCells.item(i).className == "ticnb") {
	                    tableCells.item(i).className = "ticsnb";
		  }
		  else if (tableCells.item(i).className == "ticwb") {
	                    tableCells.item(i).className = "ticswb";
		  }
	                else if ((tableCells.item(i).className == "ttc") ||
	                		 (tableCells.item(i).className == "table_cell")) {
	                    tableCells.item(i).className = "ttcs";
	                }
	                else if (tableCells.item(i).className == "tice") {
	                    tableCells.item(i).className = "ticse";
	                }
	                // alert("selectTableRow(selecting... tableCells.item(" + i + ").nodeName=" + tableCells.item(i).nodeName + ")");
	            }
            }
        }
    }
}


/**************************************************************************************
 *  Function    : setCurrentBrowserCoordinates()                                      *
 *  Description : Records current browser focus location based upon user input        *
 *                    (scroll, click, or keypress).                                   *
 *  Parameters  : None.                                                               *
 *  ISD Feature : "Maintain position in tables"                                       *
 *  Authors     : Akesh Gupta, Light Speed Solutions                                  *
 **************************************************************************************/
 function setCurrentBrowserCoordinates() {
    var scrollX, scrollY;
    
    // if (justDoIt == true) {
        var pageLeftCoordinate = document.getElementById("pageLeftCoordinate");
        var pageTopCoordinate = document.getElementById("pageTopCoordinate");

        // do not scroll in pre-v3.2.1 apps (which do not contain the hidden scroll coordinates fields)         
        if (!pageLeftCoordinate || !pageTopCoordinate) return;
    
        if (document.all)
        {
            if (!document.documentElement.scrollLeft)
                scrollX = document.body.scrollLeft;
            else
                scrollX = document.documentElement.scrollLeft;
         
            if (!document.documentElement.scrollTop)
                scrollY = document.body.scrollTop;
            else
                scrollY = document.documentElement.scrollTop;
        }
        else
        {
            scrollX = window.pageXOffset;
            scrollY = window.pageYOffset;
        }
            
        // alert("setCurrentBrowserCoordinates(x=" + scrollX + ",y=" + scrollY + ")");
        pageLeftCoordinate.value = scrollX;
        pageTopCoordinate.value = scrollY;
    // }
}
  
/**************************************************************************************
 *  Function    : goToCurrentBrowserCoordinates()                                     *
 *  Description : Moves to the browser coordinates previously saved by                *
 *                    setCurrentBrowserCoordinates().                                 *
 *  Parameters  : None.                                                               *
 *  ISD Feature : "Maintain position in tables"                                       *
 *  Authors     : Akesh Gupta, Light Speed Solutions                                  *
 **************************************************************************************/
 function goToCurrentBrowserCoordinates() {
    // if (justDoIt == true) {
        var pageLeftCoordinate = document.getElementById("pageLeftCoordinate");
        var pageTopCoordinate = document.getElementById("pageTopCoordinate");

        // do not scroll in pre-v3.2.1 apps (which do not contain the hidden scroll coordinates fields) 
        if (!pageLeftCoordinate || !pageTopCoordinate) return;
        
        // do not scroll if not a doPostBack() reload of page
        if ((pageLeftCoordinate.value == "") && (pageTopCoordinate.value == "")) return;

        var scrollX = pageLeftCoordinate.value;
        var scrollY = pageTopCoordinate.value;
        // alert("goToCurrentBrowserCoordinates(x=" + scrollX + ",y=" + scrollY + ")");
        window.scrollTo(scrollX, scrollY);
    // }
 }

/**************************************************************************************
 *  Function    : dropDownListTypeAhead()                                             *
 *  Description : Moves focus to select option which matches string entered on        *
 *                    keyboard.                                                       *
 *  Parameters  : dropdownlist, select element catching the keypress events.          *
 *                caseSensitive, indicates whether or not keypresses and select       *
 *                    option values need to match by case.                            *
 *  ISD Feature : "Dropdown List Type Ahead"                                          *
 *  Authors     : Akesh Gupta & Samson Wong                                           *
 **************************************************************************************/
function dropDownListTypeAhead(dropdownlist,caseSensitive) {

    // if (justDoIt == true) {
        // Make sure the control is a drop down list.
        if (dropdownlist.type != 'select-one') return;
    
        // check the keypressBuffer attribute is defined on the dropdownlist
        var undefined;
        
        // if enter key captured...
        if ((window.event) && (window.event.keyCode == 13))
        {
        	// explicitly perform filtering
        	setTimeout("__doPostBack('" + window.event.srcElement.id + "','')", 0);
        }
        
        window.event.cancelBubble = true;
    
        if (dropdownlist.keypressBuffer == undefined) {
            dropdownlist.keypressBuffer = "";
        } 
    
        // get the key that was pressed
        var key;
        
        if (event.keyCode) {        
            key = String.fromCharCode(window.event.keyCode);
        }
        else if (event.which) {
            key = String.fromCharCode(event.which);
        }
        
        dropdownlist.keypressBuffer += key;

        if (!caseSensitive) {
            // convert buffer to lowercase"
            dropdownlist.keypressBuffer = dropdownlist.keypressBuffer.toLowerCase();
        }
    
        // find if it is the start of any of the options
        var optionsLength = dropdownlist.options.length;
        
        for (var n=0; n < optionsLength; n++) {
            var optionText = dropdownlist.options[n].text;
            if (!caseSensitive) {
                optionText = optionText.toLowerCase();
            }
            if (optionText.indexOf(dropdownlist.keypressBuffer,0) == 0) {
                dropdownlist.selectedIndex = n;
                
                // if (dropdownlist.keypressBuffer.length > 1) {
                //  alert("dropDownListTypeAhead(match, keypressBuffer=" + dropdownlist.keypressBuffer + ",selectedIndex=" + dropdownlist.selectedIndex + ")");
                // }

                // cancel the default behavior since we have selected our own value
                window.event.returnValue = false;
                return false;
            }
        }
    
        // alert("dropDownListTypeAhead(reset, keypressBuffer=" + dropdownlist.keypressBuffer + ")");
        
        // reset initial key to be inline with default behavior
        dropdownlist.keypressBuffer = key;
    // }

    // give default behavior
    return true;
}

/**************************************************************************************
 *  Description : Event handlers (scroll, click, and keypress) active for all pages.  *
 *  Parameters  : None.                                                               *
 *  ISD Feature : "Maintain position in tables"                                       *
 *  Authors     : Akesh Gupta, Light Speed Solutions                                  *
 **************************************************************************************/
  window.onload = goToCurrentBrowserCoordinates;
  window.onscroll = setCurrentBrowserCoordinates;
  window.onclick = setCurrentBrowserCoordinates;
  window.onkeypress = setCurrentBrowserCoordinates;  




/**************************************************************************************
 *  Description : Global variables used by "Detail Rollever Popup" feature.           *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
var gDisplayInnerHTML = 0;
var gPersist = false;
var gPopupTimer = null;
var gCurrentInnerHTML = '';
var gRTL = false;

// dummy "content" to be displayed in popup (for demo purposes only)
var gTitle = "Lorem Ipsum (2006)";
var gInnerHTML0 = 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.';
var gInnerHTML1 = 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<br><br>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.';
var gInnerHTML2 = 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<br><br>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.<br><br>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.';
var gInnerHTML3 = '<!-- Begin Table Panel.html --><table class="dialog_view" cellpadding="0" cellspacing="0" border="0"><tr><td class="dialog_header"><table cellpadding="0" cellspacing="0" width="100%" border="0"><tr><td class="dialogHeaderEdgeL"><img src="../Images/space.gif" alt=""/></td><td class="dialogHeaderExpandCollapseIcon" valign="middle"><a onclick="toggleExpandCollapse(this);"><img id="ExpandCollapseIcon" src="../Images/DialogHeaderIconCollapse.gif" border="0" alt="Collapse panel"/></a></td><td class="dialogHeaderIcon"><img id="CategoriesTableIcon" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="dialog_header_text" valign="middle">Categories</td><td class="dialogHeaderTotalRecordCount"><table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0"><tr><td class="dialogHeaderTotalRecordCountText"><span id="CategoriesTotalItems">8</span></td></tr></table></td><td class="dialogHeaderEdgeR"><img src="../Images/space.gif" alt=""/></td></tr></table></td></tr><tr><td class="dialog_body"><table id="CollapsibleRegion" style="display:;" cellspacing="0" cellpadding="0" border="0"><tr><td><table cellpadding="0" cellspacing="3" border="0"><!-- Search & Filter Area --><tr><td class="filter_area">Search for</td><td><span><input name="CategoriesSearchArea" type="text" id="CategoriesSearchArea" class="Search_Input" CaseSensitive="False" Fields="CategoryName" FilterOperator="Contains" /></span></td><td class="filter_button_cell"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesSearchButton__Button" class="button_link" href="">Go</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td></tr><tr><td></td><td></td><td rowspan="100" class="filter_button_cell"></td> </tr><tr><td class="filter_area">Category Name</td><td><select name="CategoryNameFilter" onchange="" id="CategoryNameFilter" class="Filter_Input" FilterOperator="="><option selected="selected" value="--ANY--">All</option><option value="Beverages">Beverages</option><option value="Condiments">Condiments</option><option value="Confections">Confections</option><option value="Dairy Products">Dairy Products</option><option value="Grains/Cereals">Grains/Cereals</option><option value="Meat/Poultry">Meat/Poultry</option><option value="Produce">Produce</option><option value="Seafood">Seafood</option></select></td></tr></table><div class="spacer"></div><!-- Category Area --><table cellspacing="0" cellpadding="0" border="0"><tr><td><table cellspacing="0" cellpadding="0" border="0"><tr><td><table class="table_view" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><!-- Pagination Area --><td class="pagination_row" colspan="100"><table cellspacing="0" cellpadding="0" border="0"><tr><td class="paginationRowEdgeL"><img src="../Images/space.gif" alt=""/></td><td class="button_bar_cell"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesNewButton__Button" class="button_link" href="">New</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td><td class="button_bar_cell"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesEditButton__Button" class="button_link" href="">Edit</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td><td class="button_bar_cell"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesDeleteButton__Button" class="button_link" href="">Delete</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td><td class="button_bar_cell"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesExportButton__Button" class="button_link" href="">Export</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td><td class="pagination_area"><table cellspacing="0" cellpadding="0" border="0"><tr><td><img src="../Images/space.gif" width="15" height="1" alt=""/></td><td class="pagination_label"><input type="image" name="CategoriesPagination$_FirstPage" id="CategoriesPagination__FirstPage" disabled="disabled" class="paginationButtonFirst" src="../Images/space.gif" style="border-width:0px;" /></td><td class="pagination_label"><input type="image" name="CategoriesPagination$_PreviousPage" id="CategoriesPagination__PreviousPage" disabled="disabled" class="paginationButtonPrevious" src="../Images/space.gif" style="border-width:0px;" /></td><td class="pagination_label" style="padding-right: 6px;">Page<b><span id="CategoriesPagination__CurrentPage">1</span></b>of<b><span id="CategoriesPagination__TotalPages">1</span></b></td><td class="pagination_label"><input type="image" name="CategoriesPagination$_NextPage" id="CategoriesPagination__NextPage" disabled="disabled" class="paginationButtonNext" src="../Images/space.gif" style="border-width:0px;" /></td><td class="pagination_label"><input type="image" name="CategoriesPagination$_LastPage" id="CategoriesPagination__LastPage" disabled="disabled" class="paginationButtonLast" src="../Images/space.gif" style="border-width:0px;" /></td><td class="pagination_label">Page Size <span onKeyPress="" ></span></td><td class="pagination_label"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="button-TL-white"><img src="../Images/space.gif" height="5" width="17" alt=""/></td><td class="button-T-white"><img src="../Images/space.gif" height="5" width="4" alt=""/></td><td class="button-TR-white"><img src="../Images/space.gif" height="5" width="16" alt=""/></td></tr><tr><td class="button-L-white"><img src="../Images/space.gif" height="14" width="17" alt=""/></td><td class="button-white"><a id="CategoriesPagination__PageSizeButton__Button" class="button_link" href="">Go</a></td><td class="button-R-white"><img src="../Images/space.gif" height="14" width="16" alt=""/></td></tr><tr><td class="button-BL-white"><img src="../Images/space.gif" height="8" width="17" alt=""/></td><td class="button-B-white"><img src="../Images/space.gif" height="8" width="4" alt=""/></td><td class="button-BR-white"><img src="../Images/space.gif" height="8" width="16" alt=""/></td></tr></table></td><td class="pagination_label">Total Items:  <span id="CategoriesPagination__TotalItems">8</span></td></tr></table></td><td class="paginationRowEdgeR"><img src="../Images/space.gif" alt=""/></td></tr></table></td></tr><!--Table View Area --><tr><td class="tableRowsEdge"><table cellspacing="0" cellpadding="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><!-- This is the tables header row --><tr class="column_header"><th class="header_cell" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th><th class="header_cell" scope="col"><a id="CategoryNameLabel1" href="">Category Name</a></th><th class="header_cell" scope="col">Description</th></tr><!-- Table Rows --><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl00$CategoriesRecordRowEditButton" id="Row1_ctl00_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl00$CategoriesRecordRowViewButton" id="Row1_ctl00_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl00_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl00$CategoriesRecordRowSelection" /></td><td class="table_cell" >Beverages</td><td class="table_cell" >Soft drinks, coffees, teas, beers, and ales</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl01$CategoriesRecordRowEditButton" id="Row1_ctl01_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl01$CategoriesRecordRowViewButton" id="Row1_ctl01_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl01_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl01$CategoriesRecordRowSelection" /></td><td class="table_cell" >Condiments</td><td class="table_cell" >Sweet and savory sauces, relishes, spreads, and seasonings</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl02$CategoriesRecordRowEditButton" id="Row1_ctl02_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl02$CategoriesRecordRowViewButton" id="Row1_ctl02_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl02_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl02$CategoriesRecordRowSelection" /></td><td class="table_cell" >Confections</td><td class="table_cell" >Desserts, candies, and sweet breads</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl03$CategoriesRecordRowEditButton" id="Row1_ctl03_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl03$CategoriesRecordRowViewButton" id="Row1_ctl03_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl03_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl03$CategoriesRecordRowSelection" /></td><td class="table_cell" >Dairy Products</td><td class="table_cell" >Cheeses</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl04$CategoriesRecordRowEditButton" id="Row1_ctl04_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl04$CategoriesRecordRowViewButton" id="Row1_ctl04_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl04_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl04$CategoriesRecordRowSelection" /></td><td class="table_cell" >Grains/Cereals</td><td class="table_cell" >Breads, crackers, pasta, and cereal</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl05$CategoriesRecordRowEditButton" id="Row1_ctl05_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl05$CategoriesRecordRowViewButton" id="Row1_ctl05_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl05_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl05$CategoriesRecordRowSelection" /></td><td class="table_cell" >Meat/Poultry</td><td class="table_cell" >Prepared meats</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl06$CategoriesRecordRowEditButton" id="Row1_ctl06_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl06$CategoriesRecordRowViewButton" id="Row1_ctl06_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl06_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl06$CategoriesRecordRowSelection" /></td><td class="table_cell" >Produce</td><td class="table_cell" >Dried fruit and bean curd</td></tr><tr><td class="icon_cell" scope="row"><input type="image" name="Row1$ctl07$CategoriesRecordRowEditButton" id="Row1_ctl07_CategoriesRecordRowEditButton" class="button_link" RedirectURL="../Categories/EditCategoriesPage.aspx?Categories={PK}" src="../Images/icon_edit.gif" style="border-width:0px;" /></td><td class="icon_cell"><input type="image" name="Row1$ctl07$CategoriesRecordRowViewButton" id="Row1_ctl07_CategoriesRecordRowViewButton" class="button_link" RedirectURL="../Categories/ShowCategoriesPage.aspx?Categories={PK}" src="../Images/icon_view.gif" style="border-width:0px;" /></td><td class="icon_cell" onclick="moveToThisTableRow(this);"><input id="Row1_ctl07_CategoriesRecordRowSelection" type="checkbox" name="Row1$ctl07$CategoriesRecordRowSelection" /></td><td class="table_cell" >Seafood</td><td class="table_cell" >Seaweed and fish</td></tr><!-- Totals Area --></table></td></tr></table></td></tr></table></td></tr></table></td></tr></table></td></tr></table><!-- End Table Panel.html -->';


/**************************************************************************************
 *  Function    : getNextInnerHTML()                                                  *
 *  Description : Selects the next dummy "content" to be displayed in the popup.      *
 *                    (Just used for demo purposes; popup will use real data returned *
 *                    by AJAX call.)                                                  *
 *  Parameters  : None.                                                               *
 *  Returns     : Next dummy "content" to be displayed in the popup.                  *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function getNextInnerHTML() {
    
    var rInnerHTML = "";
    
    switch(gDisplayInnerHTML) {
        case 0:
            rInnerHTML = gInnerHTML0;
            break;
        case 1:
            rInnerHTML = gInnerHTML1;
            break;
        case 2:
            rInnerHTML = gInnerHTML2;
            break;
        case 3:
            rInnerHTML = gInnerHTML3;
            break;
    }
    
    gDisplayInnerHTML = (gDisplayInnerHTML + 1) % 4;
    
    return rInnerHTML;
}


/**************************************************************************************
 *  Function    : setRTL()                                                            *
 *  Description : Sets the boolean to indicate that the application is RTL.           *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function setRTL()
{
	gRTL = true; 
}


/**************************************************************************************
 *  Function    : clearRTL()                                                          *
 *  Description : Clears the boolean to indicate that the application is not RTL.     *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function clearRTL()
{
	gRTL = false; 
}


/**************************************************************************************
 *  Function    : delayRolloverPopup()                                                *
 *  Description : Starts a timer, and invokes the specified function upon timer       *
 *                    expiration.                                                     *
 *  Parameters  : aFunction, a piece of JavaScript code to execute.                   *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function delayRolloverPopup(aFunction, aDelay) {
    if (justDoIt == true) {
 
 		// if valid piece of JavaScript passed in...
 		if (aFunction != null)
 		{
 			if ((aDelay == null) || (aDelay <= 0))
 			{
 				// set default delay to 500ms
 				aDelay = 500;
 			}
 			
	    	// clear any previous pending popup invocation
	    	if (gPopupTimer != null)
	    	{
	    		clearTimeout(gPopupTimer);
	    		gPopupTimer = null;
	    	}
		    
		    // reinvoke delayed popup
			gPopupTimer = setTimeout(aFunction, aDelay);
		}
    }
}

/**************************************************************************************
 *  Function    : detailRolloverPopup()                                              *
 *  Description : Displays "content" (returned from AJAX call) in a popup.            *
 *  Parameters  : aTitle, string to be displayed in title bar of popup                *
 *                aContent, string containing HTML to be displayed in body of popup.  *
 *                aPersist, boolean indicating whether popup should remain even on    *
 *                    mouseout.                                                       *
 *                aWidth, default width of AJAX popup                                 *
 *                aHeight, default height of AJAX popup                               *
 *                aIsScrollable, boolean indicating whether scroll bar should be      *
 *                    displayed if content is too long/wide for popup with specified  *
 *                    width and height                                                *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function detailRolloverPopup(aTitle, aContent, aPersist, aWidth, aHeight, aIsScrollable) {
    if (justDoIt == true) {

    	// gRTL = true;
     	// aTitle = gTitle;
    	// aContent = gInnerHTML2;
    	// aContent = '<img src="../Images/WhatISDDoesFlowchart.gif">';
    	// aContent = 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa';
    	// aPersist = true;
    	// aWidth = 400;
    	// aHeight = 200;
    	// aIsScrollable = false;
    	        
    	// if default size of popup is not specified...
    	if ((aWidth == null) || (aHeight == null))
    	{
    		// set default size as 300x200px
    		aWidth = 300;
    		aHeight = 200;
    	}
    	// ...else if specified sizes are "too small/large"...
    	else
    	{
    		// set a min/max size
	    	if (aWidth < 100)
	    	{
	    		aWidth = 100;
	    	}
	    	else if (aWidth > 1000)
	    	{
	    		aWidth = 1000;
	    	}
	    	
	    	if (aHeight < 100)
	    	{
	    		aHeight = 100;
	    	}
	    	else if (aHeight > 1000)
	    	{
	    		aHeight = 1000;
	    	}
	    }
    	
    	if (aIsScrollable)
    	{
	    	// define scrollable region
	      	aContent = '<div style="clear:both;height:' + aHeight + 'px;width:' + aWidth + 'px;overflow:auto;">' + aContent + '</div>';
	    }

    	var lPageOffsetX;
    	var lPageOffsetY;
    	var lClientHeight;
    	var lClientWidth;
    	
    	// determine browser window scrolled position
        lPageOffsetX = document.documentElement.scrollLeft;
        lPageOffsetY = document.documentElement.scrollTop;
        
    	// determine current browser window dimensions in IE
    	if (document.all)
    	{
            lClientHeight = document.documentElement.clientHeight;
            lClientWidth = document.documentElement.clientWidth;
        }
        else // in Firefox
        {
            lClientHeight = window.innerHeight;
            lClientWidth = window.innerWidth;
        }
		
    	// determine mouse cursor position (top left, top right, bottom left, or bottom right) relative to current browser window
    	var lRelativeX = gEventClientX - lPageOffsetX;
     	var lRelativeY = gEventClientY - lPageOffsetY;
   		var lInLeftHalf;
   		var lInTopHalf;
  
    	if (lRelativeX <= (lClientWidth/2))
    	{
    		if (!gRTL)
    		{
    			lInLeftHalf = true;
    		}
    		else
    		{
    			lInLeftHalf = false;
    		}
    	}
    	else
    	{
     		if (!gRTL)
    		{
		   		lInLeftHalf = false;
		   	}
		   	else
		   	{
		   		lInLeftHalf = true;
		   	}
    	}
    	
    	if (lRelativeY <= (lClientHeight/2))
    	{
    		lInTopHalf = true;
    	}
    	else
    	{
    		lInTopHalf = false;
    	}
    	
    	// determine PNG support based on broswer version (for IE6 or lower, we'll need to use css filters to simulate PNG transparency)
    	var lPNGSupported = true;
    	if (navigator.appName == "Microsoft Internet Explorer")
    	{
    		var lIEVersion = 0;
    		if (navigator.appVersion.indexOf("MSIE") != -1)
    		{
    			var lIEAppVersionStringArray = navigator.appVersion.split("MSIE");
    			lIEVersion = parseFloat(lIEAppVersionStringArray[1]);
    		}

    		if (lIEVersion < 7)
    		{
    			lPNGSupported = false;
    		}
    	}

		// correct for IE RTL offset
	    if ((document.all) && (gRTL))
	    {
	    	gEventClientX -= (document.documentElement.scrollWidth - lClientWidth + 20);
	    }
 		    	
    	// create appropriate html shell to display popup in correct location relative to mouse cursor position
    	var lInnerHTML;
    	if (lInLeftHalf && lInTopHalf)
    	{
    		// alert("detailRolloverPopup(inNW)");
	    	gEventClientX = gEventClientX + 10;
    		if (gRTL)
    		{
	    		gEventClientX -= 450;
	    	}
    		gEventClientY = gEventClientY - 60;
    		if (lPNGSupported)
    		{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL">&nbsp;</td><td class="detailRolloverT" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR">&nbsp;</td></tr><td class="detailRolloverL"><img src="../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.rtl.png';
	            }
	            
	            lInnerHTML += '"></td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr><tr><td class="detailRolloverBL">&nbsp;</td><td class="detailRolloverB">&nbsp;</td><td class="detailRolloverBR">&nbsp;</td></tr></table>';
	        }
	        else
	        {
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL_noPNG">&nbsp;</td><td class="detailRolloverT_noPNG" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR_noPNG">&nbsp;</td></tr><td class="detailRolloverL_noPNG"><div style="width:65px;height:84px;filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod=image, src=\'../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.rtl.png';
	            }
	            
	            lInnerHTML += '\');"></div></td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR_noPNG">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr><tr><td class="detailRolloverBL_noPNG">&nbsp;</td><td class="detailRolloverB_noPNG">&nbsp;</td><td class="detailRolloverBR_noPNG">&nbsp;</td></tr></table>';
			}
    	}
     	else if (!lInLeftHalf && lInTopHalf)
    	{
    		// alert("detailRolloverPopup(inNE)");
	    	gEventClientX = gEventClientX - (140 + aWidth);
    		if (gRTL)
    		{
	    		gEventClientX += 450;	    	
	    	}
    		gEventClientY = gEventClientY - 60;
    		if (lPNGSupported)
    		{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL">&nbsp;</td><td class="detailRolloverT" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR">&nbsp;</td></tr><td class="detailRolloverL">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR"><img src="../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.rtl.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.png';
	            }
	                                
	        	lInnerHTML += '"></td></tr><tr><td class="detailRolloverBL">&nbsp;</td><td class="detailRolloverB">&nbsp;</td><td class="detailRolloverBR">&nbsp;</td></tr></table>';
	    	}
	    	else
	    	{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL_noPNG">&nbsp;</td><td class="detailRolloverT_noPNG" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR_noPNG">&nbsp;</td></tr><td class="detailRolloverL_noPNG">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR_noPNG"><div style="width:65px;height:84px;filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod=image, src=\'../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.rtl.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.png';
	            }
	                                
	        	lInnerHTML += '\');"></div></td></tr><tr><td class="detailRolloverBL_noPNG">&nbsp;</td><td class="detailRolloverB_noPNG">&nbsp;</td><td class="detailRolloverBR_noPNG">&nbsp;</td></tr></table>';    	
	    	}
    	}
    	else if (lInLeftHalf && !lInTopHalf)
    	{
    		// alert("detailRolloverPopup(inSW)");
    		gEventClientX = gEventClientX + 6;
    		if (gRTL)
    		{
	    		gEventClientX -= 450;
	    	}    		
    		gEventClientY = gEventClientY - (45 + aHeight);
    		if (lPNGSupported)
    		{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL">&nbsp;</td><td class="detailRolloverT" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR">&nbsp;</td></tr><td class="detailRolloverL" style="padding-bottom:15px;vertical-align:bottom;"><img src="../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.rtl.png';
	            }
	                                
	        	lInnerHTML += '"></td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr><tr><td class="detailRolloverBL">&nbsp;</td><td class="detailRolloverB">&nbsp;</td><td class="detailRolloverBR">&nbsp;</td></tr></table>';
			}
			else
			{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL_noPNG">&nbsp;</td><td class="detailRolloverT_noPNG" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR_noPNG">&nbsp;</td></tr><td class="detailRolloverL_noPNG" style="padding-bottom:15px;vertical-align:bottom;"><div style="width:65px;height:84px;filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod=image, src=\'../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.rtl.png';
	            }
	                                
	        	lInnerHTML += '\');"></div></td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR_noPNG">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr><tr><td class="detailRolloverBL_noPNG">&nbsp;</td><td class="detailRolloverB_noPNG">&nbsp;</td><td class="detailRolloverBR_noPNG">&nbsp;</td></tr></table>';			
			}	                                
    	}
    	else // (!lInLeftHalf && !InTopHalf)
    	{
    		// alert("detailRolloverPopup(inSE)");
    		gEventClientX = gEventClientX - (140 + aWidth);
    		if (gRTL)
    		{
	    		gEventClientX += 450;
	    	}    		
    		gEventClientY = gEventClientY - (45 + aHeight);
    		if (lPNGSupported)
    		{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL">&nbsp;</td><td class="detailRolloverT" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR">&nbsp;</td></tr><td class="detailRolloverL">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR" style="padding-bottom:15px;vertical-align:bottom;"><img src="../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.rtl.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.png';
	            }
	                                
	        	lInnerHTML += '"></div></td></tr><tr><td class="detailRolloverBL">&nbsp;</td><td class="detailRolloverB">&nbsp;</td><td class="detailRolloverBR">&nbsp;</td></tr></table>';
			}
			else
			{
	        	lInnerHTML = '<table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTL_noPNG">&nbsp;</td><td class="detailRolloverT_noPNG" style="vertical-align:middle;"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="detailRolloverTitle"><br><br>'
	                                + aTitle
	                                + '</td><td style="vertical-align:middle;padding-bottom:8px;"><br><br><a onclick="gPersist=false;detailRolloverPopupClose();"><img id="detailRolloverPopupCloseButton" src="../Images/closeButton.gif" border="0"></a></td></tr></table></td><td class="detailRolloverTR_noPNG">&nbsp;</td></tr><td class="detailRolloverL_noPNG">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td><td class="detailRolloverC" style="padding:2px;">'
	                                + aContent
	                                + '</td><td class="detailRolloverR_noPNG" style="padding-bottom:15px;vertical-align:bottom;"><div style="width:65px;height:84px;filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod=image, src=\'../Images/';
	                                
	            if (!gRTL)
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.rtl.png';
	            }
	            else
	            {
	            	lInnerHTML += 'detailRolloverPoint.btt.png';
	            }
	                                
	       		lInnerHTML += '\');"></div></td></tr><tr><td class="detailRolloverBL_noPNG">&nbsp;</td><td class="detailRolloverB_noPNG">&nbsp;</td><td class="detailRolloverBR_noPNG">&nbsp;</td></tr></table>';	
			}
    	}
   	   
        gPersist = aPersist;
        var popupNode = document.getElementById("detailPopup");
        popupNode.innerHTML = lInnerHTML;
        popupNode.style.top = (gEventClientY) + "px";
        popupNode.style.left = (gEventClientX) + "px";
    }
}


/**************************************************************************************
 *  Function    : detailRolloverPopupClose()                                          *
 *  Description : Closes (previously invoked by onmouseover/onclick event) popup.     *
 *  Parameters  : None.                                                               *
 *  ISD Feature : "Detail Rollover Popup"                                             *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function detailRolloverPopupClose() {

    if (justDoIt == true) {
    
    	// clear any previous pending popup invocation
    	if (gPopupTimer != null)
    	{
    		clearTimeout(gPopupTimer);
    		gPopupTimer = null;
    	}
	        
        if (gPersist != true) {
            // document.getElementById("detailPopup").innerHTML = "";
            gPopupTimer = setTimeout('document.getElementById("detailPopup").innerHTML = "";', 250);            
        }
    }
}

/**************************************************************************************
 *  Function    : SaveMousePosition()                                                 *
 *  Description : Saves the mouse position for use by detailRolloverPopup         *
 *  Parameters  : event, reference to mouseover/onclick event                 *
 **************************************************************************************/

var gEventClientX = 0;
var gEventClientY = 0;

// save latest coordinates (based on last mouse movement) instead of using those saved
// an AJAX-popup-delay (default 500ms) earlier
var IE = document.all?true:false;
if (!IE) document.captureEvents(Event.MOUSEMOVE)
document.onmousemove = SaveMousePosition;

function SaveMousePosition(evt)
{
    gEventClientX = mouseX(evt);
    gEventClientY = mouseY(evt);
}

function mouseX(evt) {
	evt = evt || window.event;
    if (evt.pageX) return evt.pageX;
    else if (evt.clientX)
        return evt.clientX + (document.documentElement.scrollLeft ?
            document.documentElement.scrollLeft :
            document.body.scrollLeft);
    else return null;
}


function mouseY(evt) {
	evt = evt || window.event;
    if (evt.pageY) return evt.pageY;
    else if (evt.clientY)
        return evt.clientY + (document.documentElement.scrollTop ?
            document.documentElement.scrollTop :
            document.body.scrollTop);
    else return null;
}


/**************************************************************************************
 *  Description : Global variables used by "Date Formatter" feature.                  *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
var gDateSeparator1 = "/";      // single character separator of first two components of date string ("m"s, "d"s, and "y"s)
var gDateSeparator2 = "/";      // single character separator of last two components of date string ("m"s, "d"s, and "y"s)
var gPreviousDatePattern = ""; // last recorded date pattern
var gDatePatternArray= null;   // split portions of date pattern
var gDateMonthPosition = 1;    // position of month portion within date pattern
var gDateDayPosition = 2;      // position of day portion within date pattern
var gDateYearPosition = 3;     // position of year portion within date pattern
var gDateFormatterState = "0"  // current date formatter state machine state
var gDateStringEntered = "";   // last value in date textbox
var gCurrentValidDateArray = new Array(3);


// Check browser version
var isNav4 = false, isNav5 = false, isIE4 = false

if(navigator.appName == "Netscape") 
{
   if (navigator.appVersion < "5")  
   {
      isNav4 = true;
      isNav5 = false;
    }
   else
   if (navigator.appVersion > "4") 
   {
      isNav4 = false;
      isNav5 = true;
    }
}
else  
{
   isIE4 = true;
}


/**************************************************************************************
 *  Function    : initializeDateFormatter()                                           *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function initializeDateFormatter(aInputTextbox) {
    gDateSeparator1 = "/";
    gDateSeparator2 = "/";
    gPreviousDatePattern = "";
    gDatePatternArray = null;
    gDateMonthPosition = 1;
    gDateDayPosition = 2;
    gDateYearPosition = 3;
    gDateFormatterState = "0";
    gCurrentValidDateString = new Array(3);
    gDateStringEntered = "";
}

function myAlert(aAlertString) {
    var debug = false;
    if (debug) {
        alert(aAlertString);
    }
}

/**************************************************************************************
 *  Function    : toggleEnableDisableDateFormatter()                                  *
 *  Description : Enables/disables Date Formatter.  On onfocus change (tabbing or     *
 *                    onclick), pasting, backspacing/deleting, or left/right          *
 *                    arrowing, date formatter is enabled if the date textbox is      *
 *                    empty; disabled, otherwise (in which case the user is allowed   *
 *                    to enter whatever he/she wishes, and date validation is only    *
 *                    performed upon onblur).                                         *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                aDatePattern, date pattern (containing some combination of "m"s,    *
 *                    "s"s, "y"s, and "separators" to which the user-inputted date    *
 *                     string is to be formated                                       *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function toggleEnableDisableDateFormatter(aInputTextbox, aDatePattern)  {

    aInputTextbox.style.background = "#ffffff";
    initializeDateFormatter(aInputTextbox);

    // myAlert("onfocus:gPreviousDatePattern(" + gPreviousDatePattern + "), aDatePattern(" + aDatePattern + ")");
    // re-parse date pattern only if different from that in previous call
    if (gPreviousDatePattern != aDatePattern) { 
        // parse date pattern
        if (!parseDatePattern(aInputTextbox, aDatePattern)) {
            goToNextState("DisableDateFormatter");
            return false;
        }       
    }

    if (aInputTextbox.value != "") {
        // myAlert("toggleEnableDisableDateFormatter(disabling:" + aInputTextbox.value + ")");
        goToNextState("DisableDateFormatter");
    }
    // else {
        // myAlert("toggleEnableDisableDateFormatter(enabling:" + aInputTextbox.value + ")");
    // }
}


/**************************************************************************************
 *  Function    : DateFormat()                                                        *
 *  Description : This event handler accepts user-inputted date string, and           *
 *                    auto-formats it according to the required date pattern.         *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                aDateStringEntered, current contents (value) in the input textbox   * 
 *                aEvent, reference to event (onkeyup) causing this event handler to  *
 *                    be called                                                       *
 *                aDatePattern, date pattern (containing some combination of "m"s,    *
 *                    "s"s, "y"s, and "separators" to which the user-inputted date    *
 *                     string is to be formated                                       *
 *  Returns:    : false, if an invalid date digit is entered (it is automatically     *
 *                    cleared for the user)                                           *
 *                true, if valid date digit is entered                                *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function DateFormat(aInputTextbox, aDateStringEntered, aEvent, aDatePattern)  {

    // if (justDoIt == true) {
    
        var whichCode;
        if (typeof(aEvent) == "number") {
        	whichCode = aEvent;
        }
        else {
        	whichCode = (window.Event) ? aEvent.which : aEvent.keyCode;
        }
        
        // if backspace, delete, left arrow, or right arrow...
        if ( (whichCode == 8) || (whichCode == 46) || (whichCode == 37) || (whichCode == 39) ) {

            if (!toggleEnableDisableDateFormatter(aInputTextbox, aDatePattern)) {
                return false;
            }
        }
        // if Ctrl-v...
        else if (whichCode == 86) {
            // allow "pasting" of "copied" text into date field, but disable date formatter because
            //    user could have pasted anything (date validation will still be performed onblur)
            goToNextState("DisableDateFormatter");
        }
		// if "up arrow" or "plus"
		else if ((whichCode == 38) || (whichCode == 107)) {
	        if ((gDatePatternArray == null) || (gPreviousDatePattern == "") || (gPreviousDatePattern != aDatePattern))
	        {
	            toggleEnableDisableDateFormatter(aInputTextbox, aDatePattern);
	        }

			while ((whichCode == 107) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "+"))
			{
				aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
			}
			
			// if date field not initialized...
			if (aInputTextbox.value == "") {
				// display today's date
				var lCurrentDate = new Date();
				displayDate(aInputTextbox, lCurrentDate);
			}
			else {					
				if (presubmitDateValidation(aInputTextbox, aDatePattern)) {
					// create new date object based on current contents of date field
					var lCurrentDate = createNewDate(aInputTextbox);
					
					// if not a credit card expiration date (which lacks a day field)...
					if (gDateDayPosition != 0)
					{
						// increment to next day (1000ms/s * 60s/min + 60min/hr + 24hr/day = 86400000ms/day)
						lCurrentDate.setTime(lCurrentDate.getTime() + 86400000);
					}
					else
					{
						if (lCurrentDate.getMonth() != 11)
						{
							lCurrentDate.setMonth(lCurrentDate.getMonth()+1);
						}
						else
						{
							if (new Number(lCurrentDate.getYear()) < 9999)
							{
								lCurrentDate.setMonth(0);
								lCurrentDate.setYear(lCurrentDate.getYear()+1);
							}
						}
					}
					
					// display new date
					displayDate(aInputTextbox, lCurrentDate);
				}
			}
		}
		// if "down arrow" or "minus"
		else if ((whichCode == 40) || (whichCode == 109)) {
	        if ((gDatePatternArray == null) || (gPreviousDatePattern == "") || (gPreviousDatePattern != aDatePattern))
	        {
	            toggleEnableDisableDateFormatter(aInputTextbox, aDatePattern);
	        }

			while ((whichCode == 109) && (aInputTextbox.value.charAt(aInputTextbox.value.length-1) == "-"))
 			{
				aInputTextbox.value = (aInputTextbox.value).substring(0,aInputTextbox.value.length-1);
			}

			// if date field not initialized...
			if (aInputTextbox.value == "") {
				// display today's date
				var lCurrentDate = new Date();
				displayDate(aInputTextbox, lCurrentDate);
			}
			else {					
				if (presubmitDateValidation(aInputTextbox, aDatePattern)) {
				
					// create new date object based on current contents of date field
					var lCurrentDate = createNewDate(aInputTextbox);

					// if not a credit card expiration date (which lacks a day field)...
					if (gDateDayPosition != 0)
					{					
						// decrement to previous day (1000ms/s * 60s/min + 60min/hr + 24hr/day = 86400000ms/day)
						lCurrentDate.setTime(lCurrentDate.getTime() - 86400000);
					}
					else
					{
						if (lCurrentDate.getMonth() != 0)
						{
							lCurrentDate.setMonth(lCurrentDate.getMonth()-1);
						}
						else
						{
							if (new Number(lCurrentDate.getYear()) > 1000)
							{
								lCurrentDate.setMonth(11);
								lCurrentDate.setYear(lCurrentDate.getYear()-1);
							}
						}
					}
					
					// display new date
					displayDate(aInputTextbox, lCurrentDate);
				}
			}
		}        
        else
        {
            // if date formatter not disabled...
            if ((gDateFormatterState != "4") || (aInputTextbox.value.length == 1)) {
            
                // re-parse date pattern only if different from that in previous call
                if (gPreviousDatePattern != aDatePattern) { 
                    // parse date pattern
                    if (!parseDatePattern(aInputTextbox, aDatePattern)) {
                        goToNextState("DisableDateFormatter");
                        return false;
                    }       
                }
                
                // convert numpad digit entries into regular (top of) keyboard digits
                if ((whichCode >=96) && (whichCode <=105)) {
                    whichCode -= 48;
                }
                else if ((whichCode == 111) || (whichCode == 191)) {
                    // date separator "/" returns whichCode 111 (from numpad) and 191 (from keyboard), but should be 47
                    whichCode = 47;
                }
                
                aInputTextbox.value = gDateStringEntered + String.fromCharCode(whichCode);
        
                var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);
                // myAlert("DateFormat(lLastCharEntered=" + lLastCharEntered + ",whichCode=" + whichCode + ")");
            
                var lValidDigits = "1234567890";    
                // if last character entered is not a numerical digit nor the date separator...
                if ((lValidDigits.indexOf(lLastCharEntered) == -1) && (lLastCharEntered != gDateSeparator1) && (lLastCharEntered != gDateSeparator2)) {
                // sam (original) - not needed
                // sam - fixed bug in original code where once one invalid character is accepted (because of "quick typing" race condition)
                //     all further alphabetic checking fails (i.e., all subsequent invalid characters are accepted)
                //if (alphaCheck.indexOf(gDateStringEntered.charAt(gDateStringEntered.length-1)) >= 1)  
                //{
                    clearLastCharEntered(aInputTextbox);
        
                    return false;
                }
                
                if (gPreviousDatePattern != "") {
                
                    // enter state machine
                    switch(gDateFormatterState) {
                        case "0": // empty date string
                            if (gDateMonthPosition == 1) {
                                processFirstMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 1) {
                                processFirstDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in first position
                            else {
                                processFirstYearDigit(aInputTextbox, gDateStringEntered);
                            }
                            break;
                        case "0.1": // validating first portion of date string, and at least one digit has already been entered for it
                            if (gDateMonthPosition == 1) {
                                processSecondMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 1) {
                                processSecondDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in first position
                            else {
                                processSucceedingYearDigit(aInputTextbox, gDateStringEntered);
                            }               
                            break;
                        case "1": // first portion of date string validated, awaiting first digit of second portion
                            if (gDateMonthPosition == 2) {
                                processFirstMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 2) {
                                processFirstDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in second position
                            else {
                                processFirstYearDigit(aInputTextbox, gDateStringEntered);
                            }               
                            break;
                        case "1.1": // validating second portion of date sring, and at least one digit has already been entered for it
                            if (gDateMonthPosition == 2) {
                                processSecondMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 2) {
                                processSecondDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in second position
                            else {
                                processSucceedingYearDigit(aInputTextbox, gDateStringEntered);
                            }               
                            break;
                        case "2":
                            if (gDateMonthPosition == 3) {
                                processFirstMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 3) {
                                processFirstDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in third position
                            else if (gDateYearPosition == 3) {
                                processFirstYearDigit(aInputTextbox, gDateStringEntered);
                            }   
                            // no third date portion (e.g., credit card expiration date mm/yyyy)
                            else {
                                // clear last digit entered; disallow all addition digit entry (await onblur date validation)
                                aInputTextbox.value = aInputTextbox.value.substring(0, gDateStringEntered.length-1);
                                gDateFormatterState = "3";
                            }           
                            break;
                        case "2.1":
                            if (gDateMonthPosition == 3) {
                                processSecondMonthDigit(aInputTextbox, gDateStringEntered);
                            }
                            else if (gDateDayPosition == 3) {
                                processSecondDayDigit(aInputTextbox, gDateStringEntered);
                            }
                            // year portion of date pattern is in third position
                            else {
                                processSucceedingYearDigit(aInputTextbox, gDateStringEntered);
                            }               
                            break;
                        case "3":
                            // disallow all addition digit entry (await onblur date validation)
                            aInputTextbox.value = aInputTextbox.value.substring(0, gDateStringEntered.length);
                            break;
                    }
                }
            }
        }
        
        // save current valid string entered
        gDateStringEntered = aInputTextbox.value;

        return true;
    // }
}


/**************************************************************************************
 *  Function    : goToNextState()                                                     *
 *  Description : Updates the state machine to the next state following               *
 *                    "portionUpdated".                                               *
 *  Parameters  : portionUpdated, last state of parser                                *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function goToNextState(portionUpdated) {
    switch(portionUpdated) {
        case "FirstMonthDigit":
            switch(gDateMonthPosition) {
                case 1:
                    gDateFormatterState = "0.1";
                    break;
                case 2:
                    gDateFormatterState = "1.1";
                    break;
                case 3:
                    gDateFormatterState = "2.1";
                    break;
            }
            break;
        case "SecondMonthDigit":
            switch(gDateMonthPosition) {
                case 1:
                    gDateFormatterState = "1";
                    break;
                case 2:
                    gDateFormatterState = "2";
                    break;
                case 3:
                    gDateFormatterState = "3";
                    break;
            }
            break;
        case "FirstDayDigit":
            switch(gDateDayPosition) {
                case 1:
                    gDateFormatterState = "0.1";
                    break;
                case 2:
                    gDateFormatterState = "1.1";
                    break;
                case 3:
                    gDateFormatterState = "2.1";
                    break;
            }
            break;
        case "SecondDayDigit":
            switch(gDateDayPosition) {
                case 1:
                    gDateFormatterState = "1";
                    break;
                case 2:
                    gDateFormatterState = "2";
                    break;
                case 3:
                    gDateFormatterState = "3";
                    break;
            }
            break;
        case "FirstYearDigit":
            switch(gDateYearPosition) {
                case 1:
                    gDateFormatterState = "0.1";
                    break;
                case 2:
                    gDateFormatterState = "1.1";
                    break;
                case 3:
                    gDateFormatterState = "2.1";
                    break;
            }
            break;
        case "SucceedingYearDigit":
            switch(gDateYearPosition) {
                case 1:
                    gDateFormatterState = "1";
                    break;
                case 2:
                    if (gDateDayPosition != 0) {
                        gDateFormatterState = "2";
                    }
                    // else if special case of "credit card expiration date field" (i.e., without "day" value), early terminate date formatter
                    else {
                        gDateFormatterState = "3";
                    }
                    break;
                case 3:
                    gDateFormatterState = "3";
                    break;
            }
            break;
        case "DisableDateFormatter":
            gDateFormatterState = "4";
            break;
    }   
}


/**************************************************************************************
 *  Function    : processFirstMonthDigit()                                            *
 *  Description : Parses the first month digit entered.                               *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processFirstMonthDigit(aInputTextbox, gDateStringEntered) {

    // myAlert("processFirstMonthDigit(aInputTextbox.value=" + aInputTextbox.value + ",gDateStringEntered=" + gDateStringEntered + ")");

    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);

    var lValidDigits = "01";
    // if user entered premature date separator...
    if ((lLastCharEntered == gDateSeparator1) || (lLastCharEntered == gDateSeparator2)) {
        clearLastCharEntered(aInputTextbox);
    }
    // if "2", "3",..., or "9" entered...
    else if (lValidDigits.indexOf(lLastCharEntered) == -1) {
        // pre-pend month's leading "0" for user
        // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1) + "0" + lLastCharEntered;
        aInputTextbox.value = gDateStringEntered + "0" + lLastCharEntered;

        if (gDateMonthPosition == 1) {
            aInputTextbox.value += gDateSeparator1;
        }
        else if (gDateMonthPosition == 2) {
            aInputTextbox.value += gDateSeparator2;
        }

        // record current valid month entry
        gCurrentValidDateArray[gDateMonthPosition-1] = "0" + lLastCharEntered;
    
        goToNextState("SecondMonthDigit");
    }
    // if "0" or "1" entered...
    else {
        // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1) + lLastCharEntered;
        aInputTextbox.value = gDateStringEntered + lLastCharEntered;
        
        // record current valid month entry
        gCurrentValidDateArray[gDateMonthPosition-1] = lLastCharEntered + "m";

        goToNextState("FirstMonthDigit");
    }
}


/**************************************************************************************
 *  Function    : processSecondMonthDigit()                                           *
 *  Description : Parses the second month digit entered.                              *
 *  Assumption  : First month digit entered was "0" or "1".                           *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processSecondMonthDigit(aInputTextbox, gDateStringEntered) {
    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);
    var lFirstCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-2);

    // myAlert("processSecondMonthDigit(aInputTextbox.value=" + aInputTextbox.value + ",gDateStringEntered=" + gDateStringEntered + ")");

    // if user entered premature date separator...
    if (((gDateMonthPosition == 1) && (lLastCharEntered == gDateSeparator1)) || ((gDateMonthPosition == 2) && (lLastCharEntered == gDateSeparator2))) {
        // if valid user-entered premature date separator...
        if (lFirstCharEntered != "0") {
            // pre-pend month's leading "0" for user
            // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-2) + "0" + lFirstCharEntered;
            aInputTextbox.value = gDateStringEntered.substring(0,(gDateStringEntered.length)-1) + "0" + lFirstCharEntered;
            
            if (gDateMonthPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateMonthPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }        
           
            // record current valid month entry
            gCurrentValidDateArray[gDateMonthPosition-1] = "0" + lFirstCharEntered;

            goToNextState("SecondMonthDigit");
        }
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state      
        }
    }
    // if user entered incorrect premature date separator...
    else if (((gDateMonthPosition == 1) && (lLastCharEntered == gDateSeparator2)) || ((gDateMonthPosition == 2) && (lLastCharEntered == gDateSeparator1)))
	{
		clearLastCharEntered(aInputTextbox);
		
		// remain in current state
	}
    else if (lFirstCharEntered == "0") {
        // if valid month portion entered...
        if (lLastCharEntered != "0") {

            if (gDateMonthPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateMonthPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }
           
            // record current valid month entry
            gCurrentValidDateArray[gDateMonthPosition-1] = gCurrentValidDateArray[gDateMonthPosition-1].replace(/m/,lLastCharEntered);

            goToNextState("SecondMonthDigit");
        }
        // invalid month digit entered...
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state
        }
    }
    else if (lFirstCharEntered == "1") {
        var lValidDigits = "012";
        // if valid month portion entered...                        
        if (lValidDigits.indexOf(lLastCharEntered) != -1) {

            if (gDateMonthPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateMonthPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }
           
            // record current valid month entry
            gCurrentValidDateArray[gDateMonthPosition-1] = gCurrentValidDateArray[gDateMonthPosition-1].replace(/m/,lLastCharEntered);

            goToNextState("SecondMonthDigit");
        }
        // invalid month digit entered...
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state
        }
    }
}


/**************************************************************************************
 *  Function    : processFirstDayDigit()                                              *
 *  Description : Parses the first day digit entered.                                 *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processFirstDayDigit(aInputTextbox, gDateStringEntered) {
    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);
    
    // myAlert("processFirstDayDigit(aInputTextbox.value=" + aInputTextbox.value + ",gDateStringEntered=" + gDateStringEntered + ")");

    var lValidDigits = "0123";
    if ((lLastCharEntered == gDateSeparator1) || (lLastCharEntered == gDateSeparator2)) {
        clearLastCharEntered(aInputTextbox);
    }
    // if "4", "5",..., or "9" entered...
    else if (lValidDigits.indexOf(lLastCharEntered) == -1) {
        // pre-pend month's leading "0" for user
        // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1) + "0" + lLastCharEntered;
        aInputTextbox.value = gDateStringEntered + "0" + lLastCharEntered;

        if (gDateDayPosition == 1) {
            aInputTextbox.value += gDateSeparator1;
        }
        else if (gDateDayPosition == 2) {
            aInputTextbox.value += gDateSeparator2;
        }
        
        // record current valid day entry
        gCurrentValidDateArray[gDateDayPosition-1] = "0" + lLastCharEntered;        
            
        goToNextState("SecondDayDigit");
    }
    // if "0", "1", "2", or "3" entered...
    else {
        // record current valid day entry
        gCurrentValidDateArray[gDateDayPosition-1] = lLastCharEntered + "d";
        
        goToNextState("FirstDayDigit");
    }
}


/**************************************************************************************
 *  Function    : processSecondDayDigit()                                             *
 *  Description : Parses the second day digit entered.                                *
 *  Assumption  : First month digit entered was "0",..., or "3.                       *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processSecondDayDigit(aInputTextbox, gDateStringEntered) {
    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);
    var lFirstCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-2);

    // myAlert("processSecondDayDigit(aInputTextbox.value=" + aInputTextbox.value + ",gDateStringEntered=" + gDateStringEntered + ")");
    
    // if user entered premature date separator...
    if (((gDateDayPosition == 1) && (lLastCharEntered == gDateSeparator1)) || ((gDateDayPosition == 2) && (lLastCharEntered == gDateSeparator2))) {
        // if valid user-entered premature date separator...
        if (lFirstCharEntered != "0") {
            // pre-pend day's leading "0" for user
            // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-2) + "0" + lFirstCharEntered;
            aInputTextbox.value = gDateStringEntered.substring(0,(gDateStringEntered.length)-1) + "0" + lFirstCharEntered;

            if (gDateDayPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }   
            else if (gDateDayPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }   
           
            // record current valid day entry
            gCurrentValidDateArray[gDateDayPosition-1] = "0" + lFirstCharEntered;
            
            goToNextState("SecondDayDigit");
        }
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state      
        }
    }
    // if user entered incorrect premature date separator...
    else if (((gDateDayPosition == 1) && (lLastCharEntered == gDateSeparator2)) || ((gDateDayPosition == 2) && (lLastCharEntered == gDateSeparator1)))
	{
		clearLastCharEntered(aInputTextbox);
		
		// remain in current state
	}
    else if (lFirstCharEntered == "0") {
        // if valid day portion entered...
        if (lLastCharEntered  != "0") {
            if (gDateDayPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateDayPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }
            
            // record current valid day entry
            gCurrentValidDateArray[gDateDayPosition-1] = gCurrentValidDateArray[gDateDayPosition-1].replace(/d/,lLastCharEntered);
                        
            goToNextState("SecondDayDigit");
        }
        // invalid day digit entered...
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state
        }
    }
    else if ( (lFirstCharEntered == "1") ||
              (lFirstCharEntered == "2") ) {
            // all second day digits are valid
            
            if (gDateDayPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateDayPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }
           
            // record current valid day entry
            gCurrentValidDateArray[gDateDayPosition-1] = gCurrentValidDateArray[gDateDayPosition-1].replace(/d/,lLastCharEntered);
                                    
            goToNextState("SecondDayDigit");
    }
    // first day digit is "3"...
    else {
        var lValidDigits = "01";
        // if valid second day portion entered...                       
        if (lValidDigits.indexOf(lLastCharEntered) != -1) {

            if (gDateDayPosition == 1) {
                aInputTextbox.value += gDateSeparator1;
            }
            else if (gDateDayPosition == 2) {
                aInputTextbox.value += gDateSeparator2;
            }
            
            // record current valid day entry
            gCurrentValidDateArray[gDateDayPosition-1] = gCurrentValidDateArray[gDateDayPosition-1].replace(/d/,lLastCharEntered);
                                                
            goToNextState("SecondDayDigit");
        }
        // invalid second day digit entered...
        else {
            clearLastCharEntered(aInputTextbox);
            
            // remain in current state
        }
    }
}


/**************************************************************************************
 *  Function    : processFirstYearDigit()                                             *
 *  Description : Parses the first year digit entered.                                *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processFirstYearDigit(aInputTextbox, gDateStringEntered) {
    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);
        
    // if four-digit year...
    if (gDatePatternArray[gDateYearPosition-1].length == 4) {
        if ((lLastCharEntered == gDateSeparator1) || (lLastCharEntered == gDateSeparator2)) {
            clearLastCharEntered(aInputTextbox);
        }
        // if invalid year digit entered...
        else if ( (lLastCharEntered != "1") &&
             (lLastCharEntered != "2") ) {
            
            // pre-pend year's leading "20" for user (assume 21st century)
            // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1) + "20" + lLastCharEntered;
            aInputTextbox.value = gDateStringEntered + "20" + lLastCharEntered;

            // record current valid year entry
            gCurrentValidDateArray[gDateYearPosition-1] = "20" + lLastCharEntered + "y";    
        }
        else {
            // aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1) + lLastCharEntered;
            aInputTextbox.value = gDateStringEntered + lLastCharEntered;

            // record current valid year entry
            gCurrentValidDateArray[gDateYearPosition-1] = lLastCharEntered + "yyy"; 
        }
    }
    // if two-digit year...
    else {
        if ((lLastCharEntered == gDateSeparator1) || (lLastCharEntered == gDateSeparator2)) {
            clearLastCharEntered(aInputTextbox);
        }
        else {
            // any initial year digit is valid
    
            // record current valid year entry
            gCurrentValidDateArray[gDateYearPosition-1] = lLastCharEntered + "y";
        }
    }   
    
    goToNextState("FirstYearDigit");
}


/**************************************************************************************
 *  Function    : processSucceedingYearDigit()                                        *
 *  Description : Parses subsequent year digits entered.                              *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function processSucceedingYearDigit(aInputTextbox, gDateStringEntered) {
    var lLastCharEntered = (aInputTextbox.value).charAt((aInputTextbox.value).length-1);

    var lDateStringArray;
    var lYearStringEnteredSoFar;
    
    if (gDateSeparator1 == gDateSeparator2)
    {
    	lDateStringArray = (aInputTextbox.value).split(gDateSeparator1);
    	lYearStringEnteredSoFar = lDateStringArray[gDateYearPosition-1];
    }
    else
    {
	    if (gDateYearPosition == 3)
	    {
	    	lDateStringArray = (aInputTextbox.value).split(gDateSeparator2);
	    	lYearStringEnteredSoFar = lDateStringArray[1];
	    }
	    else if (gDateYearPosition == 2)
	    {
	    	lDateStringArray = (aInputTextbox.value).split(gDateSeparator2);
	    	lDateStringArray = lDateStringArray[0].split(gDateSeparator1);
	    	lYearStringEnteredSoFar = lDateStringArray[1];	    
	    }
	    else // (gDateYearPosition == 1)
	    {
	    	lDateStringArray = (aInputTextbox.value).split(gDateSeparator1);
	    	lYearStringEnteredSoFar = lDateStringArray[0];
	    }
	}
    
    if ((lLastCharEntered == gDateSeparator1) || (lLastCharEntered == gDateSeparator2)) {
        clearLastCharEntered(aInputTextbox);
    }
    else {  
        // any subsequent year digit is valid
        
        // record current valid year entry
        gCurrentValidDateArray[gDateYearPosition-1] = gCurrentValidDateArray[gDateYearPosition-1].replace(/y/,lLastCharEntered);        
    }
    
    if (gCurrentValidDateArray[gDateYearPosition-1].indexOf("y") == -1) {
    
        if ((gDateYearPosition == 1) && (gDateDayPosition != 0)) {
            aInputTextbox.value += gDateSeparator1;
        }
        else if ((gDateYearPosition == 2) && (gDateDayPosition != 0)) {
            aInputTextbox.value += gDateSeparator2;
        }

        goToNextState("SucceedingYearDigit");
    }
    // else, remain in current state
}


/**************************************************************************************
 *  Function    : clearPreviousCharEntered()                                          *
 *  Description : Clears the previous date digit entered, and adjusts the state       *
 *                    machine accordingly.                                            *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                gDateStringEntered, current contents (value) in the input textbox   *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function clearPreviousCharEntered(aInputTextbox) {
/*
    switch(gDateFormatterState) {
        case "0.0":
            break;
            
        case "0.1":
            if (gDateYearPosition ==1) {
                // clear previous date digit        
                aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-1);
                
                // reset current valid date string
                gCurrentValidDateArray[0].charAt(gDatePatterArray.length-1) = gDatePatternArray[0].charAt(gDatePatterArray.length-1);
                
                if (gCurrentValidDateArray[0].indexOf() {
                    // remain in current state machine state
                    gDateFormatterState = "0.1"
                }
                else {
                    // reset state machine state
                    gDateFormatterState = "0.0"
                }
            }
            else {
                // clear only date digit        
                aInputTextbox.value = "";
                
                // reset current valid date string
                gCurrentValidDateArray[0] = gDatePatternArray[0];
                
                // reset state machine state
                gDateFormatterState = "0.0";
            }
            break;
        case "1.0":
            // clear date separator and last date digit
            aInputTextbox.value = aInputTextbox.value.substring(0, aInputTextbox.value.length-2);

            // reset current valid date string
            gCurrentValidDateArray[0].charAt(gDatePatterArray.length-1) = gDatePatternArray[0].charAt(gDatePatterArray.length-1);
            
            // reset state machine state
            gDateFormatterState = "0.1";
        
            break;
        case "1.1":
        
            break;
        case "2.0":
        
            break;
        case "2.1":
        
            break;
        case "3.0":
        
            break;
    }
*/
}


/**************************************************************************************
 *  Function    : parseDatePattern()                                                  *
 *  Description : Parses, validates, and records the input date pattern to which the  *
 *                     user-inputted date string will be formatted.                   *
 *  Parameters  : aDatePattern, date pattern (should be composed of a combination of  *
 *                    "m"s, "d"s, "y"s, and "separators").                            *
 *  Returns:    : true, if date pattern is valid.                                     *
 *                false, if date pattern is invalid.                                  *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function parseDatePattern(aInputTextbox, aDatePattern) {

    var lDatePattern = aDatePattern;
    //lDatePattern = "yyyy/mm/dd";
    
    // initialize global variables
    initializeDateFormatter(aInputTextbox);
            
    // strip all occurrences of "m"s, "d"s, and "y"s
    lDatePattern = stripChar(lDatePattern, "m");
    if (lDatePattern != "invalid date pattern") {
        lDatePattern = stripChar(lDatePattern, "d");
    }
    else {
        return false;
    }
    if (lDatePattern != "invalid date pattern") {
        lDatePattern = stripChar(lDatePattern, "y");
    }
    else {
        return false;
    }
    
    if (lDatePattern == "invalid date pattern") {
        return false;
    }

    // strip extraneous spaces in Hungarian and Slovak date patterns
    // while (lDatePattern.indexOf(" ") != -1)
    // {
    //   lDatePattern = lDatePattern.replace(" ", "");
    //   aDatePattern = aDatePattern.replace(" ", "");
    // }
    
    // strip extraneous trailing separator in Slovak date pattern
    // if ((lDatePattern.length == 3) && (lDatePattern.charAt(2) == ".")) {
    //  lDatePattern = lDatePattern.substring(0,lDatePattern.length-1);
    //  aDatePattern = aDatePattern.substring(0,aDatePattern.length-1);
    // }
    
    // myAlert("parseDatePattern(lDatePattern=" + lDatePattern + ",aDatePattern=" + aDatePattern + ")");
            
    // determine date separator
    // alert("lDatePattern.length(" + lDatePattern.length + ")");
    if ((lDatePattern.length == 2) || (lDatePattern.length == 1)) {
         
		if (lDatePattern.length == 2)
		{
			gDateSeparator1 = lDatePattern.charAt(0);
 			gDateSeparator2 = lDatePattern.charAt(1);
 		}
 		else // (lDatePattern.length == 1)
 		{
			gDateSeparator1 = lDatePattern.charAt(0);
 			gDateSeparator2 = lDatePattern.charAt(0);
 		}
       
		if (gDateSeparator1 == gDateSeparator2)
		{
	        // split date pattern into date component portions
	        gDatePatternArray = aDatePattern.split(gDateSeparator1);
	    }
	    else // (gDateSeparator1 != gDateSeparator2)
		{
			var lTempArray1 = aDatePattern.split(gDateSeparator1);
			var lDatePortion1 = lTempArray1[0];
			var lTempArray2 = lTempArray1[1].split(gDateSeparator2);
			var lDatePortion2 = lTempArray2[0];
			if (lTempArray2.length == 1)
			{
				gDatePatternArray = new Array(lDatePortion1, lDatePortion2);
			}
			else if (lTempArray2.length > 1)
			{
				gDatePatternArray = new Array(lDatePortion1, lDatePortion2, lTempArray2[1]);
			}
		}
		
        // alert("gDatePatternArray.length(" + gDatePatternArray.length + ")");
        if ((gDatePatternArray.length == 3) || (gDatePatternArray.length == 2)) {

            // now that an actual date pattern is being passed in via the event handlers, initialize date portion positions
            gDateMonthPosition = 0;
            gDateDayPosition = 0;
            gDateYearPosition = 0;
            
            for (var i=0; i<(gDatePatternArray.length); i++) {
                // alert("gDatePatternArray[" + i + "](" + gDatePatternArray[i] + ")");
                switch(gDatePatternArray[i].charAt(0)) {
                    case "m":
                        gDateMonthPosition = i+1;
                        break;
                    case "d":
                        gDateDayPosition = i+1;
                        break;
                    case "y":
                        gDateYearPosition = i+1;
                        break;
                }
                
				gCurrentValidDateArray[i] = gDatePatternArray[i];
            }
            
            // alert("parseDatePattern.mdyPositions(" + gDateMonthPosition + "," + gDateDayPosition + "," + gDateYearPosition + ")");
            // alert("parseDatePattern(gCurrentValidDateArray[0]=" + gCurrentValidDateArray[0] + ",gCurrentValidDateArray[1]=" + gCurrentValidDateArray[1] + ",gCurrentValidDateArray[2]=" + gCurrentValidDateArray[2] + ")");
            
            // record date pattern
            gPreviousDatePattern = aDatePattern;

            return true;
        }
    }

    // clear recorded date pattern
    gPreviousDatePattern = "";
            
    return false;
}


/**************************************************************************************
 *  Function    : stripChar()                                                         *
 *  Description : Helper function to removes all occurrences of an alphabetic         *
 *                     character from an input string.                                *
 *  Parameters  : pString, date pattern composed of a combination of "m"s, "d"s, and  *
 *                    "y"s.                                                           *
 *                pCharToStrip, alphabetic character to be removed from pString.      *
 *  Returns:    : Original input string with alphabetic character removed.            *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Author      : Samson Wong                                                         *
 **************************************************************************************/
function stripChar(pString, pCharToStrip) {
    var indexOfCharToEliminate = -1;
    var indexOfPreviousCharEliminated = -1;
    var lDone = false;
    
    while (!lDone) {
        if (pString.length == 0) {
            lDone = true;
        }
        else {
            indexOfCharToEliminate = pString.indexOf(pCharToStrip);

            // myAlert("stripChar(pString=" + pString + ",pCharToStrip=" + pCharToStrip + ",indexOfCharToEliminate=" + indexOfCharToEliminate + ")");
            
            if (indexOfCharToEliminate == -1) {
                lDone = true;
            }
            else {
            
                if ( (indexOfPreviousCharEliminated == -1) ||
                     ((indexOfPreviousCharEliminated != -1) && (indexOfPreviousCharEliminated == indexOfCharToEliminate)) ) {
                    // remove single character from input string
                    pString = pString.substring(0, indexOfCharToEliminate) + pString.substring(indexOfCharToEliminate+1, (pString.length));
                    
                    // record index of last character eliminated (the next, if any, character to be eliminated must be in the same location
                    //    as this character removed, i.e., the individual "m"s, "d"s, and "y"s, respectively, must be adjacent to each other,
                    //    otherwise the date pattern is invalid)
                    indexOfPreviousCharEliminated = indexOfCharToEliminate;
                }
                else {
                    // myAlert("stripCharInvalid(pString=" + pString + ",pCharToStrip=" + pCharToStrip + ")");
                    return("invalid date pattern");
                } 
            }           
        }
    }
    return(pString);
}


/**************************************************************************************
 *  Function    : clearLastCharEntered()                                              *
 *  Description : Helper function to remove the last character entered in the input   *
 *                     textbox.                                                       *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *  Returns:    : true, if last character successfully removed.                       *
 *                false, if reference to input textbox invalid.                       *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Authors     : Richard Gorremans (xbase@volcano.net), www.spiritwolfx.com, and     *
 *                    Samson Wong                                                     *
 **************************************************************************************/
function clearLastCharEntered(aInputTextbox) {

    // myAlert("clearLastCharEntered(lastChar=" + aInputTextbox.value.charAt(aInputTextbox.value.length-1) + ")");
    if (aInputTextbox) {
        if (isNav4)
        {
            aInputTextbox.value = "";
            aInputTextbox.focus();
            aInputTextbox.select();
        }
        else
        {
            if (aInputTextbox.value.length > 1) {
                // clear last character, but retain the rest of (previously-entered) date string        
                aInputTextbox.value = aInputTextbox.value.substring(0, ((aInputTextbox.value.length)-1));
            }
            else {
                aInputTextbox.value = "";
            }
        }
        return true;
    }
    return false;
}


/**************************************************************************************
 *  Function    : presubmitDateValidation()                                           *
 *  Description : onblur event handler to determine if date string entered is valid.  *
 *                    Changes the date textbox's background color to pink if invalid. *
 *  Parameters  : aInputTextbox, reference to the html textbox into which the user    *
 *                    enters the date string                                          *
 *                aDatePattern, date pattern (containing some combination of "m"s,    *
 *                    "s"s, "y"s, and "separators" to which the user-inputted date    *
 *                     string is to be formated                                       *
 *  ISD Feature : "Date Formatter"                                                    *
 *  Authors     : Samson Wong                                                         *
 **************************************************************************************/
function presubmitDateValidation(aInputTextbox, aDatePattern) {

    var lInputTextboxArray;
    var lDatePatternArray;
    var lDateMonthString;
    var lDateDayString;
    var lDateYearString;
    var lValidDigits;   
    var lDateValid = true; // assume valid date string unless discovered otherwise
    
    // myAlert("presubmitDateValidation(aInputTextbox.value=" + aInputTextbox.value + ",aDatePattern=" + aDatePattern + ")");
    // myAlert("presubmitDateValidation(gPreviousDatePattern=" + gPreviousDatePattern + ",aDatePattern=" + aDatePattern + ")");
    
    // re-parse date pattern only if different from that in previous call
    if (gPreviousDatePattern != aDatePattern) {
    
        // parse date pattern
        if (!parseDatePattern(aInputTextbox, aDatePattern)) {
            goToNextState("DisableDateFormatter");
            return false;
        }       
    }
    
    if (aInputTextbox.value.length > 0) {
		if (gDateSeparator1 == gDateSeparator2)
		{
	        // split date pattern into date component portions
	        lDatePatternArray = aDatePattern.split(gDateSeparator1);
	        lInputTextboxArray = aInputTextbox.value.split(gDateSeparator1);
	    }
	    else // (gDateSeparator1 != gDateSeparator2)
		{
			lDatePatternArray = new Array(3);
			var lTempArray1 = aDatePattern.split(gDateSeparator1);
			lDatePatternArray[0] = lTempArray1[0];
			var lTempArray2 = lTempArray1[1].split(gDateSeparator2);
			lDatePatternArray[1] = lTempArray2[0];
			lDatePatternArray[2] = lTempArray2[1];
			
			lInputTextboxArray = new Array(3);
			var lTempArray1 = aInputTextbox.value.split(gDateSeparator1);
			lInputTextboxArray[0] = lTempArray1[0];
			var lTempArray2 = lTempArray1[1].split(gDateSeparator2);
			lInputTextboxArray[1] = lTempArray2[0];
			lInputTextboxArray[2] = lTempArray2[1];
			
		}


        if (lDatePatternArray.length != lInputTextboxArray.length) {
            lDateValid = false;
        }
        
        if (lDatePatternArray.length == 3) {
            // extract individual month, day, and year strings
            switch(gDateMonthPosition) {
                case 1:
                    lDateMonthString = lInputTextboxArray[0];
                    break;
                case 2:
                    lDateMonthString = lInputTextboxArray[1];
                    break;
                case 3:
                    lDateMonthString = lInputTextboxArray[2];
                    break;
            }
            switch(gDateDayPosition) {
                case 1:
                    lDateDayString = lInputTextboxArray[0];
                    break;
                case 2:
                    lDateDayString = lInputTextboxArray[1];
                    break;
                case 3:
                    lDateDayString = lInputTextboxArray[2];
                    break;
            }
            switch(gDateYearPosition) {
                case 1:
                    lDateYearString = lInputTextboxArray[0];
                    break;
                case 2:
                    lDateYearString = lInputTextboxArray[1];
                    break;
                case 3:
                    lDateYearString = lInputTextboxArray[2];
                    break;
            }
            
            // myAlert("lDateMonthString(" + lDateMonthString + ")");
            // myAlert("lDateDayString(" + lDateDayString + ")");
            // myAlert("lDateYearString(" + lDateYearString + ")");
            
            // validate month string
            if ((lDateMonthString != null) && (lDateMonthString.length <= 2)) {
                // if two digit month string...
                if (lDateMonthString.length == 2) {
                    // if first digit is "0"...
                    if (lDateMonthString.charAt(0) == "0") {
                        lValidDigits = "123456789";
                        // if second digit is not "1"-"9"...
                        if (lValidDigits.indexOf(lDateMonthString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // if first digit is "1"...
                    else if (lDateMonthString.charAt(0) == "1") {
                        lValidDigits = "012";
                        // if second digit is not "0"-"2"...
                        if (lValidDigits.indexOf(lDateMonthString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // invalid first month digit
                    else {
                        lDateValid = false;
                    }
                }
                // if single digit month string...
                else if (lDateMonthString.length == 1) {
                    lValidDigits = "123456789";
                    // if single digit is not "1"-"9"...
                    if (lValidDigits.indexOf(lDateMonthString.charAt(0)) == -1) {
                        lDateValid = false;
                    }
                }
                // zero-lengthed month string (i.e., consecutive date separators in date textbox)
                else {
                    lDateValid = false;
                }
            }
            // too many characters in month string
            else {
                lDateValid = false;
            }

            // validate day string
            if ((lDateDayString != null) && (lDateDayString.length <= 2)) {
                // if two digit day string...
                if (lDateDayString.length == 2) {
                    // if first digit is "0"...
                    if (lDateDayString.charAt(0) == "0") {
                        lValidDigits = "123456789";
                        // if second digit is not "1"-"9"...
                        if (lValidDigits.indexOf(lDateDayString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // if first digit is "1" or "2"...
                    else if ((lDateDayString.charAt(0) == "1") || (lDateDayString.charAt(0) == "2")) {
                        lValidDigits = "0123456789";
                        // if second digit is not "0"-"9"...
                        if (lValidDigits.indexOf(lDateDayString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // if first digit is "3"...
                    else if (lDateDayString.charAt(0) == "3") {
                        lValidDigits = "01";
                        // if second digit is not "0" or "1"...
                        if (lValidDigits.indexOf(lDateDayString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // invalid first day digit
                    else {
                        lDateValid = false;
                    }
                }
                // if single digit day string...
                else if (lDateDayString.length == 1) {
                    lValidDigits = "123456789";
                    // if single digit is not "1"-"9"...
                    if (lValidDigits.indexOf(lDateDayString.charAt(0)) == -1) {
                        lDateValid = false;
                    }
                }
                // zero-lengthed day string (i.e., consecutive date separators in date textbox)
                else {
                    lDateValid = false;
                }
            }
            // too many digits in day string
            else {
                lDateValid = false;
            }
            
            // validate year string
            if ((lDateYearString != null) && (lDateYearString.length != 2) && (lDateYearString.length != 4)) {
                lDateValid = false;
            }
        }
        // special case of "credit card expiration date"...
        else if (lDatePatternArray.length == 2) {
            lInputTextboxArray = aInputTextbox.value.split(gDateSeparator1);

            // extract individual month and year strings
            lDateMonthString = lInputTextboxArray[0];
            lDateYearString = lInputTextboxArray[1];
            
            // myAlert("lDateMonthString(" + lDateMonthString + ")");
            // myAlert("lDateYearString(" + lDateYearString + ")");
            
            // validate month string
            if ((lDateMonthString != null) && (lDateMonthString.length <= 2)) {
                // if two digit month string...
                if (lDateMonthString.length == 2) {
                    // if first digit is "0"...
                    if (lDateMonthString.charAt(0) == "0") {
                        lValidDigits = "123456789";
                        // if second digit is not "1"-"9"...
                        if (lValidDigits.indexOf(lDateMonthString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // if first digit is "1"...
                    else if (lDateMonthString.charAt(0) == "1") {
                        lValidDigits = "012";
                        // if second digit is not "0"-"2"...
                        if (lValidDigits.indexOf(lDateMonthString.charAt(1)) == -1) {
                            lDateValid = false;
                        }
                    }
                    // invalid first month digit
                    else {
                        lDateValid = false;
                    }
                }
                // if single digit month string...
                else if (lDateMonthString.length == 1) {
                    lValidDigits = "123456789";
                    // if single digit is not "1"-"9"...
                    if (lValidDigits.indexOf(lDateMonthString.charAt(0)) == -1) {
                        lDateValid = false;
                    }
                }
                // zero-lengthed month string (i.e., consecutive date separators in date textbox)
                else {
                    lDateValid = false;
                }
            }
            // too many characters in month string
            else {
                lDateValid = false;
            }
            
            // validate year string
            if ((lDateYearString != null) && (lDateYearString.length != 2) && (lDateYearString.length != 4)) {
                lDateValid = false;
            }
        }
        else {
            lDateValid = false;
        }
        
        if (lDateValid == false) {
            // change date text field background color to pink
            aInputTextbox.style.background = "pink";
        }
    }
    
    if (lDateValid == false) {
	    // clear recorded date pattern
	    gPreviousDatePattern = "";
	}
	
	return(lDateValid);          
}


function updateTarget(targetName, selectedValue, selectedDisplayValue)
    {
        if (window.opener && !window.opener.closed) {
            var target = window.opener.document.getElementById(targetName);
            
            // sam - always replace last dropdown list entry before selecting entry via Fev_SetFormControlValue()
            // because Firefox/Netscape does not support adding additional entries
            // var bSuccess = Fev_SetFormControlValue(target, selectedValue);
            var bSuccess = false;
            
            if (!bSuccess)
            {
                // sam - replace last dropdown list entry (instead inserting a new list item) because Firefox/Netscape
                // does not support adding additional entries
                if ( /* insertListControlValue(window.opener.document, target, selectedValue, selectedDisplayValue) || */
                    Fev_ReplaceLastListControlOption(target, selectedValue, selectedDisplayValue) )
                {
                    //try setting the selection again
                    bSuccess = Fev_SetFormControlValue(target, selectedValue);
                }
            }
            
            if (bSuccess)
            {
                if(target != null) {
                    if (navigator.appName == "Netscape") {
                        var myevent = document.createEvent("HTMLEvents")
                        myevent.initEvent("change", true, true)
                        target.dispatchEvent(myevent);
                    }
                    else { // IE
                        target.fireEvent('onchange');
                    }
                }
            }           

            window.close();
        }
    }

    /******************************************************************************************************/
    /* sam - this function should only be used for IE (Firefox/Netscape does not support "options.add()") *
    /******************************************************************************************************/
    //Inserts the value into a list element, independent of the element's type.
    function insertListControlValue(objDocument, objListElement, strValue, strText)
    {
        var strTagName = Fev_GetElementTagName(objListElement);
        switch (strTagName.toLowerCase())
        {
            case "select":
                var objOption = objDocument.createElement("OPTION");
                objOption.value = strValue;
                objOption.text = strText;
                objListElement.options.add(objOption);
                return true;
                break;
            default:
                break;
        }
        return false;
    }


/**************************************************************************************
 *  Description : Global variables used by "JavaScript Date Selector" feature.        *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
var dateSelectorDivID = "dateSelector";
var iFrameDivID = "dateSelectoriframe";

var dayArrayShort = new Array('Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa');
var dayArrayMed = new Array('Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat');
var dayArrayLong = new Array('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday');
var monthArrayShort = new Array('Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec');
var monthArrayMed = new Array('Jan', 'Feb', 'Mar', 'Apr', 'May', 'June', 'July', 'Aug', 'Sept', 'Oct', 'Nov', 'Dec');
var monthArrayLong = new Array('January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December');
 
// these variables define the date formatting we're expecting and outputting.
// If you want to use a different format by default, change the defaultDateSeparator
// and defaultDateFormat variables either here or on your HTML page.
var defaultDateSeparator = "/";        // common values would be "/" or "."
var defaultDateFormat = "mdy"    // valid values are "mdy", "dmy", and "ymd"
var dateSeparator = defaultDateSeparator;
var dateFormat = defaultDateFormat;


/**************************************************************************************
 *  Function    : displayDateSelector()                                               *
 *  Description : Displays the date selector beneath the "date input field" when the  *
 *                     "date selector icon" is clicked.                               *
 *  Parameters  : dateFieldName, html element name of the "date input field" that     *
 *                     will be filled in if the user picks a date                     *
 *                displayBelowThisObject, html element name of the object below which *
 *                     the date selector is displayed (optional)                      *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function displayDateSelector(dateFieldName, displayBelowThisObject, dtFormat, dtSep)
{
  var targetDateField = document.getElementsByName (dateFieldName).item(0);
 
  // if we weren't told what node to display the dateSelector beneath, just display it
  // beneath the date field we're updating
  if (!displayBelowThisObject)
    displayBelowThisObject = targetDateField;
 
  // if a date separator character was given, update the dateSeparator variable
  if (dtSep)
    dateSeparator = dtSep;
  else
    dateSeparator = defaultDateSeparator;
 
  // if a date format was given, update the dateFormat variable
  if (dtFormat)
    dateFormat = dtFormat;
  else
    dateFormat = defaultDateFormat;
 
  var x = displayBelowThisObject.offsetLeft;
  var y = displayBelowThisObject.offsetTop + displayBelowThisObject.offsetHeight ;
 
  // deal with elements inside tables and such
  var parent = displayBelowThisObject;
  while (parent.offsetParent) {
    parent = parent.offsetParent;
    x += parent.offsetLeft;
    y += parent.offsetTop ;
  }
 
  drawDateSelector(targetDateField, x, y);
}


/**************************************************************************************
 *  Function    : drawDateSelector()                                                  *
 *  Description : Called by displayDateSelector() to draw the dateSelector object     *
 *                (which is just a table with calendar elements) at the specified x   *
 *                and y coordinates.                                                  *
 *  Parameters  : targetDateField, html element name of the "date input field" that   *
 *                     will be filled in if the user picks a date                     *
 *                x, x-coordinate of the displayed date selector                      *
 *                y, y-coordinate of the displayed date selector                      *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function drawDateSelector(targetDateField, x, y)
{
  var dt = getFieldDate(targetDateField.value );
 
  // the dateSelector table will be drawn inside of a <div> with an ID defined by the
  // global dateSelectorDivID variable. If such a div doesn't yet exist on the HTML
  // document we're working with, add one.
  if (!document.getElementById(dateSelectorDivID)) {
    // don't use innerHTML to update the body, because it can cause global variables
    // that are currently pointing to objects on the page to have bad references
    //document.body.innerHTML += "<div id='" + dateSelectorDivID + "' class='dpDiv'></div>";
    var newNode = document.createElement("div");
    newNode.setAttribute("id", dateSelectorDivID);
    newNode.setAttribute("class", "dpDiv");
    newNode.setAttribute("style", "visibility: hidden;");
    document.body.appendChild(newNode);
  }
 
  // move the dateSelector div to the proper x,y coordinate and toggle the visiblity
  var selectorDiv = document.getElementById(dateSelectorDivID);
  selectorDiv.style.position = "absolute";
  selectorDiv.style.left = x + "px";
  selectorDiv.style.top = y + "px";
  selectorDiv.style.visibility = (selectorDiv.style.visibility == "visible" ? "hidden" : "visible");
  selectorDiv.style.display = (selectorDiv.style.display == "" ? "none" : "");
  selectorDiv.style.zIndex = 10000;
 
  // draw the dateSelector table
  refreshDateSelector(targetDateField.name, dt.getFullYear(), dt.getMonth(), dt.getDate());
}


/**************************************************************************************
 *  Function    : refreshDateSelector()                                               *
 *  Description : Function which actually does the drawing of the date selector       *
 *                    html table.                                                     *
 *  Parameters  : dateFieldName, html element name of the "date input field" that     *
 *                     will be filled in if the user picks a date                     *
 *                year, year to highlight (optional) (default is today's year)        *
 *                month, month to highlight (optional) (default is today's month)     *
 *                day, day to highlight (optional) (default is today's day)           *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function refreshDateSelector(dateFieldName, year, month, day)
{
  // if no arguments are passed, use today's date; otherwise, month and year
  // are required (if a day is passed, it will be highlighted later)
  var thisDay = new Date();
 
  if ((month >= 0) && (year > 0)) {
    thisDay = new Date(year, month, 1);
  } else {
    day = thisDay.getDate();
    thisDay.setDate(1);
  }
 
  // the calendar will be drawn as a table
  // you can customize the table elements with a global CSS style sheet,
  // or by hardcoding style and formatting elements below
  var crlf = "\r\n";
  var TABLE = "<table cols=7 class='dpTable'>" + crlf;
  var xTABLE = "</table>" + crlf;
  var TR = "<tr class='dpTR'>";
  var TR_title = "<tr class='dpTitleTR'>";
  var TR_days = "<tr class='dpDayTR'>";
  var TR_todaybutton = "<tr class='dpTodayButtonTR'>";
  var xTR = "</tr>" + crlf;
  var TD = "<td class='dpTD' onMouseOut='this.className=\"dpTD\";' onMouseOver=' this.className=\"dpTDHover\";' ";    // leave this tag open, because we'll be adding an onClick event
  // sam
  var TD_noDay = "<td>";
  // sam
  // var TD_title = "<td colspan=5 class='dpTitleTD'>";
  var TD_title = "<td colspan=3 class='dpTitleTD'>";
  // var TD_buttons = "<td class='dpButtonTD'>";
  var TD_buttons = "<td class='dpButtonTD' colspan='2' style='text-align:center;'>";
  var TD_todaybutton = "<td colspan=7 class='dpTodayButtonTD'>";
  var TD_days = "<td class='dpDayTD'>";
  var TD_selected = "<td class='dpDayHighlightTD' onMouseOut='this.className=\"dpDayHighlightTD\";' onMouseOver='this.className=\"dpTDHover\";' ";    // leave this tag open, because we'll be adding an onClick event
  var xTD = "</td>" + crlf;
  var DIV_title = "<div class='dpTitleText'>";
  var DIV_selected = "<div class='dpDayHighlight'>";
  var xDIV = "</div>";
 
  // start generating the code for the calendar table
  var html = TABLE;
 
  // this is the title bar, which displays the month and the buttons to
  // go back to a previous month or forward to the next month
  html += TR_title;
  
  // sam
  html += TD_buttons + getButtonCode(dateFieldName, thisDay, -12, "arrow_beg.gif") + "&nbsp;" + getButtonCode(dateFieldName, thisDay, -1, "arrow_left.gif") + xTD;
  html += TD_title + DIV_title + monthArrayLong[ thisDay.getMonth()] + " " + thisDay.getFullYear() + xDIV + xTD;
  html += TD_buttons + getButtonCode(dateFieldName, thisDay, 1, "arrow_right.gif") + "&nbsp;" + getButtonCode(dateFieldName, thisDay, 12, "arrow_end.gif") + xTD;
  html += xTR;
 
  // this is the row that indicates which day of the week we're on
  html += TR_days;
  for(i = 0; i < dayArrayShort.length; i++)
    html += TD_days + dayArrayShort[i] + xTD;
  html += xTR;
 
  // now we'll start populating the table with days of the month
  html += TR;
 
  // first, the leading blanks
  for (i = 0; i < thisDay.getDay(); i++)
    html += TD_noDay + "&nbsp;" + xTD;
 
  // now, the days of the month
  do {
    dayNum = thisDay.getDate();
    TD_onclick = " onclick=\"updateDateField('" + dateFieldName + "', '" + getDateString(thisDay) + "');\">";
    
    if (dayNum == day)
      html += TD_selected + TD_onclick + DIV_selected + dayNum + xDIV + xTD;
    else
      html += TD + TD_onclick + dayNum + xTD;
    
    // if this is a Saturday, start a new row
    if (thisDay.getDay() == 6)
      html += xTR + TR;
    
    // increment the day
    thisDay.setDate(thisDay.getDate() + 1);
  } while (thisDay.getDate() > 1)
 
  // fill in any trailing blanks
  if (thisDay.getDay() > 0) {
    for (i = 6; i > thisDay.getDay(); i--)
      html += TD_noDay + "&nbsp;" + xTD;
  }
  html += xTR;
 
  // add a button to allow the user to easily return to today, or close the calendar
  var today = new Date();
  var todayString = "Today is " + dayArrayMed[today.getDay()] + ", " + monthArrayMed[ today.getMonth()] + " " + today.getDate();
  html += TR_todaybutton + TD_todaybutton;
  
  // sam
  // html += "<button class='dpTodayButton' onClick='refreshDateSelector(\"" + dateFieldName + "\");'>this month</button> ";
    html += "<table cellpadding='0' cellspacing='0' border='0' style='padding-top:10px;' width='100%'>"
    html += "        <tr><td style='text-align:right;'>";
  
    html += "<table cellpadding='0' cellspacing='0' border='0'>"
    html += "        <tr>";
    html += "           <td class='button-TL-white'><img src='../Images/space.gif' height='5' width='17' alt=''/></td>";
    html += "           <td class='button-T-white'><img src='../Images/space.gif' height='5' width='4' alt=''/></td>";
    html += "           <td class='button-TR-white'><img src='../Images/space.gif' height='5' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "        <tr>";
    html += "           <td class='button-L-white'><img src='../Images/space.gif' height='12' width='17' alt=''/></td>";
    html += "           <td class='button-white'><a id='OkButton__Button' class='button_link' href='#' onClick='refreshDateSelector(\"" + dateFieldName + "\");'>Today</a></td>";
    html += "           <td class='button-R-white'><img src='../Images/space.gif' height='12' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "        <tr>";
    html += "           <td class='button-BL-white'><img src='../Images/space.gif' height='8' width='17' alt=''/></td>";
    html += "           <td class='button-B-white'><img src='../Images/space.gif' height='8' width='4' alt=''/></td>";
    html += "           <td class='button-BR-white'><img src='../Images/space.gif' height='8' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "       </table>";

    html += "        </td>";
    html += "       <td width='10'>";
    html += "        </td>";
    html += "       <td>";

    html += "<table cellpadding='0' cellspacing='0' border='0'>"
    html += "        <tr>";
    html += "           <td class='button-TL-white'><img src='../Images/space.gif' height='5' width='17' alt=''/></td>";
    html += "           <td class='button-T-white'><img src='../Images/space.gif' height='5' width='4' alt=''/></td>";
    html += "           <td class='button-TR-white'><img src='../Images/space.gif' height='5' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "        <tr>";
    html += "           <td class='button-L-white'><img src='../Images/space.gif' height='12' width='17' alt=''/></td>";
    html += "           <td class='button-white'><a id='CancelButton__Button' class='button_link' href='#' onClick='updateDateField(\"" + dateFieldName + "\");'>Cancel</a></td>";
    html += "           <td class='button-R-white'><img src='../Images/space.gif' height='12' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "        <tr>";
    html += "           <td class='button-BL-white'><img src='../Images/space.gif' height='8' width='17' alt=''/></td>";
    html += "           <td class='button-B-white'><img src='../Images/space.gif' height='8' width='4' alt=''/></td>";
    html += "           <td class='button-BR-white'><img src='../Images/space.gif' height='8' width='16' alt=''/></td>";
    html += "        </tr>";
    html += "       </table>";

    html += "        </td></tr>";
    html += "       </table>";
    
  // html += "<button class='dpTodayButton' onClick='updateDateField(\"" + dateFieldName + "\");'>close</button>";
  html += xTD + xTR;
 
  // and finally, close the table
  html += xTABLE;
 
  document.getElementById(dateSelectorDivID).innerHTML = html;
  // add an "iFrame shim" to allow the dateSelector to display above selection lists
  adjustiFrame();
}


/**************************************************************************************
 *  Function    : getButtonCode()                                                     *
 *  Description : Helper function to construct the html for the previous/next         *
 *                    month/year buttons.                                             *
 *  Parameters  : dateFieldName, html element name of the "date input field" that     *
 *                     will be filled in if the user picks a date                     *
 *                dateVal, current date highlighted                                   *
 *                adjust, number of months to move back/forward                       *
 *                label, previous/next month/year button image to use for this button *
 *  Returns:    : The html for previous/next month/year button.                       *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function getButtonCode(dateFieldName, dateVal, adjust, label)
{
  var newMonth = (dateVal.getMonth () + adjust) % 12;
  var newYear = dateVal.getFullYear() + parseInt((dateVal.getMonth() + adjust) / 12);
  if (newMonth < 0) {
    newMonth += 12;
    newYear += -1;
  }
 
  // sam
  // return "<button class='dpButton' onClick='refreshDateSelector(\"" + dateFieldName + "\", " + newYear + ", " + newMonth + ");'>" + label + "</button>";
  return "<a href='#' onClick='refreshDateSelector(\"" + dateFieldName + "\", " + newYear + ", " + newMonth + ");'><img src='../Images/" + label + "' border='0'></a>"
}


/**************************************************************************************
 *  Function    : getDateString()                                                     *
 *  Description : Convert a JavaScript Date object to a string, based on the          *
 *                dateFormat and dateSeparator variables at the beginning of this     *
 *                script library.                                                     *
 *  Parameters  : dateVal, current date highlighted                                   *
 *  Returns:    : The highlighted date as a string.                                   *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function getDateString(dateVal)
{
  var dayString = "00" + dateVal.getDate();
  var monthString = "00" + (dateVal.getMonth()+1);
  dayString = dayString.substring(dayString.length - 2);
  monthString = monthString.substring(monthString.length - 2);
 
  switch (dateFormat) {
    case "dmy" :
      return dayString + dateSeparator + monthString + dateSeparator + dateVal.getFullYear();
    case "ymd" :
      return dateVal.getFullYear() + dateSeparator + monthString + dateSeparator + dayString;
    case "mdy" :
    default :
      return monthString + dateSeparator + dayString + dateSeparator + dateVal.getFullYear();
  }
}


/**************************************************************************************
 *  Function    : getFieldDate()                                                      *
 *  Description : Converts a string to a JavaScript Date objec                        *
 *  Parameters  : dateString, date string to be converted into a JavaScript Date      *
 *                    object.                                                         *
 *  Returns:    : The date string as a JavaScript Date object.                        *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function getFieldDate(dateString)
{
  var dateVal;
  var dArray;
  var d, m, y;
 
  try {
    dArray = splitDateString(dateString);
    if (dArray) {
      switch (dateFormat) {
        case "dmy" :
          d = parseInt(dArray[0], 10);
          m = parseInt(dArray[1], 10) - 1;
          y = parseInt(dArray[2], 10);
          break;
        case "ymd" :
          d = parseInt(dArray[2], 10);
          m = parseInt(dArray[1], 10) - 1;
          y = parseInt(dArray[0], 10);
          break;
        case "mdy" :
        default :
          d = parseInt(dArray[1], 10);
          m = parseInt(dArray[0], 10) - 1;
          y = parseInt(dArray[2], 10);
          break;
      }
      dateVal = new Date(y, m, d);
    } else if (dateString) {
      dateVal = new Date(dateString);
    } else {
      dateVal = new Date();
    }
  } catch(e) {
    dateVal = new Date();
  }
 
  return dateVal;
}


/**************************************************************************************
 *  Function    : splitDateString()                                                   *
 *  Description : Splits a date string into an array of elements, using common date   *
 *                    separators.                                                     *
 *  Parameters  : dateString, date string to be converted into a JavaScript Date      *
 *                    object.                                                         *
 *  Returns:    : The split date array, if operation successful; false, otherwise.    *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function splitDateString(dateString)
{
  var dArray;
  if (dateString.indexOf("/") >= 0)
    dArray = dateString.split("/");
  else if (dateString.indexOf(".") >= 0)
    dArray = dateString.split(".");
  else if (dateString.indexOf("-") >= 0)
    dArray = dateString.split("-");
  else if (dateString.indexOf("\\") >= 0)
    dArray = dateString.split("\\");
  else
    dArray = false;
 
  return dArray;
}


/**************************************************************************************
 *  Function    : dateSelectorClosed()                                                *
 *  Description : Update the "date input field" with the date string, and hide the    *
 *                    date selector.  If no date string is passed, just close the     *
 *                    date selector without changing the field value.                 *
 *  Parameters  : dateFieldName, html element name of the "date input field" that     *
 *                    will be filled in if the user picks a date                      *
 *                dateString, date string with which the "date input field" is to be  *
 *                    updated.                                                        *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
/**
If the page developer has defined a function called dateSelectorClosed anywhere on
the page or in an imported library, we will attempt to run that function with the updated
field as a parameter. This can be used for such things as date validation, setting default
values for related fields, etc. For example, you might have a function like this to validate
a start date field:

function dateSelectorClosed(dateField)
{
  var dateObj = getFieldDate(dateField.value);
  var today = new Date();
  today = new Date(today.getFullYear(), today.getMonth(), today.getDate());
 
  if (dateField.name == "StartDate") {
    if (dateObj < today) {
      // if the date is before today, alert the user and display the dateSelector again
      alert("Please enter a date that is today or later");
      dateField.value = "";
      document.getElementById(dateSelectorDivID).style.visibility = "visible";
      adjustiFrame();
    } else {
      // if the date is okay, set the EndDate field to 7 days after the StartDate
      dateObj.setTime(dateObj.getTime() + (7 * 24 * 60 * 60 * 1000));
      var endDateField = document.getElementsByName ("EndDate").item(0);
      endDateField.value = getDateString(dateObj);
    }
  }
}

*/
function updateDateField(dateFieldName, dateString)
{
  var targetDateField = document.getElementsByName (dateFieldName).item(0);
  if (dateString)
    targetDateField.value = dateString;
 
  var selectorDiv = document.getElementById(dateSelectorDivID);
  selectorDiv.style.visibility = "hidden";
  selectorDiv.style.display = "none";
 
  adjustiFrame();
  targetDateField.focus();
 
  // after the dateSelector has closed, optionally run a user-defined function called
  // dateSelectorClosed, passing the field that was just updated as a parameter
  // (note that this will only run if the user actually selected a date from the dateSelector)
  if ((dateString) && (typeof(dateSelectorClosed) == "function"))
    dateSelectorClosed(targetDateField);
}


/**************************************************************************************
 *  Function    : adjustiFrame()                                                      *
 *  Description : Uses an "iFrame shim" to deal with problems where the dateSelector  *
 *                    shows up behind selection list elements, if they're below the   *
 *                    date selector.                                                  *
 *                The problem and solution are described at:                          *
 *                 http://dotnetjunkies.com/WebLog/jking/archive/2003/07/21/488.aspx  *
 *                 http://dotnetjunkies.com/WebLog/jking/archive/2003/10/30/2975.aspx *
 *  Parameters  : selectorDiv, html div containing date selector                      *
 *                iFrameDiv, html div containing iframe shim.                         *
 *  Returns:    : None.                                                               *
 *  ISD Feature : "JavaScript Date Selector"                                          *
 *  Authors     : Julian Robichaux, http://www.nsftools.com, and Samson Wong          *
 **************************************************************************************/
function adjustiFrame(selectorDiv, iFrameDiv)
{
  // we know that Opera doesn't like something about this, so if we
  // think we're using Opera, don't even try
  var is_opera = (navigator.userAgent.toLowerCase().indexOf("opera") != -1);
  if (is_opera)
    return;
  
  // put a try/catch block around the whole thing, just in case
  try {
    if (!document.getElementById(iFrameDivID)) {
      // don't use innerHTML to update the body, because it can cause global variables
      // that are currently pointing to objects on the page to have bad references
      //document.body.innerHTML += "<iframe id='" + iFrameDivID + "' src='javascript:false;' scrolling='no' frameborder='0'>";
      var newNode = document.createElement("iFrame");
      newNode.setAttribute("id", iFrameDivID);
      newNode.setAttribute("src", "javascript:false;");
      newNode.setAttribute("scrolling", "no");
      newNode.setAttribute ("frameborder", "0");
      document.body.appendChild(newNode);
    }
    
    if (!selectorDiv)
      selectorDiv = document.getElementById(dateSelectorDivID);
    if (!iFrameDiv)
      iFrameDiv = document.getElementById(iFrameDivID);
    
    try {
      iFrameDiv.style.position = "absolute";
      iFrameDiv.style.width = selectorDiv.offsetWidth;
      iFrameDiv.style.height = selectorDiv.offsetHeight ;
      iFrameDiv.style.top = selectorDiv.style.top;
      iFrameDiv.style.left = selectorDiv.style.left;
      iFrameDiv.style.zIndex = selectorDiv.style.zIndex - 1;
      iFrameDiv.style.visibility = selectorDiv.style.visibility ;
      iFrameDiv.style.display = selectorDiv.style.display;
    } catch(e) {
    }
 
  } catch (ee) {
  }
}


/**************************************************************************************
 *  Function    : DisplayPopupWindowCallBackWith11()                                  *
 *  Description : Displays a popup window with the content received from Ajax method  *
 *					of .NET 1.1 application     									  *
 *  Parameters  : result is the data recieved from ajax method                        *        
 *  Assumptions : Only Ajax method will call this                                     *
 *  ISD Feature :                                                                     *
 *  Authors     : Sowmya.                                                             *
 **************************************************************************************/

function PopupDisplayWindowCallBackWith11(result)
{
    // The detailRollOverPopup() displays the content returned from the AJAX call in a popup window 
    // It accepts three parameters: 
    // - aTitle, string to be displayed in the title bar of the popup window.
    // - aContent, string containing HTML to be displayed in the body of the popup. 
    // - aPersist, boolean indicating whether the popup should remain visible even on mouseout.
    
    detailRolloverPopup(result.value[0], result.value[1], result.value[2], result.value[3], result.value[4], result.value[5]); 
}



/**************************************************************************************
 *  Function    : DisplayPopupWindowCallBackWith20()                                  *
 *  Description : Displays a popup window with the content received from Ajax method  *
 *		            of .NET 2.0 application											  *
 *  Parameters  : result is the data recieved from ajax method                        *        
 *  Assumptions : Only Ajax method will call this                                     *
 *  ISD Feature :                                                                     *
 *  Authors     : Sowmya.                                                             *
 **************************************************************************************/

function PopupDisplayWindowCallBackWith20(result)
{
    // The detailRollOverPopup() displays the content returned from the AJAX call in a popup window 
    // It accepts three parameters: 
    // - aTitle, string to be displayed in the title bar of the popup window.
    // - aContent, string containing HTML to be displayed in the body of the popup. 
    // - aPersist, boolean indicating whether the popup should remain visible even on mouseout.
    
        detailRolloverPopup(result[0], result[1], result[2], result[3], result[4], result[5]);  
}

