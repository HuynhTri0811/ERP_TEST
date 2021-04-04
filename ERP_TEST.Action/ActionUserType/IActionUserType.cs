using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_TEST.Action
{
    public interface IActionUserType<T,K> where K : class  where T : class
    {
        //UpdateUserType
        void UpdateUserType(T UserTypeNew,K User);

    }
}
