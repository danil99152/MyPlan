using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Diary
{
    public class Kind  : IKind<long>
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Kind()
        {
            Users = new List<User>();
        }

        public Kind(string kindName) : this()
        {
            Name = kindName;
        }
    }
}