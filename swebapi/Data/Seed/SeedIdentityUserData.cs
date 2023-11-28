namespace swebapi.Data.Seed;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using swebapi.Models;

public static class SeedIdentityUserData
{
    public static void SeedUserIDentityData(this ModelBuilder modelBuilder)
    {
        string AdministradorGeneralRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id= AdministradorGeneralRoleId,
            Name="Administrador",
            NormalizedName = "Administrador".ToUpper(),
        });

        string UsuarioGeneralRoleId = Guid.NewGuid().ToString();
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = UsuarioGeneralRoleId,
            Name = "Usuario general",
            NormalizedName = "Usuario general".ToUpper()
        });

        var UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName = "gvera@uv.mx",
                Email = "gvera@uv.mx",
                NormalizedEmail = "gvera@uv.mx".ToUpper(),
                Nombre="Guillermo Humberto Vera Amaro",
                NormalizedUserName = "gvera@uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "gverapwd")
            }
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorGeneralRoleId,
                UserId = UsuarioId,
            }
        );

        UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName="sperez@uv.mx",
                Email="sperez@uv.mx",
                NormalizedEmail = "sperez@uv.mx".ToUpper(),
                Nombre="Saul Perez Garcia",
                NormalizedUserName="sperez@uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "saulpwd")
            }
        );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorGeneralRoleId,
                UserId = UsuarioId
            }
        );

        UsuarioId = Guid.NewGuid().ToString();
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName = "gochoa@gmail.com",
                Email = "gochoa@gmail.com",
                NormalizedEmail = "gochoa@gmail.com".ToUpper(),
                Nombre = "Gerardo Ochoa Martinez",
                NormalizedUserName = "gochoa@gmail.com".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null, "saulpwd")
            }
        )
        ;

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorGeneralRoleId,
                UserId = UsuarioId
            }
        );


    }

}
