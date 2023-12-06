namespace AgendaAPP.View
{
    partial class PesquisarRua
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
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            btn_pesquisarRua = new Button();
            label6 = new Label();
            txb_PesquisarRua = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Nome, Telefone, Endereço });
            dataGridView1.Location = new Point(85, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(630, 181);
            dataGridView1.TabIndex = 60;
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
            // btn_pesquisarRua
            // 
            btn_pesquisarRua.Location = new Point(324, 385);
            btn_pesquisarRua.Name = "btn_pesquisarRua";
            btn_pesquisarRua.Size = new Size(180, 34);
            btn_pesquisarRua.TabIndex = 59;
            btn_pesquisarRua.Text = "Pesquisar";
            btn_pesquisarRua.UseVisualStyleBackColor = true;
            btn_pesquisarRua.Click += btn_pesquisarRua_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 124);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 58;
            label6.Text = "Digite a rua:";
            // 
            // txb_PesquisarRua
            // 
            txb_PesquisarRua.Location = new Point(197, 120);
            txb_PesquisarRua.Name = "txb_PesquisarRua";
            txb_PesquisarRua.Size = new Size(180, 23);
            txb_PesquisarRua.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 31);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 56;
            label1.Text = "Pesquisar por Endereço";
            // 
            // PesquisarRua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_pesquisarRua);
            Controls.Add(label6);
            Controls.Add(txb_PesquisarRua);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PesquisarRua";
            ShowIcon = false;
            Text = "Pesquisar por Endereço";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Endereço;
        private Button btn_pesquisarRua;
        private Label label6;
        private TextBox txb_PesquisarRua;
        private Label label1;
    }
}