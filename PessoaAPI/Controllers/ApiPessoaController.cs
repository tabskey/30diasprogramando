using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PessoaAPI.BLL;
using PessoaAPI.BE;


namespace PessoaAPI.Controllers
{
       [Route("api/[controller]")]

        public class ApiPessoaController : Controller
    {
        // fazer um GET simples api/values
        [HttpGet("{id}")]
       public List<PessoaAPI.BE.BEPessoa> Get(){
           return new BLLPessoa().RetornarPessoas();
       }      
    }
}