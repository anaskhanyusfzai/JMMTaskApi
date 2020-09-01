﻿// <auto-generated />
using System;
using JMMTaskApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JMMTaskApi.Migrations
{
    [DbContext(typeof(jmmContext))]
    [Migration("20200829112653_ChangedPPriceTypeToInt")]
    partial class ChangedPPriceTypeToInt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JMMTaskApi.Customer", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("c_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CAddress")
                        .IsRequired()
                        .HasColumnName("c_address")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnName("c_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CPhone")
                        .IsRequired()
                        .HasColumnName("c_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CId")
                        .HasName("PK__Customer__213EE774A73BA1F6");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("JMMTaskApi.OrderProduct", b =>
                {
                    b.Property<int>("OpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("op_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OId")
                        .HasColumnName("o_id")
                        .HasColumnType("int");

                    b.Property<int>("OpQuantity")
                        .HasColumnName("op_quantity")
                        .HasColumnType("int");

                    b.Property<int>("PId")
                        .HasColumnName("p_id")
                        .HasColumnType("int");

                    b.HasKey("OpId")
                        .HasName("PK__Order_Pr__A26AE2CEA6F14704");

                    b.HasIndex("OId");

                    b.HasIndex("PId");

                    b.ToTable("Order_Product");
                });

            modelBuilder.Entity("JMMTaskApi.Orders", b =>
                {
                    b.Property<int>("OId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("o_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CId")
                        .HasColumnName("c_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ODate")
                        .HasColumnName("o_date")
                        .HasColumnType("datetime");

                    b.Property<string>("OType")
                        .IsRequired()
                        .HasColumnName("o_type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("SId")
                        .HasColumnName("s_id")
                        .HasColumnType("int");

                    b.HasKey("OId")
                        .HasName("PK__ORDERS__904BC20E6DAFDC73");

                    b.HasIndex("CId");

                    b.HasIndex("SId");

                    b.ToTable("ORDERS");
                });

            modelBuilder.Entity("JMMTaskApi.Product", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("p_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PCode")
                        .IsRequired()
                        .HasColumnName("p_code")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnName("p_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("PPrice")
                        .HasColumnName("p_price")
                        .HasColumnType("int");

                    b.Property<int>("PStock")
                        .HasColumnName("p_stock")
                        .HasColumnType("int");

                    b.HasKey("PId")
                        .HasName("PK__Product__82E06B91AA14A403");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("JMMTaskApi.Supplier", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("s_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SAddress")
                        .IsRequired()
                        .HasColumnName("s_address")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SIban")
                        .IsRequired()
                        .HasColumnName("s_iban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnName("s_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SPhone")
                        .IsRequired()
                        .HasColumnName("s_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId")
                        .HasName("PK__Supplier__2F3684F43611EC1C");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("JMMTaskApi.OrderProduct", b =>
                {
                    b.HasOne("JMMTaskApi.Orders", "O")
                        .WithMany("OrderProduct")
                        .HasForeignKey("OId")
                        .HasConstraintName("FK_Orders_OrderProduct")
                        .IsRequired();

                    b.HasOne("JMMTaskApi.Product", "P")
                        .WithMany("OrderProduct")
                        .HasForeignKey("PId")
                        .HasConstraintName("FK_OrderProduct_Product")
                        .IsRequired();
                });

            modelBuilder.Entity("JMMTaskApi.Orders", b =>
                {
                    b.HasOne("JMMTaskApi.Customer", "C")
                        .WithMany("Orders")
                        .HasForeignKey("CId")
                        .HasConstraintName("FK_ORDERS_CUSTOMER");

                    b.HasOne("JMMTaskApi.Supplier", "S")
                        .WithMany("Orders")
                        .HasForeignKey("SId")
                        .HasConstraintName("FK_ORDERS_SUPPLIERS");
                });
#pragma warning restore 612, 618
        }
    }
}
