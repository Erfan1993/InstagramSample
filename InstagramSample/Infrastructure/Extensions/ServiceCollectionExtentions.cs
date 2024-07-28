using DataLayer.Repository;
using Infrastructure.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions;
public static class ServiceCollectionExtentions
{
    public static void AddInfrastructurServices(this IServiceCollection services , IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<InstagramDBContext>(opt=>opt.UseSqlServer(connectionString));   
        
        services.AddScoped<IPostReposiory, PostRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IFollowRepository, FollowRepository>();
    }
}
