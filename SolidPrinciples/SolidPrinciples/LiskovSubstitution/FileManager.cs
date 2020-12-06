using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Voilation
{
    class FileManager
    {
        public List<ILoadFile> allFiles { get; set; }
        public List<IWriteFile> allwriteFiles { get; set; }

        public string GetContentfromfile()
        {
            StringBuilder objstringbuilder = new StringBuilder();
            foreach(var objfile in allFiles)
            {
                objstringbuilder.Append(objfile.LoadContent());
            }
            return objstringbuilder.ToString();
        }

        public void SaveContentToFiles()
        {
            foreach(var objfile in allwriteFiles)
            {
                 objfile.SaveContent();
            }
        }
    }
}
