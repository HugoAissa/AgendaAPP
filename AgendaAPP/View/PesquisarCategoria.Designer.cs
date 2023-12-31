﻿namespace AgendaAPP.View
{
    partial class PesquisarCategoria
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
            txb_PesquisarCategoria = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(325, 377);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(180, 34);
            btn_pesquisar.TabIndex = 49;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 116);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 48;
            label6.Text = "Digite a Categoria:";
            // 
            // txb_PesquisarCategoria
            // 
            txb_PesquisarCategoria.Location = new Point(198, 112);
            txb_PesquisarCategoria.Name = "txb_PesquisarCategoria";
            txb_PesquisarCategoria.Size = new Size(180, 23);
            txb_PesquisarCategoria.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 23);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 46;
            label1.Text = "Pesquisar por Categoria";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Nome, Telefone, Endereço });
            dataGridView1.Location = new Point(86, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 200;
            dataGridView1.Size = new Size(630, 181);
            dataGridView1.TabIndex = 50;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 71;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 83;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 65;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.Width = 76;
            // 
            // Endereço
            // 
            Endereço.HeaderText = "Endereço";
            Endereço.Name = "Endereço";
            Endereço.Width = 81;
            // 
            // PesquisarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_pesquisar);
            Controls.Add(label6);
            Controls.Add(txb_PesquisarCategoria);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PesquisarCategoria";
            ShowIcon = false;
            Text = "Pesquisar por Categoria";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pesquisar;
        private Label label6;
        private TextBox txb_PesquisarCategoria;
        private Label label1;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Endereço;
    }
}