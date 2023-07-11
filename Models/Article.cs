using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp
{
    [Table("Dulieu")]
    public class Article 
    {
        [Key]
        public int Id{ get;set;}
        [StringLength(250, MinimumLength =2, ErrorMessage ="{0} phải từ 2 ký tự trở lên")]
        [Required(ErrorMessage ="{0} không được để rỗng")]
        
        [Column(TypeName ="nvarchar")]
        [DisplayName("Tieu De")]
    

        public string Title{ get;set;}
        [DataType( DataType.Date)]
        [Required]
        [DisplayName("Ngay Tao")]

        public DateTime Created{ get;set;}
        [Column(TypeName ="ntext")]
        [DisplayName("Noi Dung")]
        public int Content{ get;set;}
    }
}