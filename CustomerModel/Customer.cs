using System;

namespace CustomerModel
{
    public class Customer
    {
        private readonly int _status;
        private readonly int _id;
        private readonly string _name;

        private int Id
        {
            get { return _id; }
        }

        private string Name
        {
            get { return _name; }
        }

        private int Status
        {
            get { return _status; }
        }


        public Customer(int status, string name, int id)
        {
            _status = status;
            _name = name;
            _id = id;
        }

        public void GetCustumerName(int id)
        {
            
        }
    }
}
