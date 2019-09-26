using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    public class Data_Context : DbContext

    {

        public Data_Context() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webEval.Models.Student> Students { get; set; }
    }
}