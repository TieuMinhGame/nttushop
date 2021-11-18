﻿using NttuShop.Data.Infrastructure;
using NttuShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttuShop.Data.Reponsitories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}