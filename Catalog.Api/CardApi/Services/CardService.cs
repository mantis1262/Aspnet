using Cards.Api.Model;
using Cards.Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepsoitory _cardRepository;

        public CardService(ICardRepsoitory cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public Task<int> CreateCard(Card card)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Card>> GetAllCard()
        {
            return await _cardRepository.GetAllCard();
        }

        public async Task<Card> GetCard(int id)
        {
            return await _cardRepository.GetCard(id);
        }

        public Task<Card> GetCard(string name)
        {
            throw new NotImplementedException();
        }
    }
}
