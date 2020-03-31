using System.Collections.Generic;
using PessoaAPI.BE;
using PessoaAPI.DAL;



namespace PessoaAPI.BLL
{
    public class BLLPessoa
    {
        public List<BEPessoa> RetornarPessoas(){
           return new DALPessoa().RetornarPessoas();
       }      
 
    }
}