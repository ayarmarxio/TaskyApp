namespace TaskyWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TaskyEntityDataModel : DbContext
    {
        public TaskyEntityDataModel()
            : base("name=TaskyEntityDataModel")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(e => e.IsDone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);
        }
    }
}
