using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.MEDIA.MEDIATYPE
{
    internal class MediaTypeRepository: GenericRepository<Mediatype>, IMediaTypeRepository
    {
        public MediaTypeRepository(QLBH_ONLINEContext context) : base(context) { }

    }
}
