using Cards.Api.Model;
using Cards.Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepsoitory _userRepository;

        public UserService(IUserRepsoitory userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<int> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Card>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Card> GetUser(string name)
        {
            throw new NotImplementedException();
        }
    }
}
