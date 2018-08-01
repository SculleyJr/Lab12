using System;
namespace Lab12
{
    public class Staff : Person
    {
        private string _school { set; get; }
        private double _pay { set; get; }

        public Staff()
        {

        }
        public Staff(string name, string address) : base(name, address)
        {

        }
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            _school = school;
            _pay = pay;
        }
        public override string ToString()
        {
            return $"{GetName()}, {GetAddress()},{_school},${_pay}/year";
        }
    }
}