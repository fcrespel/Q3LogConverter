using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Q3LogConverter.lib.impl
{
    class BBCodeLogConverter : AbstractLogConverter
    {
        protected static string[] colorTable = { "black", "red", "lime", "yellow", "blue", "cyan", "magenta", "white", "black", "black" };

        public override string Convert(string inputString, ColorProcessing colorProcessing)
        {
            string outputString;
            switch (colorProcessing)
            {
                case ColorProcessing.COLOR_REMOVE:
                    outputString = colorCodeRegex.Replace(inputString, "");
                    break;

                case ColorProcessing.COLOR_CONVERT:
                    outputString = colorCodeAndTextRegex.Replace(inputString, new MatchEvaluator(BBCodeColorCodesMatchEvaluator));
                    break;

                case ColorProcessing.COLOR_KEEP:
                default:
                    outputString = inputString;
                    break;
            }
            return outputString;
        }

        public static string BBCodeColorCodesMatchEvaluator(Match m)
        {
            if (m.Groups.Count == 3)
            {
                int color = int.Parse(m.Groups[1].Value);
                string text = m.Groups[2].Value;
                return "[color=" + colorTable[color] + "]" + text + "[/color]";
            }
            else
            {
                return m.Value;
            }
        }
    }
}
