using System;
using System.Collections.Generic;
using System.Text;

namespace Espadana.Service.Contract
{
    public class CreateResultDto<TKey>
    {
        public TKey CreatedId { get; set; }
    }
}
