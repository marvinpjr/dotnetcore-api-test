﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsKeeper.Api.EntityFramework
{
    public static class DbInitializer
    {
        public static void Initialize(StatKeeperContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
