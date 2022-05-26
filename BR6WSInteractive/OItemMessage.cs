using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BR6WSInteractive
{
    public class OItemMessage
    {
        public string Available { get; set; }
        public int Index { get; set; }

        public Color Colour { get; set; }
        public OItemMessage(string message)
        {
            Available = message.Substring(17);
            Index = Int32.Parse(message.Substring(12, 1));
            Colour = Color.Red;
        }
    }
}
