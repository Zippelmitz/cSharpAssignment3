using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
        protected bool _trashCompactor;// >If the droid has a trash compactor.
        protected bool _vacuum;// >If the droid has a vacuum.
        

        // Properties
        //
        public bool TrashCompactor
        {
            get { return _trashCompactor; }
        }
        public bool Vaccum
        {
            get { return _vacuum; }
        }


        // >Methods
        //
        // >Determine the overall cost of the droid.
        public override void CalculateTotalCost()
        {
            // >Add the base cost.
            base.CalculateTotalCost();

            // >Add the trash compactor cost.
            if (_toolBox)
            {
                _totalCost += DroidPricing.trashCompactorCost;
            }

            // >Add the vacuum cost.
            if (_computerConnection)
            {
                _totalCost += DroidPricing.vacuumCost;
            }
        }

        // >Returns a string listing the droids details.
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Trash Compactor: " + _trashCompactor + Environment.NewLine +
                "Vacuum: " + _vacuum + Environment.NewLine;
        }


        // >Constructors
        //
        public JanitorDroid(string model, string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum) : base (model, material, color, hasToolBox, hasComputerConnection, hasArm)
        {
            _trashCompactor = hasTrashCompactor;
            _vacuum = hasVacuum;

            CalculateBaseCost();
        }

    }
}
