using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BR6WSInteractive
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, Font font)
        {   //simple extension of rich textbox to overload and improve the append text method to be a little more feature rich
            try
            { 
                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;
                box.SelectionColor = color;
                box.SelectionFont = font;
                if (box.TextLength == 0)
                { box.AppendText(text); }
                else
                { box.AppendText(Environment.NewLine + text); }
                box.SelectionColor = box.ForeColor;
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
