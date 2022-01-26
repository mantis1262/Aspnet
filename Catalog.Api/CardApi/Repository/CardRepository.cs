using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Repository
{
    public class CardRepository : ICardRepsoitory
    {
        IEnumerable<Card> cards;
       
        public CardRepository()
        {
            cards = new List<Card>() { (new Card { ID = 1, Title = "szczury", Description = "dsada", PictureURL = "" }),
                                      (new Card { ID = 2, Title = "krokodyl", Description = "dsada", PictureURL = "" }) };

        }

        public async Task<IEnumerable<Card>> GetAllCard()
        {
            return cards;
        }

        public async Task<Card> GetCard(int id)
        {
            var result = cards.FirstOrDefault(x=>x.ID.Equals(id));
            return result;
        }

        public Task<Card> GetCard(string name)
        {
            throw new NotImplementedException();
        }
    }
}
