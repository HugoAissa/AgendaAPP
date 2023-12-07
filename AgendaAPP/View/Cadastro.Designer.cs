namespace AgendaAPP.View
{
    partial class Cadastro
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
            txb_ruaAgenda = new TextBox();
            txb_numeroAgenda = new TextBox();
            txb_nomeAgenda = new TextBox();
            label1 = new Label();
            txb_categoriaAgenda = new TextBox();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(73, 243);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(180, 29);
            btn_cadastrar.TabIndex = 19;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 205);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 18;
            label5.Text = "Rua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 175);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 17;
            label4.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 16;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 115);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 15;
            label2.Text = "Nome:";
            // 
            // txb_ruaAgenda
            // 
            txb_ruaAgenda.Location = new Point(73, 202);
            txb_ruaAgenda.Name = "txb_ruaAgenda";
            txb_ruaAgenda.Size = new Size(180, 23);
            txb_ruaAgenda.TabIndex = 14;
            // 
            // txb_numeroAgenda
            // 
            txb_numeroAgenda.Location = new Point(73, 173);
            txb_numeroAgenda.Name = "txb_numeroAgenda";
            txb_numeroAgenda.Size = new Size(180, 23);
            txb_numeroAgenda.TabIndex = 13;
            txb_numeroAgenda.TextChanged += txb_numeroAgenda_TextChanged;
            // 
            // txb_nomeAgenda
            // 
            txb_nomeAgenda.Location = new Point(73, 115);
            txb_nomeAgenda.Name = "txb_nomeAgenda";
            txb_nomeAgenda.Size = new Size(180, 23);
            txb_nomeAgenda.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 33);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 10;
            label1.Text = "Cadastar Numero";
            // 
            // txb_categoriaAgenda
            // 
            txb_categoriaAgenda.Location = new Point(73, 144);
            txb_categoriaAgenda.Name = "txb_categoriaAgenda";
            txb_categoriaAgenda.Size = new Size(180, 23);
            txb_categoriaAgenda.TabIndex = 12;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 310);
            Controls.Add(btn_cadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_ruaAgenda);
            Controls.Add(txb_numeroAgenda);
            Controls.Add(txb_categoriaAgenda);
            Controls.Add(txb_nomeAgenda);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastro";
            ShowIcon = false;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txb_ruaAgenda;
        private TextBox txb_numeroAgenda;
        private TextBox txb_nomeAgenda;
        private Label label1;
        private TextBox txb_categoriaAgenda;
    }
}