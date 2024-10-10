using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyFriends.Services.DTOs
{
    public class LoginDto
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        [MinLength(4, ErrorMessage = "Password must be at least 4 characters long.")]
        public string Password { get; set; }

        [JsonProperty("rememberMe")]
        public bool RememberMe { get; set; }
    }
}
