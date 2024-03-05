using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IPaymentDAL
    {

        public string AddPayment(PaymentBO Detail);
        public string DeletePayment(PaymentBO Detail);

        public List<ReturnPaymentBO> Getpayment(int StudentId);
    }
}
