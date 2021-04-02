using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team16Project.Shared
{
    public class UserResponseManager
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string[] Errors { get; set; }
        public Dictionary<string, string> UserInfo { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
