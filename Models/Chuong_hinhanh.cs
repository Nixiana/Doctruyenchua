using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class Chuong_hinhanh
    {
        public int Id { get; set; }
        public Chuong Chuong { get; set; }
        public string Tenhinhanh { get; set; }
    }
}