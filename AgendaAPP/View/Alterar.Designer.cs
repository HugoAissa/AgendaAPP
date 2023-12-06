namespace AgendaAPP.View
{
    partial class Alterar
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
            btn_cadastrar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txb_ruaAlterar = new TextBox();
            txb_numeroAlterar = new TextBox();
            txb_categoriaAlterar = new TextBox();
            txb_nomeAlterar = new TextBox();
            label1 = new Label();
            lbl_id = new TextBox();
            label6 = new Label();
            btn_pesquisar = new Button();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(73, 250);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(180, 29);
            btn_cadastrar.TabIndex = 29;
            btn_cadastrar.Text = "Alterar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 212);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 28;
            label5.Text = "Rua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 182);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 27;
            label4.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 26;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 122);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 25;
            label2.Text = "Nome:";
            // 
            // txb_ruaAlterar
            // 
            txb_ruaAlterar.Location = new Point(73, 209);
            txb_ruaAlterar.Name = "txb_ruaAlterar";
            txb_ruaAlterar.Size = new Size(180, 23);
            txb_ruaAlterar.TabIndex = 24;
            // 
            // txb_numeroAlterar
            // 
            txb_numeroAlterar.Location = new Point(73, 180);
            txb_numeroAlterar.Name = "txb_numeroAlterar";
            txb_numeroAlterar.Size = new Size(180, 23);
            txb_numeroAlterar.TabIndex = 23;
            // 
            // txb_categoriaAlterar
            // 
            txb_categoriaAlterar.Location = new Point(73, 151);
            txb_categoriaAlterar.Name = "txb_categoriaAlterar";
            txb_categoriaAlterar.Size = new Size(180, 23);
            txb_categoriaAlterar.TabIndex = 22;
            // 
            // txb_nomeAlterar
            // 
            txb_nomeAlterar.Location = new Point(73, 122);
            txb_nomeAlterar.Name = "txb_nomeAlterar";
            txb_nomeAlterar.Size = new Size(180, 23);
            txb_nomeAlterar.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 20;
            label1.Text = "Alterar Numero";
            // 
            // lbl_id
            // 
            lbl_id.Location = new Point(73, 93);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(99, 23);
            lbl_id.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 93);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 31;
            label6.Text = "ID:";
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(178, 92);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(75, 23);
            btn_pesquisar.TabIndex = 32;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // Alterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 310);
            Controls.Add(btn_pesquisar);
            Controls.Add(label6);
            Controls.Add(lbl_id);
            Controls.Add(btn_cadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_ruaAlterar);
            Controls.Add(txb_numeroAlterar);
            Controls.Add(txb_categoriaAlterar);
            Controls.Add(txb_nomeAlterar);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Alterar";
            Text = "Alterar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txb_ruaAlterar;
        private TextBox txb_numeroAlterar;
        private TextBox txb_categoriaAlterar;
        private TextBox txb_nomeAlterar;
        private Label label1;
        private TextBox lbl_id;
        private Label label6;
        private Button btn_pesquisar;
    }
}