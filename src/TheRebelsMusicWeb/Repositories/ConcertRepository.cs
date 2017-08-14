using System;
using TheRebelsMusicWeb.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheRebelsMusicWeb.Repositories
{
    public class ConcertRepository
    {
        public ConcertRepository()
        {}

        public async Task<IEnumerable<Concert>> GetAll()
        {
            using(var connection = new MySqlConnection(""))
            {
                return await connection.QueryAsync<Concert>("", new { Test = 0 });
            }
        }
    }
}