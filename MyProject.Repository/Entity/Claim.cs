using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Entity
{
   public enum ePolicy { Deny,Allow}
    public class Claim
    {
        public int Id { get; set; }
        public ePolicy Policy  { get; set; }

        public int IdRole { get; set; }
        public int IdPermission { get; set; }
    }
}
