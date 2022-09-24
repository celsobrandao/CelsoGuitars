﻿// <auto-generated />
using System;
using CelsoGuitars.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CelsoGuitars.Repository.Migrations
{
    [DbContext(typeof(CelsoGuitarsContext))]
    partial class CelsoGuitarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CaptadorGuitarra", b =>
                {
                    b.Property<Guid>("CaptadoresID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuitarrasID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CaptadoresID", "GuitarrasID");

                    b.HasIndex("GuitarrasID");

                    b.ToTable("CaptadorGuitarra");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Cliente.Cliente", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Fornecedor.Marca", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("Marcas", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Guitarra", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BracoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("ConfiguracaoCaptadores")
                        .HasColumnType("tinyint");

                    b.Property<string>("ConfiguracaoCaptadoresOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CorpoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("PonteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TarraxaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrasteID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("BracoID");

                    b.HasIndex("CorpoID");

                    b.HasIndex("MarcaID");

                    b.HasIndex("PonteID");

                    b.HasIndex("TarraxaID");

                    b.HasIndex("TrasteID");

                    b.ToTable("Guitarras", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Braco", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("ComprimentoEscala")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte>("Formato")
                        .HasColumnType("tinyint");

                    b.Property<string>("FormatoOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte>("JuncaoBraco")
                        .HasColumnType("tinyint");

                    b.Property<string>("JuncaoBracoOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("MadeiraBracoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MadeiraEscalaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("QuantidadeTrastes")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("RaioEscala")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("ID");

                    b.HasIndex("MadeiraBracoID");

                    b.HasIndex("MadeiraEscalaID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Bracos", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Captador", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("CorCaptador")
                        .HasColumnType("tinyint");

                    b.Property<string>("CorCaptadorOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Resistencia")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<byte>("TipoCaptador")
                        .HasColumnType("tinyint");

                    b.Property<string>("TipoCaptadorOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Captadores", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Chaveamento", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("TipoChaveamento")
                        .HasColumnType("tinyint");

                    b.Property<string>("TipoChaveamentoOutro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Chaveamentos", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Corpo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MadeiraCorpoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MadeiraTopoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("MadeiraCorpoID");

                    b.HasIndex("MadeiraTopoID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Corpos", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Madeira", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Madeiras", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Ponte", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("Cor")
                        .HasColumnType("tinyint");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Pontes", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Tarraxa", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("Cor")
                        .HasColumnType("tinyint");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<bool>("IndicaComTrava")
                        .HasColumnType("bit");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Tarraxas", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Traste", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoFabricante")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("Cor")
                        .HasColumnType("tinyint");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<Guid>("MarcaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Trastes", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Servico.OrdemServico", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioServico")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataSaidaEfetiva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaidaPrevista")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuitarraID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<decimal>("PercentualDesconto")
                        .HasPrecision(5, 4)
                        .HasColumnType("decimal(5,4)");

                    b.Property<decimal?>("ValorEfetivo")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.Property<decimal>("ValorPrevisto")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("GuitarraID");

                    b.ToTable("OrdensServicos", (string)null);
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Servico.TipoServico", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int>("MinutosExecucao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("TiposServicos", (string)null);
                });

            modelBuilder.Entity("ChaveamentoGuitarra", b =>
                {
                    b.Property<Guid>("ChaveamentosID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuitarrasID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChaveamentosID", "GuitarrasID");

                    b.HasIndex("GuitarrasID");

                    b.ToTable("ChaveamentoGuitarra");
                });

            modelBuilder.Entity("OrdemServicoTipoServico", b =>
                {
                    b.Property<Guid>("OrdensServicosID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TiposServicosID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrdensServicosID", "TiposServicosID");

                    b.HasIndex("TiposServicosID");

                    b.ToTable("OrdemServicoTipoServico");
                });

            modelBuilder.Entity("CaptadorGuitarra", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Captador", null)
                        .WithMany()
                        .HasForeignKey("CaptadoresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Guitarra", null)
                        .WithMany()
                        .HasForeignKey("GuitarrasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Cliente.Cliente", b =>
                {
                    b.OwnsOne("CelsoGuitars.Domain.ValueObject.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ClienteID")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Email");

                            b1.HasKey("ClienteID");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteID");
                        });

                    b.Navigation("Email");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Guitarra", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Braco", "Braco")
                        .WithMany()
                        .HasForeignKey("BracoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Corpo", "Corpo")
                        .WithMany()
                        .HasForeignKey("CorpoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Ponte", "Ponte")
                        .WithMany()
                        .HasForeignKey("PonteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Tarraxa", "Tarraxa")
                        .WithMany()
                        .HasForeignKey("TarraxaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Traste", "Traste")
                        .WithMany()
                        .HasForeignKey("TrasteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Braco");

                    b.Navigation("Corpo");

                    b.Navigation("Marca");

                    b.Navigation("Ponte");

                    b.Navigation("Tarraxa");

                    b.Navigation("Traste");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Braco", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Madeira", "MadeiraBraco")
                        .WithMany()
                        .HasForeignKey("MadeiraBracoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Madeira", "MadeiraEscala")
                        .WithMany()
                        .HasForeignKey("MadeiraEscalaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MadeiraBraco");

                    b.Navigation("MadeiraEscala");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Captador", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Chaveamento", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Corpo", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Madeira", "MadeiraCorpo")
                        .WithMany()
                        .HasForeignKey("MadeiraCorpoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Madeira", "MadeiraTopo")
                        .WithMany()
                        .HasForeignKey("MadeiraTopoID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MadeiraCorpo");

                    b.Navigation("MadeiraTopo");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Madeira", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Ponte", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Tarraxa", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Guitarra.Parte.Traste", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Fornecedor.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Servico.OrdemServico", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Cliente.Cliente", "Cliente")
                        .WithMany("OrdensServicos")
                        .HasForeignKey("ClienteID");

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Guitarra", "Guitarra")
                        .WithMany()
                        .HasForeignKey("GuitarraID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Guitarra");
                });

            modelBuilder.Entity("ChaveamentoGuitarra", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Guitarra.Parte.Chaveamento", null)
                        .WithMany()
                        .HasForeignKey("ChaveamentosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Guitarra.Guitarra", null)
                        .WithMany()
                        .HasForeignKey("GuitarrasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrdemServicoTipoServico", b =>
                {
                    b.HasOne("CelsoGuitars.Domain.Servico.OrdemServico", null)
                        .WithMany()
                        .HasForeignKey("OrdensServicosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CelsoGuitars.Domain.Servico.TipoServico", null)
                        .WithMany()
                        .HasForeignKey("TiposServicosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CelsoGuitars.Domain.Cliente.Cliente", b =>
                {
                    b.Navigation("OrdensServicos");
                });
#pragma warning restore 612, 618
        }
    }
}
