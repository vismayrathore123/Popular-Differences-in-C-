using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_Singleton
{
   public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                VoteMachine.RegisterVote();
            });
            Console.WriteLine(VoteMachine.TotalVotes);
            Console.ReadLine();
        }
    }
}
