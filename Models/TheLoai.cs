using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class TheLoai
    {
        public int Id { get; set; }
        [Display(Name ="Tên thể Loại")]
        [Required]
        public string TenTheLoai { get; set; }

    }
}