using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WecareMVC.Models
{
    public class Artist
    {
        [DisplayName("制造商ID")]
        public int ArtistId { get; set; }
        [DisplayName("制造商名称")]
        public string Name { get; set; }
    }
}