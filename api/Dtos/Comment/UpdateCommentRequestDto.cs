using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be more than 5 chars")]
        [MaxLength(25, ErrorMessage = "Title cannot be over 25 chars")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be more than 5 chars")]
        [MaxLength(280, ErrorMessage = "Content cannot be over 280 chars")]
        public string Content { get; set; }= string.Empty;
    }
}