using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using Microsoft.VisualBasic;

namespace Gerenciando_SQL_Server_Compact_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarBD_Click(object sender, EventArgs e)
        {
            /* define os parâmetros para o inputbox */
            string Prompt = "Informe o nome do Banco de Dados a ser criado.Ex: Teste.sdf";
            string Titulo = "www.macoratti.net";
            string Resultado = Interaction.InputBox(Prompt, Titulo, @"c:\dados\Agenda.sdf", 650, 350);
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (Resultado != "")
            {
                if (!Resultado.Contains(".sdf"))
                {
                    MessageBox.Show("Informe a extensão .sdf no arquivo...");
                    return;
                }
                try
                {
                    string connectionString;
                    string nomeArquivoBD = Resultado;
                    string senha = "";

                    if (File.Exists(nomeArquivoBD))
                    {
                        if (MessageBox.Show("O arquivo já existe !. Deseja excluir e criar novamente ? ", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            File.Delete(nomeArquivoBD);
                        }
                        else
                        {
                            return;
                        }
                    }

                    connectionString = string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, senha);

                    if (MessageBox.Show("Será criado arquivo " +  connectionString  +" Confirma ? ", "Criar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCeEngine SqlEng = new SqlCeEngine(connectionString);
                        SqlEng.CreateDatabase();
                        lblResultado.Text = "Banco de dados " + nomeArquivoBD + " com sucesso !";
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("A operação foi cancelada...");
            }
         }

        private void btnCriarTabelas_Click(object sender, EventArgs e)
        {
                /* define os parâmetros para o inputbox */
                string Prompt = "Informe o nome da tabela a ser criada.Ex: Teste";
                string Titulo = "www.macoratti.net";
                string Resultado = Interaction.InputBox(Prompt, Titulo, "Contatos", 650, 350);
                /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */

                if (Resultado != "")
                {
                    if (Resultado.Contains(".sdf"))
                    {
                        MessageBox.Show("Não informe a extensão .sdf no arquivo...");
                        return;
                    }

                    SqlCeConnection cn = new SqlCeConnection(stringConexao());

                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlCeCommand cmd;

                    string sql = "create table " + Resultado + "("
                               + "Nome nvarchar (60) not null, "
                               + "Sobrenome nvarchar (80), "
                               + "URL nvarchar (150) )";

                    cmd = new SqlCeCommand(sql, cn);

                    if (MessageBox.Show("Confirma a criação da tabela ? ", "Criar Tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            lblResultado.Text = "Tabela " + Resultado + " criada com sucesso ";
                        }
                        catch (SqlCeException sqlexception)
                        {
                            MessageBox.Show(sqlexception.Message, "Caramba.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Caramba.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("A operação foi cancelada...");
                }
        }

         private string stringConexao()
         {
             string connectionString="";
             try
             {
                 string nomeArquivo = @"c:\dados\Agenda.sdf";
                 string senha = "";
                 connectionString = string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivo, senha);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             return connectionString;
         }

         private void btnCarregarTabela_Click(object sender, EventArgs e)
         {
                try
                {
                    CarregarLinha("Macoratti", "Jose Carlos", @"http:\\www.macoratti.net");
                    CarregarLinha("Janice", "Rachel", @"janjan@uol.com.br");
                    CarregarLinha("Jefferson", "Andre", @"jeff@bol.com.br");
                    CarregarLinha("Miriam", "Estela", @"mimi@hotmail.com");
                    CarregarLinha("Jessica", "Naara", @"jessicalang@ig.com.br");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oxente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         }
         private void CarregarLinha(string nome, string sobrenome, string url)
         {
                SqlCeConnection cn = new SqlCeConnection(stringConexao());
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                SqlCeCommand cmd;
                string sql = "insert into Contatos "
                            + "(sobrenome, nome, url) "
                            + "values (@sobrenome, @nome, @url)";
                try
                {
                    cmd = new SqlCeCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@url", url);
                    cmd.ExecuteNonQuery();
                    lblResultado.Text = "Linha Incluída.";
                }
                catch (SqlCeException sqlexception)
                {
                    MessageBox.Show(sqlexception.Message, "Uaí Sô.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uaí Sô.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                cn.Close();
                }
          }

        private void btnCarregarGrid_Click(object sender, EventArgs e)
        {
                SqlCeConnection cn = new SqlCeConnection(stringConexao());
                if (cn.State==ConnectionState.Closed)
                {
                    try
                    {
                        cn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                try
                {
                    // define o command par ausar a tabela e não a consulta
                    SqlCeCommand cmd = new SqlCeCommand("Contatos", cn);
                    cmd.CommandType = CommandType.TableDirect;

                    // Pega a tabela
                    SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);

                    // carrega o resultado no grid 
                    dgvDados.DataSource = rs;
                }
                catch (SqlCeException sqlexception)
                {
                    MessageBox.Show(sqlexception.Message, "Arre Égua.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Arre Égua.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
       }

         private void btnLerRegistros_Click(object sender, EventArgs e)
         {
             SqlCeConnection cn = new SqlCeConnection(stringConexao());
             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }
             // Monta a consulta SQL 
             string sql = "select sobrenome, nome from Contatos ";
             try
             {
                 SqlCeCommand cmd = new SqlCeCommand(sql, cn);
                 cmd.CommandType = CommandType.Text;
                 SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable);
                 // se você precisa atualizar o result set então use:
                 // SqlCeResultSet rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable | ResultSetOptions.Updatable);
                 if (rs.HasRows)
                 {
                     int ordSobrenome = rs.GetOrdinal("sobrenome");
                     int ordNome = rs.GetOrdinal("nome");
                     // trata a saida
                     StringBuilder saida = new StringBuilder();
                     // le o primeiro registro e pega os dados
                     rs.ReadFirst();
                     saida.AppendLine(rs.GetString(ordNome) + " " + rs.GetString(ordSobrenome));
                     while (rs.Read())
                     {
                         saida.AppendLine(rs.GetString(ordNome) + " " + rs.GetString(ordSobrenome));
                     }
                     // defina a saida
                     lblResultado.Text = saida.ToString();
                 }
                 else
                 {
                     lblResultado.Text = "Nenhum registro encontrado.";
                 }
             }
             catch (SqlCeException sqlexception)
             {
                 MessageBox.Show(sqlexception.Message, "Bah Tchê.", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Bah Tchê.", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 cn.Close();
             }
         }
    }           
}
