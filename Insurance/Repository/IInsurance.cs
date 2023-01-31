using Insurance.Model;

namespace Insurance.Repository
{
    public interface IInsurance
    {
        double CalculatePremium(InsuranceModel insuranceModel);
    }
}
