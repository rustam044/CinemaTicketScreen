using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> selected = new List<Button>();   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butunButtons_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn.BackColor==Color.SeaGreen){
                clickedBtn.BackColor = Color.Gray;
                selected.Add(clickedBtn);
            }
            else
            {
                clickedBtn.BackColor = Color.SeaGreen;
                selected.Remove(clickedBtn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                foreach (Button btn in selected)
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Adinizi Daxil edin");
            }
          
        }
    }
}
