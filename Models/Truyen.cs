﻿using System;
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
        [Required]
        [Display(Name = "Tên truyện")]
        public string TenTruyen { get; set; }
        [Display(Name = "Ảnh bìa truyện: (link)")]
        public string AnhBia { get; set; }
        [Required]
        [Display(Name = "Tác giả")]
        public string TacGia { get; set; }
        [Required]
        public TheLoai TheLoai { get; set; }
        [StringLength(int.MaxValue)]
        [Display(Name = "Mô tả truyện: ")]
        public string MoTaNgan { get; set; }
        [Display(Name = "Ngày đăng: ")]
        public DateTime DateTime { get; set; }

        public virtual ICollection<Chuong> Chuongs { get; set; }


    }
}