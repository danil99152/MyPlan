using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Diary
{
    public class User : IUser<long>
    {
        public virtual long Id { get; set; }

        [Display(Name = "Логин")]
        public virtual string UserName { get; set; }

        public virtual string Password { get; set; }

        [Display(Name = "Заметки")]
        public virtual ICollection<Note> Notes { get; set; }

        public virtual bool IsEnabled { get; set; } = true;

        public User()
        {
            Notes = new List<Note>();
        }

        public User(string userName) : this()
        {
            UserName = userName;
        }
    }
}