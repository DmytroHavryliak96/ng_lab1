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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            switch (comboBox1.Text)
            {
                case "Метод Лапласа":
                    {
                        f2.Text = "Метод Лапласа";
                        f2.getLabel9().Text = "Kl";
                        f2.getLabel10().Text = "MAX";
                        f2.getLabel11().Hide();
                        f2.getTextBox17().Hide();
                        break;
                    }
                case "Метод Вальда":
                    {
                        f2.Text = "Метод Вальда";
                        f2.getLabel9().Text = "Kv";
                        f2.getLabel10().Text = "MAX";
                        f2.getLabel11().Hide();
                        f2.getTextBox17().Hide();
                        break;
                    }
                case "Метод Севіджа":
                    {
                        f2.Text = "Метод Севіджа";
                        f2.getLabel9().Text = "Ks";
                        f2.getLabel10().Text = "MIN";
                        f2.getLabel11().Hide();
                        f2.getTextBox17().Hide();
                        break;
                    }
                case "Метод компромісу Гурвіца":
                    {
                        f2.Text = "Метод компромісу Гурвіца";
                        f2.getLabel9().Text = "K mk";
                        f2.getLabel10().Text = "min ij";
                        f2.getLabel11().Text = "max ij";
                        /*Label label11 = f2.AddNewLabel();
                        label11.Text = "max ij";
                        TextBox textBox17 = f2.AddNewTextBox();
                        textBox17.ReadOnly = true;*/
                        break;
                    }
                case "Метод половинного компромісу ризиків":
                    {
                        f2.Text = "Метод половинного компромісу ризиків";
                        f2.getLabel9().Text = "Kmr";
                        f2.getLabel10().Text = "MIN";
                        f2.getLabel11().Hide();
                        f2.getTextBox17().Hide();
                        break;
                    }
            }
            this.Hide();
            
            f2.ShowDialog();
            this.Close();
        }
    }
}
