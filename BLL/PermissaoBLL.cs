using System;
using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(DAL.Permissao _permissao)
        {
            if (_permissao.Senha.Length <= 3)

                throw new Exception("A senha deve ter mais de 3 caracteres");


            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public void Alterar(DAL.Permissao _permissao)
        {
            ValidarDados(_permissao);
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }

        private void ValidarDados(DAL.Permissao permissao)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int _id)
        {
            new PermissaoDAL().Excluir(_id);
        }
        public List<DAL.Permissao> BuscarTodos()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public DAL.Permissao BuscarPorDescricao(string _descricao)
        {
            return new PermissaoDAL().BuscarPorDescricao(_descricao);
        }

        private void ValidarDados1(DAL.Permissao _descricao)
        {
            if (_descricao.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres");
            if (_descricao.Nome.Length <= 2)
                throw new Exception("o nome deve ter mais de 2 caracteres");

        }

        private class PermissaoDAL
        {
            public PermissaoDAL()
            {
            }

            internal void Alterar(DAL.Permissao permissao)
            {
                throw new NotImplementedException();
            }

            internal DAL.Permissao BuscarPorDescricao(string descricao)
            {
                throw new NotImplementedException();
            }

            internal List<DAL.Permissao> BuscarTodos()
            {
                throw new NotImplementedException();
            }

            internal void Excluir(int id)
            {
                throw new NotImplementedException();
            }

            internal void Inserir(DAL.Permissao permissao)
            {
                throw new NotImplementedException();
            }
        }
    }
}


