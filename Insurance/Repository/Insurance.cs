using Insurance.Model;
using System.Linq;

namespace Insurance.Repository
{
    public class Insurancecls : IInsurance
    {
        private const double LightManualRate = 1.50;
        private const double ProfessionalRate = 1.0;
        private const double WhiteCollarRate = 1.25;
        private const double HeavyManualRate = 1.75;
        private const string Professional = "Professional";
        private const string LightManual = "Light Manual";
        private const string WhiteCollar = "White Collar";
        private const string HeavyManual = "Heavy Manual";
        public double CalculatePremium(InsuranceModel insuranceModel)
        {
            double total = 0;
            if (insuranceModel.Occupation == Professional)
                total = (insuranceModel.Death * ProfessionalRate * insuranceModel.Age) / (1000 * 12);
            else if (insuranceModel.Occupation == LightManual)
                total = (insuranceModel.Death * LightManualRate * insuranceModel.Age) / (1000 * 12);
            else if (insuranceModel.Occupation == WhiteCollar)
                total = (insuranceModel.Death * WhiteCollarRate * insuranceModel.Age) / (1000 * 12);
            else if (insuranceModel.Occupation == HeavyManual)
                total = (insuranceModel.Death * HeavyManualRate * insuranceModel.Age) / (1000 * 12);
            else
                total = 0;
            return total;
        }
    }
}
