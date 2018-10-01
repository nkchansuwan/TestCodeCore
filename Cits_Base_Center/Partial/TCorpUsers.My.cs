using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Cits_Base_Center
{
   public partial class TCorpUsers
    {
        [ForeignKey("CorpId")]
        [InverseProperty("TCorpUsers")]
        public virtual MCorps MCorps { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("TCorpUsers")]
        public virtual MUsers MUsers { get; set; }

        public static IQueryable<object> GetCorp(string userId)
        {
            var db = new Db();

            var corp = db.TCorpUsers
                        .Where(x => x.UserId == userId && x.MUsers.DeleteStatus == 0)
                        .AsQueryable()
                        .Select(c => new
                        {
                            c.CorpUserId,
                            c.CorpId,
                            c.MCorps.CorpCode,
                            c.MCorps.CorpNameTh,
                        });

            return corp;
        }
    }
}
