using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AnalogClockApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AnalogClockControl.AnalogClock analogClock1;
		private AnalogClockControl.AnalogClock analogClock2;
		private AnalogClockControl.AnalogClock analogClock3;
		private System.Windows.Forms.Button cmdDecreaseSize;
		private System.Windows.Forms.Button cmdIncreaseSize;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.analogClock2 = new AnalogClockControl.AnalogClock();
            this.analogClock3 = new AnalogClockControl.AnalogClock();
            this.cmdDecreaseSize = new System.Windows.Forms.Button();
            this.cmdIncreaseSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = false;
            this.analogClock1.Draw5MinuteTicks = false;
            this.analogClock1.HourHandColor = System.Drawing.Color.MediumSlateBlue;
            this.analogClock1.Location = new System.Drawing.Point(32, 32);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.MediumOrchid;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.White;
            this.analogClock1.Size = new System.Drawing.Size(150, 150);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // analogClock2
            // 
            this.analogClock2.Draw1MinuteTicks = false;
            this.analogClock2.Draw5MinuteTicks = true;
            this.analogClock2.HourHandColor = System.Drawing.Color.HotPink;
            this.analogClock2.Location = new System.Drawing.Point(320, 24);
            this.analogClock2.MinuteHandColor = System.Drawing.Color.MediumAquamarine;
            this.analogClock2.Name = "analogClock2";
            this.analogClock2.SecondHandColor = System.Drawing.Color.Yellow;
            this.analogClock2.Size = new System.Drawing.Size(150, 150);
            this.analogClock2.TabIndex = 1;
            this.analogClock2.TicksColor = System.Drawing.Color.Blue;
            // 
            // analogClock3
            // 
            this.analogClock3.Draw1MinuteTicks = true;
            this.analogClock3.Draw5MinuteTicks = true;
            this.analogClock3.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock3.Location = new System.Drawing.Point(64, 168);
            this.analogClock3.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock3.Name = "analogClock3";
            this.analogClock3.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock3.Size = new System.Drawing.Size(352, 352);
            this.analogClock3.TabIndex = 2;
            this.analogClock3.TicksColor = System.Drawing.Color.Black;
            // 
            // cmdDecreaseSize
            // 
            this.cmdDecreaseSize.Image = ((System.Drawing.Image)(resources.GetObject("cmdDecreaseSize.Image")));
            this.cmdDecreaseSize.Location = new System.Drawing.Point(248, 80);
            this.cmdDecreaseSize.Name = "cmdDecreaseSize";
            this.cmdDecreaseSize.Size = new System.Drawing.Size(24, 32);
            this.cmdDecreaseSize.TabIndex = 3;
            this.cmdDecreaseSize.Click += new System.EventHandler(this.cmdDecreaseSize_Click);
            // 
            // cmdIncreaseSize
            // 
            this.cmdIncreaseSize.Image = ((System.Drawing.Image)(resources.GetObject("cmdIncreaseSize.Image")));
            this.cmdIncreaseSize.Location = new System.Drawing.Point(216, 80);
            this.cmdIncreaseSize.Name = "cmdIncreaseSize";
            this.cmdIncreaseSize.Size = new System.Drawing.Size(24, 32);
            this.cmdIncreaseSize.TabIndex = 4;
            this.cmdIncreaseSize.Click += new System.EventHandler(this.cmdIncreaseSize_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdIncreaseSize);
            this.Controls.Add(this.cmdDecreaseSize);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.analogClock2);
            this.Controls.Add(this.analogClock3);
            this.Name = "Form1";
            this.Text = "Analog Clock Control Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.analogClock1.Stop();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.analogClock1.Start();
		}

		private void cmdDecreaseSize_Click(object sender, System.EventArgs e)
		{
			this.analogClock1.Height-=20;
			this.analogClock2.Height-=20;
		}

		private void cmdIncreaseSize_Click(object sender, System.EventArgs e)
		{
			this.analogClock1.Height+=20;
			this.analogClock2.Height+=20;

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
		
	}
}
