using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class Acc
    {
        private static int serie;
        private String? name;
        private String? address;
        private Double balance;

        public string? Address { get => address; set => address = value; }
        public double Balance { get => balance; set => balance = value; }
        public static int Serie { get => serie; set => serie = value; }
        public string? Name { get => name; set => name = value; }

        public Acc(int serie, string? name, string? address, double balance)
        {
            Serie = serie;
            Name = name;
            Address = address;
            Balance = balance;
        }
        //Chưa cần thiết
        //public void search()
        //{
        //}

    }
}
