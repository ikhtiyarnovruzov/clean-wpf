using Clean.Domain.Entities;
using Clean.Infrastructure.Transferables;

using System.Collections.Generic;

namespace Clean.Infrastructure.Contracts.Services
{
    public interface IFooBarService
    {
        IReadOnlyList<FooBarDTO> Unify(FooBar fooBar);
    }
}
