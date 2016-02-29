using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        protected bool _toolBox;// >If the droid has a toolbox.
        protected bool _computerConnection;// >If the droid has a computer connection.
        protected bool _arm;// >If the droid has and newDroidArm.


        // >Properties
        //
        public bool ToolBox
        {
            get { return _toolBox; }
        }
        public bool ComputerConnection
        {
            get { return _computerConnection; }
        }
        public bool Arm
        {
            get { return _arm; }
        }


        // >Methods
        //
        // >Determine the overall cost of the droid.
        public override void CalculateTotalCost()
        {
            // >Add the base cost.
            base.CalculateTotalCost();

            // >Add the newDroidToolBox cost.
            if (_toolBox)
            {
                _totalCost += DroidPricing.toolBoxCost;
            }

            // >Add the newDroidComputerConnection cost.
            if (_computerConnection)
            {
                _totalCost += DroidPricing.computerConnectionCost;
            }

            // >Add the newDroidArm cost.
            if (_arm)
            {
                _totalCost += DroidPricing.armCost;
            }
        }

        // >Returns a string listing the droids details.
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "ToolBox: " + _toolBox + Environment.NewLine +
                "Computer Connection: " + _computerConnection + Environment.NewLine +
                "Arm: " + _arm;
        }
        

        // >Constructors
        //
        public UtilityDroid(string model, string material, string color, bool hasToolBox, bool hasComputerConnection, bool hasArm) : base (model, material, color)
        {
            _toolBox = hasToolBox;
            _computerConnection = hasComputerConnection;
            _arm = hasArm;

            CalculateBaseCost();
        }
    }
}
