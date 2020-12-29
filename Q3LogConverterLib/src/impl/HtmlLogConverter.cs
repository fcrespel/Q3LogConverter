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
                if (m.Groups[1].Value != "")
                    return "<span class=\"colorcode-" + m.Groups[1].Value + "\"'>" + m.Groups[2].Value + "</span>";
                else
                    return "";
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
                       ".colorcode-0 { color: black; }\n" +
                       ".colorcode-1 { color: red; }\n" +
                       ".colorcode-2 { color: lime; }\n" +
                       ".colorcode-3 { color: yellow; }\n" +
                       ".colorcode-4 { color: blue; }\n" +
                       ".colorcode-5 { color: cyan; }\n" +
                       ".colorcode-6 { color: magenta; }\n" +
                       ".colorcode-7 { color: white; }\n" +
                       ".colorcode-8 { color: #FF7F00; }\n" +
                       ".colorcode-9 { color: #7F00CC; }\n" +
                       ".colorcode-A { color: #964B00; }\n" +
                       ".colorcode-B { color: #FFCBA4; }\n" +
                       ".colorcode-C { color: #00CCCC; }\n" +
                       ".colorcode-D { color: #000080; }\n" +
                       ".colorcode-E { color: #4F2683; }\n" +
                       ".colorcode-F { color: #FFC0CB; }\n" +
                       ".colorcode-G { color: #007BA7; }\n" +
                       ".colorcode-H { color: #004953; }\n" +
                       ".colorcode-I { color: #F88379; }\n" +
                       ".colorcode-J { color: #008080; }\n" +
                       ".colorcode-K { color: #800000; }\n" +
                       ".colorcode-L { color: #A45A52; }\n" +
                       ".colorcode-M { color: #40826D; }\n" +
                       ".colorcode-N { color: #7F00FF; }\n" +
                       ".colorcode-O { color: #BEBEBE; }\n" +
                       ".colorcode-P { color: #36454F; }\n" +
                       ".colorcode-Q { color: #6699CC; }\n" +
                       ".colorcode-R { color: #E34234; }\n" +
                       ".colorcode-S { color: #C46210; }\n" +
                       ".colorcode-T { color: #D99058; }\n" +
                       ".colorcode-U { color: #E86100; }\n" +
                       ".colorcode-V { color: #CCCCFF; }\n" +
                       ".colorcode-W { color: #B0E0E6; }\n" +
                       ".colorcode-X { color: #ADD8E6; }\n" +
                       ".colorcode-Y { color: #89CFF0; }\n" +
                       ".colorcode-Z { color: #0000FF; }\n" +
                       ".colorcode-a { color: #3F00FF; }\n" +
                       ".colorcode-b { color: #00008B; }\n" +
                       ".colorcode-c { color: #1D2951; }\n" +
                       ".colorcode-d { color: #FFFFCC; }\n" +
                       ".colorcode-e { color: #EFCC00; }\n" +
                       ".colorcode-f { color: #FFD300; }\n" +
                       ".colorcode-g { color: #FFEF00; }\n" +
                       ".colorcode-h { color: #FFFF78; }\n" +
                       ".colorcode-i { color: #FADA5E; }\n" +
                       ".colorcode-j { color: #FFD700; }\n" +
                       ".colorcode-k { color: #C3B091; }\n" +
                       ".colorcode-l { color: #808000; }\n" +
                       ".colorcode-m { color: #E0115F; }\n" +
                       ".colorcode-n { color: #FF1493; }\n" +
                       ".colorcode-o { color: #FF6FFF; }\n" +
                       ".colorcode-p { color: #66023C; }\n" +
                       ".colorcode-q { color: #7851A9; }\n" +
                       ".colorcode-r { color: #702963; }\n" +
                       ".colorcode-s { color: #78184A; }\n" +
                       ".colorcode-t { color: #8F9779; }\n" +
                       ".colorcode-u { color: #87A96B; }\n" +
                       ".colorcode-v { color: #568203; }\n" +
                       ".colorcode-w { color: #ADFF2F; }\n" +
                       ".colorcode-x { color: #444C38; }\n" +
                       ".colorcode-y { color: #00563F; }\n" +
                       ".colorcode-z { color: #8A9A5B; }\n" +
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
