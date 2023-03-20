using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class ThreadDemo
{
    public void FirstThread()
    {
      
            Console.WriteLine("My Thread");
        
    }
}
class Sample
{
    public static void Main()
    {
        Thread th = Thread.CurrentThread; 
        th.Name= "main";//naming thread
        Console.WriteLine(th.Name);
        Console.WriteLine(th.IsAlive);//checking current thread status
        Console.WriteLine(th.Priority);
   //creating thread
        Thread t1 = new Thread(method1);
        t1.Name = "thread1";
      
        Thread t2 = new Thread(method2);
        t2.Name = "thread2";

        Thread t3 = new Thread(method3);
        t3.Name = "thread3";
        t1.Start();
        t2.Start();
        t3.Start();

     static void method1()
        {
            Console.WriteLine("This is method 1 with " + Thread.CurrentThread.Name);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("HELLO");
            }
            Console.WriteLine("Method1 completed");

        }
     static void method2()
        {
            Console.WriteLine("Method 2 started with " + Thread.CurrentThread.Name);
            int sum = 0;
            Thread.Sleep(2000);
            for(int i = 0; i < 50; i++)
            {
                sum = sum + 1;
            }
            Console.WriteLine(sum);
            Console.WriteLine("Method2 completed");
        }
     static void method3()
        {
            Console.WriteLine("This is method 3 with " +Thread.CurrentThread.Name);
            Console.WriteLine("Method3 completed");
        }

        Console.Read();
    }
}