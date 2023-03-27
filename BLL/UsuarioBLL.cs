using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL;
using BLL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmarSenha)
        {
            ValidarPermissao(2);
            ValidarDados(_usuario, _confirmarSenha);

            if (_usuario.Senha.Length <= 3)

                throw new Exception("A senha deve ter mais de 3 caracteres");


            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario, string _confirmarSenha)
        {
            ValidarPermissao(3);
            ValidarDados(_usuario, _confirmarSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(4);
            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorCPF(string _cpf)
        {
            return new UsuarioDAL().BuscarPorCPF(_cpf);
        }
        public Usuario BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        private void ValidarDados(Usuario _usuario, string _confirmarSenha)
        {    

            if (_usuario.Senha != _confirmarSenha)
                throw new Exception("A senha e a confirmação de senha devem ser iguais");


            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres");
            if (_usuario.Nome.Length <= 2)
                throw new Exception("o nome deve ter mais de 2 caracteres");

        }
        public void ValidarPermissao(int _idPermissao)
        {
            //if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
            //{
              //  throw new Exception("Você não tem permissão para realizar essa operação. Procure o adiministrador do sistema");

            //}
        }
        public void ValidarPermissaoUsuarioLogado(int _idPermissaoUsuarioLogdo)
        {
            //if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissaoUsuarioLogdo))
            //    throw new Exception("Você não tem permissão para realizar essa operação. Procure o adiministrador do sistema");

            //  }
        }
        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            if (!new UsuarioDAL().UsuarioPertenceAoGrupo(_idUsuario, _idUsuario))
                new UsuarioDAL().AdcionarGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            new UsuarioDAL().RemoverGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
        public void Altenticar(string _nomeUsuario, string _Senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
            if (_Senha == usuario.Senha && usuario.Ativo)
                Constantes.IdUsuarioLogado = usuario.Id;
            else
                throw new Exception("Usuário ou senha inválidos.");      
        }
    }
}



