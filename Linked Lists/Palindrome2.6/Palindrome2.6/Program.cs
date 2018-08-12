using System;
using System.Collections.Generic;
using System.Collections;

namespace Palindrome2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList<char> lista = new LinkedList<char>();
            lista.AddLast('a');
            lista.AddLast('n');
            lista.AddLast('i');
            lista.AddLast('t');
            lista.AddLast('a');
            lista.AddLast('l');
            lista.AddLast('a');
            lista.AddLast('v');
            lista.AddLast('a');
            lista.AddLast('l');
            lista.AddLast('a');
            lista.AddLast('t');
            lista.AddLast('i');
            lista.AddLast('n');
            lista.AddLast('a');


            Console.WriteLine(palindrome(lista));
        }
        public static bool palindrome(LinkedList<char> lista)
        {
            LinkedListNode<char> first = lista.First;
            LinkedListNode<char> last = lista.Last;
            while(first!=null)
            {
                if(first.Value!=last.Value)
                {
                    return false;
                }
                first = first.Next;
                last = last.Previous;
            }
            return true;
        }
    }
}
