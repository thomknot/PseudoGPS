using System;
using System.Collections;

namespace MVC
{
	/// <summary>
	/// Summary description for MVC_Model.
	/// </summary>
	public class MVC_Model
	{
		private ArrayList buidlingList;
        private ArrayList squareList;

		private MVC_Controller theController;

		public MVC_Model(MVC_Controller aController)
		{
			buidlingList = new ArrayList();
            squareList = new ArrayList();

			theController = aController;
		}

        public ArrayList BuildingList
		{
			get
			{
				return buidlingList;
			}
		}

        public void AddBuilding(AnyBuilding aBuilding)
		{

            buidlingList.Add(aBuilding);
            
			UpdateViews();
		}


        public void RemoveBuilding(int index)
        {
            buidlingList.RemoveAt(index);
            UpdateViews();
        }

        

		public void UpdateViews()
		{
			theController.UpdateViews();
		}

        
    }
}
