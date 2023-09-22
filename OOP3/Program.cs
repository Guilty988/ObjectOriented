using System;


namespace OOP3;
class Program
{
    static void Main(string[] args)
    {
        ICreditManager financeCredit = new FinanceCredit();
        ICreditManager transportCredit = new TransportCredit();
        ICreditManager mortgageLoan = new MortgageLoan();
    
        ApplyManager applyManager = new ApplyManager();
       // applyManager.Apply(financeCredit);

        List<ICreditManager> credits = new List<ICreditManager>() {financeCredit,transportCredit,mortgageLoan};
        applyManager.CreditPreliminaryInformation(credits);
    }
}