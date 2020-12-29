using System;
using System.Collections.Generic;
using System.Text;

namespace Q3LogConverter.lib.impl
{
    class TextLogConverter : AbstractLogConverter
    {
        public override string Convert(string inputString, ColorProcessing colorProcessing)
        {
            string outputString;
            switch (colorProcessing)
            {
                case ColorProcessing.COLOR_REMOVE:
                case ColorProcessing.COLOR_CONVERT:
                    outputString = colorCodeRegex.Replace(inputString, "");
                    break;

                case ColorProcessing.COLOR_KEEP:
                default:
                    outputString = inputString;
                    break;
            }
            return outputString;
        }
    }
}
