using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Collections;



namespace StringApplication

{

    class Program

    {

       static  void Main(string[] args)
        {
            var result= Calculate(1, 0);
            foreach (var item in result)
            {
                Console.WriteLine(item.Date + " Value= " + item.Value + " Remaning" + item.Remaining);
            }

            var result1 = Calculate(1+1, 0);
            foreach (var item in result1)
            {
                Console.WriteLine(item.Date + " Value= " + item.Value + " Remaning" + item.Remaining);
            }
            var result2 = Calculate(1+2, 0);
            foreach (var item in result2)
            {
                Console.WriteLine(item.Date + " Value= " + item.Value + " Remaning" + item.Remaining);

            }
            var result3 = Calculate(1, 1);
            foreach (var item in result3)
            {
                Console.WriteLine(item.Date + " Value= " + item.Value + " Remaning" + item.Remaining);
            }
            Console.WriteLine("--------");
            //var result1 = Calculate(1, 0,1);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.Date + "  " + item.Value + " " + item.Remaining);
            //}


            Console.ReadKey();
            Console.ReadKey();
        }
      
        private static List<Result> Calculate(int n,int startday)
        {
            List<Result> results = new List<Result>();
            int[] capacity = new int[] { 3, 2, 1, 1, 2, 3,1 }; //Days Configuration
            for (int i = startday; n!=0; i++)
            {
                 if (n < capacity[i])
                    {
                        results.Add(new Result() { Date = DateTime.Now.AddDays(i), Value = n, Remaining = capacity[i % 7] - n });
                        return results;
                    }
                    else
                    {
                        results.Add(new Result() { Date = DateTime.Now.AddDays(i), Value = capacity[i % 7], Remaining = 0 });
                        n -= capacity[i];
                    }
               
                
            }
            return results;
        }


    }
public class Result
    {
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public int Remaining { get; set; }
    }

}