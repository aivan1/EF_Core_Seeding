using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustWorkForGodsSake.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserGroupId { get; set; }
        public string HomeTown { get; set; }
    }
}
