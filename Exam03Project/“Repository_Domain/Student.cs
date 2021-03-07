using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Repository_Domain
{
    [Serializable]
    [Table("Trainee")]
    public partial class Trainee : IEntity<int>
    {
        [Key] public int TraineeID { get; set; }

        [Required] [StringLength(50)] public string TraineeName { get; set; }

        [Required] [StringLength(15)] public string CourseName { get; set; }

        [Required] [StringLength(10)] public string RoundNo { get; set; }

        [Required] [StringLength(15)] public string CellPhoneNo { get; set; }
    }
}
