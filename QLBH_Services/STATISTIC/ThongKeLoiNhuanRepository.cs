using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.STATISTIC
{
    public class ThongKeLoiNhuanRepository : GenericRepository<Thongkeloinhuan>, IThongKeLoiNhuanRepository
    {
        public ThongKeLoiNhuanRepository(QLBH_ONLINEContext context) : base(context) { }

    }
}
