namespace AgendaAPP.View.MenuAgenda
{
    partial class TelaAgenda
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
            btn_alterar = new Button();
            btn_cadastrar = new Button();
            btn_deletar = new Button();
            btn_pesquisarcategoria = new Button();
            btn_pesquisarid = new Button();
            btn_pesquisarnome = new Button();
            btn_pesquisarrua = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(108, 69);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(274, 62);
            btn_alterar.TabIndex = 0;
            btn_alterar.Text = "Alterar ";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(108, 147);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(274, 62);
            btn_cadastrar.TabIndex = 1;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(108, 225);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(274, 62);
            btn_deletar.TabIndex = 2;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_pesquisarcategoria
            // 
            btn_pesquisarcategoria.Location = new Point(400, 147);
            btn_pesquisarcategoria.Name = "btn_pesquisarcategoria";
            btn_pesquisarcategoria.Size = new Size(274, 62);
            btn_pesquisarcategoria.TabIndex = 3;
            btn_pesquisarcategoria.Text = "Pesquisar por Categoria";
            btn_pesquisarcategoria.UseVisualStyleBackColor = true;
            btn_pesquisarcategoria.Click += btn_pesquisarcategoria_Click;
            // 
            // btn_pesquisarid
            // 
            btn_pesquisarid.Location = new Point(400, 69);
            btn_pesquisarid.Name = "btn_pesquisarid";
            btn_pesquisarid.Size = new Size(274, 62);
            btn_pesquisarid.TabIndex = 4;
            btn_pesquisarid.Text = "Pesquisar por id";
            btn_pesquisarid.UseVisualStyleBackColor = true;
            btn_pesquisarid.Click += btn_pesquisarid_Click;
            // 
            // btn_pesquisarnome
            // 
            btn_pesquisarnome.Location = new Point(400, 225);
            btn_pesquisarnome.Name = "btn_pesquisarnome";
            btn_pesquisarnome.Size = new Size(274, 62);
            btn_pesquisarnome.TabIndex = 5;
            btn_pesquisarnome.Text = "Pesquisar por Nome";
            btn_pesquisarnome.UseVisualStyleBackColor = true;
            btn_pesquisarnome.Click += btn_pesquisarnome_Click;
            // 
            // btn_pesquisarrua
            // 
            btn_pesquisarrua.Location = new Point(108, 303);
            btn_pesquisarrua.Name = "btn_pesquisarrua";
            btn_pesquisarrua.Size = new Size(274, 62);
            btn_pesquisarrua.TabIndex = 6;
            btn_pesquisarrua.Text = "Pesquisar por Endereço";
            btn_pesquisarrua.UseVisualStyleBackColor = true;
            btn_pesquisarrua.Click += btn_pesquisarrua_Click;
            // 
            // button1
            // 
            button1.Location = new Point(400, 303);
            button1.Name = "button1";
            button1.Size = new Size(274, 62);
            button1.TabIndex = 7;
            button1.Text = "Pesquisar por Numero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(button1);
            Controls.Add(btn_pesquisarrua);
            Controls.Add(btn_pesquisarnome);
            Controls.Add(btn_pesquisarid);
            Controls.Add(btn_pesquisarcategoria);
            Controls.Add(btn_deletar);
            Controls.Add(btn_cadastrar);
            Controls.Add(btn_alterar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAgenda";
            ShowIcon = false;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_alterar;
        private Button btn_cadastrar;
        private Button btn_deletar;
        private Button btn_pesquisarcategoria;
        private Button btn_pesquisarid;
        private Button btn_pesquisarnome;
        private Button btn_pesquisarrua;
        private Button button1;
    }
}