using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.Entity
{
   public enum ePofile { Deny,Allow}
    public class ClaimDto
    {
        public int Id { get; set; }
        public ePofile profile { get; set; }

        public int IdRole { get; set; }
        public int IdPermission { get; set; }
    }
}
