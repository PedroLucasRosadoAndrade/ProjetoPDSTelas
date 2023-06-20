﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDePDS3_A.Models
{
    internal class Filme
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        public Sexo Sexo { get; set; }

        public Endereco Endereco { get; set; }
    }
}
