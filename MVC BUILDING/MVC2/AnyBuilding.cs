using System;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Drawing;

namespace MVC
{
	/// <summary>
	/// Summary description for AnyBuilding.
	/// </summary>
	public abstract class AnyBuilding
	{
		protected int x;
		protected int y;
		protected Color backColor;
        protected String bname;

		public AnyBuilding(int x_at, int y_at, Color bkColor, String name)
		{
			x = x_at;
			y = y_at;
			backColor = bkColor;
            bname = name;
		}
		

		public abstract void Display(Graphics g);

		public string Position()  //non abstract method
		{
			return "(" + x.ToString() + "," + y.ToString() + ")";
		}

		public abstract int x_pos //abstract property
		{
			get;
			set;
		}

		public abstract int y_pos //abstract property
		{
			get;
			set;
		}

        public  String name_pos() // non abstract property
        {
            return "bname";
        }
	}
}
