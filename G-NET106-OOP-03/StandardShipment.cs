using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET106_OOP_02.part2
{
    internal class StandardShipment: Shipment
    {
        public StandardShipment(string trackingCode, string describtion, decimal weight, decimal deliveryFee) : base(trackingCode,describtion, weight, deliveryFee) { 
        
        }
        public StandardShipment() { }

        

    }
}
