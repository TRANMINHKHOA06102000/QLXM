using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLXEMAY.Class;
using QLXEMAY.Model;

namespace QLXEMAY.Controller
{
    class XeMayBLL
    {
        XeMayDAL dalXM;
        public XeMayBLL()
        {
            dalXM = new XeMayDAL();
        }
        public DataTable getALLXeMay()
        {
            return dalXM.getAllXeMay();
        }
        public bool Insertxemay(XeMayModel xm)
        {
            return dalXM.Insertxemay(xm);
        }
        public bool Updatexemay(XeMayModel xm)
        {
            return dalXM.Updatexemay(xm);
        }
        public bool DELETExemay(XeMayModel xm)
        {
            return dalXM.DELETExemay(xm);
        }
        public DataTable Findxemay(string xm)
        {
            return dalXM.Findxemay(xm);
        }
    }
}
