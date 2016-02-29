using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected decimal _totalCost;// >The total cost of the droid.
        protected decimal _baseCost;// >The base cost of the droid.

        protected string _model;// >The droid model.
        protected string _material;// >Material the droid is made of.
        protected string _color;// >Primary color of the droid.


        // >Properties
        //
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
        public decimal BaseCost
        {
            get { return _baseCost; }
        }
        public string Model
        {
            get { return _model; }
        }
        public string Material
        {
            get { return _material; }
        }
        public string Color
        {
            get { return Color; }
        }


        // >Methods
        //
        // >Determines the baseCost based on model & material.
        protected virtual void CalculateBaseCost()
        {
            // >Set the base cost of this droid.
            _baseCost = DroidPricing.FindModelCost(_model);

            // >Add the material cost to the base cost.
            _baseCost += DroidPricing.FindMaterialCost(_material);
        }

        // >Determine the overall cost of the droid.
        public virtual void CalculateTotalCost()
        {
            // >Reset the total cost.
            _totalCost = 0.0m;

            // >Add the base cost.
            _totalCost += _baseCost;
        }

        // >Returns a string listing the droids details.
        public override string ToString()
        {
            // >Get the most accurate cost.
            CalculateTotalCost();

            return "Base Cost: " + _baseCost + Environment.NewLine +
                "Total Cost: " + _totalCost + Environment.NewLine +
                "Model: " + _model + Environment.NewLine +
                "Material: " + _material + Environment.NewLine +
                "Color: " + _color;
        }


        // >Constructor
        //
        public Droid(string model, string material, string color)
        {
            _model = model;
            _material = material;
            _color = color;

            // >Find the base cost.
            CalculateBaseCost();
        }

    }
}
