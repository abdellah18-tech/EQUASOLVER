using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiraffeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Let's make our application exit !!
            Application.Exit();
        }

        private void CheckSolutionButton_Click(object sender, EventArgs e)
        {
            // First the user should check a one of radio buttons
            if (rDomainButton.Checked == false && cDomainButton.Checked == false)
            {
                MessageBox.Show("You should to choice the domain","Domain Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (textBoxA.Text == "" ||textBoxB.Text == ""||textBoxC.Text == "")
            {
                MessageBox.Show("Please give me the values", "Error Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rDomainButton.Checked == true)
            {
                // Declaration of values
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                double x0,x1,x2;
                if (a!=0)
                {
                    double delta = (Math.Pow(b, 2)) - (4 * a * c);
                    if (delta>0)
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        SolutionOneLabel.Text = x1.ToString();
                        SolutionTwoLabel.Text = x2.ToString();
                    }
                    else if (delta == 0)
                    {
                        x0 = -b / (2 * a);
                        SolutionOneLabel.Text = x0.ToString();
                        SolutionTwoLabel.Text = "There's no other solution :) ";
                    }
                    else
                    {
                        SolutionOneLabel.Text = "NO SOLUTION";
                        SolutionTwoLabel.Text = "NO SOLUTION";
                        // Let's reset the text boxes :)
                        textBoxA.ResetText();
                        textBoxB.ResetText();
                        textBoxC.ResetText();
                    }
                }
            }
            else if (cDomainButton.Checked == true)
            {
                // I copied the same code but I edited on it
                // Declaration of values
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                double x0,x1,x2,x11,x12;
                if (a != 0)
                {
                    double delta = (Math.Pow(b, 2)) - (4 * a * c);
                    if (delta > 0)
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        SolutionOneLabel.Text = x1.ToString();
                        SolutionTwoLabel.Text = x2.ToString();
                    }
                    else if (delta == 0)
                    {
                        x0 = -b / (2 * a);
                        SolutionOneLabel.Text = x0.ToString();
                        SolutionTwoLabel.Text = "There's no other solution :) ";
                    }
                    else
                    {
                        //SolutionOneLabel.Text = "NO SOLUTION";
                        //SolutionTwoLabel.Text = "NO SOLUTION";
                        //// Let's reset the text boxes :)
                        //textBoxA.ResetText();
                        //textBoxB.ResetText();
                        //textBoxC.ResetText();
                        x11 = (-b / (2 * a));
                        x12 = (Math.Sqrt(-delta) / (2 * a));
                        SolutionOneLabel.Text = x11.ToString() + " + " + x12.ToString() + "i";
                        SolutionTwoLabel.Text = x11.ToString() + " - " + x12.ToString() + "i";
                        textBoxA.ResetText();
                        textBoxB.ResetText();
                        textBoxC.ResetText();

                    }

                }
            }
        }
    }
}