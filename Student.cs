using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11;

internal class Student
{
    string groupNo;
    string fullName;
    static int _id;
    
    public int Id { get; }
    public string Fullname { get; set; }
    public string GroupNo { get; set; }
    public byte Age { get; set; }

    public Student(string fullName,string groupNo,byte age)
    {
        Fullname = fullName;
        GroupNo = groupNo;
        Age = age;
        Id = _id;
        _id++;
    }
}
