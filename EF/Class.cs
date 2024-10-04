namespace Конструирование_ПО
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Hours_count { get; set; }

        public int? ID_Plan_discipline { get; set; }

        public int? ID_Class_type { get; set; }

        public virtual Class_type Class_type { get; set; }

        public virtual Plan_discipline Plan_discipline { get; set; }
    }
}
