using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Texter.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        
        public Contact(string name, string number, int id = 0)
        {
            Name = name;
            Number = number;
            Id = id;
        }
        public Contact() { }
    }
}
