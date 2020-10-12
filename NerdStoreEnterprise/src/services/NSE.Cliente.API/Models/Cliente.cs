﻿using NSE.Core.DomainObjects;

namespace NSE.Cliente.API.Models
{
    public class Cliente : Entity, IAggregateRoot
    {
        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Excluido = false;
        }

        // EF Relation
        protected Cliente() { }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public bool Excluido { get; private set; }
        public Endreco Endreco { get; private set; }
    }
}