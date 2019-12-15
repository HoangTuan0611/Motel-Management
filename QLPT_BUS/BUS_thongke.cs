using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using QLPT_Entity;
using System.Data;
namespace QLPT_BUS
{
    public class BUS_thongke
    {
        DAL_thongke sql = new DAL_thongke();
        public DataTable taobang(string DieuKien1,string DieuKien2)
        {
            return sql.TaoBang(DieuKien1, DieuKien2);
        }
    }
}
