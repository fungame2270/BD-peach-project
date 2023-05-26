using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Peach
{
    [Serializable()]
    public class Store
    {
        private String _id;
        private String _name;
        private String _address;
        private String _email;
        private String _phone;
        private String _nif;

        public String Id { get { return _id; } set { _id = value; } }
        public String Name { get { return _name;} set { _name = value; } }
        public String Address { get { return _address;} set { _address = value; } }
        public String Email
        {
            get
            {
                if (_email != "")
                    return _email;
                else
                    return "Unknown";
            }
            set { _email = value; } 
        }
        public String Phone { get { return _phone;} set { _phone = value; } }
        public String Nif 
        { 
            get 
            {
                if (_nif != "")
                    return _nif;
                else 
                    return "Unknown";
            } 
            set { _nif = value; } 
        }

        public override string ToString()
        {
            return _name;
        }

        public Store() : base() { }




    }
}
