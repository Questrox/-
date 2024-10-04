namespace Конструирование_ПО
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plan")]
    public partial class Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan()
        {
            Plan_discipline = new HashSet<Plan_discipline>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Admission_date { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialty { get; set; }

        [Required]
        [StringLength(20)]
        public string Form { get; set; }

        public int Duration { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        public int? ID_Field_of_study { get; set; }

        public int? ID_Department { get; set; }

        public virtual Department Department { get; set; }

        public virtual Field_of_study Field_of_study { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_discipline> Plan_discipline { get; set; }
    }
}
