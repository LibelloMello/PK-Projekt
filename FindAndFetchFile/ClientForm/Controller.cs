using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientForm.FileServiceProvider;

namespace ClientForm
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
