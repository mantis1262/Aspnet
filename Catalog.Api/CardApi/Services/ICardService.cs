using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Services
{
    public interface ICardService
    {
        public Task<Card> GetCard(int id);
        public Task<Card> GetCard(string name);
        public Task<IEnumerable<Card>> GetAllCard();
        public Task<int> CreateCard(Card card);
    }
}
