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
    [Table("CreditScoreee")]
   public class CreditScore
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }

        public long TCNo { get; set; }
        public long Score { get; set; }

    }
}
