using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.MEDIA
{
    public interface IMediaRepository : IGenericRepository<Medium>
    {
        List<Medium> GetListMedia();

        List<Medium> GetBanner();

        Medium GetLogo();

    }
}
