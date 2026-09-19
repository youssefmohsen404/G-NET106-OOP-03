using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, describtion, weight, deliveryFee)
        {
            ExtraFee = extraFee;
        }
        public ExpressShipment() { }
        private decimal _extraFee;

        public decimal ExtraFee
        {
            get { return _extraFee; }

            set { if (value >= 0) {
                    _extraFee = value;
                }
                else
                {
                    Console.WriteLine("invalid extra fee");
                }

            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }

        }

        public override string ToString()
        {
            return base.ToString()+$"\n extra fees:{ExtraFee}";
        }
    }


    }

