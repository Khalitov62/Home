using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    internal class Students
    {
        public static int _id { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        private static int _count = 1000;
        public int Count;


        public Students(string fullName, string subject)
        {
            _count++;
            Count = _count;
            _id++;
            Id = _id;
            FullName = fullName;
            Subject = subject;
        }

        public string GetName(string subject)
        {
            return char.ToUpper(subject[0]) + char.ToUpper(subject[1]).ToString();
        }
        
    }
}
