namespace TaskyWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            UserTables = new HashSet<UserTable>();
        }

        public int TaskID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Required]
        [StringLength(15)]
        public string TaskType { get; set; }

        public DateTime TaskDueDate { get; set; }

        public DateTime? DoneDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Periodicity { get; set; }

        [StringLength(150)]
        public string Registration { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }

        [StringLength(1)]
        public string IsDone { get; set; }

        public int? EquipmentID { get; set; }

        public virtual Equipment Equipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTable> UserTables { get; set; }
    }
}
