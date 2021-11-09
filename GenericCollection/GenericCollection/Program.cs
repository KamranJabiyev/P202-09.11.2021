using GenericCollection.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Student s1 = new Student("Vugar", "Bala", 22);
            //Student s2 = new Student("Nigar", "Bala", 19);
            //Student s3 = new Student("Qudret", "Bala", 25);
            //Student[] arr = { s1, s2, s3 };
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generic
            //MyList intList = new MyList();
            //intList.Add(5);
            //intList.Add(15);
            //intList.Add(25);
            //intList.Add("gdgh");
            //intList.Add(false);
            //MyList strList = new MyList();
            //strList.Add("asaf");
            //MyList<int,object> intList = new MyList<int,object>();
            //intList.Add(10);
            //MyList<string,object> strList = new MyList<string, object>();
            //strList.Add("Tural");
            //MyList<Student,IComparable> stList = new MyList<Student, IComparable>();
            //stList.Add(new Student());
            #endregion

            #region Collection
            #region Non-generic
            //ArrayList arrList = new ArrayList();
            //arrList.Add("str");
            //arrList.Add(10);
            //arrList.Add(true);
            //arrList.Add(new Student("Revan","Bala",19));
            //arrList.Clear();
            //arrList.Remove(10);
            //arrList.RemoveAt(0);
            //arrList.Reverse();
            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generic
            #region List
            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(15);
            //numbers.Add(0);
            //numbers.Add(0);
            //numbers.Add(-5);
            //numbers.Remove(0);
            //Console.WriteLine(numbers.Contains(15));
            //numbers.Clear();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO,Queue - FIFO
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Shahnaz");
            //queue.Enqueue("Vugar");
            //queue.Enqueue("Orxan");

            //Console.WriteLine("Ilk shexs:");
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine("Getdi:");
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Novbedekiler:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);

            //Console.WriteLine("Ilk shexs:");
            //Console.WriteLine(numbers.Peek());
            //Console.WriteLine("Getdi:");
            //Console.WriteLine(numbers.Pop());
            //Console.WriteLine("Novbedekiler:");
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            SortedList<string, string> phones = new SortedList<string, string>();
            phones.Add("Kamran", "+994512373434");
            phones.Add("Nursultan", "+994707646668");
            phones.Add("Ramal", "+994557382270");
            Console.WriteLine(phones["Kamran"]);
            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}
            #endregion
            #endregion
            #endregion
        }
    }

    #region Generic
    class MyList<T,U>
        //where T: class,U,new()
        //where T:struct,IComparable
        //where T:IComparable
        //where T:new()
        //where T:class
        //where T:struct
    {
        private T[] list;
        public MyList()
        {
            list = new T[0];
        }

        public void Add(T elm)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = elm;
        }
    }

    //class MyList
    //{
    //    private object[] list;
    //    public MyList()
    //    {
    //        list = new object[0];
    //    }

    //    public void Add(object elm)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = elm;
    //    }
    //}
    #endregion
}
