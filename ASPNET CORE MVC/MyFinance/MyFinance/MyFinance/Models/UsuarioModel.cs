using MyFinance.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        //tags helpers
        //campo NOME obrigatorio
        [Required(ErrorMessage ="Preencha o nome!")]
        public string Nome { get; set; }
        //campo EMAIL obrigatorio
        [Required(ErrorMessage = "Preencha o email!")]
        //valida o email
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Email invalido!")]
        public string Email { get; set; }
        //campo Senha obrigatorio
        [Required(ErrorMessage = "Preencha o senha!")]
        public string Senha { get; set; }
        //campo Data obrigatorio
        [Required(ErrorMessage = "Preencha o data de nascimento!")]
        public string Data_Nasimento { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, NOME, DATA_NASCIMENTO FROM USUARIO WHERE EMAIL='{Email}' AND SENHA='{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if(dt.Rows.Count == 1)
                {
                    Id = int.Parse(dt.Rows[0]["ID"].ToString());
                    Nome = dt.Rows[0]["NOME"].ToString();
                    Data_Nasimento = dt.Rows[0]["DATA_NASCIMENTO"].ToString();
                    return true;
                }
            }

            return false;
        }

        public void RegistrarUsuario()
        {
            string sql = $"insert into usuario(Nome,Email,Senha,Data_Nascimento) values('{Nome}', '{Email}', '{Senha}', '{DateTime.Parse(Data_Nasimento).ToString("yyyy-MM-dd")}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
