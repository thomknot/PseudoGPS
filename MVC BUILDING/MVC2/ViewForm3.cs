using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC2
{
    /// <summary>
    /// Summary description for ViewForm1.
    /// </summary>
    public class ViewForm3 : System.Windows.Forms.Form, IView
    {
        private MVC_Model myModel;
        private int tempXPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.Button btnAddShape;
        private System.Windows.Forms.Button btnRedisplay;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ViewForm3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.btnRedisplay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtYPos);
            this.panel1.Controls.Add(this.txtXPos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.btnAddShape);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbCircle);
            this.panel1.Controls.Add(this.rbSquare);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 107);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(20, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 49);
            this.panel2.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 19);
            this.label13.TabIndex = 31;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Magenta;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(84, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 19);
            this.label12.TabIndex = 30;
            this.label12.Click += new System.EventHandler(this.label13_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Blue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(64, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 19);
            this.label11.TabIndex = 29;
            this.label11.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(44, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 28;
            this.label10.Click += new System.EventHandler(this.label13_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(24, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 19);
            this.label9.TabIndex = 27;
            this.label9.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 26;
            this.label8.Click += new System.EventHandler(this.label13_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(84, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 25;
            this.label7.Click += new System.EventHandler(this.label13_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(64, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 24;
            this.label6.Click += new System.EventHandler(this.label13_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(44, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 23;
            this.label5.Click += new System.EventHandler(this.label13_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(24, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 22;
            this.label4.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(380, 58);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(50, 30);
            this.txtYPos.TabIndex = 25;
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(290, 58);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(50, 30);
            this.txtXPos.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(350, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(250, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "X:";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(210, 58);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 29);
            this.lblColor.TabIndex = 19;
            // 
            // btnAddShape
            // 
            this.btnAddShape.Location = new System.Drawing.Point(360, 10);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(130, 38);
            this.btnAddShape.TabIndex = 8;
            this.btnAddShape.Text = "Add Shape";
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(290, 10);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(60, 30);
            this.txtWidth.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width:";
            // 
            // rbCircle
            // 
            this.rbCircle.Location = new System.Drawing.Point(120, 10);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(100, 29);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.Text = "Circle";
            // 
            // rbSquare
            // 
            this.rbSquare.Checked = true;
            this.rbSquare.Location = new System.Drawing.Point(20, 10);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(100, 29);
            this.rbSquare.TabIndex = 0;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(140, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "Color:";
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(540, 378);
            this.pnlDrawOn.TabIndex = 4;
            this.pnlDrawOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseDown);
            this.pnlDrawOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseUp);
            // 
            // btnRedisplay
            // 
            this.btnRedisplay.Location = new System.Drawing.Point(430, 475);
            this.btnRedisplay.Name = "btnRedisplay";
            this.btnRedisplay.Size = new System.Drawing.Size(120, 29);
            this.btnRedisplay.TabIndex = 6;
            this.btnRedisplay.Text = "Redisplay";
            this.btnRedisplay.Click += new System.EventHandler(this.btnRedisplay_Click);
            // 
            // ViewForm1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 23);
            this.ClientSize = new System.Drawing.Size(503, 486);
            this.Controls.Add(this.btnRedisplay);
            this.Controls.Add(this.pnlDrawOn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.Load += new System.EventHandler(this.ViewForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnAddShape_Click(object sender, System.EventArgs e)
        {
            int X, Y, Width;
            Color aColor;
            X = Convert.ToInt32(txtXPos.Text);
            Y = Convert.ToInt32(txtYPos.Text);
            Width = Convert.ToInt32(txtWidth.Text);
            aColor = lblColor.BackColor;

            AnyShape aShape;
            if (rbSquare.Checked)
            {
                aShape = new AnySquare(X, Y, aColor, Width);
            }
            else
            {
                aShape = new AnyCircle(X, Y, aColor, Width);
            }
            myModel.AddShape(aShape);
        }

        public void RefreshView()
        {
            ArrayList theShapeList = myModel.ShapeList;
            AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
            Graphics g = this.pnlDrawOn.CreateGraphics();
            foreach (AnyShape sh in theShapes)
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

        private void label13_Click(object sender, System.EventArgs e)
        {
            lblColor.BackColor = (sender as Label).BackColor;
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

        private void ViewForm3_Load(object sender, EventArgs e)
        {

        }
    }
}
