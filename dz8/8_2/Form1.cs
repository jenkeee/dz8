using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _8_2
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 2.
        /// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "8.2 C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.";
            catchERROR.Visible = false;
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            decimal y = numericUpDownNumber.Value;
            textBoxNumber.Text = Convert.ToString(y);
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int tbInput))
            {
                if (tbInput >= 513) { catchERROR.Text = $"Введите целое число от 0 до 512"; catchERROR.Visible = true; }
                else if (tbInput < 0)
                {
                    catchERROR.Text = $"Введите целое число от 0 до 512"; catchERROR.Visible = true;
                }
                else if (tbInput >= 0 && tbInput <= 513) { numericUpDownNumber.Text = textBoxNumber.Text; catchERROR.Visible = false; catchERROR.Text = $"Работает"; }
                else if (tbInput == 0) { catchERROR.Text = $"Вводите пожалуйста числа а не прочее"; }

                            }
            else catchERROR.Text = $"Вводите пожалуйста числа а не прочее"; catchERROR.Visible = true; SystemSounds.Beep.Play(); SystemSounds.Hand.Play(); // так и не запел

            //////////////////////////////////немогу привыкнуть трай итд
            /*
            try
        {
            int x = Convert.ToInt32(textBoxNumber.Text);

        }

        catch (ArgumentOutOfRangeException ex)
        {
            numericUpDownNumber.Text = $"Вводите пожалуйста числа а не прочее"; catchERROR.Visible = true;
            //MessageBox.Show($"Некорректный ввод: {ex.Message}");
        }
        catch (FormatException ex)
        {
            numericUpDownNumber.Text = $"Вводите пожалуйста числа а не прочее"; catchERROR.Visible = true;
            //MessageBox.Show($"Некорректный ввод: {ex.Message}");
        }*/


            //if (x >= 100) catchERROR.Text = $"Введите целое число от 0 до 100"; catchERROR.Visible = true;
            //if (x <= 0) catchERROR.Text = $"Введите целое число от 0 до 100"; catchERROR.Visible = true;
            //if (x >= 0 && x <= 100) numericUpDownNumber.Text = textBoxNumber.Text;

            //else numericUpDownNumber.Text = $"Вводите пожалуйста числа а не прочее";
        }

        private void updateUI()
        {
            textBoxNumber.Text = textBoxNumber.Text;
            numericUpDownNumber.Text = numericUpDownNumber.Text;
        }

    }
}