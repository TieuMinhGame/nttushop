using NttuShop.Data.Infrastructure;
using NttuShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttuShop.Data.Reponsitories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}