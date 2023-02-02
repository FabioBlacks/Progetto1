using System;

namespace Training
{
    internal partial class Program
    {
        public class Person 
        {
            private DateTime _birthdate;             

            public DateTime Birthdate
                { 
                get { return _birthdate; }
                private set { _birthdate = value; }
            }

            public int Age 
            {
                get 
                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days / 365;
                    return years;
                }
            }

            public Person(DateTime birthdate)
            {
                Birthdate = birthdate;
            }
        }
    }
}
