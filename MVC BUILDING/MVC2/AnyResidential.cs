using System;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Drawing;

namespace MVC
{
	class AnyResidential : AnyBuilding
	{
		protected int side ;
      		
		public AnyResidential(int x_at, int y_at, Color bkColor, int aSide, String name) : base(x_at, y_at, bkColor, name )
		{
			side = aSide;
            
		}

		public override string ToString()
		{
			return "Residential: " +this.bname+" at " + this.Position();
		}
	
		public override void Display(Graphics g)
		{
			if (g != null)
			{
                Brush br = new SolidBrush(Color.Blue );
				
				g.FillRectangle(br, x,y,side,side);
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
