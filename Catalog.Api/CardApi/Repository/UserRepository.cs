using Cards.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Api.Repository
{
    public class UserRepository : IUserRepsoitory
    {
        IEnumerable<User> _userList;
       
        public UserRepository()
        {
            _userList = new List<User>() { (new User { Id = 1, Name = "test" }) };

        }

        public async Task<IEnumerable<User>> GetAllCard()
        {
            return _userList;
        }

        public async Task<User> GetCard(int id)
        {
            var result = _userList.FirstOrDefault(x=>x.Id.Equals(id));
            return result;
        }

        public Task<User> GetCard(string name)
        {
            throw new NotImplementedException();
        }
    }
}
