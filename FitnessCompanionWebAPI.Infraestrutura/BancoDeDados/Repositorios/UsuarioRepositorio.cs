using FitnessCompanionWebAPI.Aplicacao.Repositorios;
using FitnessCompanionWebAPI.Dominio.Entidades;
using FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Contexto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Infraestrutura.BancoDeDados.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(FitnessCompanionContexto fitnessCompanionContexto) : base(fitnessCompanionContexto)
        {

        }

        public Task Editar(Usuario usuario, CancellationToken cancellationToken)
        {
            usuario.DataAtualizacao = DateTime.Now;
            return UpdateAsync(usuario);
        }

        public Task<Usuario> InserirAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            return CreateAsync(usuario, cancellationToken);
        }

        public IEnumerable<Usuario> Listar()
        {
            return QueryAll();
        }

        public Task<Usuario> Obter(Guid id, CancellationToken cancellationToken = default)
        {
            return GetAsync(cancellationToken, id);
        }

        public Task<Usuario> ObterPorEmail(string email, CancellationToken cancellationToken)
        {
            return GetAsync(u => u.Email.ToLower() == email.ToLower());
            //return Task.FromResult(usuario);
        }
    }
}
