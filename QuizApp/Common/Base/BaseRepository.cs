using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuizApp.Data;
using QuizApp.Model;

namespace QuizApp.Common.Base;

public class BaseRepository<TId, TModel> where TModel : Entity<TId>
{
    private readonly QuizAppContext _context;

    public BaseRepository()
    {
        _context = new QuizAppContext();
    }

    public TModel? GetById(TId id)
    {
        return _context.Set<TModel>().Find(id);
    }

    public IQueryable<TModel> Where(Expression<Func<TModel, bool>> predicate)
    {
        return _context.Set<TModel>().Where(predicate);
    }

    public TModel Add(TModel model)
    {
        var entry = _context.Set<TModel>().Add(model);
        _context.SaveChanges();
        return entry.Entity;
    }
}