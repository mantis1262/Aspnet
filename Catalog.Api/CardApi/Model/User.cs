using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JWTToken { get; set; }
    }
}
