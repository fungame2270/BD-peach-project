using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace UI_Peach
{
    internal class Reservation
    {
        private String _id;
        private String _storeName;
        private String _storeID;
        private String _Date;
        private String _quantaty;

        public String ID { get { return _id; } set { _id = value; } }
        public String StoreName { get { return _storeName;} set { _storeName = value; } }
        public String StoreId { get { return _storeID; } set { _storeID = value; } }
        public String Date { get { return _Date;} set { _Date = value; } }
        public String Quantaty { get { return _quantaty; } set { _quantaty = value; } }

        public override string ToString()
        {
            return String.Format("{0,-25} {1,11} {2,8}", _storeName, _Date, _quantaty);
        }

    }
}
