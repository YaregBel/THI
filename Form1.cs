using Lab_3_for_THP;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab_5_for_THP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(this);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PriceCounter.listOfObjects.ListOfCars.Count(); i++)
            {
                if (listBox1.SelectedItem.ToString() == PriceCounter.listOfObjects.ListOfCars[i].GetName())
                {
                    PriceCounter.listOfObjects.ListOfCars.RemoveAt(i);
                }
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            label2.Text = PriceCounter.listOfObjects.PriceCount().ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}