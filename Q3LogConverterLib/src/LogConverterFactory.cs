using System;
using System.Collections.Generic;
using System.Text;
using Q3LogConverter.lib.impl;

namespace Q3LogConverter.lib
{
    public class LogConverterFactory
    {
        public static LogConverter create(string className)
        {
            throw new NotImplementedException(); // TODO
        }

        public static LogConverter create(LogConverterType type)
        {
            switch (type)
            {
                case LogConverterType.TYPE_TEXT:
                    return new TextLogConverter();
                    
                case LogConverterType.TYPE_HTML:
                    return new HtmlLogConverter();

                case LogConverterType.TYPE_BBCODE:
                    return new BBCodeLogConverter();

                default:
                    throw new ArgumentException("type");
            }
        }
    }
}
