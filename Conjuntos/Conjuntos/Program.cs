using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------
            //   HASHSET
            //-----------------------------------------------------------------------
            HashSet<string> set = new HashSet<string>();

            set.Add("Teste");
            set.Add("Teste1");
            set.Add("Teste2");
            set.Add("Teste2");
            set.Add("Teste3");
            set.Add("Teste4");

            Console.WriteLine(set.Contains("Teste"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            //-----------------------------------------------------------------------
            //   SORTEDSET
            //-----------------------------------------------------------------------
            SortedSet<int> a = new SortedSet<int>() { 0,5,4,6,9,7,1};

            SortedSet<int> b = new SortedSet<int>() { 5,2,9,3};
            
            //uniao
            SortedSet<int> c = new SortedSet<int>(a);

            c.UnionWith(b);

            PrintCollection(c);

            Console.WriteLine("");

            //intersecao
            SortedSet<int> d = new SortedSet<int>(a);

            d.IntersectWith(b);

            PrintCollection(d);

            Console.WriteLine("");

            //diferença
            SortedSet<int> e = new SortedSet<int>(a);

            e.ExceptWith(b);

            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
