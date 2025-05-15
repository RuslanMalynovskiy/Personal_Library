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
            BookChoose.Items.AddRange(new string[]
            {
                "Тип книги",
                "Фікшн",
                "Хобі",
                "Господарство",
                "Спеціальна",
                "Інше"
            });
            BookChoose.SelectedIndex = 0; // обрати перший елемент

            StatusSort.Items.AddRange(new string[]
            { 
                "Наявна",
                "Відсутня",
                "Очікую на прибуття",
                "Запозичена"
            });
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AuthorSort_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StatusCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
