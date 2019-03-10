using System;
using System.Collections.Generic;

namespace Meetup.SheSharp.Eventos.Models
{
    class Evento
    {

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }

        public List<Palestrante> Palestrantes { get; set; }
        public List<Integrante> Inscritos { get; set; }

    }
}
