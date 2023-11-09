using RocketFreight.Data;
using RocketFreight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketFreight.Interface
{
    internal interface IAppInterface 
    {   
        //Users
        Task<bool> SaveUser(User item);
        Task<bool> UpdateUser(User item, int i);
        Task<User> GetUser(int Id);
        Task<bool> RemoveUser(int Id);
        Task<List<User>> GetUsers();


    }
}
