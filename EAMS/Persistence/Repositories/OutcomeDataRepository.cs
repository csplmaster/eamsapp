﻿using EAMS.Core.IRepositories;
using EAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using EAMS.DB_Contexts;

namespace EAMS.Persistence.Repositories
{
    public class OutcomeDataRepository : Repository<OutcomeData>, IOutcomeDataRepository
    {
        public OutcomeDataRepository(DbContext context) : base(context)
        {

        }
        
    }
}