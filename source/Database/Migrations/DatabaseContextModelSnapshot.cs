// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace DotNetCoreArchitecture.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreArchitecture.Model.UserEntity", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email").IsRequired().HasMaxLength(300);
                    b.Property<string>("Login").IsRequired().HasMaxLength(100);
                    b.Property<string>("Name").IsRequired().HasMaxLength(100);
                    b.Property<string>("Password").IsRequired().HasMaxLength(500);
                    b.Property<int>("Roles");
                    b.Property<int>("Status");
                    b.Property<string>("Surname").IsRequired().HasMaxLength(200);

                    b.HasKey("UserId");

                    b.HasIndex("Email").IsUnique();
                    b.HasIndex("Login").IsUnique();

                    b.ToTable("Users", "User");

                    b.HasData(new
                    {
                        UserId = 1L,
                        Email = "administrator@administrator.com",
                        Login = "admin",
                        Name = "Administrator",
                        Password = "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==",
                        Roles = 3,
                        Status = 1,
                        Surname = "Administrator"
                    });
                });

            modelBuilder.Entity("DotNetCoreArchitecture.Model.UserLogEntity", b =>
            {
                b.Property<long>("UserLogId")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Content").HasMaxLength(8000);
                b.Property<DateTime>("DateTime");
                b.Property<int>("LogType");
                b.Property<long>("UserId");

                b.HasKey("UserLogId");

                b.HasIndex("UserId");

                b.ToTable("UsersLogs", "User");
            });

            modelBuilder.Entity("DotNetCoreArchitecture.Model.UserLogEntity", b =>
            {
                b.HasOne("DotNetCoreArchitecture.Model.UserEntity", "User")
                    .WithMany("UsersLogs")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
