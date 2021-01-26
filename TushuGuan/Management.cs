using System;
using System.Collections.Generic;
using System.Text;

namespace TushuGuan
{
    public class Management
    {
        List<Student> Students { get; set; }

        List<Book> Books { get; set; }

        public Management()
        {
            Students = new List<Student>();
            Books = new List<Book>();
        }
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="studentId">学生ID</param>
        public void AddStudent(string studentId)
        {
            //新建学生
            Student student = new Student
            {
                StudentID = studentId
            };
            //添加学生到学生列表
            Students.Add(student);

        }
        public void Addbook(string iSBN)
        {
            Book book = new Book
            {
                ISBN = iSBN,
                StudentID = ""
            };
            Books.Add(book);
        }
        public void RemoveStudent(string studentId)
        {
            //遍历学生列表
            for(int i=0;i<Students.Count;i++)
            {
                //判断是否匹配
                if(Students[i].StudentID==studentId)
                {
                    Students.RemoveAt(i);
                }
            }
        }
        public void RemoveBook(string iSBN)
        {
            for(int i = 0;i<Books.Count; i++)
            {
                if(Books[i].ISBN==iSBN)
                {
                    Books.RemoveAt(i);
                }
            }
        }
    }
}
