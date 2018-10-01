using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Cits_Base_Center
{
    public partial class MCorps
    {
        public MCorps()
        {
            TCorpUsers = new HashSet<TCorpUsers>();
            MVendors = new HashSet<MVendors>();
        }

        [InverseProperty("MCorps")]
        public virtual ICollection<TCorpUsers> TCorpUsers { get; set; }

        public virtual ICollection<MVendors> MVendors { get; set; }
    }
}
