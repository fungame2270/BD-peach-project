using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Peach
{
    internal class Sale
    {
        private String _storeName;
        private String _storeId;
        private String _id;
        private String _Date;
        private String _State;
        private String _Price;

        public Sale() { }

        public String StoreName { get { return _storeName; } set { _storeName = value; } }
        public String StoreId { get { return _storeId;} set { _storeId = value; } }
        public String Id 
        { get { return _id;}
            set
            {
                _id = value;
            } 
        }  
        public String Date { get { return _Date;} set { _Date = value; } }
        public String State 
        { get { return _State;}
            set
            {
                _State = value;
            } }
        public String Price { get { return _Price;} set { _Price = value; } }

        public override string ToString()
        {
            return String.Format("{0,-25} {1,11} {2,8} {3,7}", _storeName, _Date, _State,_Price);
        }
    }
}
