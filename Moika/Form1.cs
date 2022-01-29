using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Configuration;
using System.Collections.Specialized;
using System.Drawing.Printing;

namespace Moika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int j;
        int x1;
        int x2;
        int x3;
        int x4;
        int x5;
        private string m1 = "0";
        private string m2 = "0";
        private string m3 = "0";
        private string m4 = "0";
        private string m5 = "0";




        private static List<int> coin1 = new List<int>();
        private static List<int> coin2 = new List<int>();
        private static List<int> coin3 = new List<int>();
        private static List<int> coin4 = new List<int>();
        private static List<int> coin5 = new List<int>();

        private int monets1 = 0;
        private int monets2 = 0;
        private int monets3 = 0;
        private int monets4 = 0;
        private int monets5 = 0;
        private string sum = "0";
        private int parse;
      

        private void timer1_Tick(object sender, EventArgs e)
        {
             var a = ConfigurationManager.AppSettings.Get("stopWatch1");

            ConfigurationManager.AppSettings.Get("stopWatch1");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Thread.Sleep(int.Parse(a));
            stopWatch.Stop();


            if (j == 0)
            {
                j += 1;
            }



            j -= 1;
            x1 += 1;
            if (j == 0)
            {

                x1 -= 1;

            }
            int clicked = monets1 = x1;
            coin1.Add(monets1);
            m1 = Water.Text = clicked.ToString();

            if (clicked == j)
            {
                ++x1;

            }





            label1.Text = j.ToString();
          
        }

        int clickCount = 1;
        private void button4_Click(object sender, EventArgs e)
        {




            var r = Start.Text = (clickCount++).ToString();
            

            j += 10;
            parse = int.Parse(sum);
            parse = int.Parse(r)*10;
           
           
           

     
            label1.Text = j.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
        }

        private void Foam_Click(object sender, EventArgs e)
        {


            


            timer2.Enabled = true;
        }

    
             
        private void Wax_Click(object sender, EventArgs e)
        {
           
      



            timer3.Enabled = true;

          
            
            


        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            var b = ConfigurationManager.AppSettings.Get("stopWatch2");

            ConfigurationManager.AppSettings.Get("stopWatch2");

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            Thread.Sleep(int.Parse(b));
            stopWatch2.Stop();



            if (j == 0)
            {
                j += 1;
            }

            j -= 1;
            x2 += 1;
            if (j == 0)
            {

                x2 -= 1;

            }
            int clicked = monets3 = x2;
            coin2.Add(monets2);
            m2 = Foam.Text = clicked.ToString();
            if (clicked == j)
            {
                ++x2;

            }



            label1.Text = j.ToString();
        }


        
        private void timer3_Tick(object sender, EventArgs e)
        {


            var c = ConfigurationManager.AppSettings.Get("stopWatch3");

            ConfigurationManager.AppSettings.Get("stopWatch3");

            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Thread.Sleep(int.Parse(c));
            stopWatch3.Stop();


            if (j == 0)
            {
                j += 1;
            }

            j -= 1;
            x3 += 1;
            if (j == 0)
            {

                x3 -= 1;

            }

            int clicked = monets3 = x3;
            coin3.Add(monets3);
            m3 = Wax.Text = clicked.ToString();
            if (clicked == j)
            {
                ++x3;

            }





            label1.Text = j.ToString();
        }

      

        private void timer4_Tick(object sender, EventArgs e)
        {
            var x = ConfigurationManager.AppSettings.Get("stopWatch4");

            ConfigurationManager.AppSettings.Get("stopWatch4");

            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Thread.Sleep(int.Parse(x));
            stopWatch3.Stop();


            if (j == 0)
            {
                j += 1;
            }

            j -= 1;
            x4 += 1;
            if (j == 0)
            {

                x4 -= 1;

            }
            int clicked = monets4 = x4;
            coin4.Add(monets4);
            m4 = Сleaner.Text = clicked.ToString();

            if (clicked == j)
            {
                ++x4;

            }


            label1.Text = j.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            var z = ConfigurationManager.AppSettings.Get("stopWatch5");

            ConfigurationManager.AppSettings.Get("stopWatch5");

            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Thread.Sleep(int.Parse(z));
            stopWatch3.Stop();


            if (j == 0)
            {
                j += 1;
            }

            j -= 1;
            x5 += 1;
            if (j == 0)
            {

                x5 -= 1;

            }
            int clicked = monets5 = x5;
            coin5.Add(monets5);
            m5 = Drying.Text = clicked.ToString();



            if (clicked == j)
            {
                ++x5;

            }



            label1.Text = j.ToString();

        }

        private void Drying_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
        }
        private void Сleaner_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }
        public string text = "";
        public string water = "";
        public string wax = "";
        public string foam = "";
        public string cleaner = "";
        public string drying = "";

        Bitmap bitmap;
        private void PrintButton_Click(object sender, EventArgs e)
        {




           
            
                water = $"pay for water: \n{water += m1}{Environment.NewLine}\n";
                
                
            
            
          
            
                wax = $"pay for wax: {wax +=m3}{Environment.NewLine}\n";
              
            
              
           
            
                foam = $"pay for foam: \n{foam += m2}{Environment.NewLine}\n";
               
                
              
            
           
       
         
            
                cleaner = $"pay for cleaner: \n{cleaner += m4}{Environment.NewLine}\n";
               
               
                
             
            
            
           
            
                drying = $"pay for drying: \n{drying += m5}{Environment.NewLine}\n";
               
                
            
           
           
            
            
           

     
            text = "Ваша сумма: ";
            text += parse.ToString();

            CheckPrint checkPrint = new CheckPrint();

          
            Graphics graphics = checkPrint.CreateGraphics();
            Size size = checkPrint.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(checkPrint.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();



            //PrintDocument printDocument = new PrintDocument();
            //printDocument.PrintPage += PrintPageHandler;

            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument;

            //if (printDialog.ShowDialog() == DialogResult.OK)
            //    printDialog.Document.Print();
        }

        void PrintPageHandler(object sender,PrintPageEventArgs e)
        {
            

         
            //e.Graphics.DrawString(wax, new Font("Arial", 20), Brushes.Black, 0, 0);
            //e.Graphics.DrawString(drying, new Font("Arial", 20), Brushes.Black, 0, 0);
            //e.Graphics.DrawString(water, new Font("Arial", 20), Brushes.Black, 0, 0);
            //e.Graphics.DrawString(cleaner, new Font("Arial", 20), Brushes.Black, 0, 0);
            //e.Graphics.DrawString(foam, new Font("Arial", 20), Brushes.Black, 0, 0);
           
           

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}















































