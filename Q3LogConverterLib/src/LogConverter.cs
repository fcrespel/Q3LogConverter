using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Q3LogConverter.lib
{
    public interface LogConverter
    {
        string Convert(string inputString, ColorProcessing colorProcessing);

        string Header { get; }
        string Footer { get; }
    }
}
