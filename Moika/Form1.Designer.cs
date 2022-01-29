
using System;

namespace Moika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Water = new System.Windows.Forms.Button();
            this.Foam = new System.Windows.Forms.Button();
            this.Wax = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Сleaner = new System.Windows.Forms.Button();
            this.Drying = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.PrintButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // Water
            // 
            this.Water.BackColor = System.Drawing.SystemColors.Highlight;
            this.Water.Location = new System.Drawing.Point(40, 196);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(101, 48);
            this.Water.TabIndex = 0;
            this.Water.Text = "Water";
            this.Water.UseVisualStyleBackColor = false;
            this.Water.Click += new System.EventHandler(this.button1_Click);
            // 
            // Foam
            // 
            this.Foam.BackColor = System.Drawing.SystemColors.Window;
            this.Foam.Location = new System.Drawing.Point(40, 275);
            this.Foam.Name = "Foam";
            this.Foam.Size = new System.Drawing.Size(101, 50);
            this.Foam.TabIndex = 1;
            this.Foam.Text = "Foam";
            this.Foam.UseVisualStyleBackColor = false;
            this.Foam.Click += new System.EventHandler(this.Foam_Click);
            // 
            // Wax
            // 
            this.Wax.BackColor = System.Drawing.Color.DarkOrange;
            this.Wax.Location = new System.Drawing.Point(41, 354);
            this.Wax.Name = "Wax";
            this.Wax.Size = new System.Drawing.Size(100, 46);
            this.Wax.TabIndex = 2;
            this.Wax.Text = "Wax";
            this.Wax.UseVisualStyleBackColor = false;
            this.Wax.Click += new System.EventHandler(this.Wax_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Red;
            this.Start.Location = new System.Drawing.Point(632, 366);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(98, 34);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 59.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Yellow;
            this.Stop.Location = new System.Drawing.Point(263, 366);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(94, 34);
            this.Stop.TabIndex = 5;
            this.Stop.Text = " Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Сleaner
            // 
            this.Сleaner.BackColor = System.Drawing.Color.GreenYellow;
            this.Сleaner.Location = new System.Drawing.Point(40, 118);
            this.Сleaner.Name = "Сleaner";
            this.Сleaner.Size = new System.Drawing.Size(101, 48);
            this.Сleaner.TabIndex = 6;
            this.Сleaner.Text = "Сleaner";
            this.Сleaner.UseVisualStyleBackColor = false;
            this.Сleaner.Click += new System.EventHandler(this.Сleaner_Click);
            // 
            // Drying
            // 
            this.Drying.BackColor = System.Drawing.Color.OrangeRed;
            this.Drying.Location = new System.Drawing.Point(41, 32);
            this.Drying.Name = "Drying";
            this.Drying.Size = new System.Drawing.Size(101, 48);
            this.Drying.TabIndex = 7;
            this.Drying.Text = "Drying";
            this.Drying.UseVisualStyleBackColor = false;
            this.Drying.Click += new System.EventHandler(this.Drying_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(439, 366);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(104, 34);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.Drying);
            this.Controls.Add(this.Сleaner);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Wax);
            this.Controls.Add(this.Foam);
            this.Controls.Add(this.Water);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button Water;
        private System.Windows.Forms.Button Foam;
        private System.Windows.Forms.Button Wax;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button Сleaner;
        private System.Windows.Forms.Button Drying;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

