using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalsAndSpectrums
{
    public static class TextBoxInputController
    {

        public static KeyPressEventArgs TextBoxDoublePositiveOnKeyPress(KeyPressEventArgs e, string text)//Метод проверки, определяющий, вводить ли символ с клавиатуры
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)8)
                e.Handled = true;
            else if (e.KeyChar == '.' | e.KeyChar == ',')
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0];
                if (text.Split(e.KeyChar).Length == 2)
                {
                    e.Handled = true;
                }
            }
            return e;
        }

        public static KeyPressEventArgs TextBoxDoubleOnKeyPress(KeyPressEventArgs e, ref string text)//Метод проверки, определяющий, вводить ли символ с клавиатуры
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != (char)8 && e.KeyChar != '-')
                e.Handled = true;
            else if (e.KeyChar == '.' | e.KeyChar == ',')
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0];
                if (text.Split(e.KeyChar).Length == 2)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == '-')
            {
                if (text[0] == '-')
                {
                    text = new string(text.ToCharArray(1, text.Length - 1)).ToString();
                }
                else
                {
                    text = "-" + text;
                }
                e.Handled = true;
            }
            return e;
        }
        
        public static KeyPressEventArgs TextBoxIntOnKeyPress(KeyPressEventArgs e, string text)//Метод проверки, определяющий, вводить ли символ с клавиатуры
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
            return e;
        }

        public static string CheckInputNumberDouble(string text)
        {
            if (text == "")
                return "0";
            else if (text[0] == System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                text = "0" + text;
            if (text[text.Length - 1] == System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                return text.Remove(text.Length - 1);
            return text;
        }

    }
}
