using System.Collections.Generic;
using System.Linq;

namespace credit.strat
{
    partial class Program
    {
        public class Simulator
        {
            public SimulationResult Simulation(double tartgetAmount, SimulationModel model)
            {
                double current = tartgetAmount;

                var payments = new List<Payment>();

                foreach (var payment in model.Payments)
                {
                    var reducedByPayment = current - payment;
                    var next = reducedByPayment + (reducedByPayment / 100 * model.Fee);
                    payments.Add(new Payment { Rate = payment, Current = current, Next = next });
                    current = next;
                }

                return new SimulationResult
                {
                    Payments = payments,
                    Surplus = current,
                    PercentageSurplus = current / tartgetAmount * 100
                };
            }

        }

    }
}



