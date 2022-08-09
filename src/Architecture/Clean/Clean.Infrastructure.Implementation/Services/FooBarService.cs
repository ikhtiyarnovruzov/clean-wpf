using Clean.Domain.Entities;
using Clean.Infrastructure.Contracts.Services;
using Clean.Infrastructure.Transferables;

using System.Collections.Generic;

namespace Clean.Infrastructure.Implementation.Services
{
    public class FooBarService : IFooBarService
    {
        public IReadOnlyList<FooBarDTO> Unify(FooBar fooBar)
        {
            throw new System.NotImplementedException();
        }
    }
}
