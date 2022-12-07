using System.Diagnostics;

namespace CollectionTest
{
    class Program
    {
        public static  string file1 = Console.ReadLine();
        public static string file = File.ReadAllText(file1);

        static void Main(string[] args)
        {
            Console.WriteLine();
            var stopwatch2 = Stopwatch.StartNew();
            LinkedListTest();
            Console.WriteLine("Время работы LinkedListTest : ");
            Console.WriteLine(stopwatch2.Elapsed.TotalMilliseconds);
            var stopwatch = Stopwatch.StartNew();
            ListTest();
            Console.WriteLine("Время работы List : ");
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();
            //summary
            //я проверил и там и там время с разных программ,запихнул все в одну специально,
            //чтобы не прикреплять две ссылки


        }
        public static string ListTest()
        {
            List<string> list = new List<string>();
            list.Add(file);
            return file;
        }
        public static string LinkedListTest()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst(file);
            return file;
        }
    }
}















//using System;
//using System.Collections.Concurrent;
//using System.Threading;

//namespace StackTest
//{
//    class Program
//    {
//        public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
//            Console.WriteLine();

//            StartQueueProcessing();

//            while (true)
//            {
//                var input = Console.ReadLine();
//                if (input == "peek")
//                {
//                    if (words.TryPeek(out var elem))
//                        Console.WriteLine(elem);
//                }
//                else
//                {
//                    words.Enqueue(input);
//                }
//            }
//        }
//        static void StartQueueProcessing()
//        {
//            new Thread(() =>
//            {
//                Thread.CurrentThread.IsBackground = true;

//                while (true)
//                {
//                    Thread.Sleep(10000);
//                    if (words.TryDequeue(out var element))
//                        Console.WriteLine("======>  " + element + " прошел очередь");
//                }

//            }).Start();
//        }
//    }
//}