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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private bool isnumber(string string1)
        {
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] <= '0' || string1[i] >= '9')
                {
                    return false;
                }
            }
            return true;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                groupBox1.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else if (textBox1.Text == "2")
            {
                label3.Text = "Введите заряд батареи";
                label4.Text = "Управление производится: 0 - кнопками, 1 - сенсором ";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else if (textBox1.Text == "3")
            {
                label3.Text = "Введите время запуска";
                label4.Text = "Введите тип экрана: LCD, OLED: ";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else
            {
                textBox1.Text = "Введите 1,2 или 3";
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                if (textBox2.Text == "" || !isnumber(textBox3.Text) || textBox3.Text == "")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "Введите значение";
                    }
                    if (!isnumber(textBox3.Text) || textBox3.Text == "")
                    {
                        textBox3.Text = "Введите число";
                    }

                }
                else
                {
                    Tech a1 = new Tech(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                    Data.form3.Add_Net(a1);
                    this.Close();
                }
            }
            else if (textBox1.Text == "2" || textBox1.Text == "3")
            {
                if (textBox2.Text == "" || !isnumber(textBox3.Text) || textBox3.Text == "" || !isnumber(textBox4.Text) || textBox4.Text == "" || textBox5.Text == "")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "Введите значение";
                    }
                    if (!isnumber(textBox3.Text) || textBox3.Text == "")
                    {
                        textBox3.Text = "Введите число";
                    }
                    if (!isnumber(textBox4.Text) || textBox4.Text == "")
                    {
                        textBox4.Text = "Введите число";
                    }
                    if (textBox5.Text == "")
                    {
                        textBox5.Text = "Введите значение";
                    }
                }
                else
                {
                    if (textBox1.Text == "2")
                    {
                        EBook a1 = new EBook(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text),  Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                        Data.form3.Add_Wifi(a1);
                        this.Close();
                    }
                    else
                    {
                        PH a1 = new PH(Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                        Data.form3.Add_Switch(a1);
                        this.Close();
                    }
                }
            }
        }
    }
}
