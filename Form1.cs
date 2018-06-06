using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHEMING_WILDCAT_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textBox1.Text;

            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: // DEC ASCII
                        {
                            string[] tokens = input.Split(' ');

                            textBox2.Clear();
                            for (int i = 0; i < tokens.Length; i++)
                            {
                                textBox2.Text += (char)(Int32.Parse(tokens[i]));
                            }
                            break;
                        }
                    default:
                        return;
                }
            } catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
