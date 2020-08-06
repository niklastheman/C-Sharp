using Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logic.DAL
{
    public class UserDataAccess
    {
        private const string path = @"\User.json";

        public async Task<List<User>> GetUsers()
        {

            var a = System.AppDomain.CurrentDomain.BaseDirectory;

            using (FileStream fs = File.OpenRead(path))
            {
                List<User> users = await JsonSerializer.DeserializeAsync<List<User>>(fs);

                return users;
            }
        }
    }
}
