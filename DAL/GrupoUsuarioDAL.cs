using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                try
                {
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "INSERT INTO GrupoUsuario(NomeGrupo) Values (@NomeGrupo)";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);

                    cmd.Connection = cn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu erro ao tentar inserir um grupo no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        public List<Usuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection=cn;
                cmd.CommandText = "SELECT Id, Nome, NomeGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32 (rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = rd["Ativo"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar todos os grupos do banco de dados",ex);
            }
        }
        public GrupoUsuario BuscarPorNomeGrupo(string _nomeGrupo)
        {
            GrupoUsuario _grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _nomeGrupo);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        _grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        _grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                    }
                }
                return _grupoUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar nome do grupo de usuários do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public GrupoUsuario BuscaPorId(int _id)
        {
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM grupoUsuario where Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["Nome"].ToString();
                    }
                }
                return grupoUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar id do grupo de usuários do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE GrupoUsuario SET NomeGrupo = @NomeGrupo, Id = @Id";
                //cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@Id", _grupoUsuario.Id);
    
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um grupo de usuários no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM GrupoUsuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Grupo no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}