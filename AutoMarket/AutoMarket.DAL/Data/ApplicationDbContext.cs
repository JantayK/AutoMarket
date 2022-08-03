using AutoMarket.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMarket.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<CarCharacteristics> CarCharacteristics { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var advert = builder.Entity<Advert>();
            var user = builder.Entity<User>();
            var brand = builder.Entity<Brand>();
            var model = builder.Entity<Model>();
            var generation = builder.Entity<Generation>();
            var carCharacteristics = builder.Entity<CarCharacteristics>();
            var comment = builder.Entity<Comment>();

            advert.Property(x => x.ManufacturerYear).IsRequired();
            advert.Property(x => x.Mileage).IsRequired();
            advert.Property(x => x.Color).IsRequired();
            advert.Property(x => x.Condition).IsRequired();
            advert.Property(x => x.DateOfAddition).IsRequired();
            advert.Property(x => x.DriveType).IsRequired();
            advert.Property(x => x.FuelType).IsRequired();
            advert.Property(x => x.GearBox).IsRequired();
            advert.Property(x => x.Price).IsRequired();
            advert.Property(x => x.Steer).IsRequired();
            advert.Property(x => x.BodyType).IsRequired();
            advert.Property(x => x.EngineVolume).IsRequired();

            user.Property(x => x.FirstName).IsRequired();

            brand.Property(x => x.Name).IsRequired();

            model.Property(x => x.Name).IsRequired();

            carCharacteristics.Property(x => x.AccelerationTime).IsRequired();
            carCharacteristics.Property(x => x.AverageFuelConsumption).IsRequired();
            carCharacteristics.Property(x => x.Clearance).IsRequired();
            carCharacteristics.Property(x => x.Cylinders).IsRequired();
            carCharacteristics.Property(x => x.EnginePower).IsRequired();
            carCharacteristics.Property(x => x.FuelTankCapacity).IsRequired();
            carCharacteristics.Property(x => x.Height).IsRequired();
            carCharacteristics.Property(x => x.Length).IsRequired();
            carCharacteristics.Property(x => x.MaxSpeed).IsRequired();
            carCharacteristics.Property(x => x.Torque).IsRequired();
            carCharacteristics.Property(x => x.Weight).IsRequired();
            carCharacteristics.Property(x => x.Width).IsRequired();

            comment.Property(x => x.Text).IsRequired();

            brand.HasIndex(x => x.Name).IsUnique();
            model.HasIndex(x => x.Name).IsUnique();

            user.HasIndex(x => x.Email).IsUnique();
            user.HasIndex(x => x.PhoneNumber).IsUnique();

            generation.Property(x => x.BodyName).IsRequired();
        }
    }
}
