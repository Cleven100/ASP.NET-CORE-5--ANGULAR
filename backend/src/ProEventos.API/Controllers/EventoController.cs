using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
     
        public IEnumerable<Evento> _evento = new Evento[]{
             new Evento(){
                        eventoId = 1,
                        tema = "Angular e .net",
                        local = "Rio de janeiro",
                        lote =  "1",
                        quantidadePessoa = 200,
                        dataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                        imagemURL = "foto.png"
                    },

                    new Evento(){
                        eventoId = 2,
                        tema = "React .dotnet Core 6",
                        local = "Rio de janeiro",
                        lote =  "15",
                        quantidadePessoa = 2000,
                        dataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                        imagemURL = "foto1.png"
                    }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          
         return _evento;

         }

          [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
          
         return _evento.Where(evento => evento.eventoId == id);

         }
        


        [HttpPost]
        public string Post()
        {
                
          return "Exemplo de post";
         }


        [HttpPut("{id}")]
        public string Put(int id)
        {
                
          return $"Exemplo de put com id {id}";
         }  

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
                
          return $"Exemplo de Delete com id {id}";
         } 



            }

    }

   

