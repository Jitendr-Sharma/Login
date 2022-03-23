using CRMAPP.Models.viewModel;
using CRMAPP.Utils.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace CRMAPP.Respository.Contract
{
    public interface IUser
    {
        SignUp Register(SignUp model);
        AuthoEnum AuthenticateUser(SignIn model);
        VerifyAccountEnum VerifyAccount(string Otp);
        bool UpdateProfile(string Email, string Path);
    }
}
