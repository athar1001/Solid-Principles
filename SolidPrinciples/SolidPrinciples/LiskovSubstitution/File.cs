﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Voilation
{
    class File : ILoadFile, IWriteFile
    {
        public string LoadContent()
        {
            return string.Empty;
        }

        public void SaveContent()
        {

        }
    }
}
