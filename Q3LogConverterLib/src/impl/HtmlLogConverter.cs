using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Q3LogConverter.lib.impl
{
    class HtmlLogConverter : AbstractLogConverter
    {
        protected static string[] colorTable = { "black", "red", "lime", "yellow", "blue", "cyan", "magenta", "white", "black", "black" };

        public override string Convert(string inputString, ColorProcessing colorProcessing)
        {
            inputString = inputString.Replace("&", "&amp;").Replace(">", "&gt;").Replace(">", "&lt;");
            string outputString;
            switch (colorProcessing)
            {
                case ColorProcessing.COLOR_REMOVE:
                    outputString = colorCodeRegex.Replace(inputString, "");
                    break;

                case ColorProcessing.COLOR_CONVERT:
                    outputString = colorCodeAndTextRegex.Replace(inputString, new MatchEvaluator(HtmlColorCodesMatchEvaluator));
                    break;

                case ColorProcessing.COLOR_KEEP:
                default:
                    outputString = inputString;
                    break;
            }
            return outputString + "<br />";
        }

        protected static string HtmlColorCodesMatchEvaluator(Match m)
        {
            if (m.Groups.Count == 3)
            {
                int color = int.Parse(m.Groups[1].Value);
                string text = m.Groups[2].Value;
                return "<span style='color: " + colorTable[color] + "'>" + text + "</span>";
            }
            else
            {
                return m.Value;
            }
        }

        public override string Header
        {
            get {
                return "<html>\n\n" +
                       "<head>\n" +
                       "<style type=\"text/css\">\n" +
                       "body {\n" +
                       "    background-color: #555555;\n" +
                       "    color: white;\n" +
                       "    font-family: Tahoma, Arial, Helvetica, sans-serif;\n" +
                       "    font-size: 10pt;\n" +
                       "}\n" +
                       "hr {\n" +
                       "    margin-top: 20px;\n" +
                       "    border: 1px solid #cccccc;\n" +
                       "}\n" +
                       ".footer {\n" +
                       "    color: #cccccc;\n" +
                       "    font-style: italic;\n" +
                       "}\n" +
                       "</style>\n" +
                       "</head>\n\n" +
                       "<body>\n";
            }
        }

        public override string Footer
        {
            get {
                return "\n" +
                       "<hr />\n" +
                       "<p class=\"footer\">This log file was converted with Soh Raun's <strong>Q3 Log Converter</strong></p>\n" +
                       "</body>\n" +
                       "</html>\n";
            }
        }
    }
}
