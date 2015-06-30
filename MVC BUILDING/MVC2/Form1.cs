using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MVC
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private MVC_Model theModel;
		private MVC_Controller theController;
		private IView View1, View2, View4;
		private ViewForm1 myViewForm1;
		private ViewForm2 myViewForm2;
        private ViewForm4 myViewForm4;
		private System.Windows.Forms.Button btnMakeController;
		private System.Windows.Forms.Button btnmakeModel;
		private System.Windows.Forms.Button btnMakeViews;
		private System.Windows.Forms.Button btnShowViews;
        private Button button1;

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
            this.btnMakeController = new System.Windows.Forms.Button();
            this.btnmakeModel = new System.Windows.Forms.Button();
            this.btnMakeViews = new System.Windows.Forms.Button();
            this.btnShowViews = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeController
            // 
            this.btnMakeController.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeController.Location = new System.Drawing.Point(32, 12);
            this.btnMakeController.Name = "btnMakeController";
            this.btnMakeController.Size = new System.Drawing.Size(210, 39);
            this.btnMakeController.TabIndex = 5;
            this.btnMakeController.Text = "Make Controller";
            this.btnMakeController.UseVisualStyleBackColor = false;
            this.btnMakeController.Visible = false;
            this.btnMakeController.Click += new System.EventHandler(this.btnMakeController_Click);
            // 
            // btnmakeModel
            // 
            this.btnmakeModel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmakeModel.Location = new System.Drawing.Point(32, 12);
            this.btnmakeModel.Name = "btnmakeModel";
            this.btnmakeModel.Size = new System.Drawing.Size(210, 39);
            this.btnmakeModel.TabIndex = 6;
            this.btnmakeModel.Text = "Make Model";
            this.btnmakeModel.UseVisualStyleBackColor = false;
            this.btnmakeModel.Visible = false;
            this.btnmakeModel.Click += new System.EventHandler(this.btnmakeModel_Click);
            // 
            // btnMakeViews
            // 
            this.btnMakeViews.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeViews.Location = new System.Drawing.Point(32, 12);
            this.btnMakeViews.Name = "btnMakeViews";
            this.btnMakeViews.Size = new System.Drawing.Size(210, 39);
            this.btnMakeViews.TabIndex = 7;
            this.btnMakeViews.Text = "MakeViews";
            this.btnMakeViews.UseVisualStyleBackColor = false;
            this.btnMakeViews.Visible = false;
            this.btnMakeViews.Click += new System.EventHandler(this.btnMakeViews_Click);
            // 
            // btnShowViews
            // 
            this.btnShowViews.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowViews.Location = new System.Drawing.Point(32, 12);
            this.btnShowViews.Name = "btnShowViews";
            this.btnShowViews.Size = new System.Drawing.Size(210, 39);
            this.btnShowViews.TabIndex = 8;
            this.btnShowViews.Text = "Show Views";
            this.btnShowViews.UseVisualStyleBackColor = false;
            this.btnShowViews.Visible = false;
            this.btnShowViews.Click += new System.EventHandler(this.btnShowViews_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 63);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowViews);
            this.Controls.Add(this.btnMakeViews);
            this.Controls.Add(this.btnmakeModel);
            this.Controls.Add(this.btnMakeController);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Pseudo GPS";
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
	  	
		private void btnMakeController_Click(object sender, System.EventArgs e)
		{
            //theController = new MVC_Controller();
		}

		private void btnmakeModel_Click(object sender, System.EventArgs e)
		{
            //theModel = new MVC_Model(theController);
		}

		private void btnMakeViews_Click(object sender, System.EventArgs e)
        {
        //    myViewForm1 = new ViewForm1();
        //    myViewForm2 = new ViewForm2();
        //    myViewForm4 = new ViewForm4();
        //    myViewForm1.MyModel = theModel;
        //    myViewForm2.MyModel = theModel;
        //    myViewForm4.MyModel = theModel;
        //    theController.AddView(myViewForm1);
        //    theController.AddView(myViewForm2);
        //    theController.AddView(myViewForm4);
		}

		private void btnShowViews_Click(object sender, System.EventArgs e)
		{
            //myViewForm1.Show();
            //myViewForm2.Show();
            //myViewForm4.Show();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            theController = new MVC_Controller();

            theModel = new MVC_Model(theController);

            myViewForm1 = new ViewForm1();
            myViewForm2 = new ViewForm2();
            myViewForm4 = new ViewForm4();
            myViewForm1.MyModel = theModel;
            myViewForm2.MyModel = theModel;
            myViewForm4.MyModel = theModel;
            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm4);

            myViewForm1.Show();
            myViewForm2.Show();
            myViewForm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

	}
}
