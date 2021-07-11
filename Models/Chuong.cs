using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class Chuong
    {

        public int Id { get; set; }
        [Required]
        public int SoChuong { get; set; }
        [Required]
        [Display(Name = "Tên Chương: ")]
        public string TenChuong { get; set; }
        [Required]
        [Display(Name = "Nội dung chương: ")]
        public string NoiDungChuong { get; set; }
        public Truyen Truyen { get; set; }
    }
}