﻿using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class ArtistaDAL : DAL<Artista>
{
    private readonly ScreenSoundContext context;

    public ArtistaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public override IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();
    }

    public override void Adicionar(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    public override void Atualizar(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    public override void Deletar(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();
    }

    public Artista? RecuperarPeloNome(string nome)
    {
        return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
    }
}
