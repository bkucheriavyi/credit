using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace credit.strat
{
    public class ModelGenerator
    {
      
        public List<SimulationModel> GetModels(double amount, ModelSettings settings)
        {
            var the_longest_ten_percent = new double[] { amount / 100 * settings.MinPayment };
            var the_shortest_half_percent = new double[]  { amount / 100 * 50 };

            var temaplate_1 = new double[] { 1500, 1000 };
            var temaplate_2 = new double[] { 1500, 1000, 3000 };
            var temaplate_3 = new double[] { 1500, 1000, 2500, 3000 };

            var templated = new double[][] {
                the_longest_ten_percent,
                the_shortest_half_percent
            };

            return templated.SelectMany(l => CombinationSum(l, amount))
                            .Select(c => new SimulationModel { Payments = c, Fee =settings.Fee })
                            .ToList();
        }

        public double[][] CombinationSum(double[] candidates, double target)
        {
            Array.Sort(candidates);
            return CombinationSumRecursion(candidates, target, 0);
        }

        public double[][] CombinationSumRecursion(double[] candidates, double target, int index)
        {
            var res = new List<double[]>();
            if (target == 0)
            {
                res.Add(new double[]{});
                return res.ToArray();
            }
            if (target < 0)
            {
                return res.ToArray();
            }

            for (int i = index; i < candidates.Count() && target >= candidates[i]; i++)
            {
                var choose = candidates[i];
                var restCombinationSum = CombinationSumRecursion(candidates, target - choose, i);

                foreach (var listofcombination in restCombinationSum)
                {
                    var list = new double[] { choose };
                    res.Add(list.Concat(listofcombination).ToArray());
                }
            }

            return res.ToArray();
        }

    }
}