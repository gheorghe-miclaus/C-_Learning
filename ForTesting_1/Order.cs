using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ns_Order
{ 
    public class Order
    {
        private string _item;
        public Order(string item, DateTime date)
        {
            _item = item;
            _date = date;
        }

        public string Item {
            get => _item;
            private set
            { 
                _item = value;
            }
        }

        private DateTime _date;

        public DateTime Date 
        {
            get => _date;

            set 
            { 
                if(value.Year == DateTime.Now.Year)
                {
                    _date = value;
                }
                            
            }
        
        }
    }

    public class Order_2
    {
        public Order_2(string item, DateTime date)
        {
            Item = item;
            Date = date;
        }

        public string Item { get; }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Year == DateTime.Now.Year)
                {
                    _date = value;
                }
                
            }
        }

    }
}
