namespace Meetup.SheSharp.Eventos.Models
{
    public class Integrante : Pessoa
    {
        public int QtdFaltas { get; set; }
        public int QtdPresencas { get; set; }
        public bool FezTrabalho { get; set; }
    }
}
