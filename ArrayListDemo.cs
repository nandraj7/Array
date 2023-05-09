using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayListDemo
    {
        private Teacher teacher;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public int Salary { get; private set; }

        public void ArrayListTest()
        {
            int[] num = new int[10];
            num[0] = 10;
            num[1] = 20;

            ArrayList arrayList = new ArrayList();

            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(10);

            Console.WriteLine(arrayList.Capacity);

            arrayList.Add(20);
            arrayList.Add("Amit");
            arrayList.Add("Amit1@gmail.com");

            Console.WriteLine(arrayList.Capacity);

            arrayList.Add("20000");

            Console.WriteLine(arrayList.Capacity);

            arrayList.Add("200000");

            Console.WriteLine(arrayList[3]);
            int result = Convert.ToInt32(arrayList[0]) + Convert.ToInt32(arrayList[1]);


            Console.WriteLine(result);


            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(10);
            //arrayList1.Add(20);
            //arrayList1.Add(30);
            //arrayList1.Add(40);

            //arrayList1.Insert(2, 25);

            //arrayList1.RemoveAt(2);

            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}

        }

        public void HastTableTest()
        {
            HashTable hashTable = new HashTable();

            //Console.WriteLine("Name :".GetHashCode());
            //Console.WriteLine("Email :".GetHashCode());

            hashTable.Add("Name :", "Ajay");
            hashTable.Add("Email :", "Ajay2@gmail.com");
            hashTable.Add("Roll No. :", 50);
            hashTable.Add("Age :", 22);
            hashTable.Add("Address :", "Pune");
            hashTable.Add("Aadhar :", "4567 5433 2323");
            hashTable.Add("Pan Card :", "ADHHK5674P");

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in hashTable.Values)
            {
                Console.WriteLine(value);
            }

            //foreach(var key in hashTable.Keys)
            //{
            //    Console.WriteLine(key +" "+ hashTable[key]);
            //}


            //Console.WriteLine(hastTable[2]);


        }

        public void ListDemo()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);

            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            numbers.Insert(2, 25);
            numbers.RemoveAt(3);

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            List<string> Names = new List<string>();
        }

        public void ListDemo1()
        {
            //List<float> number = new List<float>();
            //number.Add(20.33f);
            ////number.Add("abc");
            //int a;


            List<Teacher> teachers = new List<Teacher>();

            Teacher teacher1 = new Teacher(1, "Umesh", "Male", 2000);
            teachers.Add(teacher1);

            Teacher teacher2 = new Teacher(2, "Amol", "Male", 3000);
            teachers.Add(teacher2);

            Teacher teacher3 = new Teacher(3, "Dnyaneshwar", "Male",4400);
            teachers.Add(teacher3);

            Teacher teacher4 = new Teacher(4, "Sumit", "Male", 2300);
            teachers.Add(teacher4);


            teachers.Add(new Teacher(5, "Akshay", "Male", 2400));

            Teacher teacher6 = new Teacher()
            {
                Id = 6,
                Name = "Kiran",
                Gender = "Female",
                Salary = 3400
            };
            teachers.Add(teacher6);

            var teacher7 = new Teacher();
            {
                Id = 7;
                Name = "Rahul";
                Gender = "Male";
                Salary = 4300;
            };




            Teacher Teacher = new Teacher(20, "abc", "Female", 3000);
            teachers.Insert(1, teacher);
            teachers.RemoveAt(3);


            foreach ( var teach in teachers)
            {
                //Console.WriteLine(" Id = " + teacher.Id + " Name = " + teacher.Name + " Gender = " + teacher.Gender);

                //Console.WriteLine($" Id = {teacher.Id} Name = {teacher.Name} Gender = {teacher.Gender} Salary = {teacher.Salary}");

                Console.WriteLine($" Id = {teach.Id} Name = {teach.Name} Gender = {teach.Gender} Salary = {teacher.Salary}");
               
            }

             var maxSalary = teachers.Max(x => x.Salary);
             var minSalary = teachers.Min(x => x.Salary);
             var avgSalary = teachers.Average(x => x.Salary);
             var sumSalary = teachers.Sum(x => x.Salary);


        }

        public void ListDemo2()
        {
            List<int> numbers = new List<int>() {10, 20, 30, 40, 43, 44, 67, 09 };
            int[] num = new int[] { 10, 20, 30, 40, 43, 44, 67, 09 };

            //int max = num[0];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (max < num[i])
            //    {
            //        max = num[i];
            //    }
            //}

            var max = numbers.Max();
            var min = numbers.Min();
            var avg = numbers.Average();
            var sum = numbers.Sum();
            var countArray = numbers.Count();

            Console.WriteLine("Maximum Number = " + max);


            Teacher teacher1 = new Teacher();
            Teacher teacher2 = new Teacher();
            Teacher teacher3 = new Teacher();
            Teacher teacher4 = new Teacher();
            Teacher teacher5 = new Teacher();

            List<Teacher> teachers = new List<Teacher>() { teacher1, teacher2, teacher3, teacher4, teacher5 };
        }

        public void DictionaryDemo()
        {
            Hashtable marksTable = new Hashtable();
            marksTable.Add("History", 56);
            marksTable.Add("Math", 60);
            marksTable.Add("Name", "Sumit");

            Dictionary<string, int> marksheet = new Dictionary<string, int>();

            marksheet.Add("History", 56);
            marksheet.Add("Math 1", 60);
            marksheet.Add("English", 36);
            marksheet.Add("Math 2", 65);

            marksheet.Remove("Math 2");
            //Console.WriteLine(marksheet["math 1"]);


            foreach (var key in marksheet.Keys)
            {
                Console.WriteLine(key + " " + marksheet[key]);
            }


        }
    }

}
