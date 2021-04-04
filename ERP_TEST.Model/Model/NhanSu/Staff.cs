using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TEST.Model.Model
{
    // Nhân viên
    public class Staff
    {
        private Guid _oid;
        private string _staffId;
        private string _staffName;
        private Part _part;

        private Staff _staffManage;

        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { _oid = value; }
        }

        public string StaffId
        {
            get { return _staffId; }
            set { _staffId = value; }
        }

        public string StaffName
        {
            get { return _staffName; }
            set { _staffName = value; }
        }

        public Part Part
        {
            get { return _part; }
            set { _part = value; }
        }

        public Staff StaffManege
        {
            get { return _staffManage; }
            set { _staffManage = value; }
        }

    }
}
