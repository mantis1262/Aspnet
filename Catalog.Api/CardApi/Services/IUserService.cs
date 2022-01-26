using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Services
{
    public interface IUserService
    {
        public Task<User> GetUser(int id);
        public Task<Card> GetUser(string name);
        public Task<IEnumerable<Card>> GetAllUser();
        public Task<int> CreateUser(User user);
    }
}
