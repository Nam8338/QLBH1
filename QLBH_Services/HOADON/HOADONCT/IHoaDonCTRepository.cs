using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.HOADON.HOADONCT
{
    public interface IHoaDonCTRepository : IGenericRepository<Hoadonct>
    {
        List<Hoadonct> GetListOrderProcduct(string mahd);

        int GetTotalRec();
    }
}
