﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
