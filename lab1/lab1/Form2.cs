using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Label getLabel9()
        {
            return this.label9;
        }

        public Label getLabel10()
        {
            return this.label10;
        }

        public Label getLabel11()
        {
            return this.label11;
        }

        public TextBox getTextBox17()
        {
            return this.textBox17;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algorithm solution = new Algorithm();
            solution.alternative1[0] = Convert.ToDouble(textBox1.Text);
            solution.alternative1[1] = Convert.ToDouble(textBox4.Text);
            solution.alternative1[2] = Convert.ToDouble(textBox7.Text);
            solution.alternative1[3] = Convert.ToDouble(textBox10.Text);

            solution.alternative2[0] = Convert.ToDouble(textBox2.Text);
            solution.alternative2[1] = Convert.ToDouble(textBox5.Text);
            solution.alternative2[2] = Convert.ToDouble(textBox8.Text);
            solution.alternative2[3] = Convert.ToDouble(textBox11.Text);

            solution.alternative3[0] = Convert.ToDouble(textBox3.Text);
            solution.alternative3[1] = Convert.ToDouble(textBox6.Text);
            solution.alternative3[2] = Convert.ToDouble(textBox9.Text);
            solution.alternative3[3] = Convert.ToDouble(textBox12.Text);

            switch (this.Text)
            {
                case "Метод Лапласа":
                    {
                        solution.Laplace();
                        textBox16.Text = Convert.ToString(solution.max);
                        break;
                    }
                case "Метод Вальда":
                    {
                        solution.Wald();
                        textBox16.Text = Convert.ToString(solution.max);
                        break;
                    }
                case "Метод Севіджа":
                    {
                        solution.Savage();
                        textBox16.Text = Convert.ToString(solution.min);
                        break;
                    }
                case "Метод компромісу Гурвіца":
                    {
                        solution.Hurwits();
                        textBox16.Text = Convert.ToString(solution.min);
                        textBox17.Text = Convert.ToString(solution.max);
                        break;
                    }
                case "Метод половинного компромісу ризиків":
                    {
                        solution.Compromise();
                        textBox16.Text = Convert.ToString(solution.min);
                        break;
                    }
            }

            textBox13.Text = Convert.ToString(solution.choices[0]);
            textBox14.Text = Convert.ToString(solution.choices[1]);
            textBox15.Text = Convert.ToString(solution.choices[2]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
