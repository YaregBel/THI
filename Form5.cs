using Lab_3_for_THP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_for_THP
{
    public partial class Form5 : Form
    {
        Form1 form1;
        public Form5(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Passenger();
            p.SetName(textBox1.Text.ToString());
            p.SetPricee(int.Parse(textBox2.Text));
            p.SetCapacity(textBox3.Text.ToString());
            p.SetDurability(textBox4.Text.ToString());
            PriceCounter.listOfObjects.ListOfCars.Insert(form1.listBox1.SelectedIndex, p);
            PriceCounter.listOfObjects.ListOfCars.RemoveAt(form1.listBox1.SelectedIndex + 1);
            form1.listBox1.Items.Insert(form1.listBox1.SelectedIndex, p.GetName());
            form1.listBox1.Items.RemoveAt(form1.listBox1.SelectedIndex);
            form1.label2.Text = PriceCounter.listOfObjects.PriceCount().ToString();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
