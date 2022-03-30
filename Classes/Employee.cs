using System;

namespace Classes
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && HasOnlyLetter(value) && char.IsUpper(value[0]))
                {
                    _name = value;
                }
            }
        }

        public string Surname
        {
            get => _surname;
          
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && HasOnlyLetter(value) && char.IsUpper(value[0]))
                {
                    _surname = value;
                }
            }

        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
            }
        }

        
        static bool HasOnlyLetter(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (!char.IsLetter(item))
                {
                    count++;
                }
            }
            if (count == 0 && char.IsUpper(str[0]))
            {
                return true;
            }
            return false;
        }


    }
}
