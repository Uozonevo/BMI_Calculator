using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
  public partial class Form1: Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {}
    private void Form1_Load(object sender, EventArgs e)
    {}
    private void Button1_Click(object sender, EventArgs e)
    {
      double weight, bmi, heightF, heightI, total_inches, val;

      bool weightCheck = double.TryParse(textBox3.Text, out val);
      bool inchCheck = double.TryParse(textBox2.Text, out val);
      bool feetCheck = double.TryParse(textBox1.Text, out val);

      if(weightCheck && inchCheck && feetCheck)
      {}
      heightF = Convert.ToDouble(textBox1.Text);
      heightI = Convert.ToDouble(textBox2.Text);
      weight = Convert.ToDouble(textBox3.Text);

      total_inches = heightF * 12 + heightI;

      if((0 <= heightF) && (heightF <= 12) && (0 <= heightI) && (heightI <= 12) && (weight>0))
      {
        bmi = (weight / Math.Pow(total_inches, 2)) * 703;
        bmi = Math.Round(bmi, 1);
        string bmiout = Convert.ToString(bmi);
        textBox4.Text = bmiout;
      }
      else
      {
        textBox4.Text = "ERROR";
      }
    }
  }
}
