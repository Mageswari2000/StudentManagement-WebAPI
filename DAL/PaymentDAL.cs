using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class PaymentDAL :IPaymentDAL
    {
        readonly ApplicationDbContext db;
        public PaymentDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public string AddPayment(PaymentBO Detail)
        {
                Payment obj;
                if (Detail.Id == 0)
                {
                    obj = new Payment();
                    db.Payment.Add(obj);
                }
                else
                {
                    obj = db.Payment.FirstOrDefault(e => e.Id == Detail.Id);
                }

                obj.Id = Detail.Id;
                var Studentcheck = db.Students.FirstOrDefault(e => e.Id == Detail.StudentId && e.Email == Detail.Email);
                var PickDepartment = Studentcheck != null ? db.Department.FirstOrDefault(e => e.ID == Studentcheck.DepartmentID) : null;
                if (Studentcheck != null)
                {
                    obj.Name = Studentcheck.Name;
                    obj.Student= Studentcheck;
                    obj.StudentId = Studentcheck.Id;
                    obj.Email = Studentcheck.Email;
                    obj.DepartmentID = Studentcheck.DepartmentID;
                    obj.DepartmentName = PickDepartment.DepartmentName;
                    obj.paidAmount = Detail.paidAmount;
                    obj.Totalfees = PickDepartment.Fees;
                    obj.BalanceDue = PickDepartment.Fees - Detail.paidAmount;
                    obj.PaymentStatus = (obj.BalanceDue == 0) ? "Paid" : (obj.BalanceDue == PickDepartment.Fees) ? "Pending" : (Detail.paidAmount > PickDepartment.Fees) ?"Excess Paid": "Partialy Paid";
                    db.SaveChanges();
                    return "saved";
                }
                else
                {
                throw new Exception("Plz Enter Valid Student");
                }
        }

        public string DeletePayment(PaymentBO Detail)
        {
            var obj = db.Payment.FirstOrDefault(e => e.Id == Detail.Id);

            if (obj != null)
            {
                db.Payment.Remove(obj);
                db.SaveChanges();
                return "Department Deleted Successfully";
            }
            else
            {
                return "Department doest not here";
            }

        }


        public List<ReturnPaymentBO> Getpayment(int StudentId)
        {
            var resultdata = (from pay in db.Payment
                              where pay.Student.Id == StudentId
                              select new ReturnPaymentBO
                              {
                                  Id=pay.Id,
                                  Student=new StudentBO
                                  {
                                      Id = pay.StudentId,
                                      Name=pay.Name,
                                      Email=pay.Email,
                                      Phone=pay.Student.Phone,
                                      Age=pay.Student.Age,
                                      DateOfBirth = pay.Student.DateOfBirth,
                                  },
                                  DepartmentName = pay.DepartmentName,
                                  paidAmount = pay.paidAmount,
                                  Totalfees = pay.Totalfees,
                                  BalanceDue = pay.BalanceDue,
                                  PaymentStatus = pay.PaymentStatus,
                              }

                           ).ToList();

            return resultdata;

        }
    }
}
