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
                //a formatted string representing the path to the image
                return $"/images/{Result}.png";  
            }

            //Note no set as this is a calculated property
        }

        public override string ToString()
        {
            return $"{Name} - {Result}"; 
        }
    }
}
