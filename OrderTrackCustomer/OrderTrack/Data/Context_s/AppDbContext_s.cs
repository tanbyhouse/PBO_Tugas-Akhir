using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OrderTrack.Models_s;

namespace OrderTrack.Data.Context_s;

public partial class AppDbContext_s : DbContext
{
    public AppDbContext_s()
    {
    }

    public AppDbContext_s(DbContextOptions<AppDbContext_s> options)
        : base(options)
    {
    }

    public virtual DbSet<Browny> Brownies { get; set; }

    public virtual DbSet<DetailPesanan> DetailPesanans { get; set; }

    public virtual DbSet<LaporanBulanan> LaporanBulanans { get; set; }

    public virtual DbSet<LaporanHarian> LaporanHarians { get; set; }

    public virtual DbSet<LaporanTahunan> LaporanTahunans { get; set; }

    public virtual DbSet<Pelanggan> Pelanggans { get; set; }

    public virtual DbSet<Pesanan> Pesanans { get; set; }

    public virtual DbSet<VarianBrowny> VarianBrownies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=ep-sweet-heart-a881gavm-pooler.eastus2.azure.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_qQRVHWN3cSz4;SSL Mode=Require;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("status_pelanggan_enum", new[] { "active", "completed_order", "archived" })
            .HasPostgresEnum("status_pesanan_enum", new[] { "pending", "diproses", "dikirim", "diterima", "dibatalkan", "ditolak" });

        modelBuilder.Entity<Browny>(entity =>
        {
            entity.HasKey(e => e.IdBrownies).HasName("brownies_pkey");

            entity.ToTable("brownies");

            entity.Property(e => e.IdBrownies).HasColumnName("id_brownies");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.HargaBrownies)
                .HasPrecision(10, 2)
                .HasColumnName("harga_brownies");
            entity.Property(e => e.IdVarian).HasColumnName("id_varian");
            entity.Property(e => e.KuantitasBrownies)
                .HasPrecision(10, 2)
                .HasColumnName("kuantitas_brownies");
            entity.Property(e => e.NamaBrownies)
                .HasMaxLength(25)
                .HasColumnName("nama_brownies");
            entity.Property(e => e.SatuanKuantitas)
                .HasMaxLength(25)
                .HasColumnName("satuan_kuantitas");

            entity.HasOne(d => d.IdVarianNavigation).WithMany(p => p.Brownies)
                .HasForeignKey(d => d.IdVarian)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_brownies_id_varian");
        });

        modelBuilder.Entity<DetailPesanan>(entity =>
        {
            entity.HasKey(e => e.IdDetailPesanan).HasName("detail_pesanan_pkey");

            entity.ToTable("detail_pesanan");

            entity.HasIndex(e => new { e.IdPesanan, e.IdBrownies }, "detail_pesanan_id_pesanan_id_brownies_key").IsUnique();

            entity.Property(e => e.IdDetailPesanan).HasColumnName("id_detail_pesanan");
            entity.Property(e => e.HargaSatuanSaatPesan)
                .HasPrecision(10, 2)
                .HasColumnName("harga_satuan_saat_pesan");
            entity.Property(e => e.IdBrownies).HasColumnName("id_brownies");
            entity.Property(e => e.IdPesanan).HasColumnName("id_pesanan");
            entity.Property(e => e.JumlahItem).HasColumnName("jumlah_item");
            entity.Property(e => e.TotalHargaItem)
                .HasPrecision(10, 2)
                .HasColumnName("total_harga_item");

            entity.HasOne(d => d.IdBrowniesNavigation).WithMany(p => p.DetailPesanans)
                .HasForeignKey(d => d.IdBrownies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_detail_pesanan_id_brownies");

            entity.HasOne(d => d.IdPesananNavigation).WithMany(p => p.DetailPesanans)
                .HasForeignKey(d => d.IdPesanan)
                .HasConstraintName("fk_detail_pesanan_id_pesanan");
        });

        modelBuilder.Entity<LaporanBulanan>(entity =>
        {
            entity.HasKey(e => e.IdLaporanBulanan).HasName("laporan_bulanan_pkey");

            entity.ToTable("laporan_bulanan");

            entity.HasIndex(e => new { e.Bulan, e.Tahun }, "laporan_bulanan_bulan_tahun_key").IsUnique();

            entity.Property(e => e.IdLaporanBulanan).HasColumnName("id_laporan_bulanan");
            entity.Property(e => e.Bulan).HasColumnName("bulan");
            entity.Property(e => e.Tahun).HasColumnName("tahun");
            entity.Property(e => e.TotalPenghasilanBulanIni)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("total_penghasilan_bulan_ini");
            entity.Property(e => e.TotalPesananBulanIni)
                .HasDefaultValue(0)
                .HasColumnName("total_pesanan_bulan_ini");
        });

        modelBuilder.Entity<LaporanHarian>(entity =>
        {
            entity.HasKey(e => e.IdLaporanHarian).HasName("laporan_harian_pkey");

            entity.ToTable("laporan_harian");

            entity.HasIndex(e => e.Tanggal, "laporan_harian_tanggal_key").IsUnique();

            entity.Property(e => e.IdLaporanHarian).HasColumnName("id_laporan_harian");
            entity.Property(e => e.Tanggal).HasColumnName("tanggal");
            entity.Property(e => e.TotalPenghasilanBersih)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("total_penghasilan_bersih");
            entity.Property(e => e.TotalPesananSelesai)
                .HasDefaultValue(0)
                .HasColumnName("total_pesanan_selesai");
        });

        modelBuilder.Entity<LaporanTahunan>(entity =>
        {
            entity.HasKey(e => e.IdLaporanTahunan).HasName("laporan_tahunan_pkey");

            entity.ToTable("laporan_tahunan");

            entity.HasIndex(e => e.Tahun, "laporan_tahunan_tahun_key").IsUnique();

            entity.Property(e => e.IdLaporanTahunan).HasColumnName("id_laporan_tahunan");
            entity.Property(e => e.Tahun).HasColumnName("tahun");
            entity.Property(e => e.TotalPenghasilanTahunIni)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0.00")
                .HasColumnName("total_penghasilan_tahun_ini");
            entity.Property(e => e.TotalPesananTahunIni)
                .HasDefaultValue(0)
                .HasColumnName("total_pesanan_tahun_ini");
        });

        modelBuilder.Entity<Pelanggan>(entity =>
        {
            entity.HasKey(e => e.IdPelanggan).HasName("pelanggan_pkey");

            entity.ToTable("pelanggan");

            entity.HasIndex(e => e.NomorHp, "pelanggan_nomor_hp_key").IsUnique();

            entity.Property(e => e.IdPelanggan).HasColumnName("id_pelanggan");
            entity.Property(e => e.AlamatPelanggan).HasColumnName("alamat_pelanggan");
            entity.Property(e => e.NamaPelanggan)
                .HasMaxLength(100)
                .HasColumnName("nama_pelanggan");
            entity.Property(e => e.NomorHp)
                .HasMaxLength(20)
                .HasColumnName("nomor_hp");
        });

        modelBuilder.Entity<Pesanan>(entity =>
        {
            entity.HasKey(e => e.IdPesanan).HasName("pesanan_pkey");

            entity.ToTable("pesanan");

            entity.Property(e => e.IdPesanan).HasColumnName("id_pesanan");
            entity.Property(e => e.IdPelanggan).HasColumnName("id_pelanggan");
            entity.Property(e => e.TanggalPesanan)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnName("tanggal_pesanan");


            entity.HasOne(d => d.IdPelangganNavigation).WithMany(p => p.Pesanans)
                .HasForeignKey(d => d.IdPelanggan)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_pesanan_id_pelanggan");
        });

        modelBuilder.Entity<VarianBrowny>(entity =>
        {
            entity.HasKey(e => e.IdVarian).HasName("varian_brownies_pkey");

            entity.ToTable("varian_brownies");

            entity.HasIndex(e => e.NamaVarian, "varian_brownies_nama_varian_key").IsUnique();

            entity.Property(e => e.IdVarian).HasColumnName("id_varian");
            entity.Property(e => e.DeskripsiVarian).HasColumnName("deskripsi_varian");
            entity.Property(e => e.NamaVarian)
                .HasMaxLength(100)
                .HasColumnName("nama_varian");
        });
        modelBuilder.Entity<Pelanggan>()
            .Property(e => e.StatusPelanggan)
            .HasConversion<string>(); // Ini penting untuk Npgsql agar disimpan sebagai string

        // Konfigurasi untuk enum StatusPesanan
        modelBuilder.Entity<Pesanan>()
            .Property(e => e.StatusPesanan)
            .HasConversion<string>();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
