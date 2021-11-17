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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Form1 f1;
        private void MenuForm2_Click(object sender, EventArgs e)
        {
            if(f1 == null)
            {
                f1 = new Form1();
                f1.FormClosed += F1_FormClosed;
                f1.Show();
            }
            else
            {
                f1.Activate();
            }
            
        }

        private void F1_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
