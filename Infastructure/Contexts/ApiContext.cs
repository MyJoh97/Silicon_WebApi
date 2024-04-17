using Infastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Infastructure.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscribersEntity> Subscribers { get; set; }
}
