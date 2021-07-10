namespace BigSchool27.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
<<<<<<< HEAD
            Attendance = new HashSet<Attendance>();
        }

=======
            AspNetUsers1 = new HashSet<AspNetUsers>();
        }
        public string Name;
>>>>>>> 8d1082d2b9824be613cdc001653876a527e31fea
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LecturerId { get; set; }
        public string Name;
        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public int CategoryId { get; set; }
        public List<Category> ListCategory = new List<Category>();

<<<<<<< HEAD
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendance { get; set; }
=======
        public virtual AspNetUsers AspNetUsers { get; set; }
>>>>>>> 8d1082d2b9824be613cdc001653876a527e31fea

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUsers> AspNetUsers1 { get; set; }
    }
}
