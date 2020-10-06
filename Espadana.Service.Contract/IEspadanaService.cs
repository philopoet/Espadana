using System;
using System.Collections.Generic;
using System.Text;

namespace Espadana.Service.Contract
{
    public interface IEspadanaService
    {
        Guid CreateEspadanaUser(EspadanaUserDto user);
        EspadanaUserDto GetEspadanaUser(Guid userId);
    }
}
