using System;
using System.Collections.Generic;
using System.Text;

namespace _28mart
{
    class Group
    {
        public Group( int no,int studentlimit)
        {
            this.No = no;
            this.StudentLimit = studentlimit;
        }
        public int No;
        public int StudentLimit;
        public Student[] Students;
        int j = 0;
        public void AddStudent(Student students)
        {

            Students[j++] = students;

        }
        public Student[] GetName(string fullname)
        {
            int count = 0;
            foreach (var item in Students)
            {
               
                    if (item.FullName == fullname)
                    {
                        count++;
                    }
                
            }
        }
        public Student[] GelFilteredPoint(int minprice, int maxprice)
        {
            int count = 0;
            foreach (var item in Students)
            {
                if (item != null)
                {
                    if (item.AvgPoint > minprice && item.AvgPoint < maxprice)
                    {
                        count++;
                    }
                }
            }
            Student[] newarr = new Student[count];
            int z = 0;
            foreach (var item in Students)
            {
              
                    if (item.AvgPoint > minprice && item.AvgPoint < maxprice)
                    {
                        newarr[z++] = item;
                    }
                
            }
            return newarr;
        }
    }
}
      
