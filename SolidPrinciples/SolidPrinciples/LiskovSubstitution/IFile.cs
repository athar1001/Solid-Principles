using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution
{
    interface ILoadFile
    {
        string LoadContent();
    }

    interface IWriteFile
    {
        void SaveContent();
    }
}
