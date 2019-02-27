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
    public partial class Form1 : Form
    {
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

            

            if (d1Value == 1 && d2Value == 1)
            {
                this.result.Enabled = false;

                

            }
            
            

            if (d1Value == 1 && d2Value == 1)
            {
                MessageBox.Show("It took " + " to get snake eyes");
            }
        }
    }
}
