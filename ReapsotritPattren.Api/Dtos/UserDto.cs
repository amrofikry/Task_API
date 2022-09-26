using RepostaryPattren.Core.Entities;
using System.Collections.Generic;

namespace RepostaryPattren.Api.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<certificateDto> certificates { get; set; }
        }
}
