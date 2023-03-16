using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissaoBLL
    {
        private object permissaoDAL;

        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Senha.Length <= 3)

                throw new Exception("A senha deve ter mais de 3 caracteres");


            GrupoUsuariosDAL usuarioDAL = new GrupoUsuariosDAL();
            usuarioDAL.Inserir(_permissao);
        }
        public void Alterar(Permissao _permissao)
        {
            ValidarDados(_permissao);
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }

        private void ValidarDados(Permissao permissao)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int _id)
        {
            new GrupoUsuariosDAL().Excluir(_id);
        }
        public Usuario BuscarPorDescrissao(string _descrissao)
        {
            return new GrupoUsuariosDAL().BuscarPorDescrissao(_descrissao);
        }
    }
}
