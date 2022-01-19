using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Model
{
    public class Card
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }
         
    }
}
