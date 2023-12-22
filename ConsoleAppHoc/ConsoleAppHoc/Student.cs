using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHoc
{

    internal class Student
    {
        int id;
        string name;
        string _class;
       GENDER gender;
        float score;

        public enum GENDER {
            male, 
            female,
            bi}

        public Student(int id, string name, string @class, GENDER gender, float score)
        {
            this.id = id;
            this.name = name;
            this._class = @class;
            this.gender = gender;
            this.score = score;
        }
        public Student()
        {
            this.id = 0;
            this.name = "Hoang";
            this._class = "1A";
            this.gender = GENDER.male;
            this.score = 8;
        }
    }
}
