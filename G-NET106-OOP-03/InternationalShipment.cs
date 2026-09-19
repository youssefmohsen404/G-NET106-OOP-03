using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class InternationalShipment : Shipment
    {
        private string _destinationCountry;

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("invalid destination country");
                _destinationCountry = value;
            }
        }
        private decimal _customsFees;

        public decimal CustomsFees
        {
            get { return _customsFees; }
            set
            {
                if (value < 0)
                    Console.WriteLine("invalid customs fees");
                _customsFees = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFees;
            }

        }

        public InternationalShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee,  string destinationCountry, decimal customsFees) : base(trackingCode, describtion, weight, deliveryFee)
        {
            DestinationCountry = destinationCountry;
            CustomsFees = customsFees;


        }
        public override string ToString()
        {
            return base.ToString() +  $"\n destination country:{DestinationCountry} \n  custom fees{CustomsFees}";
        }

    }
}
