using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUsersService
    {
        IEnumerable<UserDto> GetAll();
        UserDto Get(string id);
        void Create(UserDto user);
        void Update(UserDto user);
        void Delete(string id);
    }
}
