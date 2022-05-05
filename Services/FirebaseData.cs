using Firebase.Database;
using Firebase.Database.Query;
using Sibahlenkosini.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Sibahlenkosini.Services
{
    public class FirebaseData
    {

        FirebaseClient client;
        public FirebaseData()
        {
            client = new FirebaseClient("https://sibahlenkosini-49244-default-rtdb.firebaseio.com/");
        }


        public async Task<List<Media>> GetAllMedia()
        {
            List<Media> media = new List<Media>();
            try
            {
                var items = (await client.Child("Media").OnceAsync<Media>()).ToList();


                foreach (var i in items)
                {
                    media.Add(i.Object);
                }


                return await Task.FromResult(media);
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Product>> GetDataAsync()
        {
            List<Product> products = new List<Product>();

            try
            {
                var items = (await client.Child("Products").OnceAsync<Product>()).ToList();
                foreach (var i in items)
                {
                    products.Add(i.Object);
                }

                return await Task.FromResult(products);
            }
            catch
            {
                return products;
            }
        }


    }
}
