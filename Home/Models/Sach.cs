namespace Home.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Số ký tự không quá 30.")]
        [Display(Name ="Tên tác giả")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Author { get; set; }

        [StringLength(30, ErrorMessage = "Số ký tự không quá 30.")]
        [Display(Name = "Tựa sách")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Title { get; set; }

        
        public string Description { get; set; }

        
        public string Image { get; set; }

        [Range(1000,1000000)]
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Không được để trống")]
        public int? Price { get; set; }
    }
}
