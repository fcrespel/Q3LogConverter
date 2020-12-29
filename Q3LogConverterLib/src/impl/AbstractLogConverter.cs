using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Q3LogConverter.lib.impl
{
    abstract class AbstractLogConverter : LogConverter
    {
        protected static Regex colorCodeRegex = new Regex("\\^\\d");
        protected static Regex colorCodeAndTextRegex = new Regex("\\^(\\d)(.*?)(?=\\^|$)");
        
        public abstract string Convert(string inputString, ColorProcessing colorProcessing);

        public virtual string Header {
            get { return ""; }
        }

        public virtual string Footer
        {
            get { return ""; }
        }
    }
}
