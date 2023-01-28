using System;
using System.Collections.Generic;
using System.Linq;
namespace CQRSWithInterface.Application.Interfaces.Repository;

public interface IAsyncRepository<TEntity>
{
    Task<TEntity?> GetById(int id);
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> Create(TEntity entityToCreate);
}
