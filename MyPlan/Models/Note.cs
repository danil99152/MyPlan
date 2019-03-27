using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlan.Models
{
    //Dairy
    //Note
    //- Kind
    //- Subj
    //- Start
    //- End
    //- Place
    //NoteKind
    //Contact
    //- Name
    //- ...

    public enum NoteKind
    {
        Meet = 0,
        Task = 1,
        Memo = 2,
    }

    public class Note
    {
        public virtual long Id { get; set; }

        [Display(Name = "Тема")]
        public virtual string Theme { get; set; }

        [Display(Name = "Тип заметки")]
        public NoteKind? NoteKind { get; set; }

        [Display(Name = "Текст")]
        public virtual string Text { get; set; }

        [Display(Name = "Дата создания заметки")]
        public virtual DateTime CreationDate { get; set; }

        [Display(Name = "Дата конца заметки")]
        public virtual DateTime EndDate { get; set; }

        [Display(Name = "Место")]
        public virtual string Place { get; set; }
    }
}