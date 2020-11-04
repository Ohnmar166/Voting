using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voting.Models
{
    public class VoteModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}