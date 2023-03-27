using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class Permissao
    {
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int Id { get; set; }

        public void Inserir(Models.Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Permissao(Descricao) Values (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Permissao", _permissao.Descricao);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma descrição no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Models.Permissao> BuscarTodos()
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Models.Permissao> permissoes = new List<Models.Permissao>();
            Models.Permissao permissao;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Models.Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar todos as permissões do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Models.Permissao BuscarPorDescricao(string _descricao)
        {
            List<Models.Permissao> permissaoList = new List<Models.Permissao>();
            Models.Permissao permissao = new Models.Permissao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao where Descricao like @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return permissao;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Models.Permissao BuscaPorId(int _id)
        {
            Models.Permissao permissao = new Models.Permissao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao where Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return permissao;
            }
            catch (Exception ex)
            {

                throw new Exception("ocorreu um erro ao tentar buscar id no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Models.Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Permissao SET Descricao = @Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@Id", _permissao.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma permissão no banco de dados.", ex);
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
                cmd.CommandText = "DELETE FROM Permissao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma permissão no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorDescrissao(string descrissao)
        {
            throw new NotImplementedException();
        }
    }
}
