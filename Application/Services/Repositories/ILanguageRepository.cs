
using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Repositories
{
    public interface ILanguageRepository:IAsyncRepository<Language>,IRepository<Language>
    {
      
    }
}
