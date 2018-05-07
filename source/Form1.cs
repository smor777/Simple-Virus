using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus4LogFinal
{
    public partial class Form1 : Form
    {
        //Note: This is where the virus actually is working. Not doing anything more than constantly putting a message box. HARMLESS I PROMISE
        public Form1()
        {
            InitializeComponent();
            while (1 > 0)
            {
                MessageBox.Show("Games take time to develop...they aren't something you can do in a day!");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
               
        }
        public delegate void KeyPressEventHandler(object sender, KeyPressEventArgs e) {
        keypress = KeyEventArgs.k;

        }
    }
}
