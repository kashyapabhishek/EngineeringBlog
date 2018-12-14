using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EngineeringBlog.Models
{
    public class SubjectContext: DbContext
    {
        public SubjectContext() : base("DefaultConnection")
        {

        }
        public DbSet<SubjectViewModel> ConceptName { get; set; }
    }
}