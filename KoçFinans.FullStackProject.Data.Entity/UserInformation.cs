using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoçFinans.FullStackProject.Data.Entity
{

    [Serializable]
    [Table("UsersInformation")]
  public  class UserInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter  TCNo")]
        public long TCNo { get; set; }

        [Required(ErrorMessage = "Please Enter  Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter  Surname")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Please Enter  MonthlyGain")]

        public decimal MonthlyGain { get; set; }
        
        [Required(ErrorMessage = "Please Enter  TelNo")]

        public string TelNo { get; set; }

    }
}
