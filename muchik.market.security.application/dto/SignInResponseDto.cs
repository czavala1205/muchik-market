using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.security.application.dto
{
    public class SignInResponseDto : UserDto
    {
        public string Token { get; set; } = null!;
    }
}
