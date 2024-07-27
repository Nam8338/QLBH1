using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Services.TINTUC
{
    public interface IBlogRepository : IGenericRepository<Tintuc> 
    {
        List<Tintuc> SearchBlog(string TenBlog);
        List<Tintuc> GetBlogPaging(int page, int pageSize);
        Tintuc GetBlogSaleNews();
        int GetTotalRec();

        List<Tintuc> GetBlogPagingByType(int page, int pageSize, string madm);
        int GetTotalRecByType(string madm);

        Tintuc GetByIdClient(string MaTinTuc);

        Tintuc GetAbout();
    }
}
