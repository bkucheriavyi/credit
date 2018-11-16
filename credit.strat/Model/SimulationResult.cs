using System.Collections.Generic;

namespace credit.strat
{
    public class SimulationResult
    {
        public double Surplus { get; internal set; }
        public double PercentageSurplus { get; internal set; }
        internal IEnumerable<Payment> Payments { get; set; }
    }
}