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
using System.Reflection.Metadata.Ecma335;
namespace Sistema_basico_de_Cartões_utilizando_MySQL
{
    public partial class SetForm : Form
    {
        Conexaoclass con = new Conexaoclass();

        string sql;
        MySqlCommand cmd;
        public SetForm()
        {
            InitializeComponent();
            clickPegarIdAutomatico.Checked = true;
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
        private void criarconta()
        {
            string criarcartaoid = txtCriarIDCartao.Text;
            string criarcartaonome = txtCriarNomeCartao.Text;
            string criarcartaovalor = txtValorCartao.Text;
            int autoid; // idcartao 

            //string datautilizacao = "NULL"; // porque estamos criando não utilizando!
            DateTime datacriacao = DateTime.Now;
            if (criarcartaonome != "")
            {

                con.AbrirCon();
                sql = "SELECT COUNT(*) FROM cartoes WHERE Id = @idcartao OR CartaoNome = @nomecartao"; // verificação
                cmd = new MySqlCommand(sql, con.con); // inicializando cmd
                cmd.Parameters.AddWithValue("@idcartao", criarcartaoid);
                cmd.Parameters.AddWithValue("@nomecartao", criarcartaonome);
                //                        cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@datautilizacao", datautilizacao);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                //fazer uma verificação caso tenha algum igual no banco de dados utilizando mesmo id ou algo parecido == !erro!
                if (count > 0)
                {
                    MessageBox.Show("Já existe um registro com o mesmo ID ou nome de cartão.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (criarcartaoid.ToString() == "") // autoid 
                    {
                        sql = "INSERT INTO cartoes VALUES (@idcartao, @nomecartao, @valorcartao, @datacriacao, NULL)";
                        autoid = LastId(); // idcartao 
                        cmd = new MySqlCommand(sql, con.con);//arumar nao ta indo pro cmd
                        cmd.Parameters.AddWithValue("@idcartao", autoid);//arumar nao ta indo pro cmd
                        cmd.Parameters.AddWithValue("@nomecartao", criarcartaonome);
                        cmd.Parameters.AddWithValue("@valorcartao", criarcartaovalor);
                        cmd.Parameters.AddWithValue("@datacriacao", datacriacao);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        sql = "INSERT INTO cartoes VALUES (@idcartao, @nomecartao, @valorcartao, @datacriacao, NULL)";
                        cmd = new MySqlCommand(sql, con.con);//arumar nao ta indo pro cmd
                        cmd.Parameters.AddWithValue("@idcartao", criarcartaoid);
                        cmd.Parameters.AddWithValue("@nomecartao", criarcartaonome);
                        cmd.Parameters.AddWithValue("@valorcartao", criarcartaovalor);
                        cmd.Parameters.AddWithValue("@datacriacao", datacriacao);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Resgistro Criado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.FecharCon();
            }
            else
            {
                MessageBox.Show("Preencha os Campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnCriarCartao_Click(object sender, EventArgs e)
        {
            criarconta();
            LastId();
            txtCriarNomeCartao.Text = "";
            txtValorCartao.Text = "";
        }

        private void txtCriarIDCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblvlr_Click(object sender, EventArgs e)
        {

        }

        private void btnVisuCartao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Set_Load(object sender, EventArgs e)
        {
            LoopVerificarConexao();
        }

        private void txtconexaoativaoudesativa_Click(object sender, EventArgs e)
        {

        }

        private void Set_Activated(object sender, EventArgs e)
        {

        }

        private void lblestadoconexao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clickPegarIdAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (clickPegarIdAutomatico.Checked == true)
            {
                txtCriarIDCartao.ReadOnly = true;
                txtCriarIDCartao.Text = "";
                LastId();
            }
            else
            {
                txtCriarIDCartao.ReadOnly = false;
                txtCriarIDCartao.Text = "";
            }
        }
        private void btntst_Click(object sender, EventArgs e)
        {
            LastId();
        }


        public int LastId()
        {
            try
            {
                con.AbrirCon();
                string sql = "SELECT MAX(id) FROM cartoes";
                MySqlCommand cmd = new MySqlCommand(sql, con.con);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value && result is IConvertible)
                {
                    // Converte para um inteiro
                    int ultimoId = Convert.ToInt32(result);
                    ultimoId++; txtCriarIDCartao.Text = ultimoId.ToString(); // adicão automatica para o prox id lastid + 1
                    return ultimoId;
                }
                else
                {
                    MessageBox.Show("Registro Não Encontrado!\n\nVerifique a Database!", "Erro na Conexão com a SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch 
            {
                return 0;
    
            }

        }

        private void txtCriarIDCartao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtCriarNomeCartao.Focus();
            }
            else if (txtCriarIDCartao.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtCriarNomeCartao.Focus();
            }

        }

        private void txtCriarNomeCartao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (clickPegarIdAutomatico.Checked == false && e.KeyCode == Keys.Up)
            {
                txtCriarIDCartao.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtValorCartao.Focus();
            }
            else if (txtCriarNomeCartao.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtValorCartao.Focus();
            }

        }

        private void txtValorCartao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtCriarNomeCartao.Focus();
            }
            else if (txtValorCartao.Text != "" && e.KeyCode == Keys.Enter)
            {
                criarconta();
                LastId();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//sistema antigo de click para verificar database
/*
 *  txtconexaoativaoudesativa.BackColor = Color.Gray;
            Task.Run(() =>
            {
                System.Uri Url = new System.Uri("http://localhost/phpmyadmin/");
                System.Net.WebRequest WebReq;
                System.Net.WebResponse Resp;
                WebReq = System.Net.WebRequest.Create(Url);

                try
                {
                    Resp = WebReq.GetResponse();
                    Resp.Close();
                    WebReq = null;
                    txtconexaoativaoudesativa.BeginInvoke((MethodInvoker)delegate
                    {
                        txtconexaoativaoudesativa.BackColor = Color.Green;
                        txtconexaoativaoudesativa.Text = "Ativa!";
                    });
                }
                catch
                {
                    MessageBox.Show("Não existe Ligação a Database!\n\nVerifique seu XAMPP, Ative o Apache é MySQL!", "Erro na Conexão com a SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtconexaoativaoudesativa.BeginInvoke((MethodInvoker)delegate
                    {
                        txtconexaoativaoudesativa.BackColor = Color.Red;
                        txtconexaoativaoudesativa.Text = "Desativada!";
                    });
                }
            });
 */