using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool timer_ticking = false;
        int i = 0;
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            string content = File.ReadAllText("C:/Users/Koko/Desktop/number.txt", Encoding.UTF8);
            //i = Int32.Parse(content); 
            // label1.Text = i.ToString();
            timer_ticking = true;
            //string zsalmale = (i + content).ToString();
          //  label2.Text = content.ToString();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer_ticking)
            {
                i++;
                label1.Text = i.ToString();
            }
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            File.WriteAllText("C:/Users/Koko/Desktop/number.txt", i.ToString());
        }


    }
}
