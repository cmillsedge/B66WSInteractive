using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;
using BR.Ord.Model;
using BR.Ord.Api;


namespace BR6WSInteractive
{
     public class BROrderWrapper
    {
        private Session _session;
        private string _url;
        public BROrderWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
            _url += "/ordering";
        }
        public BROrderWrapper()
        {
        }


        public OrderTypeArray GetAllOrderTypes()
        {
            OrderTypeApi ordAPI = new OrderTypeApi(_url);
            OrderTypeArray myTypes = ordAPI.OrderTypeList(_session.SessionKey);              
            return myTypes;
        }

        public OrderType GetOrderType(string orderType)
        {
            OrderTypeApi ordAPI = new OrderTypeApi(_url);
            OrderType myType = ordAPI.OrderTypeGet(_session.SessionKey, orderType);
            return myType;
        }

        public Order GetOrder(string order)
        {
            OrderApi ordAPI = new OrderApi(_url);
            Order myOrder = ordAPI.OrderFind(_session.SessionKey, order);
            return myOrder;
        }

        public Order CreateOrder(Order order)
        {
            OrderApi ordAPI = new OrderApi(_url);
            Order myOrder = ordAPI.OrderCreate(_session.SessionKey, order);
            return myOrder;
        }

        public OrderCheck CheckOrder(Order order)
        {
            OrderApi ordAPI = new OrderApi(_url);
            OrderCheck myOrder = ordAPI.OrderCheck(_session.SessionKey, order);
            return myOrder;
        }

        public Order UpdateOrderState(string order, string state)
        {
            OrderApi ordAPI = new OrderApi(_url);
            Order myOrder = ordAPI.OrderUpdateState(_session.SessionKey, order, state);
            return myOrder;
        }

        public OrderItemArray UpdateOrderItems(OrderItemBulk oItems)
        {
            OrderItemApi oItemAPI = new OrderItemApi(_url);
            OrderItemArray myItems = oItemAPI.OrderItemSave(_session.SessionKey, oItems);
            return myItems;
        }

        public Shipment DispatchContainers(Shipment shipment)
        {
            ShipmentApi shipAPI = new ShipmentApi(_url);
            Shipment myShip = shipAPI.ShipmentDispatch(_session.SessionKey, shipment);
            return myShip;
        }

        public void ReceiveContainers(string barcodes, string location)
        {
            ShipmentApi shipAPI = new ShipmentApi(_url);
            BR.Ord.Model.NamedArray itemsReturn = shipAPI.ShipmentReceipt(_session.SessionKey, barcodes, location);
        }


    }
}
