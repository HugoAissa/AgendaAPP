namespace AgendaAPP.View
{
    partial class Deletar
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
            btn_pesquisarDeletar = new Button();
            label6 = new Label();
            lbl_id = new TextBox();
            btn_deletar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txb_ruaDeletar = new TextBox();
            txb_numeroDeletar = new TextBox();
            txb_categoriaDeletar = new TextBox();
            txb_nomeDeletar = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_pesquisarDeletar
            // 
            btn_pesquisarDeletar.Location = new Point(190, 113);
            btn_pesquisarDeletar.Name = "btn_pesquisarDeletar";
            btn_pesquisarDeletar.Size = new Size(75, 23);
            btn_pesquisarDeletar.TabIndex = 45;
            btn_pesquisarDeletar.Text = "Pesquisar";
            btn_pesquisarDeletar.UseVisualStyleBackColor = true;
            btn_pesquisarDeletar.Click += btn_pesquisarDeletar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 114);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 44;
            label6.Text = "ID:";
            // 
            // lbl_id
            // 
            lbl_id.Location = new Point(85, 114);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(99, 23);
            lbl_id.TabIndex = 43;
            // 
            // btn_deletar
            // 
            btn_deletar.Location = new Point(85, 271);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(180, 29);
            btn_deletar.TabIndex = 42;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 233);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 41;
            label5.Text = "Rua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 203);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 40;
            label4.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 173);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 39;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 143);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 38;
            label2.Text = "Nome:";
            // 
            // txb_ruaDeletar
            // 
            txb_ruaDeletar.Location = new Point(85, 230);
            txb_ruaDeletar.Name = "txb_ruaDeletar";
            txb_ruaDeletar.Size = new Size(180, 23);
            txb_ruaDeletar.TabIndex = 37;
            // 
            // txb_numeroDeletar
            // 
            txb_numeroDeletar.Location = new Point(85, 201);
            txb_numeroDeletar.Name = "txb_numeroDeletar";
            txb_numeroDeletar.Size = new Size(180, 23);
            txb_numeroDeletar.TabIndex = 36;
            // 
            // txb_categoriaDeletar
            // 
            txb_categoriaDeletar.Location = new Point(85, 172);
            txb_categoriaDeletar.Name = "txb_categoriaDeletar";
            txb_categoriaDeletar.Size = new Size(180, 23);
            txb_categoriaDeletar.TabIndex = 35;
            // 
            // txb_nomeDeletar
            // 
            txb_nomeDeletar.Location = new Point(85, 143);
            txb_nomeDeletar.Name = "txb_nomeDeletar";
            txb_nomeDeletar.Size = new Size(180, 23);
            txb_nomeDeletar.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 33;
            label1.Text = "Deletar Numero";
            // 
            // Deletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 450);
            Controls.Add(btn_pesquisarDeletar);
            Controls.Add(label6);
            Controls.Add(lbl_id);
            Controls.Add(btn_deletar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_ruaDeletar);
            Controls.Add(txb_numeroDeletar);
            Controls.Add(txb_categoriaDeletar);
            Controls.Add(txb_nomeDeletar);
            Controls.Add(label1);
            Name = "Deletar";
            Text = "Deletar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pesquisarDeletar;
        private Label label6;
        private TextBox lbl_id;
        private Button btn_deletar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txb_ruaDeletar;
        private TextBox txb_numeroDeletar;
        private TextBox txb_categoriaDeletar;
        private TextBox txb_nomeDeletar;
        private Label label1;
    }
}