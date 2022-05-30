﻿using System;
using System.Collections.Generic;

namespace WGShopping.Entities
{
    public partial class Loai
    {
        public Loai()
        {
            HangHoas = new HashSet<HangHoa>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; } = null!;
        public string? MoTa { get; set; }
        public string? Hinh { get; set; }

        public virtual ICollection<HangHoa> HangHoas { get; set; }
    }
}
