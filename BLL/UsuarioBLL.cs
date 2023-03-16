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


            GrupoUsuariosDAL usuarioDAL = new GrupoUsuariosDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValidarDados(_usuario);
            GrupoUsuariosDAL usuarioDAL = new GrupoUsuariosDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            new GrupoUsuariosDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new GrupoUsuariosDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new GrupoUsuariosDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorCPF(string _cpf)
        {
            return new GrupoUsuariosDAL().BuscarPorCPF(_cpf);
        }
        public Usuario BuscarPorNome(string _nome)
        {
            return new GrupoUsuariosDAL().BuscarPorDescrissao(_nome);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new GrupoUsuariosDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        private void ValidarDados(Usuario _usuario)
        {
            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres");
            if (_usuario.Nome.Length <= 2)
                throw new Exception("o nome deve ter mais de 2 caracteres");

        }
    }
}


