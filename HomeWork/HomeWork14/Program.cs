using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>()
            {
                "Parviz",
                "Iria",
                "Peter",
                "Asghar",
                "Pangoiler",
                "Arin",
                "Asghr"
            };
            //lst=lst.Where(x=>x.Substring(0,2)=="Pa").ToList();

            // lst.ForEach(x=>)
            //   System.Console.WriteLine(v);
            // lst.RemoveAt(lst.FindIndex(x=>x.Substring(0,2)=="Pa"));
            lst.RemoveAll(y => y.Where(x => x[0] == 'P' && x[1] == 'a'));
            // lst.ForEach(x=>lst.RemoveAt());
            // lst.RemoveAt(lst.Where(x=>x.Substring(0,2)=="Pa"));
            // lst.RemoveAt(lst.ForEach(x=>x.Where(y=>y.ToString().Substring(0,2)=="Pa")));
            // lst.ForEach(t=>System.Console.WriteLine(t));
            // var r=lst.FindIndex(x=>x.Contains('a'));
            System.Console.WriteLine(lst.Count());
            foreach (var item in lst)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
