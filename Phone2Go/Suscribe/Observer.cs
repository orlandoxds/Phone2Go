﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Suscribe
{
   abstract class Observer
    {
        public abstract void Update(RichTextBox body);
    }
}
