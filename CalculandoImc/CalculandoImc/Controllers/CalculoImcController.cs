﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoImc.Controllers
{
    public class CalculoImcController : ApiController
    {
        public string Get(string nomeUsuario, double peso, double altura)
        {
            var imc = peso / Math.Pow(altura, 2);
            return $"Olá {nomeUsuario} seu imc é {imc} e foi calculado de acordo com sua altura: {altura} e peso: {peso}";
        }
    }
}
