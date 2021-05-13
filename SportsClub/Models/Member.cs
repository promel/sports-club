using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsClub.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FisrtName { get; set; }
        public string Surname { get; set; }

        public Sport Sport { get; set; }
        
    }
}
