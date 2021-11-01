using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONGarniza.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cnpj { get; set; }
        public string Local { get; set; }
        public string Hour { get; set; }
        public string Start { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Donations { get; set; }
        public string Description { get; set; }
    }
}
