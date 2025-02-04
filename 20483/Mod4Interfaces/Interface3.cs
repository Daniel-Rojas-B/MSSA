using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfaces
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal interface ICRUD<T>
    {
        void Create(T obj);
        IList<T> GetAll();
        void Update(T obj);
        void Delete(T obj);

    }
    class DataOperations : ICRUD<Student>
    {
        static List<Student> students = new List<Student>();
        public void Create(Student obj)
        {
            students.Add(obj);
            throw new NotImplementedException();
        }

        public void Delete(Student obj)
        {   
            students.Remove(obj);
            throw new NotImplementedException();
        }

        public IList<Student> GetAll() // read function 
        {
            return students;
            throw new NotImplementedException();
        }

        public void Update(Student obj)
        {

            throw new NotImplementedException();
        }

    }
}
