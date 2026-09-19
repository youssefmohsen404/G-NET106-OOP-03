using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class Shipment
    {

        public DeliveryAddress destination { get; set; }

        

        private string _trackingCode;


        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("invalid tracking code");
                _trackingCode = value;
            }
        }


        private string _describtion;

        public string Describtion
        {
            get { return _describtion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("invalid describtion");
                _describtion = value;
            }
        }


        private decimal _weight;

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0)
                    Console.WriteLine("invalid weight");
                _weight = value;
            }
        }


        private decimal _deliveryFee;

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value < 0)
                    Console.WriteLine("invalid Delivery Fee");
                _deliveryFee = value;
            }
        }


        //assignment 3 making f virtual
        public virtual decimal EstimatedCost
        {

            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }

        //constructors
        public Shipment(string trackingCode)
        {
            this._trackingCode = trackingCode;
        }
        public Shipment(string describtion = "unknown", decimal weight = 1, decimal deliveryFee = 50, DeliveryAddress destination = default)
        {
            this._describtion = describtion;
            this.Weight = weight;
            this._deliveryFee = deliveryFee;
            this.destination = destination;
        }
        public Shipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee, DeliveryAddress destination = default)
        {
            this._trackingCode = trackingCode;
            this._describtion = describtion;
            this._weight = weight;
            this._deliveryFee = deliveryFee;
            this.destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
            else
            {
                Console.WriteLine("invalid delivery fee");
            }
        }
        //assignment 3 virtual f
        public virtual void PrintShipment()
        {
            Console.WriteLine($"tracking code is:{TrackingCode} \n describtion is : {Describtion} \n weight :{Weight} \n delivery fee:{DeliveryFee} \n destination: {destination}");
        }
        //assignment 3 overloading
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0) {
                   Weight = newWeight;
                Console.WriteLine($"weight updated to {Weight}");
            }
            else {
                Console.WriteLine("invalid weight");

            }
        }
        public void UpdateWeight(decimal newWeight ,decimal packWeight )
        {
            if (newWeight > 0 && packWeight > 0) {
                Weight = newWeight + packWeight;
                Console.WriteLine($"shipment weight is {Weight}");
            }
            else { Console.WriteLine("invalid weight"); }
            
        }
        public override string ToString()
        {
            return $"tracking code is:{TrackingCode} \n describtion is : {Describtion} \n weight :{Weight} \n delivery fee:{DeliveryFee} \n estimated cost: {EstimatedCost} ";
        }
    }
}
