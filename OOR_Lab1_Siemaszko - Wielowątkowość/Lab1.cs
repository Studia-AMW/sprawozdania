using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
			ThreadStart watek_1 = new ThreadStart(new Program().thread_1);
            Thread thread_1 = new Thread(watek_1);
            thread_1.Start();

            ThreadStart watek_2 = new ThreadStart(new Program().thread_2);
            Thread thread_2 = new Thread(watek_2);
            thread_2.Start();
						
            ThreadStart watek_3 = new ThreadStart(new Program().thread_3);
            Thread thread_3 = new Thread(watek_3);
            thread_3.Start();
			
            ThreadStart watek_4 = new ThreadStart(new Program().thread_4);
            Thread thread_4 = new Thread(watek_4);
            thread_4.Start();
        }
		public void thread_1()
        {           
            int i_1=0;
			for (i_1 = 1 ; i_1 < 50 ; i_1++)
            {
                Console.WriteLine("Ilość wywołań wątka 1: " + i_1);
                Thread.Sleep(1000);
            }
        }
		
		public void thread_2()
        {           
            int i_2=0;
			for (i_2 = 1 ; i_2 < 50 ; i_2++)
            {
                Console.WriteLine("Ilość wywołań wątka 2: " + i_2);
                Thread.Sleep(1000);
            }
        }
		
		public void thread_3()
        {           
            int i_3=0;
			for (i_3 = 1 ; i_3 < 50 ; i_3++)
            {
                Console.WriteLine("Ilość wywołań wątka 3: " + i_3);
                Thread.Sleep(1000);
            }
        }
		
		public void thread_4()
        {           
            int i_4=0;
			for (i_4 = 1 ; i_4 < 50 ; i_4++)
            {
                Console.WriteLine("Ilość wywołań wątka 4: " + i_4);
                Thread.Sleep(1000);
            }
        }
		
    }
}
