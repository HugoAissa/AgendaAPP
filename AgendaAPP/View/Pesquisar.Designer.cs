namespace AgendaAPP.View
{
    partial class Pesquisar
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
            btn_pesquisar = new Button();
            label6 = new Label();
            txb_idPesquisar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txb_ruaPesquisar = new TextBox();
            txb_numeroPesquisar = new TextBox();
            txb_categoriaPesquisar = new TextBox();
            txb_nomePesquisar = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(178, 125);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(72, 23);
            btn_pesquisar.TabIndex = 45;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 125);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 44;
            label6.Text = "ID:";
            // 
            // txb_idPesquisar
            // 
            txb_idPesquisar.Location = new Point(70, 125);
            txb_idPesquisar.Name = "txb_idPesquisar";
            txb_idPesquisar.Size = new Size(102, 23);
            txb_idPesquisar.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 244);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 41;
            label5.Text = "Rua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 214);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 40;
            label4.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 184);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 39;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 154);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 38;
            label2.Text = "Nome:";
            // 
            // txb_ruaPesquisar
            // 
            txb_ruaPesquisar.Location = new Point(70, 241);
            txb_ruaPesquisar.Name = "txb_ruaPesquisar";
            txb_ruaPesquisar.Size = new Size(180, 23);
            txb_ruaPesquisar.TabIndex = 37;
            // 
            // txb_numeroPesquisar
            // 
            txb_numeroPesquisar.Location = new Point(70, 212);
            txb_numeroPesquisar.Name = "txb_numeroPesquisar";
            txb_numeroPesquisar.Size = new Size(180, 23);
            txb_numeroPesquisar.TabIndex = 36;
            // 
            // txb_categoriaPesquisar
            // 
            txb_categoriaPesquisar.Location = new Point(70, 183);
            txb_categoriaPesquisar.Name = "txb_categoriaPesquisar";
            txb_categoriaPesquisar.Size = new Size(180, 23);
            txb_categoriaPesquisar.TabIndex = 35;
            // 
            // txb_nomePesquisar
            // 
            txb_nomePesquisar.Location = new Point(70, 154);
            txb_nomePesquisar.Name = "txb_nomePesquisar";
            txb_nomePesquisar.Size = new Size(180, 23);
            txb_nomePesquisar.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 53);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 33;
            label1.Text = "Pesquisar por ID";
            // 
            // Pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 344);
            Controls.Add(btn_pesquisar);
            Controls.Add(label6);
            Controls.Add(txb_idPesquisar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txb_ruaPesquisar);
            Controls.Add(txb_numeroPesquisar);
            Controls.Add(txb_categoriaPesquisar);
            Controls.Add(txb_nomePesquisar);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pesquisar";
            ShowIcon = false;
            Text = "Pesquisar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pesquisar;
        private Label label6;
        private TextBox txb_idPesquisar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txb_ruaPesquisar;
        private TextBox txb_numeroPesquisar;
        private TextBox txb_categoriaPesquisar;
        private TextBox txb_nomePesquisar;
        private Label label1;
    }
}