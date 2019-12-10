using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Entry
    {
        public int ID { get; set; } //Database ID
        public string Canon { get; set; } //The work of canon the scripture belongs to
        public string Book { get; set; } //The book of scripture that the scripture is in
        public string Reference { get; set; } //Reference for scripture

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; } //Gets the current date and time
        public string Notes { get; set; } // Text box entry for notes

    }
}
