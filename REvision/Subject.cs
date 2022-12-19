using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace REvision
{
    internal class Subject
    {
        public string Name { get; set; }
        public char Result { get; set; }

        public string GradeImage
        {
            get
            {
                return $"/images/{Result}.png";
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Result}"; 
        }
    }
}
