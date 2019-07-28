using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/* Ed Ali - 
Student Entity modified with DataAnnotation and DataAnnotation.schema 
This allows annotations that may or may not have required fields, annotations with string length and default display names.*/
namespace ContosoUniversity.Models
{
    /* Ed Ali - Derived Student Class from Person Class */
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}