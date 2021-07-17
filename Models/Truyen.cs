using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctruyenchua.Models
{
    public class Truyen
    {
        public int Id { get; set; }
        [Required]
        public AppUser User { get; set; }
        public string TenTruyen { get; set; }
        [Display(Name = "Ảnh bìa truyện: ")]
        public string AnhBia { get; set; }
        [Required]
        public string TacGia { get; set; }
        [Required]
        public TheLoai TheLoai { get; set; }
        [StringLength(255)]
        [Display(Name = "Mô tả truyện: ")]
        public string MoTaNgan { get; set; }
        [Display(Name = "Ngày đăng: ")]
        public DateTime DateTime { get; set; }
        

    }
}