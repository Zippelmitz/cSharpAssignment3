using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        protected int _numOfLanguages;// >The number of languages the droid can speak.

        
        // >Methods
        //
        // >Determine the overall cost of the droid.
        public override void CalculateTotalCost()
        {
            // >Add the base cost.
            base.CalculateTotalCost();

            // >Add the language cost.
            _totalCost += _numOfLanguages * DroidPricing.COST_PER_LANGUAGE;
        }

        // >Returns a string listing the droids details.
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Languages: " + _numOfLanguages;
        }


        // >Constructors
        //
        public ProtocolDroid(string model, string material, string color, int numOfLanguages) : base (model, material, color)
        {
            _numOfLanguages = numOfLanguages;

            CalculateBaseCost();
        }

    }
}
