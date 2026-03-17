using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace StudentManagerApplication.Controls
{
    public class AgeControl : TextBox
    {
        public int MinAge { get; set; } 
        public int MaxAge { get; set; } 
    }
}
