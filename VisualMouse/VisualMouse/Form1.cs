using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mouse;

namespace VisualMouse
{
    //[DllImport("user32", CharSet = CharSet.Unicode)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            const int MOUSEEVENTF_WHEEL = 0x0800;
            for (int i = 0; i < 5; i++)
            {
                Class1.Mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -100, 1);
            }
        }
    }
}
