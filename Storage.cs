using NoobApp;
using System;
using System.Collections.Generic;

public class Storage
{
    Dictionary<int, Student> record;

    internal Storage()
    {
        record = new Dictionary<int, Student>();
    }

    protected internal void InitTestRecs()
    {
        Student student1 = new Student()
        {
            id = 01,
            Name = "Клим " +
                "Арбузов",
            Score = 13
        };
        Student student2 = new Student()
        {
            id = 02,
            Name = "Платон " +
            "Звонков",
            Score = 14
        };
        Student student3 = new Student()
        {
            id = 03,
            Name = "Кирилл " +
            "Кольцов",
            Score = 15
        };
        Student student4 = new Student()
        {
            id = 04,
            Name = "Зыков " +
            "Денис",
            Score = 13
        };

        record.Add(student1.id, student1);
        record.Add(student2.id, student2);
        record.Add(student3.id, student3);
        record.Add(student4.id, student4);
    }

    public Student GetStudentById(int id)
    {
        Student result = null;

        try
        {
            result = record[id];
        }
        catch (KeyNotFoundException)
        {
            // No-Op
        }

        return result;
    }
}
