using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<AccountDto> GetAll();
        AccountDto Get(int id);
        void Create(AccountDto account);
        void Update(AccountDto account);
        void Delete(int id);
    }
}
