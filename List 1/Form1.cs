using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_1
{
    public partial class Form1 : Form
    {
        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ",");
            }
        }
        public Form1()
        {
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
            nums.Add(9);
            nums.Add(10);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");
            nums.Remove(1);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");
            nums.Add(1);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
