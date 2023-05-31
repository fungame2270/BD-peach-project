using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Peach
{
    internal class Variadade
    {
        private String _code;
        private String _name;
        private String _season;
        private String _trees;
        private String _available;

        public String Code { set { _code = value; } get { return _code; } }
        public String Name { set { _name = value;} get { return _name; } }
        public String Season { set { _season = value;} get { return _season; } }
        public String Trees { set { _trees = value;} get { return _trees; } }
        public String Available { set { _available = value;} get { return _available;} }

        public override string ToString()
        {
            return String.Format("{0,-30} {1,10} {2,4} {3,10}", _name, _season, _trees, _available);
        }
    }
}
