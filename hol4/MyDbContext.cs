﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvc_hol4.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()

: base("name=conn")

        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}