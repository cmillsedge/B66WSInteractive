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
        }
        public BROrderWrapper()
        {
        }


        public OrderTypeArray GetAllOrderTypes()
        {
            OrderTypeApi ordAPI = new OrderTypeApi();
            OrderTypeArray myTypes = ordAPI.OrderTypeList(_session.SessionKey);              
            return myTypes;
        }

        public OrderType GetOrderType(string orderType)
        {
            OrderTypeApi ordAPI = new OrderTypeApi();
            OrderType myType = ordAPI.OrderTypeGet(_session.SessionKey, orderType);
            return myType;
        }

        public Order GetOrder(string order)
        {
            OrderApi ordAPI = new OrderApi();
            Order myOrder = ordAPI.OrderFind(_session.SessionKey, order);
            return myOrder;
        }

        public Order UpdateOrderState(string order)
        {
            OrderApi ordAPI = new OrderApi();
            Order myOrder = ordAPI.OrderGet(_session.SessionKey, order);
            return myOrder;
        }

        public OrderItemArray UpdateOrderItems(OrderItemArray oItems)
        {
            OrderItemApi oItemAPI = new OrderItemApi();
            OrderItemArray myItems = oItemAPI.OrderItemSave(_session.SessionKey, oItems);
            return myItems;
        }


    }
}
