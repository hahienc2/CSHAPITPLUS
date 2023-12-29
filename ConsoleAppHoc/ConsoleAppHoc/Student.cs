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
        private string _name;
        public string name
        {
            get { 
            return _name;   
            }
            private set { 
                if(value.Length> 0)
                {
                    _name = value;
                }
            }
            }
        string _class;
       GENDER gender;
        float score;

        public enum GENDER {
            male = 100, 
            female = 200,
            bi = 300}

        public Student(int id, string name, string @class, GENDER gender, float score)
        {
            this.id = id;
            this._name = name;
            this._class = @class;
            this.gender = gender;
            this.score = score;
        }
        public Student()
        {
            this.id = 0;
            this._name = "Hoang";
            this._class = "1A";
            this.gender = GENDER.male;
            this.score = 8;
            GENDER.male.ToString();
            int male = (int)GENDER.male;
            GENDER malez = (GENDER)100;


        }
    }
}
