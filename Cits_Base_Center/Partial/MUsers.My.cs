using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Cits_Base_Center
{
    public partial class MUsers
    {
        public MUsers()
        {
            TCorpUsers = new HashSet<TCorpUsers>();
        }

        [InverseProperty("MUsers")]
        public virtual ICollection<TCorpUsers> TCorpUsers { get; set; }

        public static IQueryable<object> GetUserDetail(string userId)
        {
            var db = new Db();

            var user = db.MUsers
                        .Where(x => x.UserId == userId)
                        .AsQueryable()
                        .Select(u => new
                        {
                            u.UserId,
                            u.Email,
                            u.DisplayName,
                            u.ActiveStatus,
                            u.ActiveStatusDate
                        });
            return user;

        }

        public static IQueryable<MUsers> GetUser(string userId)
        {
            var db = new Db();

            var user = db.MUsers
                        .Where(x => x.UserId == userId)
                        .AsQueryable()
                        ;
            return user;
        }

        public static IQueryable<MUsers> GetUserByFirebaseId(string firebaseId)
        {
            var db = new Db();

            var user = db.MUsers
                        .Where(x => x.FirebaseId == firebaseId)
                        .AsQueryable()
                        ;
            return user;
        }

        

    }
}
