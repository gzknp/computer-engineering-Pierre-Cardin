using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cengPC
{
    public class UserService
    {
        FirebaseClient client;
        
        public UserService()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");
        }
        public async Task<bool> IsUserExists(string umail)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Email == umail).FirstOrDefault();
            return (user != null);
                
        }
        public async Task<bool> RegisterUser(string umail, string passwd, string tel, string name, string surname)
        {
            if (await IsUserExists(umail)==false)
            {
                await client.Child("Users").PostAsync(new User()
                {

                    Password = passwd,
                    Email = umail,
                    Name = name,
                    LastName=surname,
                    TelNo=tel
                }) ;
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string umail, string passwd)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Email == umail)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();

            return (user != null);
        }

    }
}
