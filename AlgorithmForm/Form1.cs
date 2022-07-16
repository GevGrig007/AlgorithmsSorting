using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> Numbers = new List<int>();
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(listBox1.Text , out int value))
            {
                Numbers.Add(value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(var item in Numbers)
            {
                item
            }
        }
        private void DrawItems(List<int> items)
        {
            listBox1.Controls.Clear();
            panel1.Refresh();

            foreach (var item in items)
            {
                
            }

            panel1.Refresh();
        }
    }
}
