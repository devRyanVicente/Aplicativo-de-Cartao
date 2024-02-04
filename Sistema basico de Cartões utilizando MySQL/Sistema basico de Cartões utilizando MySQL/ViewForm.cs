using MySql.Data.MySqlClient;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexao;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Sistema_basico_de_Cartões_utilizando_MySQL
{
    public partial class ViewForm : Form
    {
        Conexaoclass con = new Conexaoclass();
        DataTable dtLista = new DataTable();
        SetForm form2 = new SetForm();
        string sql;
        MySqlCommand cmd;
        public ViewForm()
        {
            InitializeComponent();
            DataGridDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void MostrarResultados()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM cartoes";
            //SELECT CartaoNome FROM cartoes
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                //filtro
                string nomeDaColuna = "CartaoNome";
                string filtro = string.Format("[{0}] LIKE '%{1}%'", nomeDaColuna, txtPesquisa.Text);
                dtLista.DefaultView.RowFilter = filtro;
                //filtro
                DataGridDB.DataSource = dtLista;

            }
            catch
            {
                MessageBox.Show("An error occurred: ");
            }
            finally
            {

                if (con.con != null && con.con.State == ConnectionState.Open)
                {
                    con.con.Close();
                }
            }

        }


        public void filtrargrade()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM cartoes WHERE CartaoNome LIKE @busca";
            string boxescolha1 = boxPesquisaescolha.Text.ToString();
            if (boxescolha1 == "ID")
            {
                strSQL = "SELECT * FROM cartoes WHERE Id LIKE @busca";
            }
            else if (boxescolha1 == "Nome")
            {
                strSQL = "SELECT * FROM cartoes WHERE CartaoNome LIKE @busca";
            }
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                objCommand.Parameters.AddWithValue("@busca", "%" + txtPesquisa.Text + "%");

                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);

                // Verifica se há linhas retornadas da consulta
                if (dtLista.Rows.Count > 0)
                {
                    // Atribui os dados ao DataGridView
                    DataGridDB.DataSource = dtLista;

                    // Mostra os dados do primeiro registro nos campos de texto
                    txtOlharIDCartao.Text = dtLista.Rows[0]["Id"].ToString();
                    txtOlharNomeCartao.Text = dtLista.Rows[0]["CartaoNome"].ToString();
                    txtOlharValorCartao.Text = dtLista.Rows[0]["ValorCartao"].ToString();
                }
                else
                {
                    // Se nenhum resultado for encontrado, limpa o DataGridView e os campos de texto
                    DataGridDB.DataSource = null;
                    txtOlharIDCartao.Text = "";
                    txtOlharNomeCartao.Text = "";
                    txtOlharValorCartao.Text = "";
                }
            }
            catch
            {
                // Tratar a exceção conforme necessário

            }
            finally
            {
                if (con.con != null && con.con.State == ConnectionState.Open)
                {
                    con.FecharCon();
                }

            }
        }

        public void MostrarResultadosTotal()
        {
            MySqlCommand objCommand = null;
            string strSQL = "SELECT * FROM cartoes";
            MySqlConnection cmd = null;
            try
            {
                con.AbrirCon();
                objCommand = new MySqlCommand(strSQL, con.con);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                string nomeDaColuna = "CartaoNome";
                string filtro = string.Format("[{0}] LIKE '%{1}%'", nomeDaColuna, txtPesquisa.Text);
                dtLista.DefaultView.RowFilter = filtro;
                DataGridDB.DataSource = dtLista;

            }
            catch
            {
                MessageBox.Show("Erro ao Carregar GRID, a database existe?");
            }
            finally
            {

                if (con.con != null && con.con.State == ConnectionState.Open)
                {
                    con.con.Close();
                }
            }
        }
        private async Task LoopVerificarConexao()
        {
            while (true)
            {
                bool conexaoativada = await con.LoopVerificarConexao();
                txtconexaoativaoudesativa.BackColor = Color.Gray;
                txtconexaoativaoudesativa.Invoke((MethodInvoker)delegate
                {
                    txtconexaoativaoudesativa.Text = conexaoativada ? "Ativa!" : "Desativada!";
                    txtconexaoativaoudesativa.BackColor = conexaoativada ? Color.Green : Color.Red;
                });
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }
        private void View_Load(object sender, EventArgs e)
        {
            LoopVerificarConexao();
            MostrarResultadosTotal();
        }


        private void btnCriadorCartao_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void DataGridDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //pega a linha que você selecionou é mostra nos textboxes mesma coisa do cellcontentclick fiz duas vezes por segurança
                string idSelecionado = DataGridDB.Rows[e.RowIndex].Cells["Id"].Value.ToString(); txtOlharIDCartao.Text = idSelecionado;
                string nomeSelecionado = DataGridDB.Rows[e.RowIndex].Cells["CartaoNome"].Value.ToString(); txtOlharNomeCartao.Text = nomeSelecionado;
                string valorSelecionado = DataGridDB.Rows[e.RowIndex].Cells["ValorCartao"].Value.ToString(); txtOlharValorCartao.Text = valorSelecionado;
                string DataCriadoSelecionado = DataGridDB.Rows[e.RowIndex].Cells["DataCriado"].Value.ToString(); txtOlharDataCriado.Text = DataCriadoSelecionado;
                string DataModificadoSelecionado = DataGridDB.Rows[e.RowIndex].Cells["DataModificado"].Value.ToString(); txtOlharDataModificado.Text = DataModificadoSelecionado;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrargrade();
        }

        private void RemoverConta()
        {
            try
            {
                string IDNovoAlterar = txtOlharIDCartao.Text; // Não vou dar opção de alterar para evitar bugs futuros na propria SQL

                con.AbrirCon();
                sql = "DELETE FROM cartoes WHERE Id = @idcartao;";
                cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                cmd.Parameters.AddWithValue("@idcartao", IDNovoAlterar);
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    btnConfirmarAlteracoes.Visible = false;
                    txtOlharNomeCartao.ReadOnly = true;
                    txtOlharValorCartao.ReadOnly = true;
                    txtOlharIDCartao.Text = "";
                    txtOlharNomeCartao.Text = "";
                    txtOlharValorCartao.Text = "";
                    txtOlharDataCriado.Text = "";
                    txtOlharDataModificado.Text = "";
                    MessageBox.Show("Registro Removido com Sucesso!");
                    MostrarResultados(); // atualizar Grid
                    txtPesquisa.Focus(); // input no txtPesquisa
                }
                else
                {
                    MessageBox.Show("Nenhum registro alterado. Verifique o ID selecionado.");
  
                }
            }
            
            catch (Exception)
            {

                throw;
            }
        }
        private void AtualizarContas()
        {
            try
            {
                string IDNovoAlterar = txtOlharIDCartao.Text; // Não vou dar opção de alterar para evitar bugs futuros na propria SQL
                string NomeNovoAlterar = txtOlharNomeCartao.Text; txtOlharNomeCartao.ReadOnly = false;
                string ValorNovoAlterar = txtOlharValorCartao.Text; txtOlharValorCartao.ReadOnly = false;
                DateTime datamod = DateTime.Now;
                con.AbrirCon();
                sql = "UPDATE cartoes SET CartaoNome = @novonomecartao, ValorCartao = @valornovo, DataModificado = @datamod WHERE id = @idcartao";
                cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                cmd.Parameters.AddWithValue("@idcartao", IDNovoAlterar);
                cmd.Parameters.AddWithValue("@novonomecartao", NomeNovoAlterar);
                cmd.Parameters.AddWithValue("@valornovo", ValorNovoAlterar);
                cmd.Parameters.AddWithValue("@datamod", datamod);

                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    btnConfirmarAlteracoes.Visible = false;
                    txtOlharNomeCartao.ReadOnly = true;
                    txtOlharValorCartao.ReadOnly = true;
                    MessageBox.Show("Registro alterado com sucesso!");
                    MostrarResultados(); // atualizar Grid
                    txtPesquisa.Focus(); // input no txtPesquisa
                }
                else
                {
                    MessageBox.Show("Nenhum registro alterado. Verifique o ID selecionado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnConfirmarAlteracoes_Click(object sender, EventArgs e)
        {
            AtualizarContas();
            btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
            btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
            txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
            btnAlterarInfo.Visible = true; btnConfirmarExclusaoUser.Visible = false;
            btnExcluirUser.Visible = false;
            txtPesquisa.Focus();
        }

        private void btnCancelarAlteracao_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
            btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
            txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
            btnAlterarInfo.Visible = true; btnConfirmarExclusaoUser.Visible = false;
            btnExcluirUser.Visible = false;
            txtPesquisa.Focus();
        }

        private void btnAlterarInfo_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = false; btnCriadorCartao.Visible = false;
            btnConfirmarAlteracoes.Visible = true; btnCancelarAlteracao.Visible = true;
            txtOlharNomeCartao.ReadOnly = false; txtOlharValorCartao.ReadOnly = false;
            btnAlterarInfo.Visible = false; btnExcluirUser.Visible = true;

        }

        private void txtOlharDataUtilizado_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPesquisa.Text != "")
            {
                filtrargrade();
            }
        }

        private void txtOlharValorCartao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up && txtOlharValorCartao.ReadOnly == false)
            {
                txtOlharNomeCartao.Focus();
            }
            else if (e.KeyCode == Keys.Enter && txtOlharValorCartao.ReadOnly == false)
            {// atualizar contas sem clicar no botao para atualizar
                AtualizarContas();
                btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
                btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
                txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
                btnAlterarInfo.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {//cancelar
                btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
                btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
                txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
                btnAlterarInfo.Visible = true;
                txtPesquisa.Focus();
            }
        }

        private void txtOlharNomeCartao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtOlharNomeCartao.ReadOnly == false)
            {
                txtOlharValorCartao.Focus();
            }
            else if (e.KeyCode == Keys.Enter && txtOlharValorCartao.ReadOnly == false)
            {
                txtOlharValorCartao.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {//cancelar
                btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
                btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
                txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
                btnAlterarInfo.Visible = true;
                txtPesquisa.Focus();
            }

        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            //  RemoverContas(); // fazer confirmação deseja realmente deletar o ID ** DATABASE?

            string idexistente = txtOlharIDCartao.Text;
            string value = Regex.Replace(idexistente, "[A-Za-z ]", "");
            MessageBox.Show(value);
            if (idexistente != "")
            {
                btnBuscar.Visible = false; btnCriadorCartao.Visible = false;
                btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = true; 
                txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
                btnAlterarInfo.Visible = false; btnConfirmarExclusaoUser.Visible = true;
                btnExcluirUser.Visible = false;

            }
            else if (idexistente == "")
            {
                MessageBox.Show("Selecione um ID, Ou Escreva Manualmente.");
            }

        }

        private void btnConfirmarExclusaoUser_Click(object sender, EventArgs e)
        {
            // RemoverContas();
            btnBuscar.Visible = true; btnCriadorCartao.Visible = true;
            btnConfirmarAlteracoes.Visible = false; btnCancelarAlteracao.Visible = false;
            txtOlharNomeCartao.ReadOnly = true; txtOlharValorCartao.ReadOnly = true;
            btnAlterarInfo.Visible = true; btnConfirmarExclusaoUser.Visible = false;
            btnExcluirUser.Visible = false;
            RemoverConta();
        }

        private void clickPegarIdAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (clickPegarIdAutomatico.Checked == true)
            {
                txtOlharIDCartao.ReadOnly = false;
                btnBuscarManual.Visible = true;
            }
            else if (clickPegarIdAutomatico.Checked == false)
            {
                txtOlharIDCartao.ReadOnly = true;
                btnBuscarManual.Visible = false;
            }
        }

        private void btnBuscarManual_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirCon();
                sql = "SELECT * FROM cartoes WHERE Id = @idcampo";
                //                sql = "SELECT * FROM cartoes WHERE CartaoNome = @nomecartao OR Id = @idcartao"; // verificação
                cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                                                      //               cmd.Parameters.AddWithValue("@idcampo", "%" + txtOlharIDCartao + 
                cmd.Parameters.AddWithValue("@idcampo", txtOlharIDCartao.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    uint i = dr.GetUInt32(0);
                    string olharidcartaotxt = i.ToString();
                    double valcartao = dr.GetDouble(2);
                    string valcarstring = valcartao.ToString();

                    txtOlharIDCartao.Text = olharidcartaotxt;
                    txtOlharNomeCartao.Text = dr.GetString(1);
                    txtOlharValorCartao.Text = valcarstring;
                }
                else
                {
                    MessageBox.Show("Registro Não Encontrado!");
                }
                dr.Close(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}

//esta parte do codigo é desnecessaria
//vou deixar apenas pra algum curioso aleatorio kk
//este codigo funciona em box sozinhas ou seja sem grid
//prefiri fazer com o grid porque é bem melhor pro uso
// e tambem porque preciso estudar mais do c#
 