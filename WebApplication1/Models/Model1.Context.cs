﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebApplication1.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class WEBATTENDANCEEntities : DbContext
{
    public WEBATTENDANCEEntities()
        : base("name=WEBATTENDANCEEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<CHITIETMONHOC> CHITIETMONHOCs { get; set; }

    public virtual DbSet<DONVI> DONVIs { get; set; }

    public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }

    public virtual DbSet<LOP> LOPs { get; set; }

    public virtual DbSet<MONHOC> MONHOCs { get; set; }

    public virtual DbSet<NHOM> NHOMs { get; set; }

    public virtual DbSet<PHONG> PHONGs { get; set; }

    public virtual DbSet<ROLE> ROLEs { get; set; }

    public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

    public virtual DbSet<TKB> TKBs { get; set; }

    public virtual DbSet<FORMLUUTRU> FORMLUUTRUs { get; set; }

    public virtual DbSet<DIEMDANH> DIEMDANHs { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

}

}

