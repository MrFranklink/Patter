using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int[] Marks { get; set; } = new int[4];
        public void GetDetails()
        {
            int total = Marks.Sum();
            double average = total / 4.0;
            string res;
            if (average > 60) res = "First Division";
            else if (average > 50 && average <= 60) res = "Second Division";
            else res = "Fail";

            Console.WriteLine($"ID: {StudentId}, Name: {StudentName}, Marks: {string.Join(", ", Marks)}, Result: {res}");
        }


        public void getbyId(Student[] s, int id)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].StudentId == id)
                {
                    s[i].GetDetails();
                    break;
                }
            }
        }

        public void GetFirstClassDet(Student[] s1)
        {
            foreach (var s in s1)
            {
                if (s.Marks.Average() > 60)
                {
                    s.GetDetails();
                }
            }
        }

        public void GetByChar(Student[] s, char ch)
        {
            foreach (var st in s)
            {
                if (st.StudentName.StartsWith(ch.ToString()))
                {
                    st.GetDetails();
                }
            }
        }
    }
}
