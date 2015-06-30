using System;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Drawing;

namespace MVC
{
    /// <summary>
    /// Summary description for MyCircle.
    /// </summary>
    class AnyLandmark : AnyBuilding
    {
		protected int diameter;

		public AnyLandmark(int x_at, int y_at, Color bkColor, int theDiameter,String name) : base(x_at, y_at, bkColor,name)
		{
			diameter = theDiameter;
		}

		
		public override string ToString()
		{
			return "Landmark: " + this.bname + " at " + this.Position();
		}
	

		public override void Display(Graphics g)
		{
			if (g != null)
			{
                Brush br = new SolidBrush(Color.Red);
				
				g.FillEllipse(br,x,y,diameter,diameter);
               
			}
		}

		public override int x_pos //non abstract property
		{
			get 
			{
				return x;
			}
			set
			{
				x = value;
			}
		}

		public override int y_pos //non abstract property
		{
			get 
			{
				return y;
			}
			set
			{
				y = value;
			}
		}
    }
}
