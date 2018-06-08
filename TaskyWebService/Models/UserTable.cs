namespace TaskyWebService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserTable
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(25)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        [StringLength(20)]
        public string UserType { get; set; }

        public int? TaskID { get; set; }

        public virtual Task Task { get; set; }
    }
}
