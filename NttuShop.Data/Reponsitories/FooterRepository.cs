using NttuShop.Data.Infrastructure;
using NttuShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttuShop.Data.Reponsitories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
