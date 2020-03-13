using System;
using System.Collections.Generic;
using System.Text;

namespace NoobApp
{
    public class Student
    {
        private int _id;
        public int id { get { return _id; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Внимание Некоторые id внесены с отрицательными значениями!" +
                        "и не будут активированны!");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
