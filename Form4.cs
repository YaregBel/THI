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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Lorry();
            p.SetName(textBox1.Text.ToString());
            p.SetPricee(int.Parse(textBox2.Text));
            p.SetCapacity(textBox1.Text.ToString());
            p.SetSize(textBox1.Text.ToString());
            PriceCounter.listOfObjects.ListOfCars.Add(p);
            form1.listBox1.Items.Add(p.GetName());
            form1.label2.Text = PriceCounter.listOfObjects.PriceCount().ToString();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
