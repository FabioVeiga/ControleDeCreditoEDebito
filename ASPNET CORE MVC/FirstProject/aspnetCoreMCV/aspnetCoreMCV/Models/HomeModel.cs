using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetCoreMCV.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel
            {
                Id = 1,
                Nome = "Fabio"
            };
            lista.Add(item);

            item = new HomeModel
            {
                Id = 2,
                Nome = "Aluno"
            };
            lista.Add(item);

            return lista;

        }
    }
}
