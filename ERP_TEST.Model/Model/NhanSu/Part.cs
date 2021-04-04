using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TEST.Model.Model
{
    // Bộ phận
    public class Part
    {
        private Guid _oid;
        private decimal _STT;
        private string _partAdminID;
        private string _partID;
        private string _partName;
        private Part _partParent;
        private bool _use;


        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { _oid = value; }
        }

        public decimal STT
        {
            get { return _STT; }
            set { _STT = value; }
        }
        public string PartAdminID
        { get { return _partAdminID; }
            set { _partAdminID = value; }
        } 

        public string PartID
        {
            get { return _partID; }
            set { _partID = value; }
        }

        public string PartName
        {
            get { return _partName; }
            set { _partName = value; }
        }

        public Part PartParent
        {
            get { return _partParent; }
            set { _partParent = value; }
        }

        public bool Use
        {
            get { return _use; }
            set { _use = value; }
        }
    }
}
