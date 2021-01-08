using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalR.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Text { get; set; }
        public DateTime When { get; set; }
        public String UserID { get; set; }
        public virtual AppUser Sender { get; set; }
    }
}
