using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebService
{
    /// <summary>
    /// Summary description for FileService
    /// </summary>
    [WebService(Namespace = "http://grupp11.ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FileService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReadFile(string name)
        {
            string path = @"C:\\Users\Hallkvist\Desktop\MyFolder\";
            if (!File.Exists(path + name) || !name.Contains(".txt"))
            {
                return "************************************************************************* n"
                    + "ERROR: Couldn't fetch file. \n"
                    + "Error description: File doesn't exist in MyFolder or isn't a text file. \n"
                    + "-------------------------------------------------------------------------"
                    + "Troubleshooting: Make sure the file exists, check your spelling and enter \n"
                    + "file name followed by the correct extension: .txt. \n"
                    + "Example: test.txt"
                    + "*************************************************************************";
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
