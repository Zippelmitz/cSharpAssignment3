using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        protected bool _fireExtinquisher;// >If the droid has a fire extinquisher.
        protected int _numberOfShips;// >The number of ships this droid has worked on.
        

        // >Properties
        //
        public bool FireExtinquisher
        {
            get { return _fireExtinquisher; }
        }
        public int NumberOfShips
        {
            get { return _numberOfShips; }
        }


        // >Methods
        //
        // >Determine the overall cost of the droid.
        public override void CalculateTotalCost()
        {
            // >Add the base cost.
            base.CalculateTotalCost();

            // >Add the fire extinquisher cost.
            if (_fireExtinquisher)
            {
                _totalCost += DroidPricing.fireExtinquisherCost;
            }

            // >Add the number of ships cost.
            _totalCost += _numberOfShips * DroidPricing.COST_PER_SHIP;
            
        }

        // >Returns a string listing the droids details.
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Fire Extinquisher: " + _fireExtinquisher + Environment.NewLine +
                "Number of Ships: " + _numberOfShips + Environment.NewLine;
        }


        // >Constructors
        //
        public AstromechDroid(string model, string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm, bool hasFireExtinquisher, int numberOfShips) : base (model, material, color, hasToolBox, hasComputerConnection, hasArm)
        {
            _fireExtinquisher = hasFireExtinquisher;
            _numberOfShips = numberOfShips;

            CalculateBaseCost();
        }

    }
}
