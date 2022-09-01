using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailble { get; set; }
        public int AddedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}