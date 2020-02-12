using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OnlineInsurance
{
    public class UserManager
    {
        UserRepository userRepository = new UserRepository();

        public bool InsertCustomerDetail(UserEntity user)
        {
            return userRepository.InsertCustomerDetail(user);
        }
        public bool ValidateSignIn(UserEntity user)
        {
            return userRepository.ValidateSignIn(user);
        }
        public bool DeleteCustomerDetail(int customerId)
        {
            return userRepository.DeleteCustomerDetail(customerId);
        }
        public DataTable ViewCustomerDetail()
        {
            return userRepository.ViewCustomerDetail();
        }
        public bool UpdateCustomerDetail(UserEntity user)
        {
            return userRepository.UpdateCustomerDetail(user);
        }

    }
}
