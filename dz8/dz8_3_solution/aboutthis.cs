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
    public partial class aboutthis : Form
    {
        public aboutthis()
        {
            InitializeComponent();
            textBox1.Text = "Autor : dart vaider \r\n \n " +
                "version : 1_with_force \r\n \n " +
                "Лицензия : opensource";
            textBox1.Enabled = false;
        }
    }
}
