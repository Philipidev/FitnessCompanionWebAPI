using FitnessCompanionWebAPI.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Aplicacao.Repositorios
{
    public interface IUsuarioRepositorio
    {
        //Usuario Inserir(Usuario usuario);
        Task<Usuario> InserirAsync(Usuario usuario, CancellationToken cancellationToken = default);
        IEnumerable<Usuario> Listar();
        Task<Usuario> Obter(Guid id, CancellationToken cancellationToken = default);
        Task Editar(Usuario usuario, CancellationToken cancellationToken);
        Task<Usuario> ObterPorEmail(string email, CancellationToken cancellationToken);
    }
}
