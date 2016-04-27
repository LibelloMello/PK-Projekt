using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace FindFileService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://grupp11.ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FileService : System.Web.Services.WebService
    {

        [WebMethod]
        public String ReadFile(string name)
        {
            string path = @"C:\\Users\Hallkvist\Desktop\MyFolder\";
            if (!File.Exists(path + name) || !name.Contains(".txt"))
            {
                return "Couldn't fetch file. /n Error: File doesn't exist, or isnt a text file. /n Troubleshooting: Make sure the text file exists in 'MyFolder' and the file extension is '.txt'. /n Example: 'Test.txt' ";
            }
            else
            {
                try
                {
                    using (var text = File.OpenText(path + name))
                    {
                        string line = text.ReadToEnd();
                        return line;
                    }
                }
                catch (SoapException soapEx)
                {
                    throw soapEx;
                }
                catch (SqlException sqlEx)
                {
                    throw sqlEx;
                }
                catch (IOException ioex)
                {
                    throw ioex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
