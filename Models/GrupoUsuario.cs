using System;
using System.Collections.Generic;

namespace Models
{
    public class GrupoUsuario
    {
        public int Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}
