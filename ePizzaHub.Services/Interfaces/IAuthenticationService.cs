using ePizzaHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string Password);
        Task<bool> SignOut();
        User AuthenticateUser(string Username, string Password);
        User GetUser(string Username);
    }
}
