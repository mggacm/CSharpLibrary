using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersAndSetters
{
    class Employees
    {

        private string _name;

        public  string Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The Employee is not vaild");  //throw
                _name = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set {
                if (Id <= 0)
                    throw new Exception("The Employee ID is not vaild");
                _id = value; }
        }


    }
}
