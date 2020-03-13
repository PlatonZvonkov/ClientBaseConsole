using System;
using System.Collections.Generic;
using System.Text;

namespace NoobApp
{
    class Program
    {
        Storage studentDB;

        public static void Main()
        {
            Program p = new Program();

            p.Init();

            p.MainLoop();
        }

        void Init() {
            studentDB = new Storage();
            studentDB.InitTestRecs();
        }

        void MainLoop() {
            while (true) {

                Console.Write("Введите ваш ID: ");
                var input = Console.ReadLine();
                Student student = FindStudent(input);
                if (student == null) {
                    Console.WriteLine("Вы не в базе данны");
                } else {
                    Console.WriteLine("Здравствуйте {1}, ваш нынешний счет {2}", student.id, student.Name, student.Score);
                }

            }
        }

        public Student FindStudent(string rawid) {
            int id = -1;
            Int32.TryParse(rawid, out id);

            return studentDB.GetStudentById(id);
        }
    }
}