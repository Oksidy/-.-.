using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Предмет находится на расстоянии d0 от собирающей линзы с фокусным расстоянием F. Найти расстояние от линзы до изображения di.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double d0) && double.TryParse(textBox2.Text, out double f))
            {
                if (d0 == f)
                {
                    MessageBox.Show("Изображение формируется в бесконечности.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double invF = 1.0 / f;
                double invD0 = 1.0 / d0;
                double invDi = invF - invD0;
                double di = 1.0 / invDi;

                textBox3.Text = invF.ToString("F3");
                textBox4.Text = invD0.ToString("F3");
                textBox5.Text = invDi.ToString("F3");
                textBox6.Text = di.ToString("F2");
                textBox7.Text = di.ToString("F2");
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
    }
}