﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Screen.Shared.Modelos.Modelos;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class ScreenSoundContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; }

    public DbSet<Musica> Musicas { get; set; }

    public DbSet<Genero> Generos { get; set; }

    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSoundV0;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies(false);
    }
}
