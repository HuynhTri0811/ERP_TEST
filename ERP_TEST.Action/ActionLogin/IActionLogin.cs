using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_TEST.Action
{
    public interface IActionLogin
    {
        //Login
        bool Login(string Email,string Password);
        bool Login(string Token);

        // Logout
        void Logout(Guid Oid);
        void Logout(string Token);
        void Logout(string Email, string Password);

        //Forgot
        void ForgotPassword(string Token, string NewPassword);
    }
}
