using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgs
{
    public class ControlWriter : TextWriter
    {
        private Control textBox;
        public ControlWriter(Control _textBox)
        {
            textBox = _textBox;
        }

        public override void Write(char value)
        {
            textBox.Text += value;
        }

        public override void Write(string value)
        {
            textBox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
