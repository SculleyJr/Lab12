using System;
namespace Lab12
{
    public  class  Person
    {
        private string _name { get; set; }
        private string _address { get; set; }

        public  Person(string name,string address)
        {
            _name = name;
            _address = address;
            
        }

        public override string  ToString()
        {

               return $"{_name},{_address}";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}