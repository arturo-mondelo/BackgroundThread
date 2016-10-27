using System;
using System.Threading;

namespace BackgroundThread
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
        
        }
    }
    public static void Main()
    {
        Thread t = new Thread(new ThreadStart(ThreadMethod));
        //t.IsBackground = true app sale al momento. = false crea un foreground thread e imprime el mensaje
        t.IsBackground = false;
        t.Start();
    }
}
}

