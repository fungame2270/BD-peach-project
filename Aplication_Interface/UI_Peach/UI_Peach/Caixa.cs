using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Peach
{
    internal class Caixa
    {
        private String _vendaID;
        private String _caixaID;
        private String _Variadade;
        private String _size;
        private String _weight;
        private String _price;

        public Caixa() { }

        public String VendaID { get { return _vendaID; } set { _vendaID = value; } }
        public String CaixaID { get { return _caixaID; } set { _caixaID = value; } }
        public String Variedade { get { return _Variadade; } set { _Variadade= value; } }
        public String Size { get { return _size;} set { _size = value; } }

        public String Weight { get { return _weight;}
            set
            {
                _weight = value;
            }
        }
        public String Price { get { return _price;}
            set
            {
                _price = value;
            } 
        }

        public override string ToString()
        {
            return String.Format("{0,-25} {1,-7} {2,5} {3,6}",_Variadade,_size,_weight, _price);
        }
    }
}
