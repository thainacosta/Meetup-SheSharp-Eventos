using Meetup.SheSharp.Eventos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Meetup.SheSharp.Eventos.WebAPI
{
    public class PalestranteRepository
    {
        IList<Palestrante> Palestrantes;

        public PalestranteRepository()
        {
            Palestrantes = new List<Palestrante>()
            {
                new Palestrante()
                {
                    Id = 1,
                    Nome = "Ana Manzan",
                    Email = "ana@developers-sp.com.br",
                    RG = "12345",
                    Skills = new List<string>()
                    {
                        "C#",
                        ".NET",
                        "HTTP"

                    }

                },

                new Palestrante()
                {
                    Id = 2,
                    Nome = "Thamires",
                    Email = "tamires@developers-sp.com.br",
                    RG = "34567",
                    Skills = new List<string>()
                    {
                        "C#",
                        ".NET",
                        "HTTP"

                    }

                }
            };
            
        }

        public IList<Palestrante> RetornaTudo()
        {
            return Palestrantes;
        }

        public Palestrante RetornabyId(int id)
        {
            return Palestrantes.Where(x => x.Id == id).FirstOrDefault();
        }
            
        public Palestrante AdicionarPalestrante(Palestrante palestrante)
        {
            // Simula a inclusao do palestrante na lista 

            palestrante.Id = 3;
            Palestrantes.Add(palestrante);

            return palestrante;
        }

        public Palestrante AtualizaPalestrante (Palestrante palestrante)
        {
            // Simula a alteracao do palestrante na lista 


            var palestranteOld = this.RetornabyId(palestrante.Id);

            palestranteOld.Id = palestrante.Id;
            palestranteOld.Email = palestrante.Email;
            palestranteOld.RG = palestrante.RG;
            palestranteOld.Skills = palestrante.Skills;

            // salvar as alteracoes 

            //retornando o palestranteOld
            return palestranteOld;
        }

        public IList<Palestrante> ExcluiPalestrante(int id)
        {
            var palestrante = RetornaTudo().Where(x => x.Id == id).FirstOrDefault();

            Palestrantes.Remove(palestrante);
            return Palestrantes;
        }

    }
}
