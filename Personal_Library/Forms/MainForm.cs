using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Library.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[]
            {
                "Фікшн",
                "Фантастика",
                "Хобі",
                "Господарство",
                "Спеціальна",
                "Інше",
                "Усі"
            });
            comboBox1.SelectedIndex = 0; // обрати перший елемент
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
