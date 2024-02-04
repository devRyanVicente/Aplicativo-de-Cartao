namespace Sistema_basico_de_Cartões_utilizando_MySQL
{
    partial class ViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            txtOlharIDCartao = new TextBox();
            lblolhar = new Label();
            label1 = new Label();
            pnlVerSQL = new Panel();
            DataGridDB = new DataGridView();
            txtOlharNomeCartao = new TextBox();
            btnCriadorCartao = new Button();
            txtconexaoativaoudesativa = new Label();
            lblestadoconexao = new Label();
            txtOlharValorCartao = new TextBox();
            lblvlr = new Label();
            btnAlterarInfo = new Button();
            boxPesquisaescolha = new ComboBox();
            txtPesquisa = new TextBox();
            btnBuscar = new Button();
            lblts1 = new Label();
            txtOlharDataCriado = new TextBox();
            lbldata = new Label();
            txtOlharDataModificado = new TextBox();
            label2 = new Label();
            btnConfirmarAlteracoes = new Button();
            btnCancelarAlteracao = new Button();
            btnExcluirUser = new Button();
            btnConfirmarExclusaoUser = new Button();
            clickPegarIdAutomatico = new CheckBox();
            btnBuscarManual = new Button();
            pnlVerSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridDB).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Left;
            lbl1.AutoSize = true;
            lbl1.Location = new Point(30, 47);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(76, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "ID do Cartão:";
            // 
            // txtOlharIDCartao
            // 
            txtOlharIDCartao.Anchor = AnchorStyles.Left;
            txtOlharIDCartao.Location = new Point(112, 44);
            txtOlharIDCartao.MaxLength = 255;
            txtOlharIDCartao.Name = "txtOlharIDCartao";
            txtOlharIDCartao.ReadOnly = true;
            txtOlharIDCartao.Size = new Size(100, 23);
            txtOlharIDCartao.TabIndex = 49;
            // 
            // lblolhar
            // 
            lblolhar.Anchor = AnchorStyles.Top;
            lblolhar.AutoSize = true;
            lblolhar.Location = new Point(358, 9);
            lblolhar.Name = "lblolhar";
            lblolhar.Size = new Size(79, 15);
            lblolhar.TabIndex = 2;
            lblolhar.Text = "Olhar Cartões";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(63, 80);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // pnlVerSQL
            // 
            pnlVerSQL.Controls.Add(DataGridDB);
            pnlVerSQL.Location = new Point(358, 27);
            pnlVerSQL.Name = "pnlVerSQL";
            pnlVerSQL.Size = new Size(430, 336);
            pnlVerSQL.TabIndex = 4;
            // 
            // DataGridDB
            // 
            DataGridDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DataGridDB.Location = new Point(0, 0);
            DataGridDB.Name = "DataGridDB";
            DataGridDB.Size = new Size(430, 336);
            DataGridDB.TabIndex = 0;
            DataGridDB.CellClick += DataGridDB_CellClick;
            // 
            // txtOlharNomeCartao
            // 
            txtOlharNomeCartao.Anchor = AnchorStyles.Left;
            txtOlharNomeCartao.Location = new Point(112, 77);
            txtOlharNomeCartao.MaxLength = 255;
            txtOlharNomeCartao.Name = "txtOlharNomeCartao";
            txtOlharNomeCartao.ReadOnly = true;
            txtOlharNomeCartao.Size = new Size(100, 23);
            txtOlharNomeCartao.TabIndex = 16;
            txtOlharNomeCartao.PreviewKeyDown += txtOlharNomeCartao_PreviewKeyDown;
            // 
            // btnCriadorCartao
            // 
            btnCriadorCartao.Anchor = AnchorStyles.Bottom;
            btnCriadorCartao.Location = new Point(12, 415);
            btnCriadorCartao.Name = "btnCriadorCartao";
            btnCriadorCartao.Size = new Size(116, 23);
            btnCriadorCartao.TabIndex = 6;
            btnCriadorCartao.Text = "Criador de Cartões";
            btnCriadorCartao.UseVisualStyleBackColor = true;
            btnCriadorCartao.Click += btnCriadorCartao_Click;
            // 
            // txtconexaoativaoudesativa
            // 
            txtconexaoativaoudesativa.Anchor = AnchorStyles.Left;
            txtconexaoativaoudesativa.AutoSize = true;
            txtconexaoativaoudesativa.BackColor = Color.Gray;
            txtconexaoativaoudesativa.Location = new Point(162, 9);
            txtconexaoativaoudesativa.Name = "txtconexaoativaoudesativa";
            txtconexaoativaoudesativa.Size = new Size(66, 15);
            txtconexaoativaoudesativa.TabIndex = 13;
            txtconexaoativaoudesativa.Text = "Verificando";
            // 
            // lblestadoconexao
            // 
            lblestadoconexao.Anchor = AnchorStyles.Left;
            lblestadoconexao.AutoSize = true;
            lblestadoconexao.Location = new Point(12, 9);
            lblestadoconexao.Name = "lblestadoconexao";
            lblestadoconexao.Size = new Size(144, 15);
            lblestadoconexao.TabIndex = 12;
            lblestadoconexao.Text = "Conexão com a Database:";
            // 
            // txtOlharValorCartao
            // 
            txtOlharValorCartao.Anchor = AnchorStyles.Left;
            txtOlharValorCartao.Location = new Point(112, 114);
            txtOlharValorCartao.MaxLength = 255;
            txtOlharValorCartao.Name = "txtOlharValorCartao";
            txtOlharValorCartao.ReadOnly = true;
            txtOlharValorCartao.Size = new Size(100, 23);
            txtOlharValorCartao.TabIndex = 17;
            txtOlharValorCartao.PreviewKeyDown += txtOlharValorCartao_PreviewKeyDown;
            // 
            // lblvlr
            // 
            lblvlr.Anchor = AnchorStyles.Left;
            lblvlr.AutoSize = true;
            lblvlr.Location = new Point(70, 114);
            lblvlr.Name = "lblvlr";
            lblvlr.Size = new Size(36, 15);
            lblvlr.TabIndex = 14;
            lblvlr.Text = "Valor:";
            // 
            // btnAlterarInfo
            // 
            btnAlterarInfo.Location = new Point(114, 230);
            btnAlterarInfo.Name = "btnAlterarInfo";
            btnAlterarInfo.Size = new Size(121, 23);
            btnAlterarInfo.TabIndex = 16;
            btnAlterarInfo.Text = "Alterar Informações";
            btnAlterarInfo.UseVisualStyleBackColor = true;
            btnAlterarInfo.Click += btnAlterarInfo_Click;
            // 
            // boxPesquisaescolha
            // 
            boxPesquisaescolha.Anchor = AnchorStyles.Bottom;
            boxPesquisaescolha.AutoCompleteCustomSource.AddRange(new string[] { "Id", "CartaoNome" });
            boxPesquisaescolha.FormattingEnabled = true;
            boxPesquisaescolha.Items.AddRange(new object[] { "ID", "Nome" });
            boxPesquisaescolha.Location = new Point(667, 386);
            boxPesquisaescolha.Name = "boxPesquisaescolha";
            boxPesquisaescolha.Size = new Size(121, 23);
            boxPesquisaescolha.TabIndex = 17;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Bottom;
            txtPesquisa.Location = new Point(358, 386);
            txtPesquisa.MaxLength = 255;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(303, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom;
            btnBuscar.Location = new Point(672, 415);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblts1
            // 
            lblts1.Anchor = AnchorStyles.Bottom;
            lblts1.AutoSize = true;
            lblts1.Location = new Point(409, 426);
            lblts1.Name = "lblts1";
            lblts1.Size = new Size(79, 15);
            lblts1.TabIndex = 20;
            lblts1.Text = "Olhar Cartões";
            // 
            // txtOlharDataCriado
            // 
            txtOlharDataCriado.Anchor = AnchorStyles.Left;
            txtOlharDataCriado.Location = new Point(112, 152);
            txtOlharDataCriado.MaxLength = 255;
            txtOlharDataCriado.Name = "txtOlharDataCriado";
            txtOlharDataCriado.ReadOnly = true;
            txtOlharDataCriado.Size = new Size(100, 23);
            txtOlharDataCriado.TabIndex = 21;
            // 
            // lbldata
            // 
            lbldata.Anchor = AnchorStyles.Left;
            lbldata.AutoSize = true;
            lbldata.Location = new Point(34, 152);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(72, 15);
            lbldata.TabIndex = 22;
            lbldata.Text = "Data Criado:";
            // 
            // txtOlharDataModificado
            // 
            txtOlharDataModificado.Anchor = AnchorStyles.Left;
            txtOlharDataModificado.Location = new Point(112, 188);
            txtOlharDataModificado.MaxLength = 255;
            txtOlharDataModificado.Name = "txtOlharDataModificado";
            txtOlharDataModificado.ReadOnly = true;
            txtOlharDataModificado.Size = new Size(100, 23);
            txtOlharDataModificado.TabIndex = 23;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(8, 191);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 24;
            label2.Text = "Data Modificado:";
            // 
            // btnConfirmarAlteracoes
            // 
            btnConfirmarAlteracoes.Anchor = AnchorStyles.Left;
            btnConfirmarAlteracoes.Location = new Point(108, 230);
            btnConfirmarAlteracoes.Name = "btnConfirmarAlteracoes";
            btnConfirmarAlteracoes.Size = new Size(128, 23);
            btnConfirmarAlteracoes.TabIndex = 25;
            btnConfirmarAlteracoes.Text = "Confirmar Alterações";
            btnConfirmarAlteracoes.UseVisualStyleBackColor = true;
            btnConfirmarAlteracoes.Visible = false;
            btnConfirmarAlteracoes.Click += btnConfirmarAlteracoes_Click;
            // 
            // btnCancelarAlteracao
            // 
            btnCancelarAlteracao.Anchor = AnchorStyles.Left;
            btnCancelarAlteracao.Location = new Point(252, 230);
            btnCancelarAlteracao.Name = "btnCancelarAlteracao";
            btnCancelarAlteracao.Size = new Size(69, 23);
            btnCancelarAlteracao.TabIndex = 26;
            btnCancelarAlteracao.Text = "Cancelar";
            btnCancelarAlteracao.UseVisualStyleBackColor = true;
            btnCancelarAlteracao.Visible = false;
            btnCancelarAlteracao.Click += btnCancelarAlteracao_Click;
            // 
            // btnExcluirUser
            // 
            btnExcluirUser.Anchor = AnchorStyles.Left;
            btnExcluirUser.Location = new Point(8, 230);
            btnExcluirUser.Name = "btnExcluirUser";
            btnExcluirUser.Size = new Size(100, 23);
            btnExcluirUser.TabIndex = 50;
            btnExcluirUser.Text = "Excluir Usuario";
            btnExcluirUser.UseVisualStyleBackColor = true;
            btnExcluirUser.Visible = false;
            btnExcluirUser.Click += btnExcluirUser_Click;
            // 
            // btnConfirmarExclusaoUser
            // 
            btnConfirmarExclusaoUser.Anchor = AnchorStyles.Left;
            btnConfirmarExclusaoUser.Location = new Point(114, 259);
            btnConfirmarExclusaoUser.Name = "btnConfirmarExclusaoUser";
            btnConfirmarExclusaoUser.Size = new Size(122, 23);
            btnConfirmarExclusaoUser.TabIndex = 51;
            btnConfirmarExclusaoUser.Text = "Confirmar Exclusão";
            btnConfirmarExclusaoUser.UseVisualStyleBackColor = true;
            btnConfirmarExclusaoUser.Visible = false;
            btnConfirmarExclusaoUser.Click += btnConfirmarExclusaoUser_Click;
            // 
            // clickPegarIdAutomatico
            // 
            clickPegarIdAutomatico.AutoSize = true;
            clickPegarIdAutomatico.Location = new Point(218, 43);
            clickPegarIdAutomatico.Name = "clickPegarIdAutomatico";
            clickPegarIdAutomatico.Size = new Size(135, 19);
            clickPegarIdAutomatico.TabIndex = 52;
            clickPegarIdAutomatico.Text = "Inserir Manualmente";
            clickPegarIdAutomatico.UseVisualStyleBackColor = true;
            clickPegarIdAutomatico.CheckedChanged += clickPegarIdAutomatico_CheckedChanged;
            // 
            // btnBuscarManual
            // 
            btnBuscarManual.Anchor = AnchorStyles.Left;
            btnBuscarManual.Location = new Point(218, 68);
            btnBuscarManual.Name = "btnBuscarManual";
            btnBuscarManual.Size = new Size(131, 23);
            btnBuscarManual.TabIndex = 53;
            btnBuscarManual.Text = "Buscar Manualmente";
            btnBuscarManual.UseVisualStyleBackColor = true;
            btnBuscarManual.Visible = false;
            btnBuscarManual.Click += btnBuscarManual_Click;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarManual);
            Controls.Add(clickPegarIdAutomatico);
            Controls.Add(btnConfirmarExclusaoUser);
            Controls.Add(btnExcluirUser);
            Controls.Add(btnCancelarAlteracao);
            Controls.Add(btnConfirmarAlteracoes);
            Controls.Add(label2);
            Controls.Add(txtOlharDataModificado);
            Controls.Add(lbldata);
            Controls.Add(txtOlharDataCriado);
            Controls.Add(lblts1);
            Controls.Add(btnBuscar);
            Controls.Add(txtPesquisa);
            Controls.Add(boxPesquisaescolha);
            Controls.Add(btnAlterarInfo);
            Controls.Add(txtOlharValorCartao);
            Controls.Add(lblvlr);
            Controls.Add(txtconexaoativaoudesativa);
            Controls.Add(lblestadoconexao);
            Controls.Add(btnCriadorCartao);
            Controls.Add(txtOlharNomeCartao);
            Controls.Add(pnlVerSQL);
            Controls.Add(label1);
            Controls.Add(lblolhar);
            Controls.Add(txtOlharIDCartao);
            Controls.Add(lbl1);
            Name = "ViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olhar Cartões";
            Load += View_Load;
            pnlVerSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtOlharIDCartao;
        private Label lblolhar;
        private Label label1;
        private Panel pnlVerSQL;
        private TextBox txtOlharNomeCartao;
        private Button btnCriadorCartao;
        public Label txtconexaoativaoudesativa;
        private Label lblestadoconexao;
        private TextBox txtOlharValorCartao;
        private Label lblvlr;
        private Button btnAlterarInfo;
        private ComboBox boxPesquisaescolha;
        private TextBox txtPesquisa;
        private DataGridView DataGridDB;
        private Button btnBuscar;
        private Label lblts1;
        private TextBox txtOlharDataCriado;
        private Label lbldata;
        private TextBox txtOlharDataModificado;
        private Label label2;
        private Button btnConfirmarAlteracoes;
        private Button btnCancelarAlteracao;
        private Button btnExcluirUser;
        private Button btnConfirmarExclusaoUser;
        private CheckBox clickPegarIdAutomatico;
        private Button btnBuscarManual;
    }
}
