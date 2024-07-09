﻿using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal abstract class DAL<T>
{
    public abstract IEnumerable<T> Listar();

    public abstract void Adicionar(T objeto);

    public abstract void Atualizar(T objeto);

    public abstract void Deletar(T objeto);
}
