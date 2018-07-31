using System;

namespace Lab12
{
    public  class Student : Person
    {
        private string _program { get; set; }
        private int _year { get; set; }
        private double _fee { get; set; }


        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        public override string ToString()
        {
           return  ($"{GetName()}, {GetAddress()},{_program},{_year},${_fee}K");
        }




    }
}