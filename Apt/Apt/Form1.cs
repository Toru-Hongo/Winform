using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apt
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="x">param1</param>
        /// <param name="y">param2</param>
        /// <returns></returns>
        public int Tcalc(int x,int y)
        {
            return x + y;
        }

        /// <summary>
        /// init.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "OK";
            textBox1.Text = "12";
            textBox2.Text = "34";
            listBox1.Items.Clear();

        }
        /// <summary>
        /// Calc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Well come Git";

            int a, b,c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            c = Tcalc(a, b);

            listBox1.Items.Add("Calc: " + c.ToString());


        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
