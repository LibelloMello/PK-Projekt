using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApplication.FileServiceProvider;

namespace ClientApplication
{
    class Controller
    {
        private FileService fs = new FileService();
        public string ReadFile(string name)
        {
            return fs.ReadFile(name);
        }
    }
}
