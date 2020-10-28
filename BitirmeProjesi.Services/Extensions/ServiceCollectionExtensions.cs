using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BitirmeProjesiContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IBookService, BookManager>();
            serviceCollection.AddScoped<IMovieService, MovieManager>();
            serviceCollection.AddScoped<IBookService, BookManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            return serviceCollection;
        }
    }
}
