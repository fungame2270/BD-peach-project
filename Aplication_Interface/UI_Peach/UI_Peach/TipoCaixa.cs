using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace UI_Peach
{
    internal class TipoCaixa
    {
        private String _reservation;
        private String _Vcode;
        private String _Vname;
        private String _size;
        private String _quantaty;
        private String _pricekg;

        public String reservation { get { return _reservation; } set { _reservation = value; } }
        public String Vcode { get { return _Vcode;} set { _Vcode = value; } }
        public String Size { get { return _size; } set { _size = value; } }
        public String Quantaty { get { return _quantaty;} set { _quantaty = value; } }
        public String PriceKg { get { return _pricekg; } set { _pricekg = value; } }
        public String Vname { get { return _Vname; } set { _Vname = value;} }

        public override string ToString()
        {
            return String.Format("{0,-25} {1,11} {2,8} {3,7}", _Vname, _size, _quantaty, _pricekg);
        }
    }
}
