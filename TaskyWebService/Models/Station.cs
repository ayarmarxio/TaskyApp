namespace TaskyWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Station")]
    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            Equipments = new HashSet<Equipment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StationID { get; set; }

        [Required]
        [StringLength(25)]
        public string StationName { get; set; }

        [Required]
        [StringLength(100)]
        public string StationAddress { get; set; }

        public int? NoteID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipments { get; set; }

        public virtual Note Note { get; set; }
    }
}
