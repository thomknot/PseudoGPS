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
	public class ViewForm4 : System.Windows.Forms.Form , IView
	{
		private MVC_Model myModel;
        private System.Windows.Forms.Panel pnlDrawOn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewForm4()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm4));
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDrawOn.BackgroundImage")));
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Enabled = false;
            this.pnlDrawOn.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(540, 378);
            this.pnlDrawOn.TabIndex = 4;
            //this.pnlDrawOn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawOn_Paint);
            // 
            // ViewForm4
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.pnlDrawOn);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewForm4";
            this.Text = "ViewForm3";
            this.Load += new System.EventHandler(this.ViewForm4_Load);
            this.ResumeLayout(false);

		}
		#endregion

		

		public void RefreshView()
		{
            this.pnlDrawOn.Refresh();
			
            ArrayList theBuildingList = myModel.BuildingList;

            AnyBuilding[] theBuilding = (AnyBuilding[])theBuildingList.ToArray(typeof(AnyBuilding));
          			Graphics g = this.pnlDrawOn.CreateGraphics();

                    foreach (AnyBuilding sh in theBuilding)
            {
                if (sh is AnyLandmark )
                {
                    sh.Display(g);
                }
                else
                {
                    if (sh is AnyCommercial )
                    {
                        sh.Display(g);
                    }
                }
            }
			
		}

		

		public MVC_Model MyModel
		{
			set
			{
				myModel = value;
			}
		}

        private void ViewForm4_Load(object sender, EventArgs e)
        {

        }

        


	}
}
