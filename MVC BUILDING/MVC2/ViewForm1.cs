using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC
{
	/// <summary>
	/// Summary description for ViewForm1.
	/// </summary>
	public class ViewForm1 : System.Windows.Forms.Form , IView
	{
		private MVC_Model myModel;
		private int tempXPos;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.RadioButton rbCommercial;
        private System.Windows.Forms.RadioButton rbResidence;
		private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.Button btnAdd;
        private RadioButton rblandmark;
        private ComboBox cbbResidential;
        private ComboBox cbbLandmark;
        private ComboBox cbbCommercial;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewForm1()
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
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbResidential = new System.Windows.Forms.ComboBox();
            this.rbResidence = new System.Windows.Forms.RadioButton();
            this.cbbLandmark = new System.Windows.Forms.ComboBox();
            this.cbbCommercial = new System.Windows.Forms.ComboBox();
            this.rblandmark = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbbResidential);
            this.panel1.Controls.Add(this.rbResidence);
            this.panel1.Controls.Add(this.cbbLandmark);
            this.panel1.Controls.Add(this.cbbCommercial);
            this.panel1.Controls.Add(this.rblandmark);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.rbCommercial);
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 118);
            this.panel1.TabIndex = 3;
            // 
            // cbbResidential
            // 
            this.cbbResidential.Font = new System.Drawing.Font("Arial", 9F);
            this.cbbResidential.FormattingEnabled = true;
            this.cbbResidential.Items.AddRange(new object[] {
            "Waldorf Bankside",
            "B & T City Apts",
            "Ray White City Apts"});
            this.cbbResidential.Location = new System.Drawing.Point(176, 47);
            this.cbbResidential.Name = "cbbResidential";
            this.cbbResidential.Size = new System.Drawing.Size(121, 25);
            this.cbbResidential.TabIndex = 27;
            this.cbbResidential.Text = "Waldorf Bankside";
            this.cbbResidential.Visible = false;
            this.cbbResidential.SelectedIndexChanged += new System.EventHandler(this.cbbResidential_SelectedIndexChanged);
            // 
            // rbResidence
            // 
            this.rbResidence.Location = new System.Drawing.Point(17, 48);
            this.rbResidence.Name = "rbResidence";
            this.rbResidence.Size = new System.Drawing.Size(139, 29);
            this.rbResidence.TabIndex = 0;
            this.rbResidence.Text = "Residential";
            this.rbResidence.CheckedChanged += new System.EventHandler(this.rbResidence_CheckedChanged);
            // 
            // cbbLandmark
            // 
            this.cbbLandmark.Font = new System.Drawing.Font("Arial", 9F);
            this.cbbLandmark.FormattingEnabled = true;
            this.cbbLandmark.Items.AddRange(new object[] {
            "SkyCity",
            "Transport Centre",
            "Civic centre",
            "Aeotea Square"});
            this.cbbLandmark.Location = new System.Drawing.Point(176, 79);
            this.cbbLandmark.Name = "cbbLandmark";
            this.cbbLandmark.Size = new System.Drawing.Size(121, 25);
            this.cbbLandmark.TabIndex = 29;
            this.cbbLandmark.Text = "SkyCity";
            this.cbbLandmark.Visible = false;
            this.cbbLandmark.SelectedIndexChanged += new System.EventHandler(this.cbbLandmark_SelectedIndexChanged);
            // 
            // cbbCommercial
            // 
            this.cbbCommercial.Font = new System.Drawing.Font("Arial", 9F);
            this.cbbCommercial.FormattingEnabled = true;
            this.cbbCommercial.Items.AddRange(new object[] {
            "DownTown Mall",
            "Lumley",
            "SAP",
            "Deloitte"});
            this.cbbCommercial.Location = new System.Drawing.Point(176, 12);
            this.cbbCommercial.Name = "cbbCommercial";
            this.cbbCommercial.Size = new System.Drawing.Size(127, 25);
            this.cbbCommercial.TabIndex = 28;
            this.cbbCommercial.Text = "DownTown Mall";
            this.cbbCommercial.Visible = false;
            this.cbbCommercial.SelectedIndexChanged += new System.EventHandler(this.cbbCommercial_SelectedIndexChanged);
            // 
            // rblandmark
            // 
            this.rblandmark.Location = new System.Drawing.Point(17, 75);
            this.rblandmark.Name = "rblandmark";
            this.rblandmark.Size = new System.Drawing.Size(139, 29);
            this.rblandmark.TabIndex = 26;
            this.rblandmark.Text = "Landmark";
            this.rblandmark.CheckedChanged += new System.EventHandler(this.rblandmark_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(388, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = " Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(419, 66);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(37, 30);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "15";
            this.txtWidth.Visible = false;
            // 
            // rbCommercial
            // 
            this.rbCommercial.Location = new System.Drawing.Point(17, 13);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(159, 29);
            this.rbCommercial.TabIndex = 1;
            this.rbCommercial.Text = "Commercial";
            this.rbCommercial.CheckedChanged += new System.EventHandler(this.rbCommercial_CheckedChanged);
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(421, 419);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(50, 30);
            this.txtYPos.TabIndex = 25;
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(305, 419);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(50, 30);
            this.txtXPos.TabIndex = 24;
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDrawOn.BackgroundImage")));
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(540, 378);
            this.pnlDrawOn.TabIndex = 4;
            // 
            // ViewForm1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.ClientSize = new System.Drawing.Size(542, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDrawOn);
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(this.txtYPos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(1, 2);
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.Load += new System.EventHandler(this.ViewForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			int X, Y, Width;
			Color aColor;
            String bdname;
           
			X = Convert.ToInt32(txtXPos.Text);
			Y = Convert.ToInt32(txtYPos.Text);
			Width = Convert.ToInt32(txtWidth.Text);
			

            AnyBuilding aBuilding;
            if (rbResidence.Checked)
            {
                aColor = Color.Green;
                bdname = cbbResidential.Text;
                aBuilding = new AnyResidential(X, Y, aColor, Width, bdname);
                myModel.AddBuilding(aBuilding);
            }

            if (rbCommercial.Checked)
            {
                aColor = Color.Blue;
                bdname = cbbCommercial.Text;
                aBuilding = new AnyCommercial(X, Y, aColor, Width, bdname);
                myModel.AddBuilding(aBuilding);
            }

            else
            {
                if (rblandmark.Checked)
                {
                    aColor = Color.Red;
                    bdname = cbbLandmark.Text;
                    aBuilding = new AnyLandmark(X, Y, aColor, Width, bdname);
                    myModel.AddBuilding(aBuilding);
                }
            }

           
        }

		public void RefreshView()
		{
           
            this.pnlDrawOn.Refresh();
            ArrayList theBuildingList = myModel.BuildingList;
            AnyBuilding[] theBuilding = (AnyBuilding[])theBuildingList.ToArray(typeof(AnyBuilding));
			Graphics g = this.pnlDrawOn.CreateGraphics();
            foreach (AnyBuilding sh in theBuilding)
			{
				sh.Display(g);
			}
		}

		private void pnlDrawOn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			tempXPos = e.X;
		}

		private void pnlDrawOn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtXPos.Text = e.X.ToString();
			txtYPos.Text = e.Y.ToString();
			int temp;
			temp = tempXPos - e.X;
			txtWidth.Text = temp.ToString();
		}

		

		public MVC_Model MyModel
		{
			set
			{
				myModel = value;
			}
		}

        private void ViewForm1_Load(object sender, EventArgs e)
        {

        }

        private void rbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtXPos.Text = "258";
            txtYPos.Text = "14";
            cbbCommercial.Visible = true;
            cbbCommercial.Enabled = true;
            cbbLandmark.Enabled = false;
            cbbLandmark.Visible = false;
            cbbResidential.Visible = false;
            cbbResidential.Enabled = false;
        }

        private void rbResidence_CheckedChanged(object sender, EventArgs e)
        {
            txtXPos.Text = "373";
            txtYPos.Text = "133";
            cbbCommercial.Visible = false;
            cbbCommercial.Enabled = false;
            cbbLandmark.Enabled = false;
            cbbLandmark.Visible = false;
            cbbResidential.Visible = true;
            cbbResidential.Enabled = true;
        }

        private void rblandmark_CheckedChanged(object sender, EventArgs e)
        {
            txtXPos.Text = "136";
            txtYPos.Text = "215";
            cbbCommercial.Visible = false ;
            cbbCommercial.Enabled = false;
            cbbLandmark.Enabled = true;
            cbbLandmark.Visible = true;
            cbbResidential.Visible = false;
            cbbResidential.Enabled = false;
        }

        private void cbbCommercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCommercial.SelectedIndex == 0)
            {
                txtXPos.Text= "258";
                txtYPos.Text= "14";
            }
            else
                if (cbbCommercial.SelectedIndex == 1)
                {
                    txtXPos.Text= "393";
                   txtYPos.Text= "135";
            }
            else
                if (cbbCommercial.SelectedIndex == 2)
                {
                    txtXPos.Text= "222";
                    txtYPos.Text= "131";
            }
            else
                if (cbbCommercial.SelectedIndex == 3)
                {
                    txtXPos.Text= "247";
                    txtYPos.Text= "104";
            }
        }

        private void cbbLandmark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLandmark.SelectedIndex==0)
            {
                txtXPos.Text = "136";
                txtYPos.Text="215";
            }
            else
                if (cbbLandmark.SelectedIndex==1)
            {
                txtXPos.Text="302";
                txtYPos.Text="19";
            }
                else
                    if (cbbLandmark.SelectedIndex==2)
            {
                txtXPos.Text="127";
                txtYPos.Text="308";
            }
                    else
                        if (cbbLandmark.SelectedIndex==3)
            {
                txtXPos.Text="82";
                txtYPos.Text="365";
            }
        }

        private void cbbResidential_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbResidential.SelectedIndex == 0)
            {
                txtXPos.Text = "373";
                txtYPos.Text = "133";
            }
            else
                if (cbbResidential.SelectedIndex == 1)
                {
                    txtXPos.Text = "320";
                    txtYPos.Text = "96";
                }
                else
                    if (cbbResidential.SelectedIndex == 2)
                    {
                        txtXPos.Text = "242";
                        txtYPos.Text = "243";
                    }
        }




	}
}
