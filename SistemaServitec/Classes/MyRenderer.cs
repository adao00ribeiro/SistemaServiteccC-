﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaServitec.Classes
{
    internal class MyRenderer: ToolStripProfessionalRenderer
    {
        public MyRenderer ( ) : base ( new MyColors ( ) ) { }
    }
}
