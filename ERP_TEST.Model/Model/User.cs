using ERP_TEST.Action;
using ERP_TEST.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ERP_TEST.Model
{
    public class User:IActionLogin,IActionUserType<UserType,User>
    {
        private Guid _oid;
        private string _email;
        private string _password;
        private UserType _userType;

        #region Properties
        [Key]
        public Guid Oid
        {
            get {return _oid;}
            set { _oid = value; }
        }

        [DisplayName("Email")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = HashPassword.HashPasswordHMACSHA1(value); }
        }

        public UserType UserType
        {
            get { return _userType; }
        }

        #endregion

        #region EventHere
        public void ForgotPassword(string Token, string NewPassword)
        {
            throw new NotImplementedException();
        }
        public bool Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }
        public bool Login(string Token)
        {
            throw new NotImplementedException();
        }
        public void Logout(Guid Oid)
        {
            throw new NotImplementedException();
        }
        public void Logout(string Token)
        {
            throw new NotImplementedException();
        }
        public void Logout(string Email, string Password)
        {
            throw new NotImplementedException();
        }
        public void UpdateUserType(ERP_TEST.Model.UserType UserTypeNew,User user)
        {
            this._userType = UserTypeNew;
        }


        #endregion
    }
}