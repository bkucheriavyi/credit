using System;
using System.Linq;

namespace credit.strat
{

    partial class Program
    {
        static void Main(string[] args)
        {
            var models = new ModelGenerator().GetModels(5500, new ModelSettings { Fee = 10, MinPayment = 4 });

            var simulator = new Simulator();
            var result = models.Select(m => simulator.Simulation(5500, m)).OrderByDescending(r => r.PercentageSurplus);

            foreach (var res in result)
            {
                Console.WriteLine($"Count: {res.Payments.Count()},Surplus: {res.PercentageSurplus}");
                ShowDetails(res);
            }
        }

        private static void ShowDetails(SimulationResult res)
        {
            foreach(var payment in res.Payments) 
            {
                Console.WriteLine($"{payment.Rate}: {payment.Current}, {payment.Next}");
            }
        }

    }
}



