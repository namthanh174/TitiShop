﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TitiShop.Model.Abstract;

namespace TitiShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [Required]
        public int PostCategoryID { set; get; }

        [MaxLength(250)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("PostCategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}