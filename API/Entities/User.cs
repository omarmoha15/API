using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class User
    {
          public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public int AddedDate  { get; set; }

        public IList<Project> Project {get; set;}
    }
}