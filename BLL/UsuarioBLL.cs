using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.Senha.Length <= 3)

                throw new Exception("A senha deve ter mais de 3 caracteres");


            PermissaoDAL usuarioDAL = new PermissaoDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValidarDados(_usuario);
            UsuariosDAL usuarioDAL = new UsuariosDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            new UsuarioDAL ().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL ().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuariosDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorCPF(string _cpf)
        {
            return new PermissaoDAL().BuscarPorCPF(_cpf);
        }
        public Usuario BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuariosDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        private void ValidarDados(Usuario _usuario)
        {
            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres");
            if (_usuario.Nome.Length <= 2)
                throw new Exception("o nome deve ter mais de 2 caracteres");

        }

        private class UsuarioDAL
        {
            public UsuarioDAL()
            {
            }

            internal Usuario BuscarPorNome(string nome)
            {
                throw new NotImplementedException();
            }

            internal List<Usuario> BuscarTodos()
            {
                throw new NotImplementedException();
            }

            internal void Excluir(int id)
            {
                throw new NotImplementedException();
            }
        }
    }
}


