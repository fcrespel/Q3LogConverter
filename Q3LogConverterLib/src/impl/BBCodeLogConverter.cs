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
                if (m.Groups[1].Value != "")
                {
                    int color;
                    if (int.TryParse(m.Groups[1].Value, out color) && color < colorTable.Length)
                        return "[color=" + colorTable[color] + "]" + m.Groups[2].Value + "[/color]";
                    else
                        return m.Groups[2].Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return m.Value;
            }
        }
    }
}
