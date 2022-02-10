using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_WebApplication.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name="Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short SubjectId { get; set; }

        [Display(Name="Subject Name")]
        [Required]
        public string SubjectName { get; set; }

        #region Navigation properties to the  Department Model

        [Display(Name ="Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]   //foreign key to object in the current model
        public int DepartmentId { get; set; }      //department ID of the subject

        [Display(Name ="Department Name")]
        public Department Department { get; set; }



        #endregion
    }
}
