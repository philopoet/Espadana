using Espadana.Domain;
using Espadana.Service.Contract;
using Pap.WebPushManagement.Infrastructure.Persistence;
using System;
using System.Linq;

namespace Espadana.Service
{
    public class EspadanaService: IEspadanaService
    {
        private readonly EspadanaContext _context;

        public EspadanaService(EspadanaContext context)
        {
            _context = context;
        }
        public Guid CreateEspadanaUser(EspadanaUserDto user)
        {
            var Id = Guid.NewGuid();
            _context.EspadanaUsers.Add(new EspadanaUser()
            {
                Id = Id,
                Name = user.Name,
                CreationDate = DateTime.Now,
                LastModifiedDate = DateTime.Now,
            });
            _context.SaveChanges();
            return Id;
        }
        public EspadanaUserDto GetEspadanaUser(Guid userId)
        {
            var user = _context.EspadanaUsers.FirstOrDefault(user => user.Id == userId);
            return new EspadanaUserDto()
            {
                Id = user.Id,
                Name = user.Name,
            };
        }
    }
}
