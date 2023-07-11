using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : IGenericService<CustomerAccountProcess>
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Delete(entity);
        }

        public List<CustomerAccountProcess> TGetAll()
        {
            return _customerAccountProcessDal.GetAll();
        }

        public CustomerAccountProcess TGetById(int id)
        {
            return _customerAccountProcessDal.GetById(id);
        }

        public void TInset(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Inset(entity);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Update(entity);
        }
    }
}
