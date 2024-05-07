using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.StateAndTownshipDataFrame.Models
{
    [Table("Tbl_PlaceState")]
    public class StateDataModel
    {
        [Key]
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}
