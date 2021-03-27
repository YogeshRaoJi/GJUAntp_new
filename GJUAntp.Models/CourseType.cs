using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace GJUAntp.Models
{
    public class CourseType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreateOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        [JsonIgnore]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
