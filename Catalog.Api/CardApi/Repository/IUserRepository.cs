using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Repository
{
    public interface IUserRepsoitory
    {
        public Task<User> GetCard(int id);
        public Task<User> GetCard(string name);
        public Task<IEnumerable<User>> GetAllCard();
    }
}
