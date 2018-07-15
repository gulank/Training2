using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Pluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

           // ICollection<string> collection = (ICollection<string>) daysOfWeek;
            //Console.WriteLine("Count = " + collection.Count);
            //collection.Add("fghf");

            var presidents = new LinkedList<string>();
            presidents.AddLast("Barack Obama");
            presidents.AddLast("Barack Obama1");
            presidents.AddLast("Barack Obama11");

            LinkedListNode<string> bo = presidents.Find("Barack Obama");

            presidents.AddAfter(bo, "Barack Obam111a");
            foreach (var president in presidents)
            {
                Console.WriteLine(president+"\r\n");
            }



            var books = new Stack<string>();

            books.Push("HAcuna MAtatat");
            books.Push("Allallal");
            books.Push("polalal");
            books.Push("Hanna Montana");


            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\r\n");

            var tasks = new Queue<string>();

            tasks.Enqueue("Do the prannie");
            tasks.Enqueue("Do the prasowanie");
            tasks.Enqueue("DO the zmywanie");
            tasks.Enqueue("Do the ciasto");
            tasks.Dequeue();

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            string b = "zmienna1";
            string c = "zmienna2";
            Console.WriteLine("coco {0} coco {1} coco.", b, c);
           // Console.WriteLine(presidents.Capacity);
            //var copy = new ReadOnlyCollection<string>(presidents);
           // copy.RemoveRange(0,3);

            //presidents.CollectionChanged += OnCollectionChanged;

            //presidents.RemoveAt(0);
            //foreach (var president in presidents)
            //{
            //    Console.WriteLine(president);
            //}
            //Console.WriteLine(presidents.IndexOf("Ronald Regan"));

            
            //int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");
            //int indexOfW = Array.FindLastIndex(daysOfWeek, x => x[0] == 'S');
            //string [] allWith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);
            // foreach (var item in allWith6Chars)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine(indexOfTuesday);
            // Console.WriteLine(daysOfWeek[indexOfTuesday]);
            // Console.WriteLine(indexOfW);
            // Console.WriteLine(daysOfWeek[indexOfW]+ "\r\n");

            // MakeDaysOfWeekPlural(daysOfWeek);
            //StringLengthComparer comparer = new StringLengthComparer();
            //Array.Sort(daysOfWeek, comparer);
            //int indexOfSun = Array.BinarySearch(daysOfWeek, "Sunday");

            // foreach (var day in daysOfWeek)
            // {
            //     Console.WriteLine(day);
            // }

            // Console.WriteLine("Index is: "+ indexOfSun);
            Console.ReadKey();
        }

        //    static string [] MakeDaysOfWeekPlural(string[] daysOfWeek)
        //    {
        //        for (int i = 0; i < daysOfWeek.Length; i++)
        //        {
        //            // string day = daysOfWeek[i];
        //            //day = day + "s";

        //            daysOfWeek[i] += "s";

        //        }

        //        return daysOfWeek;

        //    }
        //}

        class StringLengthComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

        }
    }
}
