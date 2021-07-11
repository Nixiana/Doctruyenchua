using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Truyen> truyens { get; set; }
        public DbSet<Chuong> chuongs { get; set; }
        public DbSet<TheLoai> theLoais { get; set; }
        public DbSet<Chuong_hinhanh> chuong_Hinhanhs { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}