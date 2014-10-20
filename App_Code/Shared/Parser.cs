using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;

namespace KumePortali.UI
{
/// <summary>
/// Summary description for Parser: Parser for files like csv, excel etc.
/// </summary>
    public abstract class Parser
    {
        // The type of file. ie, extension of the file.
        public enum FileTypes
        {
            CSV
        }

        // Constructor
        public Parser(){}

        // Reset resources
        public abstract void Reset();

        // Get one record at a time
        public abstract string[] GetNextRow();

        //Close parser and dispose parser object
        public abstract void Close();
      
        // Generic function to get instance of parser class based on file type.
        public static Parser GetParser(string filePath, FileTypes type)
        {
            Parser parsr = null;
            switch (type)
            {
                case FileTypes.CSV:
                    parsr = new CsvParser(filePath);
                    break;
            }
            return parsr;
        }
    }
}