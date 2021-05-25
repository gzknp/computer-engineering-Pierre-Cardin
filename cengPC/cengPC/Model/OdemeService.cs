using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cengPC.Model
{

    public class OdemeService
    {    
        FirebaseClient client;
        public OdemeService()
        {
            client = new FirebaseClient("https://pierrecapp-4a4be-default-rtdb.europe-west1.firebasedatabase.app/");

        }
        public async Task<bool> IsOdemeExists(int kartno)
        {
            var user = (await client.Child("Odemeler")
                .OnceAsync<Odeme>()).Where(u => u.Object.KartNo == kartno).FirstOrDefault();
            return (user != null);

        }
        public async Task<bool> RegisterOdeme(int kartno, string adres, int ccv)
        {
            if (await IsOdemeExists(kartno) == false)
            {
                await client.Child("Odemeler").PostAsync(new Odeme()
                {

                    Ccv = ccv,
                    Adres = adres,
                    KartNo = kartno
                });
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
