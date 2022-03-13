using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI___InleverOpdrachten___1
{
    public static class Opgave2
    {

      
            public static Queue<int> Opdr2aQueue50()
        {
            int x = 50;
            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= x; i++)
            {
                q.Enqueue(i);
                //Console.WriteLine(i); controle 
            }
            return q;
        }

        public static Stack<int> Opdr2bStackFromQueue(Queue<int> q)
        {
            Stack<int> stack = new Stack<int>();

            // oude sloppy code: 

            //foreach (var item in q)
            //{
            //    if(item % 4 == 0)
            //    {
            //        stack.Push(item);
            //    }
            //    //Console.WriteLine(item); // controle of item wel werkt.
            //}
            //while(q.Count > 0)
            //{
            //    q.Dequeue();
            //}



            // nettere code: 

            while(q.Count > 0)
            {
                int i = q.Peek();

                if (i % 4 == 0)
                {
                    stack.Push(i);
                }
                q.Dequeue();
            }

            // Controle of alles wat in de stack zit deelbaar is door 4: 

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            return stack;
        }



    }
}
