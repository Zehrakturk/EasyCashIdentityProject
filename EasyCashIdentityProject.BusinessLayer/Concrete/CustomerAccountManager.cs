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
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAccount entity)
        {
            _customerAccountDal.Delete(entity);
        }

        public List<CustomerAccount> TGetAll()
        {
            return _customerAccountDal.GetAll();
        }

        public CustomerAccount TGetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public void TInset(CustomerAccount entity)
        {
            _customerAccountDal.Inset(entity);
        }

        public void TUpdate(CustomerAccount entity)
        {
            _customerAccountDal.Update(entity);
        }
    }
}
