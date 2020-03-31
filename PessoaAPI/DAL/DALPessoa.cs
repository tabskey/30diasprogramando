using Npgsql;
using System.Collections.Generic;
using System;
using PessoaAPI.BE;


namespace PessoaAPI.DAL
{
    public class DALPessoa
    {public List<BEPessoa> RetornarPessoas(){
            var connString = "Host=localhost;Username=postgres;Password=senha;Database=DotNetCoreAPI";

            List<BEPessoa> lstPessoa = new List<BEPessoa>();

            try{
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT id, cpf, Nome FROM \"Pessoa\"", conn))
                    using (var reader = cmd.ExecuteReader())
                    while (reader.Read()){
                        BEPessoa pessoa = new BEPessoa();
                        pessoa.Id = (Int64)reader["id"];
                        pessoa.CPF = (Int64)reader["cpf"];
                        pessoa.Nome = reader.GetString(2);
                        lstPessoa.Add(pessoa);
                    }
                    conn.Close();
                }
            }catch(Exception ex){
                string teste = ex.Message;
            }       
            

            return lstPessoa; 
        }
    }
}