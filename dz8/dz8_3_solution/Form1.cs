using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz8_3_solution
{
    public partial class Form1 : Form
    {
        
        //////////////////////////////////////////////////// добавим наш класс как поле в виде базы вопросов // мы уже описали класс в файле TF_engine
        private TF_engine database;

        public Form1()
        {
            InitializeComponent();
            //labelHI.Text = "    Вас приветсвует редактор вопросов для игры (верю/неверю) \n Для начала работы вам требуется создать новую базу вопросов или открыть" +
            //    " уже готовую, \nпроследуйте к верхнему меню в разделе Fail/";
            labelHI.Visible = false;
            tbVoprosy.Text = "    Вас приветсвует редактор вопросов для игры (верю/неверю) \n Для начала работы вам требуется создать новую базу вопросов или открыть" +
                " уже готовую, \nпроследуйте к верхнему меню в разделе Fail \r\n\n Кнопку save снизу оставил, добавил сейф в фаил, так удобней чем наверх лезть. \r\n " +
                "щас думаю о кнопке делит, не нравиться как работает";
            tbVoprosy.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // очень хотел маусовер сделать. 


        private void menubtnNew_Click(object sender, EventArgs e)
        {
            ////////// для того чтобы сохранить документ нам потребуется вспомогательный стандартный  класс safefiledialog
            SaveFileDialog dialog = new SaveFileDialog() // добавим фильтры
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*" 
            };

            if (dialog.ShowDialog() == DialogResult.OK) // вызываем метод который вернет создали мы фаил или нет
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";
                database = new TF_engine(dialog.FileName);
                database.Add1("Пример : Земля круглая?", true);
                try
                {
                    database.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка создания нового файла.\n{exception.Message}");
                    return;
                }
                numericUpDown1.Maximum = 1;
                numericUpDown1.Minimum = 1;
                numericUpDown1.Value = 1;
                tbVoprosy.Text = database[(int)numericUpDown1.Value - 1].Text;
                checkbox_true.Checked = database[(int)numericUpDown1.Value - 1].TrueFalse;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //if (numericUpDown1.Value == null) return;
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count == 0)
                return;
            tbVoprosy.Text = database[(int)numericUpDown1.Value - 1].Text;
            checkbox_true.Checked = database[(int)numericUpDown1.Value - 1].TrueFalse;
            database.Save();
        }

        private void menubtnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new TF_engine(dialog.FileName);
                try
                {
                    database.Load();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка открытия файла.\n{exception.Message}");
                    return;
                }
                numericUpDown1.Maximum = database.Count;
                numericUpDown1.Minimum = 1;
                numericUpDown1.Value = 1;
                tbVoprosy.Text = database[(int)numericUpDown1.Value - 1].Text;
                checkbox_true.Checked = database[(int)numericUpDown1.Value - 1].TrueFalse;
            }


        }

        private void menubtnSave_Click(object sender, EventArgs e)
        {
            
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count == 0)
                return;
            try
            {
                database.Save();
                database[(int)numericUpDown1.Value - 1].Text = tbVoprosy.Text;
                database[(int)numericUpDown1.Value - 1].TrueFalse = checkbox_true.Checked;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count == 0)
                return;
            try
            {
                database.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                return;
            }
            database[(int)numericUpDown1.Value - 1].Text = tbVoprosy.Text;
            database[(int)numericUpDown1.Value - 1].TrueFalse = checkbox_true.Checked;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            //добавим проверку
            database.Add1("#" + (database.Count + 1).ToString(), true);
            numericUpDown1.Maximum = database.Count;
            numericUpDown1.Value = database.Count;  
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count <= 1)
            {
                MessageBox.Show("Нельзя удалить последний элемент в списке.", "Ошибка");
                return;
            }
            database.Remove1((int)numericUpDown1.Value - 1);
            numericUpDown1.Maximum--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count == 0)
                return;
            try
            {
                database.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                return;
            }
            database[(int)numericUpDown1.Value - 1].Text = tbVoprosy.Text;
            database[(int)numericUpDown1.Value - 1].TrueFalse = checkbox_true.Checked;
            ////////////////////////////////////////////////////////////////////
          
    }

        private void menubtnSaveAs_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (database.Count == 0)
                return;
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";
                try
                {
                    database.FileName = dialog.FileName; // FileName это вспомогательный класс
                    database.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                    return;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              aboutthis form = new aboutthis();
            form.ShowDialog();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            tbVoprosy.Enabled = true;
        }
    }
}
