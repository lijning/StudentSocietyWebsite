namespace OrgSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            EventAssignments = new HashSet<EventAssignment>();
            Tasks = new HashSet<TaskOfEvent>();
        }

        [Key]
        public short UserId { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string RealName { get; set; }

        [StringLength(10)]
        public string Department { get; set; }

        [StringLength(10)]
        public string Position { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime? ResignTime { get; set; }

        [StringLength(150)]
        public string SelfDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventAssignment> EventAssignments { get; set; }

        public virtual MemberLogin MemberLogin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskOfEvent> Tasks { get; set; }
    }
}
