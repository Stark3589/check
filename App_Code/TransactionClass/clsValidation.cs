﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Globalization;

//Lalit Kumar Verma 16-02-09
namespace TripleITTransaction
{
    public class clsValidation
    {
        
        public clsValidation()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        // Check File Extention.
        //Lalit Kumar Verma 16-02-09
        public bool IsExtenstion(FileUpload file, String type)
        {
            String ext = System.IO.Path.GetExtension(file.FileName);
            if (type == "Image")
            {
                if (ext.ToLower() == ".jpg" || ext.ToLower() == ".png" || ext.ToLower() == ".gif" || ext.ToLower() == ".jpeg")
                {
                    return false;
                }
            }
            else if (type == "Pdf")
            {
                if (ext.ToLower() == ".pdf")
                {
                    return false;
                }
            }
            else if (type == "Video")
            {
                if (ext.ToLower() == ".mp4" || ext.ToLower() == ".flv")
                {
                    return false;
                }
            }
            else if (type == "Exe")
            {
                if (ext.ToLower() == ".exe" || ext.ToLower() == ".Exe")
                {
                    return false;
                }
            }
            else if (type == "Msi")
            {
                if (ext.ToLower() == ".msi" || ext.ToLower() == ".Msi")
                {
                    return false;
                }
            }
            else if (type == "Any")
            {
                if (ext.ToLower() == ".txt" || ext.ToLower() == ".doc" || ext.ToLower() == ".docx" || ext.ToLower() == ".pdf")
                {
                    return false;
                }
                    //return false;
            }
            else if (type == "Default")
            {
                if (ext.ToLower() == ".txt" || ext.ToLower() == ".doc" || ext.ToLower() == ".docx" || ext.ToLower() == ".pdf" 
                    || ext.ToLower() == ".jpg" || ext.ToLower() == ".png" || ext.ToLower() == ".gif" || ext.ToLower() == ".jpeg")
                {
                    return false;
                }
                //return false;
            }
            return true;
        }

        // Validate email address format.  
        //Lalit Kumar Verma 16-02-09
        public  bool IsValidEmail(string Email)
        {
            return Regex.IsMatch(Email, @"/^[A-Za-z]\w*([.|-]\w*){0,4}[@]\w+[A-Za-z-]*([.]\w{2,10}){1,4}$/gi");
        }

        public  bool IsEmail(string Email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Email))
                return (true);
            else
                return (false);
        } 

        // Checks the data not to be blank or null
        //Lalit Kumar Verma 16-02-09
        public  bool RequiredCheck(string strVal)
        {
            bool check = true;
            if (strVal != null)
            {
                if (strVal.Trim() == string.Empty)
                {
                    check = false;
                }
            }
            else
            {
                check = false;
            }
            return (check);
        }

        // Checks the data contains valid internet URL
        //Lalit Kumar Verma 16-02-09
        public  bool IsValidInternetURL(string strVal)
        {
            if (RequiredCheck(strVal))
            {
                Regex rg = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
                return (rg.IsMatch(strVal));
            }
            else
            {
                return true;
            }
        }

        public  bool IsUrl(string Url)
        {
            string strRegex = "^(https?://)"
            + "?(([0-9a-z_!~*'().&=+$%-]+: )?[0-9a-z_!~*'().&=+$%-]+@)?" //user@
            + @"(([0-9]{1,3}\.){3}[0-9]{1,3}" // IP- 199.194.52.184
            + "|" // allows either IP or domain
            + @"([0-9a-z_!~*'()-]+\.)*" // tertiary domain(s)- www.
            + @"([0-9a-z][0-9a-z-]{0,61})?[0-9a-z]\." // second level domain
            + "[a-z]{2,6})" // first level domain- .com or .museum
            + "(:[0-9]{1,4})?" // port number- :80
            + "((/?)|" // a slash isn't required if there is no file name
            + "(/[0-9a-z_!~*'().;?:@&=+$,%#-]+)+/?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(Url))
                return (true);
            else
                return (false);
        }

        // Empty Text Box
        //Lalit Kumar Verma 16-02-09
        public void ResetMe(Control parent)
        {
            {
                foreach (Control c in parent.Controls)
                {
                    // For TextBox
                    if ((c.GetType() == typeof(TextBox)))
                    {
                        ((TextBox)(c)).Text = "";
                    }
                    // For DropDownList
                    if ((c.GetType() == typeof(DropDownList)))
                    {
                        ((DropDownList)(c)).SelectedIndex  = 0;
                    }
                    // For CheckBox
                    if ((c.GetType() == typeof(CheckBox)))
                    {
                        ((CheckBox)(c)).Checked = false;
                    }
                    // For RadioButton
                    if ((c.GetType() == typeof(RadioButton)))
                    {
                        ((RadioButton)(c)).Checked = false;
                    }
                    // For HiddenField
                    if ((c.GetType() == typeof(HiddenField)))
                    {
                        ((HiddenField)(c)).Value = "";
                    }
                    // Execute Form
                    if (c.HasControls())
                    {
                        ResetMe(c);
                    }
                }
            }
        }

        public Int32 Rating(Int32 Total, Int32 Count)
        {
            Int32 nRatig = 0;
            nRatig = Total / (Count);
            return nRatig;
        }

        public string ToNumber(string Price)
        {
            string ProuctPrice = "";
            if (Price != "" && Price != "0" && Price != "NaN" && Price != "Infinity")
            {
                ProuctPrice = Price;
            }
            return ProuctPrice;
        }

        public string ToBlank(string Price)
        {
            string ProuctPrice = "";
            if (Price != "" && Price != "0" && Price != "NaN" && Price != "Infinity")
            {
                ProuctPrice = Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(Price))).ToString();
            }
            return ProuctPrice;
        }

        public string ToPrecision(string Price)
        {
            string ProuctPrice = "";
            if (Price != "" && Price != "0" && Price != "NaN" && Price != "Infinity")
            {
                ProuctPrice = Convert.ToDecimal(String.Format("{0:0.0}", Convert.ToDecimal(Price))).ToString();
            }
            return ProuctPrice;
        }
        // First Capital Letters
        //Lalit Kumar Verma 16-02-09

        public string FirstCapitalLetter(string mText)
        {
            System.Globalization.CultureInfo textInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return textInfo.TextInfo.ToTitleCase(mText);

        }

        // Replace Special Char
        //Lalit Kumar Verma 16-02-09
        public string SetUrlString(string mText)
        {
            string sUrl = mText.Replace(" ", "_"); // Blank Space
            sUrl = sUrl.Replace("&", "!"); // & 
            return sUrl;
        }

        // Replace Special Char
        //Lalit Kumar Verma 16-02-09
        public string GetUrlString(string mText)
        {
            string sUrl = mText.Replace("_", " "); // Blank Space
            sUrl = sUrl.Replace("!", "&"); // & 
            return sUrl;
        }

        // Dateformat DD/MM/YYYY
        //Lalit Kumar Verma 16-02-09
        public string DDMMYYYY(string mText)
        {
            DateTime Dt = Convert.ToDateTime(mText);
            return Dt.ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public string ToDDMMYYYY(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat);
        }
        public string ToMMDDYYYY(DateTime dt)
        {
            return dt.ToString("MM/dd/yyyy",System.Globalization.CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat);
        }

        public string ToRemoveExtraCahr(string sString)
        {
            string ProuctPrice = sString.Replace("'", "");

            return ProuctPrice;
        }

        /// Format date to "Jan. 1, 2009"
        //Lalit Kumar Verma 16-02-09
        public string RemoveSpecialCharacters(string  sString)
        {
            Regex re = new Regex("[;\\/:*?\"<>|&']");
            string nString = re.Replace(sString, " ");
            return nString;
        }

        /// Returns word count.
        //Lalit Kumar Verma 16-02-09
        public  int WordCount(string strToCount)
        {
            int words;

            Regex reg = new Regex(@"\w+");

            MatchCollection mc = reg.Matches(strToCount);

            if (mc.Count > 0)
                words = mc.Count;
            else
                words = 0;

            return words;
        }
        
        // Validate firstname and lastname.
        //Lalit Kumar Verma 16-02-09
        public  bool IsValidName(string strToCheck)
        {
            return Regex.IsMatch(strToCheck, "^[a-zA-Z ]+$");
        }

        /// Format date to "Jan. 1, 2009"
        //Lalit Kumar Verma 16-02-09
        public string FormatDate(DateTime date)
        {
            string newdateformat = date.ToString("MMM") + ". " + date.Day + ", " + date.Year;
            return newdateformat;
        }
        
        // Validate date of birth.
        //Lalit Kumar Verma 16-02-09
        public bool IsValidAge(DateTime DOB, int minAgeAllowed)
        {
            int AllowedAge;
            AllowedAge = DateTime.Now.Year - DOB.Year;

            if (AllowedAge < minAgeAllowed)
            {
                return false;
            }

            if (DOB.Year < DateTime.Now.Year)
            {
                return true;
            }

            return false;
        }

        
        // Validate a string to make sure it meets the min and max characters.
        //Lalit Kumar Verma 16-02-09
        public  bool IsMinAndMAxLenght(string strtext, int minlength, int maxlenght)
        {
            if ((strtext.Length < minlength) || strtext.Length > maxlenght)
            {
                return false;
            }

            return true;
        }

        
        // Validate a string to a expected lenght of characters.
        //Lalit Kumar Verma 16-02-09
        public  bool IsExpectedLength(string text, int length)
        {
            if (text == null)
            {
                return false;
            }

            if ((text.Length <= length) && length > 0)
            {
                return true;
            }

            return false;
        }

        
        // Validate a string to an exact lenght of characters.
        //Lalit Kumar Verma 16-02-09
        public  bool IsExactLength(string text, int length)
        {
            if (text == null)
            {
                return false;
            }

            if (text.Length == length)
            {
                return true;
            }

            return false;
        }

        
        // Validate a string to a min lenght of characters.
        //Lalit Kumar Verma 16-02-09
        public  bool IsMinimumLength(string text, int length)
        {
            if (text == null)
            {
                return false;
            }

            if (length < 0)
            {
                return false;
            }

            if (text.Length >= length)
            {
                return true;
            }

            return false;
        }


        // 
        public string GetFileNameIndexing( string DirectoryPath, string FileName, int Ind)
        {
            string nFileName = "";
            string InputFile = FileName;
            string imgPath = HttpContext.Current.Server.MapPath(DirectoryPath + "/" + InputFile);
            // get the extension
            string ext = System.IO.Path.GetExtension(InputFile);
            bool unique = false;
            nFileName = InputFile;

            if (File.Exists(imgPath))
            {
                do
                {
                    Random r = new Random();
                    nFileName = System.IO.Path.GetFileNameWithoutExtension(InputFile) + "_" + r.Next().ToString() + ext;
                    unique = !System.IO.File.Exists("upload" + "/" + nFileName);
                } while (!unique);
            }
            return nFileName;
        }

        // Convert Date in Words
        public string DateToText(DateTime dt, bool includeTime, bool isUK)
        {
            string[] ordinals =
        {
           "First",
           "Second",
           "Third",
           "Fourth",
           "Fifth",
           "Sixth",
           "Seventh",
           "Eighth",
           "Ninth",
           "Tenth",
           "Eleventh",
           "Twelfth",
           "Thirteenth",
           "Fourteenth",
           "Fifteenth",
           "Sixteenth",
           "Seventeenth",
           "Eighteenth",
           "Nineteenth",
           "Twentieth",
           "Twenty First",
           "Twenty Second",
           "Twenty Third",
           "Twenty Fourth",
           "Twenty Fifth",
           "Twenty Sixth",
           "Twenty Seventh",
           "Twenty Eighth",
           "Twenty Ninth",
           "Thirtieth",
           "Thirty First"
        };

            int day = dt.Day;
            int month = dt.Month;
            int year = dt.Year;
            DateTime dtm = new DateTime(1, month, 1);
            string date;

            if (isUK)
            {
                date = "The " + ordinals[day - 1] + " of " + dtm.ToString("MMMM") + " " + NumberToText(year, true);
            }
            else
            {
                date = dtm.ToString("MMMM") + " " + ordinals[day - 1] + " " + NumberToText(year, false);
            }

            if (includeTime)
            {
                int hour = dt.Hour;
                int minute = dt.Minute;
                string ap = "AM";

                if (hour >= 12)
                {
                    ap = "PM";
                    hour = hour - 12;
                }

                if (hour == 0) hour = 12;
                string time = NumberToText(hour, false);
                if (minute > 0) time += " " + NumberToText(minute, false);
                time += " " + ap;
                date += ", " + time;
            }

            return date;
        }

        public string NumberToText(int number, bool isUK)
        {
            if (number == 0) return "Zero";
            string and = isUK ? "and " : ""; // deals with UK or US numbering
            if (number == -2147483648) return "Minus Two Billion One Hundred " + and +
            "Forty Seven Million Four Hundred " + and + "Eighty Three Thousand " +
            "Six Hundred " + and + "Forty Eight";
            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Million ", "Billion " };
            num[0] = number % 1000;           // units
            num[1] = number / 1000;
            num[2] = number / 1000000;
            num[1] = num[1] - 1000 * num[2];  // thousands
            num[3] = number / 1000000000;     // billions
            num[2] = num[2] - 1000 * num[3];  // millions
            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10;              // ones
                t = num[i] / 10;
                h = num[i] / 100;             // hundreds
                t = t - 10 * h;               // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i < first) sb.Append(and);
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                if (i != 0) sb.Append(words3[i - 1]);
            }
            return sb.ToString().TrimEnd();
        }

        public void Alert(string message)
        {
            // Cleans the message to allow single quotation marks
            string cleanMessage = message.Replace("'", "\'");
            string script = "<script type='text/javascript'>alert('" + cleanMessage + "');</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(clsValidation), "alert", script);
            }
        }

        // Error List
        //Lalit Kumar Verma 16-02-09
        public void ErrorMessage(string Message)
        {
            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;
            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterStartupScript(typeof(Page), "Msg", "alert('" + Message + "');", true);
            }

        }

        public string AmountInWords(decimal Num)
        {
            string returnValue;

            if (Num < 0) { return ""; }
            //I have created this function for converting amount in indian rupees (INR).
            //You can manipulate as you wish like decimal setting, Doller (any currency) Prefix.


            string strNum;
            string strNumDec;
            string StrWord;
            strNum = Num.ToString();


            if (strNum.IndexOf(".") + 1 != 0)
            {
                strNumDec = strNum.Substring(strNum.IndexOf(".") + 2 - 1);


                if (strNumDec.Length == 1)
                {
                    strNumDec = strNumDec + "0";
                }
                if (strNumDec.Length > 2)
                {
                    strNumDec = strNumDec.Substring(0, 2);
                }


                strNum = strNum.Substring(0, strNum.IndexOf(".") + 0);
                StrWord = ((double.Parse(strNum) == 1) ? " Rupee " : "") + NumToWord((decimal)(double.Parse(strNum))) + ((double.Parse(strNumDec) > 0) ? (" Rupees and Paise" + cWord3((decimal)(double.Parse(strNumDec)))) : "");
            }
            else
            {
                StrWord = ((double.Parse(strNum) == 1) ? " Rupee " : "") + NumToWord((decimal)(double.Parse(strNum))) + " Rupees ";
            }
            returnValue = StrWord + " Only";
            return returnValue;
        }

        static public string NumToWord(decimal Num)
        {
            string returnValue;


            //I divided this function in two part.
            //1. Three or less digit number.
            //2. more than three digit number.
            string strNum;
            string StrWord;
            strNum = Num.ToString();


            if (strNum.Length <= 3)
            {
                StrWord = cWord3((decimal)(double.Parse(strNum)));
            }
            else
            {
                StrWord = cWordG3((decimal)(double.Parse(strNum.Substring(0, strNum.Length - 3)))) + " " + cWord3((decimal)(double.Parse(strNum.Substring(strNum.Length - 2 - 1))));
            }
            returnValue = StrWord;
            return returnValue;
        }
        static public string cWordG3(decimal Num)
        {
            string returnValue;
            //2. more than three digit number.
            string strNum = "";
            string StrWord = "";
            string readNum = "";
            strNum = Num.ToString();
            if (strNum.Length % 2 != 0)
            {
                readNum = System.Convert.ToString(double.Parse(strNum.Substring(0, 1)));
                if (readNum != "0")
                {
                    StrWord = retWord(decimal.Parse(readNum));
                    readNum = System.Convert.ToString(double.Parse("1" + strReplicate("0", strNum.Length - 1) + "000"));
                    StrWord = StrWord + " " + retWord(decimal.Parse(readNum));
                }
                strNum = strNum.Substring(1);
            }
            while (!System.Convert.ToBoolean(strNum.Length == 0))
            {
                readNum = System.Convert.ToString(double.Parse(strNum.Substring(0, 2)));
                if (readNum != "0")
                {
                    StrWord = StrWord + " " + cWord3(decimal.Parse(readNum));
                    readNum = System.Convert.ToString(double.Parse("1" + strReplicate("0", strNum.Length - 2) + "000"));
                    StrWord = StrWord + " " + retWord(decimal.Parse(readNum));
                }
                strNum = strNum.Substring(2);
            }
            returnValue = StrWord;
            return returnValue;
        }
        static public string cWord3(decimal Num)
        {
            string returnValue;
            //1. Three or less digit number.
            string strNum = "";
            string StrWord = "";
            string readNum = "";
            if (Num < 0)
            {
                Num = Num * -1;
            }
            strNum = Num.ToString();


            if (strNum.Length == 3)
            {
                readNum = System.Convert.ToString(double.Parse(strNum.Substring(0, 1)));
                StrWord = retWord(decimal.Parse(readNum)) + " Hundred";
                strNum = strNum.Substring(1, strNum.Length - 1);
            }


            if (strNum.Length <= 2)
            {
                if (double.Parse(strNum) >= 0 && double.Parse(strNum) <= 20)
                {
                    StrWord = StrWord + " " + retWord((decimal)(double.Parse(strNum)));
                }
                else
                {
                    StrWord = StrWord + " " + retWord((decimal)(System.Convert.ToDouble(strNum.Substring(0, 1) + "0"))) + " " + retWord((decimal)(double.Parse(strNum.Substring(1, 1))));
                }
            }


            strNum = Num.ToString();
            returnValue = StrWord;
            return returnValue;
        }
        static public string retWord(decimal Num)
        {
            string returnValue;
            //This two dimensional array store the primary word convertion of number.
            returnValue = "";
            object[,] ArrWordList = new object[,] { { 0, "" }, { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" }, { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }, { 10, "Ten" }, { 11, "Eleven" }, { 12, "Twelve" }, { 13, "Thirteen" }, { 14, "Fourteen" }, { 15, "Fifteen" }, { 16, "Sixteen" }, { 17, "Seventeen" }, { 18, "Eighteen" }, { 19, "Nineteen" }, { 20, "Twenty" }, { 30, "Thirty" }, { 40, "Forty" }, { 50, "Fifty" }, { 60, "Sixty" }, { 70, "Seventy" }, { 80, "Eighty" }, { 90, "Ninety" }, { 100, "Hundred" }, { 1000, "Thousand" }, { 100000, "Lakh" }, { 10000000, "Crore" } };


            int i;
            for (i = 0; i <= (ArrWordList.Length - 1); i++)
            {
                if (Num == System.Convert.ToDecimal(ArrWordList[i, 0]))
                {
                    returnValue = (string)(ArrWordList[i, 1]);
                    break;
                }
            }
            return returnValue;
        }
        static public string strReplicate(string str, int intD)
        {
            string returnValue;
            //This fucntion padded "0" after the number to evaluate hundred, thousand and on....
            //using this function you can replicate any Charactor with given string.
            int i;
            returnValue = "";
            for (i = 1; i <= intD; i++)
            {
                returnValue = returnValue + str;
            }
            return returnValue;
        }
    }
}
