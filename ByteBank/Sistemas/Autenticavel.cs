﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface Autenticavel 
    {        
        String Senha { get; set; }
        bool Autenticar(String senha);
    }
}


