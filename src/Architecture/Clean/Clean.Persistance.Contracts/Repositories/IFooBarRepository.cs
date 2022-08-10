using Clean.Domain.Entities;

using System.Collections.Generic;

namespace Clean.Persistance.Contracts.Repositories
{
    public interface IFooBarRepository
    {
        IReadOnlyList<FooBar> Get(int name);
    }
}
