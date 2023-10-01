using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace FurkanAslan_Restoran.Models
{
    public class DataContext:DbContext
    {
		public DataContext()
		{
		}

		public DataContext(DbContextOptions<DataContext> options):base(options) 
        { 
        }

        public DbSet<Garson> Garsons { get; set;}
        public DbSet<Icecek> Iceceks { get; set; }

        public DbSet<IcecekKategorileri> IcecekKategorileris { get; set; }
        public DbSet<Malzeme> Malzemes { get; set; }

        public DbSet<Masa> Masas { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Sef> Sefs { get; set; }
        public DbSet<Siparis> Sipariss { get; set; }
        public DbSet<Yemek> Yemeks { get; set; }

        public DbSet<YemekDurum> YemekDurums { get; set; }
        public DbSet<YemekKategorileri> YemekKategorileris { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RestoranVeriTabani");
        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusteriMasa>()
                .HasKey(t => new { t.Masa, t.Musteri });
            modelBuilder.Entity<MusteriMasa>()
                .HasOne(mum => mum.Musteri)
                .WithMany(mu => mu.MusteriMasalar)
                .HasForeignKey(mum => mum.Musteri);
            modelBuilder.Entity<MusteriMasa>()
                .HasOne(mum => mum.Masa)
                .WithMany(mu => mu.MusteriMasalar)
                .HasForeignKey(mum => mum.Masa);
        }*/
    }
}
