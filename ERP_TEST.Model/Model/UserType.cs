using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TEST.Model
{
    public class UserType
    {
        private Guid _guid;
        private string _userType_ID;
        private string _userType_Name;


        [Key]
        public Guid Guid
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public string UserType_ID
        {
            get { return _userType_ID; }
            set { _userType_ID = value; }
        }

        public string UserType_Name
        {
            get { return _userType_Name; }
            set { _userType_Name = value; }
        }
    }
}
