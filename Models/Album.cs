using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WecareMVC.Models
{
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }
        [DisplayName("商品分类ID")]
        public int GenreId { get; set; }
        [DisplayName("制造商ID")]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "商品名称 不得为空！")]
        [StringLength(160)]
        [DisplayName("商品名称")]
        public string Title { get; set; }
        [Required(ErrorMessage = "单间 不得为空！")]
        [Range(0.01, 1000.00,
            ErrorMessage = "价格在 0.01 到 1000.00 之间")]
        [DisplayName("单价")]
        public decimal Price { get; set; }
        [DisplayName("图片")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }  
        //讓album可以連到orderdetail獲取數量，以呈現熱賣的商品
    }
}