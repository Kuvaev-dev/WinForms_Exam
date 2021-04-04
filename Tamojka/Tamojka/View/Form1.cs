using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamojka
{
    public class FormItem
    {
        public string Text { get; set; }
        public Type Target { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carType.Items.Add("Легковые");
            carType.Items.Add("Електро");
            carType.Items.Add("Гибрид");
            carType.Items.Add("Грузовые");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formItem = carType.SelectedItem as FormItem;
            if (formItem == null) return;
            var form = (Form)Activator.CreateInstance(formItem.Target);
            form.Show();
        }
    }
}
