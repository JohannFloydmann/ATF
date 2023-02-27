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
        public static void HideHint(KryptonTextBox textBox, string @default)
        {
            _default = @default;
            if (textBox.Text == _default)
                textBox.Text = "";
            if(textBox.Name == "passwordField" || textBox.Name == "currentPasswordField")
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
        public static void ShowHint(KryptonTextBox textBox, string @default)
        {
            textBox.Text = @default;
            textBox.UseSystemPasswordChar = false;
        }
    }
}
