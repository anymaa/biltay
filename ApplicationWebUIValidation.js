//<script>

//Same as the Microsoft version, except with 1 line added to the end
function ValidatorOnLoad() {
    if (typeof(Page_Validators) == "undefined")
        return;

    var i, val;
    for (i = 0; i < Page_Validators.length; i++) {
        val = Page_Validators[i];
        if (typeof(val.evaluationfunction) == "string") {
            eval("val.evaluationfunction = " + val.evaluationfunction + ";");
        }
        if (typeof(val.isvalid) == "string") {
            if (val.isvalid == "False") {
                val.isvalid = false;                                
                Page_IsValid = false;
            } 
            else {
                val.isvalid = true;
            }
        } else {
            val.isvalid = true;
        }
        if (typeof(val.enabled) == "string") {
            val.enabled = (val.enabled != "False");
        }
        ValidatorHookupControlID(val.controltovalidate, val);
        ValidatorHookupControlID(val.controlhookup, val);
    }
    Page_ValidationActive = true;
    
    if (!Page_IsValid) { ValidationSummaryOnSubmit(); }
}

//Same as the Microsoft version, except:
//A) This function will not display duplicate validator error messages
//   in either the summary or the message box.
function ValidationSummaryOnSubmit() {
    if (typeof(Page_ValidationSummaries) == "undefined") 
        return;
    var summary, sums, s;
    for (sums = 0; sums < Page_ValidationSummaries.length; sums++) {
        summary = Page_ValidationSummaries[sums];
        summary.style.display = "none";
        if (!Page_IsValid) {
            if (summary.showsummary != "False") {
                summary.style.display = "";
                if (typeof(summary.displaymode) != "string") {
                    summary.displaymode = "BulletList";
                }
                switch (summary.displaymode) {
                    case "List":
                        headerSep = "<br>";
                        first = "";
                        pre = "";
                        post = "<br>";
                        endString = "";
                        break;
                        
                    case "BulletList":
                    default: 
                        headerSep = "";
                        first = "<ul>";
                        pre = "<li>";
                        post = "</li>";
                        endString = "</ul>";
                        break;
                        
                    case "SingleParagraph":
                        headerSep = " ";
                        first = "";
                        pre = "";
                        post = " ";
                        endString = "<br>";
                        break;
                }
                s = "";
                if (typeof(summary.headertext) == "string") {
                    s += summary.headertext + headerSep;
                }
                s += first;

                //start changed code
                var errorMessages = Fev_GetInvalidValidatorErrorMessages();
                for (i = 0; i < errorMessages.length; i++)
                {
                    s += pre + errorMessages[i] + post;
                }   
                //end changed code

                s += endString;
                summary.innerHTML = s; 
                window.scrollTo(0,0);
            }
            if (summary.showmessagebox == "True") {
                s = "";
                if (typeof(summary.headertext) == "string") {
                    s += summary.headertext + "<BR>";
                }
                
                //start changed code
                var errorMessages = Fev_GetInvalidValidatorErrorMessages();
                var pre, post;
				switch (summary.displaymode)
				{
				case "List":
					pre = '';
					post = '<BR>';
					break;
				case "BulletList":
				default: 
					pre = '  - ';
					post = '<BR>';
					break;
				case "SingleParagraph":
					pre = '';
					post = ' ';
					break;
				}
                for (i = 0; i < errorMessages.length; i++)
                {
                    s += pre + errorMessages[i] + post;
                }
                //end changed code

                span = document.createElement("SPAN");
                span.innerHTML = s;
                s = span.innerText;
                alert(s);
            }
        }
    }
}


//
// Validation constants
//
var FEV_CREDIT_CARD_TYPE_VISA = 'Visa';
var FEV_CREDIT_CARD_TYPE_DISCOVER = 'Discover';
var FEV_CREDIT_CARD_TYPE_MASTER_CARD = 'Master Card';
var FEV_CREDIT_CARD_TYPE_AMERICAN_EXPRESS = 'American Express';
var FEV_CREDIT_CARD_TYPE_ENROUTE = 'EnRoute';
var FEV_CREDIT_CARD_TYPE_CARTE_BLANCHE = 'Carte Blanche';
var FEV_CREDIT_CARD_TYPE_DINERS_CLUB = 'Diners Club';
var FEV_CREDIT_CARD_TYPE_JCB = 'JCB';
var FEV_CREDIT_CARD_TYPE_UNKNOWN = 'Unknown';
var FEV_CREDIT_CARD_TYPE_INVALID = 'Invalid';

//
// .NET Validator Control functions
//

function Fev_ValidatorEvaluateIsValid(val)
{
	var control;
    if (document && val && val.controltovalidate) {
        control = document.getElementById(val.controltovalidate);
        if (control) {
	        return CustomValidatorEvaluateIsValid(val);
	    }
	}
	return(true);
}

function Fev_FieldValueValidatorEvaluateIsValid(objSource, objArguments) {
	var innerValidatorId = objSource.id + '_InnerValidator';
	var innerValidator = document.all[innerValidatorId];
	if (innerValidator)
	{
		ValidatorValidate(innerValidator);
		objArguments.IsValid = innerValidator.isvalid;
	}
	else
	{
		objArguments.IsValid = true;
	}
}

function Fev_BooleanValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidBoolean(value);
}

function Fev_PasswordValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidPassword(value, objSource.MinLength, objSource.MaxLength);
}

function Fev_UsaPhoneNumberValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUsaPhoneNumber(value);
}

function Fev_CreditCardNumberValidatorEvaluateIsValid(objSource, objArguments)
{
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidCreditCardNumber(value, true);
}

function Fev_CreditCardDateValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidCreditCardDate(value);
}

function Fev_NumberValidatorEvaluateIsValid(objSource, objArguments)
{
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidFloatUpToNDecimals(value, objSource.MaxDecimalPlaces, objSource.MinValue, objSource.MaxValue);
}

function Fev_CountryValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidCountry(value);
}

function Fev_UsaStateValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUsaState(value);
}

function Fev_UsaZipCodeValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUsaZipCode(value);
}

function Fev_EmailValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidEmailAddress(value);
}

function Fev_UrlValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUrl(value);
}

function Fev_PercentageValidatorEvaluateIsValid(objSource, objArguments)
{
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidPercentage(value, objSource.MaxDecimalPlaces, objSource.MinValue, objSource.MaxValue);
}

function Fev_CurrencyValidatorEvaluateIsValid(objSource, objArguments)
{
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidCurrency(value, objSource.MaxDecimalPlaces, objSource.MinValue, objSource.MaxValue);
}

function Fev_ImageValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidImagePath(value);
}

function Fev_FileValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidWindowsFileName(value);
}

function Fev_DateTimeValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUsaDate_digits(value, objSource.AllowTime);
}

function Fev_ShortDateValidatorEvaluateIsValid(objSource, objArguments) {
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else objArguments.IsValid = Fev_isValidUsaDate_digits(value, false);
}

function Fev_TextBoxMaxLengthValidatorEvaluateIsValid(objSource, objArguments) {
	var ctv = Fev_GetControlToValidate(objSource);
	var value = objArguments.Value;
	if (value == '') objArguments.IsValid = true;
	else if (ctv && ctv.MaxLength)
		objArguments.IsValid = !((ctv.MaxLength > 0) && (ctv.MaxLength < value.length));
	else objArguments.IsValid = true;
}


//
// Utility functions
//


function Fev_GetControlToValidate(validator) {
    if (validator && validator.controltovalidate)
		return Fev_GetControlToValidateById(validator.controltovalidate); 
	return null;
}

function Fev_GetControlToValidateById(id) {
    var control;
    control = document.all[id];
    if (typeof(control.value) == "string") {
        return control;
    }
    if (typeof(control.tagName) == "undefined" && typeof(control.length) == "number") {
        var j;
        for (j=0; j < control.length; j++) {
            var inner = control[j];
            if (typeof(inner.value) == "string" && (inner.type != "radio" || inner.status == true)) {
                return inner;
            }
        }
    }
    else {
        return Fev_GetControlToValidateRecursive(control);
    }
    return "";
}

function Fev_GetControlToValidateRecursive(control)
{
    if (typeof(control.value) == "string" && (control.type != "radio" || control.status == true)) {
        return control;
    }
    var i;
    for (i = 0; i < control.children.length; i++) {
        var child = Fev_GetControlToValidateRecursive(control.children[i]);
        if (child != null) return child;
    }
    return null;
}


//TODO: Test
//function removes non-digit characters, and returns the string
function Fev_RemoveNonDigits(str)
{
	if (str == null || str.length < 1)
		return '';

	var i;
	var currentChar;
	for (i = 0; i < str.length; i++) {
		currentChar = str.charAt(i);

		currentChar = parseInt(currentChar, 10);
		if (isNaN(currentChar)) {
			if (i == 0) {					//1st char
				if (str.length > 1) {
					str = str.substring(1);
				} else {
					str = '';
				}
			} else if (i == str.length-1) {	//last char
				str = str.substring(0, str.length-1);
			} else {						//somewhere in the middle
				str = str.substring(0, i) + str.substring(i+1, str.length);
			}
			i--;
		}
	}
	return str;
}


//==================================================================
//Fev_StrReplace(original string, find string to replace, string that replaces, isCaseSensitive, numTimes) : Returns a copy of a string after replacement.
//	loops (replaces) numTimes times, or as long as the string is found (when numTimes = -1)
//  isCaseSensitive: true (case matters), false (case doesn't matter)
//==================================================================
function Fev_StrReplace(originalStr, findStr, replaceWith, isCaseSensitive, numTimes)
{
	if (originalStr == null || originalStr == "" || findStr == null || findStr == "")
		return originalStr;
	if (findStr == replaceWith)
		return originalStr;

	numTimes = parseInt(numTimes, 10);
	if (isNaN(numTimes) || numTimes == 0)
		return originalStr;
	var isInfinite = (numTimes < 0);

	var findStrLen = findStr.length;
	var tempStr = originalStr;
	var myCounter = 0;

	var TEMP_PLACEHOLDER = ' ';

	if (findStr.indexOf(TEMP_PLACEHOLDER) >= 0)
		return originalStr;

	var index;
	if (isCaseSensitive) {
		index = tempStr.indexOf(findStr);
	} else {
		index = tempStr.toUpperCase().indexOf(findStr.toUpperCase());
	}

	while (index >= 0 && (isInfinite || myCounter < numTimes)) {
        if (index == tempStr.length - findStrLen) {
            tempStr = tempStr.substring(0, tempStr.length - findStrLen) + TEMP_PLACEHOLDER;
        } else if (index == 0) {
            tempStr = TEMP_PLACEHOLDER + tempStr.substring(findStrLen);
        } else {
            tempStr = tempStr.substring(0, index) + TEMP_PLACEHOLDER + tempStr.substring(index + findStrLen);
        }

		if (isCaseSensitive) {
			index = tempStr.indexOf(findStr);
		} else {
			index = tempStr.toUpperCase().indexOf(findStr.toUpperCase());
		}
        myCounter++;
	}

	index = tempStr.indexOf(TEMP_PLACEHOLDER);
	findStrLen = TEMP_PLACEHOLDER.length;

	while (index >= 0 && (isInfinite || myCounter > 0)) {
        if (index == tempStr.length - findStrLen) {
            tempStr = tempStr.substring(0, tempStr.length - findStrLen) + replaceWith;
        } else if (index == 0) {
            tempStr = replaceWith + tempStr.substring(findStrLen);
        } else {
            tempStr = tempStr.substring(0, index) + replaceWith + tempStr.substring(index + findStrLen);
        }

		index = tempStr.indexOf(TEMP_PLACEHOLDER);
        myCounter--;
	}
	return tempStr;
}

function Fev_Trim(str)
{
	if (str == null) return null;
	var m = str.match(/^\s*(\S+(\s+\S+)*)\s*$/);
	return (m == null) ? "" : m[1];
}

//
// Validation functions
// Note: All Fev_isValid* functions always return true or false (they never throw errors).
//

function Fev_isValidCreditCardNumber(strCreditCardNumber, bIgnoreNonDigits)
{
	if ((strCreditCardNumber == null) || (strCreditCardNumber == ''))
		return false;

	var strDigits = Fev_RemoveNonDigits(strCreditCardNumber);

	if ((!bIgnoreNonDigits) && (strDigits != strCreditCardNumber))
		return false;
	if ((strDigits == null) || (strDigits == ''))
		return false;
	if ((strDigits.length < 4) || (strDigits.length > 19))
		return false;

	var strCardType = Fev_ParseCreditCardNumberPrefix(strDigits, true);

	//Validate the card number's length and type
	switch (strCardType)
	{
    case FEV_CREDIT_CARD_TYPE_VISA:
        if ((strDigits.length != 16) && (strDigits.length != 13)) return false;
        break;
    case FEV_CREDIT_CARD_TYPE_DISCOVER:
	case FEV_CREDIT_CARD_TYPE_MASTER_CARD:
        if (strDigits.length != 16) return false;
        break;
    case FEV_CREDIT_CARD_TYPE_AMERICAN_EXPRESS:
	case FEV_CREDIT_CARD_TYPE_ENROUTE:
        if (strDigits.length != 15) return false;
        break;
    case FEV_CREDIT_CARD_TYPE_CARTE_BLANCHE:
    case FEV_CREDIT_CARD_TYPE_DINERS_CLUB:
        if (strDigits.length != 14) return false;
        break;
    case FEV_CREDIT_CARD_TYPE_JCB:
        if ((strDigits.charAt(0) == 3) && (strDigits.length != 16)) return false;
        else if ((strDigits.charAt(0) != 3) && (strDigits.length != 15)) return false;
        break;
    case FEV_CREDIT_CARD_TYPE_UNKNOWN:
    case FEV_CREDIT_CARD_TYPE_INVALID:
	default:
        return false;
	}

	//Validate the card number's Luhn checksum
	switch (strCardType)
	{
	case FEV_CREDIT_CARD_TYPE_ENROUTE:
		//EnRoute cards can have any Checksum
		break;
	default:
		if (Fev_ComputeLuhnChecksum(strDigits) != 0) return false;
		break;
	}

	return true;
}

//TODO: TEST
//Valid time format: hh:mm:ss <am|pm>

function Fev_isValidTimeAMPM(strTime) {
	strTime = Fev_Trim(strTime);
	if (strTime == null || strTime == '')
		return false;

	var timeRE = new RegExp('^' + PATTERN_TIME_AMPM + '?$', 'i');
	return timeRE.test(strTime);
}

//TODO: TEST
//Valid time format: hh:mm:ss
//hh: from 0-23 or 00-23
//mm: from 0-59 or 00-59
//ss: from 0-59 or 00-59
function Fev_isValidTime24HR(strTime) {
	strTime = Fev_Trim(strTime);
	if (strTime == null || strTime == '')
		return false;

	var timeRE = new RegExp('^' + PATTERN_TIME_24HR + '?$', 'i');
	return timeRE.test(strTime);
}


//TODO: TEST
//valid USA date [digits - i.e. non alphabetic]:
//[?1-12]/[?1-31]/([00-99]or [0000-9999]) hh:mm:ss[ ]?am/pm
//i.e. month/day/year where
//	month is either 1[january]-12[december], where ? means option ZERO, if under 10
//	day is from 1 to 31, with optional ZERO if under 10.
//	year is either 2 or 4 digits.
//	dividers: slash, space or dash
//hh: from 0-12 or 00-12 (where 0 = 12), or 0-24/00-24
//mm: from 0-59 or 00-59
//ss: from 0-59 or 00-59
//am or pm is optional
function Fev_isValidUsaDate_digits(strDate, isAllowTime)
{
	strDate = Fev_Trim(strDate);
	if (strDate == null || strDate == '')
		return false;

	var timePattern = "";
	if (isAllowTime) {
		timePattern += "([\ ](" + PATTERN_TIME_AMPM + "|" + PATTERN_TIME_24HR + "))?";
	}

	var dateArray = new Array('^(([0]?[1-9])|10|11|12)', '(([0]?[0-9])|([1-2][0-9])|30|31)', '(([0-9]{4})|([0-9]{2}))' + timePattern + '$');

	var separatorArray = new Array('\ ', '/', '-');

	var separator;
	var i;
	var found = false;
	var RE;
	for (i = 0; i < separatorArray.length && !found; i++) {
		RE = new RegExp(dateArray.join(separatorArray[i]), 'i');
		if (RE.test(strDate)) {
			found = true;
			separator = separatorArray[i];
		}
	}
	if (!found) return false;

	var dateArr = strDate.split(separator);
	var month = parseInt(dateArr[0], 10);
	var day = parseInt(dateArr[1], 10);
	var year = parseInt(dateArr[2], 10);

	year = Fev_NormalizeYear(year);

	var highestDayOfMonth = Fev_GetHighestDayOfMonth(month, year);
	return (day >= 1 && day <= highestDayOfMonth);
}


//TODO: Test
//valid USA date [alphanumeric]:
//([jan-dec][.]? or [january-december])/[?1-31]/([00-99]or [0000-9999])
//i.e. month/day/year where
//	month is either january-december, or jan-dec or jan.-dec. (notice abbreviation can have a PERIOD)
//	day is from 1 to 31, with optional ZERO if under 10.
//	year is either 2 or 4 digits.
//	dividers: slash, space or dash
//hh: from 0-12 or 00-12 (where 0 = 12), or 0-24/00-24
//mm: from 0-59 or 00-59
//ss: from 0-59 or 00-59
//am or pm is optional
function Fev_isValidUsaDate_monthinletters(strDate, isAllowTime)
{
	strDate = Fev_Trim(strDate);
	if (strDate == null || strDate == '')
		return false;

	var monthsStr = '';
	var i;

	monthsStr += '(((';
	for (i = 0; i < Fev_Get_Months_Short().length; i++) {
		if (i > 0) {
			monthsStr += '|';
		}
		monthsStr += Fev_Get_Months_Short()[i];
	}
	monthsStr += ')[\.]?)|';
	for (i = 0; i < Fev_Get_Months_Long().length; i++) {
		if (i > 0) {
			monthsStr += '|';
		}
		monthsStr += Fev_Get_Months_Long()[i];
	}
	monthsStr += ')';

	var timePattern = "";
	if (isAllowTime) {
		timePattern += "([\ ](" + PATTERN_TIME_AMPM + "|" + PATTERN_TIME_24HR + "))?";
	}

	var dateArray = new Array('^' + monthsStr + '[' , '\ ](([0]?[0-9])|([1-2][0-9])|30|31)([', ']|(,[\ ]?))(([0-9]{4})|([0-9]{2}))' + timePattern + '$');

	var separatorArray = new Array('\ ', '/', '-');

	var separator;
	var i;
	var found = false;
	var RE;
	for (i = 0; i < separatorArray.length && !found; i++) {
		RE = new RegExp(dateArray.join(separatorArray[i]), 'i');
		if (RE.test(strDate)) {
			found = true;
			separator = separatorArray[i];
		}
	}
	if (!found) return false;

	var dateArr = strDate.split(separator);
	var month = Fev_MonthStrToInt(dateArr[0]);
	var day = parseInt(dateArr[1], 10);
	var year = parseInt(dateArr[2], 10);

	year = Fev_NormalizeYear(year);

	var highestDayOfMonth = Fev_GetHighestDayOfMonth(month, year);
	return (day >= 1 && day <= highestDayOfMonth);
}


//TODO: Test
//valid: mm/yyyy  (where m can be 1 or 2 digits)
function Fev_isValidCreditCardDate(strCreditCardDate)
{
	var separatorArray = new Array('\ ', '/', '-');

	var ccDateArray = new Array('^(([0]?[1-9])|10|11|12)[', '][0-9]{4}$');

	var separator;
	var i;
	var found = false;
	var RE;
	for (i = 0; i < separatorArray.length && !found; i++) {
		RE = new RegExp(ccDateArray.join(separatorArray[i]), 'i');
		if (RE.test(strCreditCardDate)) {
			found = true;
			separator = separatorArray[i];
		}
	}
	if (!found) return false;
	return true;
}

//TODO: Test	(testing function is in Testing section)
//valid numbers:
// - without commas:	zero
//						<optional minus>(1st digit is non-zero)[unlimited number of digits]
// - with commas:	zero
//					<optional minus>(non-zero digit)<0or1or2 digits><(comma)(3 digits)>*
//  also can have unlimited # of leading zero's (in the whole part of the number)
//  also can have unlimited # of trailing zero's in the decimal portion
function Fev_isValidInteger(strInteger, minValue, maxValue)
{
	strInteger = Fev_Trim(strInteger);
	if (strInteger == null || strInteger == '')
		return false;

	return Fev_isValidFloatUpToNDecimals(strInteger, 0, minValue, maxValue);
//	var integerRE = new RegExp('^(([-]?[1-9][0-9]*)|[0])$');	//without commas
//	var integerWithCommaRE = new RegExp('^(([-]?[1-9][0-9]{0,2}(,[0-9]{3})*)|0)$');	//with commas
//	return integerRE.test(strInteger) || integerWithCommaRE.test(strInteger);
}

//TODO: Test
//same format as Fev_isValidInteger, in addition to:
//	+ <(decimal point)(unlimited number of digits)>
//  also can have unlimited # of leading zero's (in the whole part of the number)
//  also can have unlimited # of trailing zero's in the decimal portion
function Fev_isValidFloat(strFloat, minValue, maxValue) {
	return Fev_isValidFloatUpToNDecimals(strFloat, -1, minValue, maxValue);
}

//TODO: Test
//called by Fev_isValidFloat.
//can specify the max number of allowed decimal digits
//can specify min value
//can specify max value
//  where a non positive number is unlimited, and any positive number is used as max num of decimal digits
//  also can have unlimited # of leading zero's (in the whole part of the number)
//  also can have unlimited # of trailing zero's in the decimal portion
function Fev_isValidFloatUpToNDecimals(strFloat, maxDecimalDigits, minValue, maxValue)
{
	if (maxDecimalDigits == null || maxDecimalDigits == '')
		maxDecimalDigits = -1;
	minValue = Fev_Trim(minValue);
	maxValue = Fev_Trim(maxValue);

	strFloat = Fev_Trim(strFloat);
	if (strFloat == null || strFloat == '')
		return false;

	var decStr = "";
	if (isNaN(maxDecimalDigits) || (maxDecimalDigits < 0)) {
		decStr += "[\.][0-9]*";
	} else if (maxDecimalDigits == 0) {
		decStr += "[\.][0]*";
	} else {
		decStr += "[\.][0-9]{0," + parseInt(maxDecimalDigits, 10) + "}0*";
	}

	var floatRE = new RegExp('^(([-]?[0]*[0-9]*))(' + decStr + ')?$');	//without commas
	var floatWithCommaRE = new RegExp('^([-]?[0-9]{1,3}(,[0-9]{3})*)(' + decStr + ')?$');	//with commas

	if (!(floatRE.test(strFloat) || floatWithCommaRE.test(strFloat))) {
		return false;
	}

	var myNum = parseFloat(Fev_StrReplace(strFloat, ",", "", false, -1));

	if (!isNaN(minValue)) {
		minValue = parseInt(minValue, 10);
		if (myNum < minValue) {
			return false;
		}
	}
	if (!isNaN(maxValue)) {
		maxValue = parseInt(maxValue, 10);
		if (myNum > maxValue) {
			return false;
		}
	}

	return true;
}

//TODO: TEST
function Fev_isValidCurrency(strCurrency, numDecimals, minValue, maxValue) {
	// Currency validation is handled by the Parse routine in the VB or CS code to ensure that all international currency formats are supported properly.
	return true;	

	strCurrency = Fev_Trim(strCurrency);
	if (strCurrency == null || strCurrency == '')
		return false;

	var moneyRE = new RegExp('^([\$])?[\-]?([\$])?([0-9]*[\.]?[0-9]*)$');
	var moneyWithParenthesesRE = new RegExp('^([\$])?[\(]([\$])?([0-9]*[\.]?[0-9]*)([\$])?[\)]([\$])?$');

	if (moneyRE.test(strCurrency)) {
		var myArr = strCurrency.match(moneyRE);

		if (myArr == null)
			return false;

		if (myArr.length > 3) {
			//make sure only one $ sign
			if ((myArr[1] + myArr[2]).length > 1) {
				return false;
			}
			return Fev_isValidFloatUpToNDecimals(myArr[3], numDecimals, minValue, maxValue);
		}
	} else if (moneyWithParenthesesRE.test(strCurrency)) {
		var myArr = strCurrency.match(moneyWithParenthesesRE);
		if (myArr == null)
			return false;

		if (myArr.length > 5) {
			//make sure only one $ sign
			if ((myArr[1] + myArr[2] + myArr[4] + myArr[5]).length > 1) {
				return false;
			}
			return Fev_isValidFloatUpToNDecimals(myArr[3], numDecimals, minValue, maxValue);
		}
	}

	return false;
}

//TODO: TEST
function Fev_isValidPercentage(strPercentage, numDecimals, minValue, maxValue) {
	strPercentage = Fev_Trim(strPercentage);
	if (strPercentage == null || strPercentage == '')
		return false;

	var percentageRE = new RegExp('^[\-]?([0-9]*[\.]?[0-9]*)[\%]?$');

	if (percentageRE.test(strPercentage)) {
		var myArr = strPercentage.match(percentageRE);

		if (myArr == null)
			return false;

		if (myArr.length > 1) {
			return Fev_isValidFloatUpToNDecimals(myArr[1], numDecimals, minValue, maxValue);
		}
	}

	return false;
}


//TODO: Test
function Fev_isValidEmailAddress(strEmailAddress)
{
	return true; //function is too strict. see http://www.aspemporium.com/aspEmporium/tutorials/emailvalidation.asp

	if (bShowAlerts)
		checkTLD = 1;
	else
		checkTLD = 0;

	/* The following pattern is used to check if the entered e-mail address
	fits the user@domain format.  It also is used to separate the username
	from the domain. */

	var emailPat=/^(.+)@(.+)$/;

	/* The following pattern applies if the "user" is a quoted string (in
	which case, there are no rules about which characters are allowed
	and which aren't; anything goes).  E.g. "jiminy cricket"@disney.com
	is a legal e-mail address. */

	var quotedUser="(\"[^\"]*\")";

	/* The following string represents one word in the typical username.
	For example, in john.doe@somewhere.com, john and doe are words.
	Basically, a word is either an atom or quoted string. */

	var word = "(" + atom + "|" + quotedUser + ")";

	// The following pattern describes the structure of the user

	var userPat = new RegExp("^" + word + "(\\." + word + ")*$");

	/* Finally, let's start trying to figure out if the supplied address is valid. */

	/* Begin with the coarse pattern to simply break up user@domain into
	different pieces that are easy to analyze. */

	var matchArray=strEmailAddress.match(emailPat);

	if (matchArray==null) {
		/* Too many/few @'s or something; basically, this address doesn't
		even fit the general mould of a valid e-mail address. */

		if (bShowAlerts) alert("Email address seems incorrect (check @ and .'s)");
		return false;
	}
	var strUser = matchArray[1];
	var strDomain = matchArray[2];

	// Start by checking that only basic ASCII characters are in the strings (0-127).

	for (i=0; i<strUser.length; i++) {
		if (strUser.charCodeAt(i)>127) {
			if (bShowAlerts) alert("Ths username contains invalid characters.");
			return false;
	   }
	}
	for (i = 0; i < strDomain.length; i++) {
		if (strDomain.charCodeAt(i)>127) {
			if (bShowAlerts) alert("Ths domain name contains invalid characters.");
			return false;
		}
	}

	// See if "user" is valid 

	if (strUser.match(userPat)==null) {
		// user is not valid
		if (bShowAlerts) alert("The username doesn't seem to be valid.");
		return false;
	}

	return Fev_isIsReallyAValidDomain(strDomain);
}

//TODO: Test
function Fev_isValidUrl(strUrl)
{
	var myUrlDataArr = Fev_ParseUrl(strUrl);
	if (myUrlDataArr == null) {
		myUrlDataArr = Fev_ParseUrl("http://" + strUrl);
	}

	if (myUrlDataArr == null) {
		return false;
	} else {
		return true;
	}
}

//TODO: TEST
//valid boolean values: 'T' for True, 'F' for False.
//that's it, that's all
function Fev_isValidBoolean(strBoolean) {
	return true; //disabled, because it does not handle display string values.
	strBoolean = Fev_Trim(strBoolean);
	if (strBoolean == null || strBoolean.length == '')
		return false;

	return (strBoolean == 'T' || strBoolean == 'F');
}

//TODO: TEST
function Fev_isValidPassword(strPassword, minLength, maxLength) {
	strPassword = Fev_Trim(strPassword);
	if (strPassword == null || strPassword.length < minLength)
		return false;

	if (isNaN(minLength)) {
		minLength = 0;
	} else {
		minLength = parseInt(minLength);
		if (minLength < 0) {
			minLength = 0;
		}
	}

	if (isNaN(maxLength)) {
		maxLength = null;
	} else {
		maxLength = parseInt(maxLength);
		if (maxLength < minLength) {	//if maxLength < minLength, then don't even bother checking if the password is too long
			maxLength = null;
		}
	}

	if (strPassword.length < minLength)
		return false;

	if (maxLength != null && strPassword.length > maxLength)
		return false;

	return true;
}

//TODO: TEST
//valid phone number formats:
//(ddd)<space or separator>ddd<separator>dddd<(ext<.> or x)<space>(1-5 digits)>
//	note:	opening+closing parentheses come together, and are optional
//			separator is either 'space', '.' or '-'... and try to match only by one kind of separator at a time
//					e.g. 333-333-3333 or (222).333.4556 or 333 333 3333 are all three OK, but 444-333.3333 is NOT
function Fev_isValidUsaPhoneNumber(strUsaPhoneNumber)
{
	strUsaPhoneNumber = Fev_Trim(strUsaPhoneNumber);
	if (strUsaPhoneNumber == null || strUsaPhoneNumber == '')
		return false;
	var myREasArray = new Array('^((([0-9]{3})|[\(][0-9]{3}[\)])[', '\ ]?)?[0-9]{3}[', ']?[0-9]{4}([\ ]((ext)[\.]?|(x))[\ ]?[0-9]{1,5})?$');
	//var phoneRE = new RegExp('^(([0-9]{3})|[\(][0-9]{3}[\)])[-\.\ ]?[0-9]{3}[-\.\ ]?[0-9]{4}$');
	var phoneRE_dash = new RegExp(myREasArray.join("-"), "i");
	var phoneRE_period = new RegExp(myREasArray.join("\."), "i");
	var phoneRE_space = new RegExp(myREasArray.join("\ "), "i");
	return (phoneRE_dash.test(strUsaPhoneNumber) || phoneRE_period.test(strUsaPhoneNumber) || phoneRE_space.test(strUsaPhoneNumber));
}

//TODO: TEST
//valid country format: a-z, dash, space, apostrophe, period, opening parenthesis closing parenthesis
function Fev_isValidCountry(strCountry) {
	strCountry = Fev_Trim(strCountry);
	if (strCountry == null || strCountry == '')
		return false;
	var re = new RegExp("^([a-z\-\ \'\.\(\)])*$", 'i');

	return re.test(strCountry);
}


//TODO: TEST
//valid state format: 2-letter abbreviation (e.g. "CA" for California) full name (e.g. "Arkansas", "New York")
function Fev_isValidUsaState(strUsaState)
{
	strUsaState = Fev_Trim(strUsaState);
	if (strUsaState == null || strUsaState == '')
		return false;

	var stateAbbrevRE = new RegExp('^(al|ak|az|ar|ca|co|ct|dc|de|fl|ga|hi|id|il|in|ia|ks|ky|la|me|md|ma|mi|mn|ms|mo|mt|ne|nv|nh|nj|nm|ny|nc|nd|oh|ok|or|pa|ri|sc|sd|tn|tx|ut|vt|va|wa|wv|wi|wy)$', 'i');
	var stateFullRE = new RegExp('^(alabama|alaska|arizona|arkansas|california|colorado|connecticut|delaware|florida|georgia|hawaii|idaho|illinois|indiana|iowa|kansas|kentucky|louisiana|maine|maryland|massachusetts|michigan|minnesota|mississippi|missouri|montana|nebraska|nevada|new hampshire|new jersey|new mexico|new york|north carolina|north dakota|ohio|oklahoma|oregon|pennsylvania|rhode island|south carolina|south dakota|tennessee|texas|utah|vermont|virginia|washington|(washington((,[\ ]?)|[\ ])((district of columbia)|(d[\.]?c[\.]?)))|west virginia|wisconsin|wyoming)$', 'i');

	return stateAbbrevRE.test(strUsaState) || stateFullRE.test(strUsaState);
}

//TODO: TEST
//valid zip code formats: ddddd, ddddd-dddd
function Fev_isValidUsaZipCode(strUsaZipCode) {
	strUsaZipCode = Fev_Trim(strUsaZipCode);
	if (strUsaZipCode == null || strUsaZipCode == '')
		return false;
	var zipRE = new RegExp('^[0-9]{5}([- ]?[0-9]{4})?$')
	return zipRE.test(strUsaZipCode);
}


//TODO: TEST
//valid filename: any character other than: backslash, slash, colon, asterisk (*), questionmark, double-quote, >, <, vertical bar (|)
//ends with jpg|jpe|jpeg|gif|bmp|png
function Fev_isValidImagePath(strPath) {
	strPath = Fev_Trim(strPath);
	if (strPath == null || strPath == '')
		return false;
	var imagePathRE = new RegExp('[\.](jpg|jpe|jpeg|gif|bmp|png)$', 'i');
	return imagePathRE.test(strPath) && Fev_isValidWindowsFileName(strPath);
}

//TODO: TEST
//[drive]:[\(dir)]*[\(dir|filename)]{0,1}
function Fev_isValidWindowsFilePath(strPath) {
	strPath = Fev_Trim(strPath);
	if (strPath == null || strPath == '')
		return false;
	var filePathRE = new RegExp('^[a-z][\:]([\\\\][^\\\/\:\*\?\"\<\>\|]*)*$', 'i');
	return filePathRE.test(strPath);
}

//TODO: TEST
//valid filename: any character other than: backslash, slash, colon, asterisk (*), questionmark, double-quote, >, <, vertical bar (|)
function Fev_isValidWindowsFileName(strFilename) {
	strFilename = Fev_Trim(strFilename);
	if (strFilename == null || strFilename == '')
		return false;
	if (strFilename.indexOf("\\") >= 0)
		return false;
	var filePathRE = new RegExp('^[^\\\/\:\*\?\"\<\>\|]*$', 'i');
	return filePathRE.test(strFilename);
}


//
// Helper Variables
//

//private variables, should not be called except by Fev_Get_Months_Long, and Fev_Get_Months_Short
var PATTERN_TIME_AMPM = '(([0]?[0-9])|10|11|12)[\:]([0-5]?[0-9])[\:]([0-5]?[0-9])([\ ]?(AM|PM))';
var PATTERN_TIME_24HR = '(([0-1]?[0-9])|20|21|22|23)[\:]([0-5]?[0-9])[\:]([0-5]?[0-9])';

var Fev_MONTHS_LONG = null;
var Fev_MONTHS_SHORT = null;

/* The following variable tells the rest of the function whether or not
to display alerts that specify why the value is invalid */

var bShowAlerts = false;

/* The following string represents the pattern for matching all special
characters.  We don't want to allow special characters in the address. 
These characters include ( ) < > @ , ; : \ " . [ ] */

var specialChars="\\(\\)><@,;:\\\\\\\"\\.\\[\\]";

/* The following string represents the range of characters allowed in a 
username or domainname.  It really states which chars aren't allowed.*/

var validChars="\[^\\s" + specialChars + "\]";

/* The following string represents an atom (basically a series of non-special characters.)
*/

var atom=validChars + '+';

/* The following variable tells the rest of the function whether or not
to verify that the address ends in a two-letter country or well-known
TLD.  1 means check it, 0 means don't. */

var checkTLD = 0;



//
// Validation Helper functions
//

//This function returns an array containing the error message strings of 
//all invalid validators in the page.  Duplicates are ignored.
function Fev_GetInvalidValidatorErrorMessages()
{
	var i, j;
	var msgArray = new Array();
	if (!Page_IsValid)
	{
		for (i = 0; i < Page_Validators.length; i++)
		{
			if (!Page_Validators[i].isvalid && typeof(Page_Validators[i].errormessage) == "string")
			{
				var msg = Page_Validators[i].errormessage;
				var b = false;
				for (j = 0; j < msgArray.length; j++)
				{
					if (msgArray[j] == msg)
					{
						b = true;
						break;
					}
				}   
				if (!b)
				{
					msgArray[msgArray.length] = msg;
				}
			}
		}   
	}
	return msgArray;
}

//returns an int between 0 and 9 (inclusive)
function Fev_ComputeLuhnChecksum(strDigits) 
{
	strDigits = Fev_RemoveNonDigits(strDigits);
	var digit;
	var i;
	var sum = 0;

	for (i = strDigits.length - 2; i >= 0; i -= 2)
	{
		digit = parseInt(strDigits.charAt(i), 10);
		digit *= 2;
		sum += ((digit > 9) ? (digit - 9) : (digit));
	}
	for (i = strDigits.length - 1; i >= 0; i -= 2)
	{
		digit = parseInt(strDigits.charAt(i), 10);
		sum += digit;
	}

	return (sum % 10);
}

//Returns one of the Credit Card Type constants (FEV_CREDIT_CARD_TYPE_*)
function Fev_ParseCreditCardNumberPrefix(strCardNumber, bIgnoreNonDigits)
{
	//Card Types             Prefix            Width      Luhn Checksum        Example
	//American Express       34, 37            15         Mod 10 = 0           3400 0000 0000 009
	//Diners Club            300 to 305, 36    14         Mod 10 = 0           3000 0000 0000 04
	//Carte Blanche          38                14         Mod 10 = 0           3000 0000 0000 04
	//Discover               6011              16         Mod 10 = 0           6011 0000 0000 0004
	//EnRoute                2014, 2149        15         Any                  2014 0000 0000 009
	//JCB                    3                 16         Mod 10 = 0           3088 0000 0000 0009
	//JCB                    2131, 1800        15         Mod 10 = 0           
	//Master Card            51 to 55          16         Mod 10 = 0           5500 0000 0000 0004
	//Visa                   4                 13, 16     Mod 10 = 0           4111 1111 1111 1111

	if (bIgnoreNonDigits)
		strCardNumber = Fev_RemoveNonDigits(strCardNumber);

	if (strCardNumber.length < 4)
		return FEV_CREDIT_CARD_TYPE_INVALID;
	if (Fev_RemoveNonDigits(strCardNumber.substr(0, 4)).length < 4)
		return FEV_CREDIT_CARD_TYPE_INVALID;

	//Parse 1st 2 digits
	switch (parseInt(strCardNumber.substr(0, 2), 10))
	{
	case 51:
	case 52:
	case 53:
	case 54:
	case 55:
		return FEV_CREDIT_CARD_TYPE_MASTER_CARD;
	case 34:
	case 37:
		return FEV_CREDIT_CARD_TYPE_AMERICAN_EXPRESS;
	case 36:
		return FEV_CREDIT_CARD_TYPE_DINERS_CLUB;
	case 38:
		return FEV_CREDIT_CARD_TYPE_CARTE_BLANCHE;
	}

	//Parse 1st 4 digits
	switch (parseInt(strCardNumber.substr(0, 4), 10))
	{
	case 6011:
		return FEV_CREDIT_CARD_TYPE_DISCOVER;
	case 2014:
	case 2149:
		return FEV_CREDIT_CARD_TYPE_ENROUTE;
	case 2131:
	case 1800:
		return FEV_CREDIT_CARD_TYPE_JCB;
	}

	//Parse 1st 3 digits
	switch (parseInt(strCardNumber.substr(0, 3), 10))
	{
	case 300:
	case 301:
	case 302:
	case 303:
	case 304:
	case 305:
		return FEV_CREDIT_CARD_TYPE_DINERS_CLUB;
	}

	//Parse 1st digit
	switch (parseInt(strCardNumber.substr(0, 1), 10))
	{
	case 4:
		return FEV_CREDIT_CARD_TYPE_VISA;
	case 3:
		return FEV_CREDIT_CARD_TYPE_JCB;
	}

	return FEV_CREDIT_CARD_TYPE_UNKNOWN;
}

function Fev_Get_Months_Long() {
	if (Fev_MONTHS_LONG == null) {
		Fev_MONTHS_LONG = new Array('january','february','march','april','may','june','july','august','september','october','november','december');
	}
	return Fev_MONTHS_LONG;
}

function Fev_Get_Months_Short() {
	if (Fev_MONTHS_SHORT == null) {
		Fev_MONTHS_SHORT = new Array('jan','feb','mar','apr','may','jun','jul','aug','(sep[t]?)','oct','nov','dec');
	}
	return Fev_MONTHS_SHORT;
}

function Fev_MonthStrToInt(strMonth) {
	var INVALID_MONTH = -1;
	if (strMonth == null || strMonth == '')
		return INVALID_MONTH;

	strMonth = strMonth.toLowerCase();
	var i;
	for (i = 0; i < Fev_Get_Months_Long().length; i++) {
		if (strMonth == Fev_Get_Months_Long()[i] || strMonth == Fev_Get_Months_Short()[i] || strMonth == (Fev_Get_Months_Short()[i] + '.')) {
			return i+1;
		}
	}

	return -1;
}

function Fev_isValidMonth(month) {
	var myMonth = parseInt(month, 10);
	if (isNaN(myMonth)) {
		return false;
		//will need to support non numeric months
	} else {
		return (myMonth >= 1 && myMonth <= 12);
	}
}

function Fev_NormalizeYear(intYear) {
	if (intYear < 100) {
		if (intYear > 30) {
			intYear += 1900;
		} else {
			intYear += 2000;
		}
	}
	return intYear;
}

function Fev_GetHighestDayOfMonth(intMonth, intYear) {
	var isLeapYear = Fev_isLeapYear(intYear);

	var highestDayOfMonth = -1;
	switch (intMonth) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			highestDayOfMonth = 31;
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			highestDayOfMonth = 30;
			break;
		case 2:
			if (isLeapYear) {
				highestDayOfMonth = 29;
			} else {
				highestDayOfMonth = 28;
			}
			break;
		default:
			break;
	}

	return highestDayOfMonth;
}

function Fev_isLeapYear(strYear) {
	if ((strYear == null) || (strYear == ''))
		return false;

	var strYearFormat = new RegExp('^([0-9]{4}|[0-9]{2})');

	if (!strYearFormat.test(strYear))
		return false;

	var intYear = parseInt(strYear, 10);

	if (intYear % 400 == 0)
		return true;
	if (intYear % 100 == 0)
		return false;
	if (intYear % 4 == 0)
		return true;

	return false;
}

function Fev_ParseUrl(strUrl) {
//[a-zA-Z0-9]([\$-_\.\+][a-zA-Z0-9])*[a-zA-Z0-9]
//(http|https|ftp)://(<user>(:<password>)+[\@])+<host>(:<port>)+(/<url-path>)+

	var myStuffStr = "";
	var myStuffArr = null;

//	var urlRE = new RegExp('^(http|https|ftp)\://([0-9a-z]+([\.\-][0-9a-z]+)*)([/][0-9a-z]*)*$', 'i');
	var urlRE = new RegExp('^(http|https|ftp)\://(([^\/:]+)([\:]([^\/:]*))?\@)?([a-z0-9]([a-z0-9\-\.]+[a-z0-9])?)(:([0-9]{1,5}))?([/][^\/]*)*$', 'i');

	if (!urlRE.test(strUrl)) return myStuffArr;

	var myArr = strUrl.match(urlRE);

	var strProtocol, strHost, strPath, strPort, strUsername, strPassword;

//alert("test for " + strUrl + "...\ndoes it fit url pattern? = " + urlRE.test(strUrl));

	if (myArr != null) {
		var i = 0;
		for (i = 0; i < myArr.length; i++) {
			switch (i) {
				case 1:
					//myStuffStr += "protocol: ";
					strProtocol = myArr[i];
					break;
				case 3:
					//myStuffStr += "username: ";
					strUsername = myArr[i];
					break;
				case 5:
					//myStuffStr += "password: ";
					strPassword = myArr[i];
					break;
				case 6:
					//myStuffStr += "host: ";
					strHost = myArr[i];
					break;
				case 9:
					//myStuffStr += "port: ";
					strPort = myArr[i];
					break;
				case 10:
					//myStuffStr += "path: ";
					strPath = myArr[i];
					break;
				default:
					break;
			}
			//alert(myArr[i]);
		}

		if (Fev_isIsReallyAValidDomain(strHost)) {
			myStuffArr = new Array(7);
			myStuffArr[0] = strUrl;
			myStuffArr[1] = strProtocol;
			myStuffArr[2] = strHost;
			myStuffArr[3] = strPort;
			myStuffArr[4] = strPath;
			myStuffArr[5] = strUsername;
			myStuffArr[6] = strPassword;
		}

		myStuffStr += "url: " + strUrl + "\n";
		myStuffStr += "protocol: " + strProtocol + "\n";
		myStuffStr += "host: " + strHost + "\n";
		myStuffStr += "port: " + strPort + "\n";
		myStuffStr += "path: " + strPath + "\n";
		myStuffStr += "username: " + strUsername + "\n";
		myStuffStr += "password: " + strPassword;
	}

	//alert(myStuffStr);
	//alert(myStuffStr + "\n\n" + strHost + " is Valid domain?: " + Fev_isIsReallyAValidDomain(strHost));

	//alert(strHost + " is Valid domain?: " + Fev_isIsReallyAValidDomain(strHost));
	
	return myStuffArr;
}

function Fev_isIsReallyAValidDomain(strDomain) {
	if (Fev_isAQuadDomain(strDomain)) {
		return Fev_isValidIP(strDomain);
	} else {
		return Fev_isValidDomain(strDomain);
	}
}

// determines if a domain is in "ddd.ddd.ddd.ddd" format
function Fev_isAQuadDomain(strDomain) {
	var ipDomainPat= new RegExp('^([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})$');

	var IPArray = strDomain.match(ipDomainPat);
	return (IPArray != null);
}

//given a str, detemine if it's a valid IP address
function Fev_isValidIP(strDomain) {
	var ipDomainPat= new RegExp('^([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})$');

	var IPArray = strDomain.match(ipDomainPat);
	if (IPArray != null) {
		// this is an IP address

		for (var i=1; i<=4; i++) {
			if (IPArray[i] > 255) {
				return false;
			}
		}
		return true;
	}
	return false;
}

//given a str, detemine if it's a valid domain name
function Fev_isValidDomain(strDomain) {

	/* The following pattern describes the structure of a normal symbolic
	domain, as opposed to ipDomainPat, shown above. */

	var domainPat = new RegExp("^" + atom + "(\\." + atom +")*$");

	// Domain is symbolic name.  Check if it's valid.
	 
	var atomPat = new RegExp("^" + atom + "$");
	var domArr = strDomain.split(".");
	var len = domArr.length;
	for (i = 0; i < len; i++) {
		if (domArr[i].search(atomPat)==-1) {
			if (bShowAlerts) alert("The domain name does not seem to be valid.");
			return false;
		}
	}

	/* The following is the list of known TLDs that an e-mail address must end with. */
	var knownDomsPat=/^(com|net|org|edu|int|mil|gov|arpa|biz|aero|name|coop|info|pro|museum)$/;

	/* domain name seems valid, but now make sure that it ends in a
	known top-level domain (like com, edu, gov) or a two-letter word,
	representing country (uk, nl), and that there's a hostname preceding 
	the domain or country. */

	if (checkTLD && domArr[domArr.length-1].length!=2 && 
		domArr[domArr.length-1].search(knownDomsPat)==-1) {
			if (bShowAlerts)
				alert("The address must end in a well-known domain or two letter " + "country.");
			return false;
	}

	// Make sure there's a host name preceding the domain.
	// this requires SOMETHING.TLD
//	if (len<2) {
//		if (bShowAlerts)
//			alert("This address is missing a hostname!");
//		return false;
//	}

	// If we've gotten this far, everything's valid!
	return true;
}

