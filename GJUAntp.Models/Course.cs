using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GJUAntp.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// full course name like '2021 Complete Python Bootcamp From Zero to Hero in Python'
        /// </summary>
        [Required]
        public string FullName { get; set; }
        /// <summary>
        /// short name of the course like Python
        /// </summary>
        [Required]
        public string ShortName { get; set; }
        /// <summary>
        /// Language to be used in tutorial i.e English
        /// </summary>
        public string CourseLanguage { get; set; }//English
        /// <summary>
        /// Course content list 
        /// </summary>
        public string CurseContent { get; set; }
        /// <summary>
        /// What you'll learn
        /// </summary>
        public string CoursePoints { get; set; }
        /// <summary>
        ///  Prerequisite for the course 
        /// </summary>
        public string Prerequisite { get; set; }
        /// <summary>
        /// Short Description that will be shown just below the full name
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// course availability 
        /// </summary>
        public bool IsActive { get; set; } = true;
        /// <summary>
        /// time of creation of the course
        /// </summary>
        public DateTime CreateOn { get; set; }
        /// <summary>
        /// time of updation
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// amount to be paid by the student to enroll in the course
        /// </summary>
        [Required]
        public double Price { get; set; }
        /// <summary>
        /// course type id 
        /// </summary>
        [ForeignKey("CourseType"), Required]
        public int CourseTypeId { get; set; }
        /// <summary>
        /// Type of couse
        /// </summary>

        public virtual CourseType Type { get; set; }

    }
}
