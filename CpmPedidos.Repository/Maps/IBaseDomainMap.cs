using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CpmPedidos.Repository.Maps
{
    public interface IBaseDomainMap<TDomain> where TDomain : BaseDomain
    {
        void Configure(EntityTypeBuilder<TDomain> builder);
    }
}