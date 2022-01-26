using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Repository
{
    public interface ICardRepsoitory
    {
        public Task<Card> GetCard(int id);
        public Task<Card> GetCard(string name);
        public Task<IEnumerable<Card>> GetAllCard();
    }
}
