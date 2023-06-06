using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Peach
{
    internal class TipoDeCaixa
    {
        private String _name;
        private String _size;
        private String _availability;
        private String _pricekg;

        public String Name { get { return _name; } set { _name = value; } }
        public String Size { get { return _size;} set { _size = value; } }
        public String Availability { get { return _availability;} set { _availability = value; } }
        public String PriceKg { get { return _pricekg; } set { _pricekg = value; } }

        public override string ToString()
        {
            return String.Format("{0,-30} {1,10} {2,4} {3,10}", _name, _size, _availability, _pricekg);
        }
    }
}
