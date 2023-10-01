﻿// <auto-generated />
using FurkanAslan_Restoran.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FurkanAslanRestoran.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230814084737_GarsonDeneme2")]
    partial class GarsonDeneme2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Garson", b =>
                {
                    b.Property<int>("GarsonId_Pk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GarsonId_Pk"));

                    b.Property<string>("GarsonAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GarsonMasaId")
                        .HasColumnType("int");

                    b.Property<string>("GarsonSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GarsonSube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GarsonTC")
                        .HasColumnType("int");

                    b.Property<int>("GarsonYemekDurumId")
                        .HasColumnType("int");

                    b.Property<int>("GarsonYemekId")
                        .HasColumnType("int");

                    b.HasKey("GarsonId_Pk");

                    b.ToTable("Garsons");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Icecek", b =>
                {
                    b.Property<int>("Icecek_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Icecek_Id"));

                    b.Property<string>("Icecek_Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Icecek_Adet")
                        .HasColumnType("int");

                    b.Property<int>("Icecek_Kat_Id")
                        .HasColumnType("int");

                    b.Property<int>("Icecek_Miktar")
                        .HasColumnType("int");

                    b.Property<string>("Icecek_Skt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Icecek_Id");

                    b.ToTable("Iceceks");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.IcecekKategorileri", b =>
                {
                    b.Property<int>("icecek_kat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("icecek_kat_id"));

                    b.Property<string>("icecek_kategori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("icecek_kat_id");

                    b.ToTable("IcecekKategorileris");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Malzeme", b =>
                {
                    b.Property<int>("Mal_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mal_Id"));

                    b.Property<string>("Mal_Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mal_Adet")
                        .HasColumnType("int");

                    b.Property<string>("Mal_Skt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mal_Sube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mal_Uretimy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mal_Id");

                    b.ToTable("Malzemes");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Masa", b =>
                {
                    b.Property<int>("masa_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("masa_id"));

                    b.Property<int>("masa_m_id")
                        .HasColumnType("int");

                    b.Property<int>("masa_ymk_durum")
                        .HasColumnType("int");

                    b.Property<int>("masa_ymk_id")
                        .HasColumnType("int");

                    b.HasKey("masa_id");

                    b.ToTable("Masas");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Musteri", b =>
                {
                    b.Property<int>("m_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("m_id"));

                    b.Property<string>("m_ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("m_masa_id")
                        .HasColumnType("int");

                    b.Property<string>("m_soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("m_yemek_durum")
                        .HasColumnType("int");

                    b.Property<int>("m_yemek_id")
                        .HasColumnType("int");

                    b.HasKey("m_id");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Request", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<int>("User_Age")
                        .HasColumnType("int");

                    b.Property<string>("User_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_Phone")
                        .HasColumnType("int");

                    b.Property<string>("User_Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Sef", b =>
                {
                    b.Property<int>("sef_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sef_id"));

                    b.Property<string>("sef_ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sef_kul_mal_id")
                        .HasColumnType("int");

                    b.Property<string>("sef_soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sef_yemek_durum")
                        .HasColumnType("int");

                    b.Property<int>("sef_yemek_id")
                        .HasColumnType("int");

                    b.HasKey("sef_id");

                    b.ToTable("Sefs");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiparisId"));

                    b.Property<int>("GarsonId_Fk")
                        .HasColumnType("int");

                    b.Property<int>("GarsonId_Pk")
                        .HasColumnType("int");

                    b.Property<int>("SiparisIcecekId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisMalzeme")
                        .HasColumnType("int");

                    b.Property<int>("SiparisMasaId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisMusteriId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisYemekDurumId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisYemekId")
                        .HasColumnType("int");

                    b.HasKey("SiparisId");

                    b.HasIndex("GarsonId_Pk");

                    b.ToTable("Sipariss");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Yemek", b =>
                {
                    b.Property<int>("Ymk_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ymk_Id"));

                    b.Property<string>("Ymk_Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ymk_Durum")
                        .HasColumnType("int");

                    b.Property<int>("Ymk_Kat_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ymk_Sef_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ymk_Spr_Id")
                        .HasColumnType("int");

                    b.HasKey("Ymk_Id");

                    b.ToTable("Yemeks");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.YemekDurum", b =>
                {
                    b.Property<int>("ymk_durum_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ymk_durum_id"));

                    b.Property<string>("ymk_durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ymk_durum_id");

                    b.ToTable("YemekDurums");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.YemekKategorileri", b =>
                {
                    b.Property<int>("ymk_kat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ymk_kat_id"));

                    b.Property<string>("ymk_kategori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ymk_kat_id");

                    b.ToTable("YemekKategorileris");
                });

            modelBuilder.Entity("FurkanAslan_Restoran.Models.Siparis", b =>
                {
                    b.HasOne("FurkanAslan_Restoran.Models.Garson", "Garson")
                        .WithMany()
                        .HasForeignKey("GarsonId_Pk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garson");
                });
#pragma warning restore 612, 618
        }
    }
}
