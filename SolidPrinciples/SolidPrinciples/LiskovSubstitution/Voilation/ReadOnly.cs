using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Voilation
{
    class ReadOnly : File
    {
        public string FileSource { get; set; }
        public string FileContent { get; set; }

        public string LoadContent()
        {
            return "File is Read Only";
        }
        public void SaveContent()
        {
            throw new IOException("File cannot be saved");
        }
    }
}
