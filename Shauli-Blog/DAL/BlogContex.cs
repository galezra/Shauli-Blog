﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Shauli_Blog.Models;

namespace Shauli_Blog.DAL
{
    public class BlogContex : DbContext
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Fan> Fans { get; set; }

        /*
         * The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table names from being pluralized.
         * If you didn't do this, the generated tables would be named Posts and Comments.
         */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}
