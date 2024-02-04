namespace Sistema_basico_de_Cartões_utilizando_MySQL
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCriarNomeCartao = new TextBox();
            label2 = new Label();
            btnCriarCartao = new Button();
            lblvlr = new Label();
            txtValorCartao = new TextBox();
            btnVisuCartao = new Button();
            lblestadoconexao = new Label();
            txtconexaoativaoudesativa = new Label();
            clickPegarIdAutomatico = new CheckBox();
            txtCriarIDCartao = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do Cartão";
            // 
            // txtCriarNomeCartao
            // 
            txtCriarNomeCartao.Anchor = AnchorStyles.Left;
            txtCriarNomeCartao.Location = new Point(93, 79);
            txtCriarNomeCartao.Name = "txtCriarNomeCartao";
            txtCriarNomeCartao.Size = new Size(100, 23);
            txtCriarNomeCartao.TabIndex = 3;
            txtCriarNomeCartao.PreviewKeyDown += txtCriarNomeCartao_PreviewKeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // btnCriarCartao
            // 
            btnCriarCartao.Anchor = AnchorStyles.Left;
            btnCriarCartao.Location = new Point(103, 176);
            btnCriarCartao.Name = "btnCriarCartao";
            btnCriarCartao.Size = new Size(80, 23);
            btnCriarCartao.TabIndex = 5;
            btnCriarCartao.Text = "Criar Cartão";
            btnCriarCartao.UseVisualStyleBackColor = true;
            btnCriarCartao.Click += btnCriarCartao_Click;
            // 
            // lblvlr
            // 
            lblvlr.Anchor = AnchorStyles.Left;
            lblvlr.AutoSize = true;
            lblvlr.Location = new Point(54, 129);
            lblvlr.Name = "lblvlr";
            lblvlr.Size = new Size(33, 15);
            lblvlr.TabIndex = 7;
            lblvlr.Text = "Valor";
            lblvlr.Click += lblvlr_Click;
            // 
            // txtValorCartao
            // 
            txtValorCartao.Anchor = AnchorStyles.Left;
            txtValorCartao.Location = new Point(93, 126);
            txtValorCartao.Name = "txtValorCartao";
            txtValorCartao.Size = new Size(100, 23);
            txtValorCartao.TabIndex = 8;
            txtValorCartao.PreviewKeyDown += txtValorCartao_PreviewKeyDown;
            // 
            // btnVisuCartao
            // 
            btnVisuCartao.Anchor = AnchorStyles.Left;
            btnVisuCartao.Location = new Point(12, 214);
            btnVisuCartao.Name = "btnVisuCartao";
            btnVisuCartao.Size = new Size(125, 23);
            btnVisuCartao.TabIndex = 9;
            btnVisuCartao.Text = "Voltar a Visualização";
            btnVisuCartao.UseVisualStyleBackColor = true;
            btnVisuCartao.Click += btnVisuCartao_Click;
            // 
            // lblestadoconexao
            // 
            lblestadoconexao.AutoSize = true;
            lblestadoconexao.Location = new Point(103, 9);
            lblestadoconexao.Name = "lblestadoconexao";
            lblestadoconexao.Size = new Size(58, 15);
            lblestadoconexao.TabIndex = 10;
            lblestadoconexao.Text = "Database:";
            lblestadoconexao.Click += lblestadoconexao_Click;
            // 
            // txtconexaoativaoudesativa
            // 
            txtconexaoativaoudesativa.AutoSize = true;
            txtconexaoativaoudesativa.BackColor = Color.Transparent;
            txtconexaoativaoudesativa.Location = new Point(159, 9);
            txtconexaoativaoudesativa.Name = "txtconexaoativaoudesativa";
            txtconexaoativaoudesativa.Size = new Size(34, 15);
            txtconexaoativaoudesativa.TabIndex = 11;
            txtconexaoativaoudesativa.Text = "INFO";
            txtconexaoativaoudesativa.Click += txtconexaoativaoudesativa_Click;
            // 
            // clickPegarIdAutomatico
            // 
            clickPegarIdAutomatico.AutoSize = true;
            clickPegarIdAutomatico.Location = new Point(199, 36);
            clickPegarIdAutomatico.Name = "clickPegarIdAutomatico";
            clickPegarIdAutomatico.Size = new Size(66, 19);
            clickPegarIdAutomatico.TabIndex = 13;
            clickPegarIdAutomatico.Text = "Auto ID";
            clickPegarIdAutomatico.UseVisualStyleBackColor = true;
            clickPegarIdAutomatico.CheckedChanged += clickPegarIdAutomatico_CheckedChanged;
            // 
            // txtCriarIDCartao
            // 
            txtCriarIDCartao.Anchor = AnchorStyles.Left;
            txtCriarIDCartao.Location = new Point(93, 36);
            txtCriarIDCartao.MaxLength = 7;
            txtCriarIDCartao.Name = "txtCriarIDCartao";
            txtCriarIDCartao.Size = new Size(100, 23);
            txtCriarIDCartao.TabIndex = 14;
            txtCriarIDCartao.TextChanged += textBox1_TextChanged;
            // 
            // SetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(295, 249);
            Controls.Add(txtCriarIDCartao);
            Controls.Add(clickPegarIdAutomatico);
            Controls.Add(txtconexaoativaoudesativa);
            Controls.Add(lblestadoconexao);
            Controls.Add(btnVisuCartao);
            Controls.Add(txtValorCartao);
            Controls.Add(lblvlr);
            Controls.Add(btnCriarCartao);
            Controls.Add(label2);
            Controls.Add(txtCriarNomeCartao);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "SetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Um Cartão";
            Activated += Set_Activated;
            Load += Set_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCriarCartão;
        private TextBox txtCriarNomeCartao;
        private Label label2;
        private Button btnCriarCartao;
        private TextBox maskedTextBox1;
        private Label lblvlr;
        private TextBox txtValorCartao;
        private Button btnVisuCartao;
        private Label lblestadoconexao;
        public Label txtconexaoativaoudesativa;
        private Button button1;
        private CheckBox clickPegarIdAutomatico;
        private TextBox txtCriarIDCartao;
    }
}