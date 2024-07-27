using QLBH_DataAccess.Models;
using QLBH_Services.GenericRepository;

namespace QLBH_Services.PHANHOI
{
    public interface IPhanHoiRepository : IGenericRepository<Phanhoi>
    {
        List<Phanhoi> SearchPH(string tieuDe);
        List<Phanhoi> GetListPaging(int page, int pageSize);

        List<Phanhoi> GetListPagingByDate(int page, int pageSize, DateTime startDate, DateTime endDate);
        List<Phanhoi> GetFeedbackByCustomerID(string MaKH);

        List<Phanhoi> GetListPagingByCusID(int page, int pageSize, string MaKH);
        int GetCusTotalFeedback(string MaKH);

        int GetTotalRec();
    }
}
