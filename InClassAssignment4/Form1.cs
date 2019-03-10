using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment4
{
    //Sylvanus edi
    //this is my work
    //9/3/2019
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dice d1 = new dice(10);
            dice d2 = new dice(10);

            //roll both die 
            int d1Value = d1.rollDie();
            int d2Value = d2.rollDie();

            this.box1.Text = " " + d1Value.ToString();
            this.box2.Text = " " + d2Value.ToString();

            //stop button from clicking when it gets snake eyes

            if (d1Value == 1 && d2Value == 1)
            {
                this.result.Enabled = false;
            }
            //count the clicks to get snake eyes
            counter++;
            //label1.Text = counter.ToString();
            //label1.Visible = false;

            //display count.
            //MessageBox.Show(d1Value.ToString(), d2Value.ToString());
            if (d1Value == 1 && d2Value == 1)
                    {
                //label1.Visible = true;
                //label1.Text = ("it took " + counter + " to get eye");

               //display counter
                MessageBox.Show("It took " + counter + " to get snake eyes!");
            }

                

            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
    }
}
