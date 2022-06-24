using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._04_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // добавляем один элемент
            comboBox1.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox1.Items.Insert(1, "Боливия");

            // добавляем один элемент
            comboBox2.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox2.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox2.Items.Insert(1, "Боливия");

            // добавляем один элемент
            comboBox3.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox3.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox3.Items.Insert(1, "Боливия");

            // добавляем один элемент
            checkedListBox1.Items.Add("Парагвай");
            // добавляем набор элементов
            checkedListBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });
            // добавляем один элемент на определенную позицию
            checkedListBox1.Items.Insert(1, "Боливия");
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
