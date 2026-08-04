using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    public class DeliveryCenter
    {
        private Shipment?[] _shipments = new Shipment?[10];

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                    return _shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _shipments.Length)
                    _shipments[index] = value;
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null && _shipments[i]!.TrackingCode == trackingCode)
                    {
                        return _shipments[i];
                    }
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
      }
    }
