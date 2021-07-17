using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class Statistic
    {
        
        public int Id { get; set; }
        public string Time { get; set; }
        [Display(Name = "Số lượng truy cập: ")]
        public int Numvisit { get; set; }
    }
}