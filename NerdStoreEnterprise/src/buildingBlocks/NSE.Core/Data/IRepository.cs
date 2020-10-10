﻿using NSE.Core.DomainObjects;
using System;

namespace NSE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : Entity, IAggregateRoot { }
}