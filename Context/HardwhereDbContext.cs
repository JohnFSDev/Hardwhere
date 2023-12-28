using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hardwhere_API.Context;

public partial class HardwhereDbContext : DbContext
{
    public HardwhereDbContext()
    {

    }

    public HardwhereDbContext(DbContextOptions<HardwhereDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<GraphicCard> GraphicCards { get; set; }

    public virtual DbSet<Processor> Processors { get; set; }

    public virtual DbSet<Ram> Rams { get; set; }

    public virtual DbSet<StorageMemory> StorageMemories { get; set; }

    public virtual DbSet<Supply> Supplies { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasKey(e => e.IdComponents).HasName("PRIMARY");

            entity.ToTable("components");

            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasColumnName("brand");
            entity.Property(e => e.Consults).HasColumnName("consults");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<GraphicCard>(entity =>
        {
            entity.HasKey(e => e.IdGraphic).HasName("PRIMARY");

            entity.ToTable("graphic_card");

            entity.HasIndex(e => e.IdComponents, "id_components").IsUnique();

            entity.Property(e => e.IdGraphic).HasColumnName("id_graphic");
            entity.Property(e => e.Coprocessor)
                .HasMaxLength(50)
                .HasColumnName("coprocessor");
            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(50)
                .HasColumnName("url_img");
            entity.Property(e => e.VramSize)
                .HasMaxLength(50)
                .HasColumnName("vram_size");

            entity.HasOne(d => d.IdComponentsNavigation).WithOne(p => p.GraphicCard)
                .HasForeignKey<GraphicCard>(d => d.IdComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("graphic_card_ibfk_1");
        });

        modelBuilder.Entity<Processor>(entity =>
        {
            entity.HasKey(e => e.IdProcessor).HasName("PRIMARY");

            entity.ToTable("processors");

            entity.HasIndex(e => e.IdComponents, "id_components").IsUnique();

            entity.Property(e => e.IdProcessor).HasColumnName("id_processor");
            entity.Property(e => e.Cpu)
                .HasMaxLength(50)
                .HasColumnName("CPU");
            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Speed)
                .HasMaxLength(50)
                .HasColumnName("speed");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(50)
                .HasColumnName("url_img");

            entity.HasOne(d => d.IdComponentsNavigation).WithOne(p => p.Processor)
                .HasForeignKey<Processor>(d => d.IdComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("processors_ibfk_1");
        });

        modelBuilder.Entity<Ram>(entity =>
        {
            entity.HasKey(e => e.IdRam).HasName("PRIMARY");

            entity.ToTable("ram");

            entity.HasIndex(e => e.IdComponents, "id_components").IsUnique();

            entity.Property(e => e.IdRam).HasColumnName("id_ram");
            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.RamSize)
                .HasMaxLength(50)
                .HasColumnName("ram_size");
            entity.Property(e => e.RamSpeed)
                .HasMaxLength(50)
                .HasColumnName("ram_speed");
            entity.Property(e => e.RamTech)
                .HasMaxLength(50)
                .HasColumnName("ram_tech");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(50)
                .HasColumnName("url_img");

            entity.HasOne(d => d.IdComponentsNavigation).WithOne(p => p.Ram)
                .HasForeignKey<Ram>(d => d.IdComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ram_ibfk_1");
        });

        modelBuilder.Entity<StorageMemory>(entity =>
        {
            entity.HasKey(e => e.IdSmemory).HasName("PRIMARY");

            entity.ToTable("storage_memory");

            entity.HasIndex(e => e.IdComponents, "id_components").IsUnique();

            entity.Property(e => e.IdSmemory).HasColumnName("id_smemory");
            entity.Property(e => e.ConnectivityTech)
                .HasMaxLength(50)
                .HasColumnName("connectivity_tech");
            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.Storage)
                .HasMaxLength(50)
                .HasColumnName("storage");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(50)
                .HasColumnName("url_img");

            entity.HasOne(d => d.IdComponentsNavigation).WithOne(p => p.StorageMemory)
                .HasForeignKey<StorageMemory>(d => d.IdComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("storage_memory_ibfk_1");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity.HasKey(e => e.IdSupply).HasName("PRIMARY");

            entity.ToTable("supply");

            entity.HasIndex(e => e.IdComponents, "id_components").IsUnique();

            entity.Property(e => e.IdSupply).HasColumnName("id_supply");
            entity.Property(e => e.ConnectorType)
                .HasMaxLength(50)
                .HasColumnName("connector_type");
            entity.Property(e => e.IdComponents).HasColumnName("id_components");
            entity.Property(e => e.MinimumInput)
                .HasMaxLength(50)
                .HasColumnName("minimum_input");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(50)
                .HasColumnName("url_img");
            entity.Property(e => e.Wattage)
                .HasMaxLength(50)
                .HasColumnName("wattage");

            entity.HasOne(d => d.IdComponentsNavigation).WithOne(p => p.Supply)
                .HasForeignKey<Supply>(d => d.IdComponents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supply_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
