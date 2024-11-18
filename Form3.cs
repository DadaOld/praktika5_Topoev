using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form3 : Form
    {
        public int k = 0;
        public Form3()
        {
            
            InitializeComponent();
        }
        public void Add_Net(Tech arg)
        {
            label1.Visible = false;
            var a = new Label();
            a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular);
            a.Text = "Информация о базовом устройстве\n" + arg.ToString();
            a.Height = 75;
            a.Width = 500;
            a.Top = 10 + k;
            k += 75;
            a.Left = 10;
            Controls.Add(a);
        }
        public void Add_Wifi(EBook arg)
        {
            label1.Visible = false;
            var a = new Label();
            a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular);
            a.Text = "Информация об электрононой книге\n" + arg.ToString();
            a.Top = 10 + k;
            a.Height = 125;
            a.Width = 500;
            k += 125;
            a.Left = 10;
            Controls.Add(a);
        }
        public void Add_Switch(PH arg)
        {
            label1.Visible = false;
            var a = new Label();
            a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular);
            a.Text = "Информация о смартфоне\n"+arg.ToString();
            a.Top = 10 + k;
            a.Height = 125;
            a.Width = 500;
            k += 125;
            a.Left = 10;
            Controls.Add(a);
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
