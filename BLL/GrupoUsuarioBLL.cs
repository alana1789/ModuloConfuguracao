using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.Senha.Length <= 3)

                throw new Exception("A senha deve ter mais de 3 caracteres");


            PermissaoDAL grupoUsuarioDAL = new PermissaoDAL();
            grupoUsuarioDAL.Inserir(_grupoUsuario);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            ValidarDados(_grupoUsuario);
            PermissaoDAL GrupoUsuarioDAL = new PermissaoDAL();
            GrupoUsuarioDAL.Alterar(_grupoUsuario);
        }
        public void Excluir(int _id)
        {
            new GrupoUsuario().Excluir(_id);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarPorId(_id);
        }
        public GrupoUsuario BuscarPorGrupo(string _nome)
        {
            return new PermissaoDAL().BuscarPorDescrissao(_nome);
        }
        private void ValidarDados(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres");
            if (_grupoUsuario.Nome.Length <= 2)
                throw new Exception("o nome deve ter mais de 2 caracteres");

        }
    }
}

