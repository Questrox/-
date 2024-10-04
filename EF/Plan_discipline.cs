namespace Конструирование_ПО
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plan_discipline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan_discipline()
        {
            Class = new HashSet<Class>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Volume { get; set; }

        [Required]
        [StringLength(20)]
        public string Exam_type { get; set; }

        public int Term { get; set; }

        public int? ID_Plan { get; set; }

        public int? ID_Discipline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Class { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual Plan Plan { get; set; }
    }
}
