using MySql.Data.MySqlClient;
using Sistema_basico_de_Cartões_utilizando_MySQL;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexao
{
    class Conexaoclass()
    {

        string conec = "SERVER=localhost; DATABASE=cartaodb; UID=root; ConvertZeroDateTime=true;";
        public MySqlConnection con = null;
        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public async Task<bool> LoopVerificarConexao()
        {
            while (true)
            {
               
                try
                {
                    System.Uri Url = new System.Uri("http://localhost/phpmyadmin/");
                    System.Net.WebRequest WebReq;
                    System.Net.WebResponse Resp;
                    WebReq = System.Net.WebRequest.Create(Url);

                    Resp = await WebReq.GetResponseAsync();
                    Resp.Close();
                    WebReq = null;
                    bool Conexaobool = true;
                    return (Conexaobool);
                }
                catch
                {
                    MessageBox.Show("Não existe Ligação a Database!\n\nVerifique seu XAMPP, Ative o Apache é MySQL!", "Erro na Conexão com a SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bool Conexaobool = false;
                    return (Conexaobool);

                }
                await Task.Delay(TimeSpan.FromSeconds(5));// Aguardar 5 Segundos Para Fazer a Verificação Denovo!
            }
            
        }


    }
}
