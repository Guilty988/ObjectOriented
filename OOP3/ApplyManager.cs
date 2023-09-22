using System;
namespace OOP3
{
	public class ApplyManager
	{
        public void Apply(ICreditManager creditManager)
		{
            //information about customers
            //Credit calculation
            /* that was wrong version
			MortgageLoan mortgageLoan = new MortgageLoan();
			mortgageLoan.Calculate();
			*/
            creditManager.Calculate();
		}

		public void CreditPreliminaryInformation(List<ICreditManager> credits) {

			foreach (var credit in credits)
			{
				credit.Calculate();
			}

		}
    }
}

