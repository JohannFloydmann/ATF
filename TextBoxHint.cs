using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;

namespace project
{
    internal class TextBoxHint
    {
        static string _default;
        public static void HideHint(KryptonTextBox textBox, string defaul)
        {
            _default = defaul;
            if (textBox.Text == _default)
                textBox.Text = "";
            if(textBox.Name == "passwordField")
                textBox.UseSystemPasswordChar = true;
        }
        public static void ShowHint(KryptonTextBox textBox)
        {
            if(textBox.Text == "")
            {
                textBox.Text = _default;
                textBox.UseSystemPasswordChar = false;
            }
        }
    }
}
