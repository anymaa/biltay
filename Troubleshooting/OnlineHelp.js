
function ShowHelp(section) {
	version = "5.2.1"
	url = "http://www.ironspeed.com/Designer/" + version + "/WebHelp/" + section
	newwindow = window.open(url,'name','left=100,top=100,scrollbars=yes,resizable=yes,menubar=yes,location=yes,status=yes,titlebar=yes,toolbar=yes');
	if (window.focus) {newwindow.focus()}
	return false;
}
