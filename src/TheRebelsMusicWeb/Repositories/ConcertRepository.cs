using System;
using TheRebelsMusicWeb.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace TheRebelsMusicWeb.Repositories
{
    public class ConcertRepository
    {
        public ConcertRepository()
        {}

        public async void GetAll()
        {
            using(var connection = new MySqlConnection(""))
            {
                var test = await connection.QueryAsync<Concert>("", new { Test = 0 });
            }
        }
    }
}