using Proj_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj.Service
{
    public class ShipmentService
    {
        private List<ShipmentStatus> Ship = new List<ShipmentStatus>();
        public void AddShip(ShipmentStatus shipmentStatus)
        {
            foreach (ShipmentStatus c in Ship)
            {
                if (c.ShipmentId == c.ShipmentId)
                {
                    Console.WriteLine("Customer ID already exists");
                    return;
                }
            }

            Ship.Add(shipmentStatus);
            Console.WriteLine("Customer added successfully");
        }
        public void ViewShipment()
        {
            foreach(var s in Ship)
            {
                Console.WriteLine("ShipmentStatus :"+s.Status+
                                  "ShipmentLocation"+s.Location);
            }
        }
        public void Searchship(int id)
        {
            foreach(ShipmentStatus s in Ship)
            {
                if (s.ShipmentId == id)
                {
                    Console.WriteLine("ShipmentId :"+s.ShipmentId  +
                                      "ShipmentStatus :"+ s.Status +
                                      "Shipment Location" + s.Location);
                }
            }
        }
    }
}
