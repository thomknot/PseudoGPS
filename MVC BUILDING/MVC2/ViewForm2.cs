using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC
{
	/// <summary>
	/// Summary description for ViewForm2.
	/// </summary>
	public class ViewForm2 : System.Windows.Forms.Form , IView
	{
		private MVC_Model myModel;
        private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;
        private String listitem;
        private RadioButton rbResidence;
        private RadioButton rbCommercial;
        private Button btnAdd;
        private TextBox txtXPos;
        private TextBox txtYPos;
        private ComboBox cbbCommercial;
        private Button btnDelete;
        private RadioButton rblandmark;
        private Panel panel1;
        private TextBox txtWidth;
        private ComboBox cbbLandmark;
        private ComboBox cbboxResidential;
        int index;

		public ViewForm2()
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbResidence = new System.Windows.Forms.RadioButton();
            this.rbCommercial = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.cbbCommercial = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rblandmark = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbLandmark = new System.Windows.Forms.ComboBox();
            this.cbboxResidential = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(-2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 340);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbResidence
            // 
            this.rbResidence.Location = new System.Drawing.Point(12, 44);
            this.rbResidence.Name = "rbResidence";
            this.rbResidence.Size = new System.Drawing.Size(135, 29);
            this.rbResidence.TabIndex = 0;
            this.rbResidence.Text = "Residential";
            this.rbResidence.CheckedChanged += new System.EventHandler(this.rbResidence_CheckedChanged);
            // 
            // rbCommercial
            // 
            this.rbCommercial.Location = new System.Drawing.Point(12, 11);
            this.rbCommercial.Name = "rbCommercial";
            this.rbCommercial.Size = new System.Drawing.Size(148, 29);
            this.rbCommercial.TabIndex = 1;
            this.rbCommercial.Text = "Commercial";
            this.rbCommercial.CheckedChanged += new System.EventHandler(this.rbCommercial_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(318, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(348, 358);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(31, 30);
            this.txtXPos.TabIndex = 24;
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(348, 405);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(31, 30);
            this.txtYPos.TabIndex = 25;
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
            this.cbbCommercial.Location = new System.Drawing.Point(166, 11);
            this.cbbCommercial.Name = "cbbCommercial";
            this.cbbCommercial.Size = new System.Drawing.Size(121, 25);
            this.cbbCommercial.TabIndex = 26;
            this.cbbCommercial.Text = "DownTown Mall";
            this.cbbCommercial.Visible = false;
            this.cbbCommercial.SelectedIndexChanged += new System.EventHandler(this.cbbCommercial_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(318, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rblandmark
            // 
            this.rblandmark.Location = new System.Drawing.Point(12, 79);
            this.rblandmark.Name = "rblandmark";
            this.rblandmark.Size = new System.Drawing.Size(148, 29);
            this.rblandmark.TabIndex = 27;
            this.rblandmark.Text = "Landmark";
            this.rblandmark.CheckedChanged += new System.EventHandler(this.rblandmark_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbbLandmark);
            this.panel1.Controls.Add(this.cbboxResidential);
            this.panel1.Controls.Add(this.rblandmark);
            this.panel1.Controls.Add(this.cbbCommercial);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rbCommercial);
            this.panel1.Controls.Add(this.rbResidence);
            this.panel1.Location = new System.Drawing.Point(-2, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 128);
            this.panel1.TabIndex = 7;
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
            this.cbbLandmark.Location = new System.Drawing.Point(166, 79);
            this.cbbLandmark.Name = "cbbLandmark";
            this.cbbLandmark.Size = new System.Drawing.Size(121, 25);
            this.cbbLandmark.TabIndex = 29;
            this.cbbLandmark.Text = "SkyCity";
            this.cbbLandmark.Visible = false;
            this.cbbLandmark.SelectedIndexChanged += new System.EventHandler(this.cbbLandmark_SelectedIndexChanged);
            // 
            // cbboxResidential
            // 
            this.cbboxResidential.Font = new System.Drawing.Font("Arial", 9F);
            this.cbboxResidential.FormattingEnabled = true;
            this.cbboxResidential.Items.AddRange(new object[] {
            "Waldorf Bankside",
            "B & T City Apts",
            "Ray White City Apts"});
            this.cbboxResidential.Location = new System.Drawing.Point(166, 46);
            this.cbboxResidential.Name = "cbboxResidential";
            this.cbboxResidential.Size = new System.Drawing.Size(121, 25);
            this.cbboxResidential.TabIndex = 28;
            this.cbboxResidential.Text = "Waldorf Bankside";
            this.cbboxResidential.Visible = false;
            this.cbboxResidential.SelectedIndexChanged += new System.EventHandler(this.cbboxResidential_SelectedIndexChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(103, 358);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(29, 30);
            this.txtWidth.TabIndex = 7;
            this.txtWidth.Text = "15";
            this.txtWidth.Visible = false;
            // 
            // ViewForm2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.ClientSize = new System.Drawing.Size(446, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.txtXPos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm2";
            this.Load += new System.EventHandler(this.ViewForm2_Load);
            this.panel1.ResumeLayout(false);
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
                bdname = cbboxResidential.Text;
                aBuilding = new AnyResidential(X, Y, aColor, Width, bdname);
                myModel.AddBuilding(aBuilding);
			}
			
                if (rbCommercial.Checked)
                {
                    bdname = cbbCommercial.Text;
                    aColor = Color.Blue;
                    aBuilding = new AnyCommercial(X, Y, aColor, Width, bdname);
                    myModel.AddBuilding(aBuilding);
                }
			
            else
			{
                    if (rblandmark.Checked)
                {
                    aColor = Color.Red;
                    bdname = cbbLandmark.Text;
                    aBuilding = new AnyLandmark (X, Y, aColor, Width, bdname);
                    myModel.AddBuilding(aBuilding);
                }
			}
              
		}
	
		public void RefreshView()
		{
			listBox1.Items.Clear();
            ArrayList theBuildingList = myModel.BuildingList;
            AnyBuilding[] theBuildings = (AnyBuilding[])theBuildingList.ToArray(typeof(AnyBuilding));
            foreach (AnyBuilding sh in theBuildings)
			{
				listBox1.Items.Add(sh);
                
			}
            if (listBox1.Items.Count != 0)
            {
                btnDelete.Enabled = true ;
            }

		}


		private void btnRedisplay_Click(object sender, System.EventArgs e)
		{
		
		}

		public MVC_Model MyModel
		{
			set
			{
				myModel = value;
			}
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            index = listBox1.SelectedIndex;
            listitem  = listBox1.SelectedItem.ToString ();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                    myModel.RemoveBuilding(index);
                    if (listBox1.Items.Count == 0)
                    {
                        btnDelete.Enabled = false; 
                    }
                    
           
        }


        private void ViewForm2_Load(object sender, EventArgs e)
        {

        }

        private void rbResidence_CheckedChanged(object sender, EventArgs e)
        {
            txtXPos.Text = "373";
            txtYPos.Text = "133";
            cbbCommercial.Visible = false;
            cbbCommercial.Enabled = false;
            cbbLandmark.Enabled = false;
            cbbLandmark.Visible = false;
            cbboxResidential.Visible = true;
            cbboxResidential.Enabled = true;
        }

        private void rblandmark_CheckedChanged(object sender, EventArgs e)
        {

            txtXPos.Text = "136";
            txtYPos.Text = "215";
            cbbCommercial.Visible = false ;
            cbbCommercial.Enabled = false;
            cbbLandmark.Enabled = true;
            cbbLandmark.Visible = true;
            cbboxResidential.Visible = false;
            cbboxResidential.Enabled = false;
        }

        private void rbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtXPos.Text = "258";
            txtYPos.Text = "14";
            cbbCommercial.Visible = true;
            cbbCommercial.Enabled = true;
            cbbLandmark.Enabled = false;
            cbbLandmark.Visible = false;
            cbboxResidential.Visible = false;
            cbboxResidential.Enabled = false;
        }

        private void cbbCommercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCommercial.SelectedIndex == 0)
            {
                txtXPos.Text = "258";
                txtYPos.Text = "14";
            }
            else
                if (cbbCommercial.SelectedIndex == 1)
                {
                    txtXPos.Text = "393";
                    txtYPos.Text = "135";
                }
                else
                    if (cbbCommercial.SelectedIndex == 2)
                    {
                        txtXPos.Text = "222";
                        txtYPos.Text = "131";
                    }
                    else
                        if (cbbCommercial.SelectedIndex == 3)
                        {
                            txtXPos.Text = "247";
                            txtYPos.Text = "104";
                        }
        }

        private void cbbLandmark_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbLandmark.SelectedIndex == 0)
            {
                txtXPos.Text = "136";
                txtYPos.Text = "215";
            }
            else
                if (cbbLandmark.SelectedIndex == 1)
                {
                    txtXPos.Text = "302";
                    txtYPos.Text = "19";
                }
                else
                    if (cbbLandmark.SelectedIndex == 2)
                    {
                        txtXPos.Text = "127";
                        txtYPos.Text = "308";
                    }
                    else
                        if (cbbLandmark.SelectedIndex == 3)
                        {
                            txtXPos.Text = "82";
                            txtYPos.Text = "365";
                        }
        }

        private void cbboxResidential_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxResidential.SelectedIndex == 0)
            {
                txtXPos.Text = "373";
                txtYPos.Text = "133";
            }
            else
                if (cbboxResidential.SelectedIndex == 1)
                {
                    txtXPos.Text = "320";
                    txtYPos.Text = "96";
                }
                else
                    if (cbboxResidential.SelectedIndex == 2)
                    {
                        txtXPos.Text = "242";
                        txtYPos.Text = "243";
                    }
        }

        

       



        
    }
}
