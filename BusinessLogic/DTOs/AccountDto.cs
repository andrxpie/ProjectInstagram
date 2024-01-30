using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string AvatartLink { get; set; }
        public string Bio { get; set; }
    }
}
