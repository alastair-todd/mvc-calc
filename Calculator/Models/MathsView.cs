using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Presentation.Models
{
    public class MathsView
    {
        public string Expression { get; set; }

        public string ErrorMessage { get; set; }

        public string Result { get; set; }
    }
}