﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nome:Taína Carvalho 3 fase

namespace ProjetoFinalBiblioteca
{
    public class Generico : Exemplar
    {
        public int Tipo { get; set; }
        public Generico()
        {
        }
        public Generico(string titulo, string autor, int tipo)
        {
            Tipo = tipo;
        }
        public override string ToString()
        {
            return "";
        }
    }
    
}
