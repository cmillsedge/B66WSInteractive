using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR6WSInteractive
{
    public static class BRExceptionCleaner
    {
        public static string GetErrorMessageFromBioRailsError(string fullText)
        {
            int startIndex = fullText.IndexOf("\"message\":\"");



            if (startIndex < 0)
            {
                return fullText;
            }



            startIndex += 11;



            int endIndex = fullText.IndexOf("\"", startIndex);



            if (endIndex < 0)
            {
                return fullText;
            }



            return fullText.Substring(startIndex, endIndex - startIndex);
        }
    }
}
