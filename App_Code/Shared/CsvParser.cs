using System;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Collections;


namespace KumePortali.UI
{
    /// <summary>
    /// Summary description for CsvParser: Parses CSV file and returns one row at a time.
    /// </summary>
    public class CsvParser : Parser
    {
        StreamReader sr = null;
        CsvStream csvStrm = null;
        String fileName = null;

        public CsvParser(string fName)
        {
            //
            // TODO: Add constructor logic here
            //
            fileName = fName;
            Reset();
        }

        // resets resourses
        public override void Reset()
        {
            if (fileName != null)
            {
                sr = new StreamReader(fileName);
                csvStrm = new CsvStream(sr);
            }
        }

        // Gets one row at a time.
        public override string[] GetNextRow()
        {
            return csvStrm.GetNextRow();
        }

        public override void Close()
        {
            csvStrm.Close();
        }

        // CsvStream is the helper class which  parses the file.
        private class CsvStream : IDisposable
        {
            private TextReader stream;

            public CsvStream(TextReader s)
            {
                stream = s;
            }

            public string[] GetNextRow()
            {
                ArrayList row = new ArrayList();
                while (true)
                {
                    string item = GetNextItem();
                    if (item == null)
                    {
                        if (row.Count == 0)
                            return null;
                        else
                        {
                            if (row[row.Count - 1].ToString() == "")
                            {
                                row.RemoveAt(row.Count - 1);
                            }
                            if (row.Count != 0)
                            {
                                return (string[])row.ToArray(typeof(string));
                            }
                        }
                    }
                    else
                    {
                        row.Add(item);
                    }
                }
            }
            public void Close()
            {
                if (stream != null)
                {
                    this.Dispose();
                }
            }
            private bool EOS = false;
            private bool EOL = false;

            public string GetNextItem()
            {
                if (EOL)
                {
                    // previous item was last in line, start new line
                    EOL = false;
                    return null;
                }

                bool quoted = false;
                bool predata = true;
                bool postdata = false;
                StringBuilder item = new StringBuilder();

                while (true)
                {
                    char c = GetNextChar(true);
                    if (EOS)
                        return item.Length > 0 ? item.ToString() : null;

                    if ((postdata || !quoted) && c == ',')
                        // end of item, return
                        return item.ToString();

                    if ((predata || postdata || !quoted) && (c == '\x0A' || c == '\x0D'))
                    {
                        // we are at the end of the line, eat newline characters and exit
                        EOL = true;
                        if (c == '\x0D' && GetNextChar(false) == '\x0A')
                            // new line sequence is 0D0A
                            GetNextChar(true);
                        return item.ToString();
                    }

                    if (predata && c == ' ')
                        // whitespace preceeding data, discard
                        continue;

                    if (predata && (c == '"' || c == '\x27'))
                    {
                        // quoted data is starting
                        quoted = true;
                        predata = false;
                        continue;
                    }

                    if (predata)
                    {
                        // data is starting without quotes
                        predata = false;
                        item.Append(c);
                        continue;
                    }

                    if ((c == '"' || c == '\x27') && quoted)
                    {
                        if (GetNextChar(false) == '"')
                            // double quotes within quoted string means add a quote       
                            item.Append(GetNextChar(true));
                        else
                            // end-quote reached
                            postdata = true;
                        continue;
                    }

                    // all cases covered, character must be data
                    item.Append(c);
                }
            }

            private char[] buffer = new char[4096];
            private int pos = 0;
            private int length = 0;

            public char GetNextChar(bool eat)
            {
                if (pos >= length)
                {
                    length = stream.ReadBlock(buffer, 0, buffer.Length);
                    if (length == 0)
                    {
                        EOS = true;
                        return '\0';
                    }
                    pos = 0;
                }
                if (eat)
                    return buffer[pos++];
                else
                    return buffer[pos];
            }
            
            public void Dispose()
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                    stream = null;
                }

            }

           
        }

    }
}
