using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Doctruyenchua.Models;

namespace Doctruyenchua.ViewModels
{
    public class TruyenViewModel
    {
        [Required]
        [Display(Name = "Tên truyện")]
        public string TenTruyen { get; set; }
        [Required]
        [Display(Name = "Ảnh bìa truyện: (link)")]
        public string AnhBia { get; set; }
        [Display(Name = "Tác giả")]
        public string TacGia { get; set; }
        [Required]
        [StringLength(int.MaxValue)]
        [Display(Name = "Mô tả truyện: ")]
        public string MoTaNgan { get; set; }
        [Required]
        public string Date { get; set; }
        public string Time { get; set; }
        [Required]
        public byte TheLoai { get; set; }
        public IEnumerable<TheLoai> theLoais { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}