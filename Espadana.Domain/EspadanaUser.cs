using Framework.Domain;
using System;

namespace Espadana.Domain
{
    public class EspadanaUser : Entity<Guid,EspadanaUser>
    {
        public string Name { get; set; }
    }
}
