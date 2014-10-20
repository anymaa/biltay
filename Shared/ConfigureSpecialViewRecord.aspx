<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head>
<title>Configure Special View Record Page</title>
<link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/BaseStyles.css"/>
<link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/Styles.css" />
</head><body>
<table cellspacing="0" cellpadding="0" border="0" class="pageBackground">
  <tr>
  <td class="pageAlignment">
    <table cellspacing="0" cellpadding="0" border="0" class="borderTable">
      <tr>
        <td class="pageBorderTL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderT"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderTR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      </tr>
      <tr>
        <td class="pageBorderL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderC">
	<table cellspacing="0" cellpadding="0" border="0" class="master_table">
	 <tr>
	  <td class="page_yellow">
		<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse" width="600" id="AutoNumber1">
		  <tr>
		  	<td class="dialog_header" colspan="3">
				<table cellpadding="0" cellspacing="0" border="0" width="100%">
				  <tr>
				    <td class="dialogHeaderEdgeL"><img src="../Images/space.gif" alt="" /></td>
					<td class="dialog_header_text">Configuring a Special View Record Page</td>
				    <td class="dialogHeaderEdgeR"><img src="../Images/space.gif" alt="" /></td>
				  </tr>
				</table>
		  	</td>
		  </tr>
		  <tr>
		  	<td width="20"></td>
			<td class="configureErrorPagesText"><br />
				The View button or icon you clicked on is not yet bound to a View Record page.<br /><br />
				The table that contains the record you are trying to view is either a non-physical table (i.e. a View or a Query), or has no primary key.  However, you can still create a View button for it by binding the View Icon and providing a Primary Key from a referenced physical table.<br /><br />
				This will enable you to view a record from one of the referenced physical tables.  For example, you could bind the View Icon for the 'Alphabetical list of products' view from the Northwind database so that it displayes a Products record for viewing.<br /><br />
      			You can bind the View button or icon to a View Record page by doing the following:<br /><br />
			    <ol>
			      <li>If you have not yet created a View Record page, use the Application Builder to create one or create one by hand.<br /><br /></li>
			      <li>Go to the Application Explorer tab, navigate in the tree to the page that contains the View button or icon, then click the Page Properties button on the tool bar.<br /><br />
			      <ul style="list-style-type:disc">
			      	<li>Select the name of the View button or icon in the tree.</li>
			      	<li>On the Bindings tab, modify the Redirect URL to point to your View Record page.<br />Example:  ../MyPages/MyViewRecordPage.aspx?QueryStringParam={0}<br /><br /></li>
			      	<li>The Redirect parameter should reference the field that is a Primary Key for an associated physical table.<br />Example: "FV:ProductID"<br /><br /></li>
			      </ul>
			      </li>
			      <li>Save changes and rebuild the application.</li>
			    </ol>
		    </td>
		  	<td width="20"></td>
		  </tr>
		</table>
	  </td>
	 </tr>
	</table>
      </td>
      <td class="pageBorderR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
    </tr>
    <tr>
      <td class="pageBorderBL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      <td class="pageBorderB"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      <td class="pageBorderBR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
    </tr>
  </table>
  </td>
  </tr>
</table>
</body></html>