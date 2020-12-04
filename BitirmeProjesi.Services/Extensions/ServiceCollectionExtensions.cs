using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection,string connectionString)
        {
            serviceCollection.AddDbContext<BitirmeProjesiContext>(options=>options.UseSqlServer(connectionString));
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                //USER PASSWORD OPTİONS
                //sifrede rakam bulunma durumu
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                //uniq karakterlerden kaç tane bulunması gerektiği (?!)
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                //USER USERNAME AND EMAİL OPTİONS
                //kullanıcı adı oluşturulurken sadece aşağıdaki özel karakterler kullanılabilir olucak.
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                //girilen emailden sistemde sadece bir tane olmasını sağladık.
                options.User.RequireUniqueEmail = true;



            }).AddEntityFrameworkStores<BitirmeProjesiContext>()
            .AddDefaultTokenProviders();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<ISerieService, SerieManager>();
            serviceCollection.AddScoped<IMovieService, MovieManager>();
            serviceCollection.AddScoped<IBookService, BookManager>();
            serviceCollection.AddScoped<IBookSerieMovieService, BookSerieMovieManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            serviceCollection.AddScoped<IActivityService, ActivityManager>();
            return serviceCollection;
        }
    }
}
