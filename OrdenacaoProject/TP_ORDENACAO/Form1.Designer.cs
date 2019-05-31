namespace OrdenacaoProject
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_bubbleSort = new System.Windows.Forms.Button();
            this.bt_selecao = new System.Windows.Forms.Button();
            this.bt_quickSort = new System.Windows.Forms.Button();
            this.bt_MergeSort = new System.Windows.Forms.Button();
            this.cb_tempos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aux_semiOrdenado = new System.Windows.Forms.Label();
            this.aux_aleatorio = new System.Windows.Forms.Label();
            this.aux_decrescente = new System.Windows.Forms.Label();
            this.aux_Crescente = new System.Windows.Forms.Label();
            this.btn_insercao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_bubbleSort
            // 
            this.bt_bubbleSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_bubbleSort.FlatAppearance.BorderSize = 3;
            this.bt_bubbleSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bubbleSort.Location = new System.Drawing.Point(14, 107);
            this.bt_bubbleSort.Name = "bt_bubbleSort";
            this.bt_bubbleSort.Size = new System.Drawing.Size(97, 37);
            this.bt_bubbleSort.TabIndex = 0;
            this.bt_bubbleSort.Text = "BubbleSort";
            this.bt_bubbleSort.UseVisualStyleBackColor = true;
            this.bt_bubbleSort.Click += new System.EventHandler(this.bt_bubbleSort_Click);
            // 
            // bt_selecao
            // 
            this.bt_selecao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_selecao.FlatAppearance.BorderSize = 3;
            this.bt_selecao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selecao.Location = new System.Drawing.Point(117, 107);
            this.bt_selecao.Name = "bt_selecao";
            this.bt_selecao.Size = new System.Drawing.Size(97, 37);
            this.bt_selecao.TabIndex = 1;
            this.bt_selecao.Text = "Seleção";
            this.bt_selecao.UseVisualStyleBackColor = true;
            this.bt_selecao.Click += new System.EventHandler(this.bt_selecao_Click);
            // 
            // bt_quickSort
            // 
            this.bt_quickSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_quickSort.FlatAppearance.BorderSize = 3;
            this.bt_quickSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quickSort.Location = new System.Drawing.Point(220, 107);
            this.bt_quickSort.Name = "bt_quickSort";
            this.bt_quickSort.Size = new System.Drawing.Size(97, 37);
            this.bt_quickSort.TabIndex = 2;
            this.bt_quickSort.Text = "QuickSort";
            this.bt_quickSort.UseVisualStyleBackColor = true;
            this.bt_quickSort.Click += new System.EventHandler(this.bt_quickSort_Click);
            // 
            // bt_MergeSort
            // 
            this.bt_MergeSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_MergeSort.FlatAppearance.BorderSize = 3;
            this.bt_MergeSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MergeSort.Location = new System.Drawing.Point(323, 107);
            this.bt_MergeSort.Name = "bt_MergeSort";
            this.bt_MergeSort.Size = new System.Drawing.Size(97, 37);
            this.bt_MergeSort.TabIndex = 3;
            this.bt_MergeSort.Text = "MergeSort";
            this.bt_MergeSort.UseVisualStyleBackColor = true;
            this.bt_MergeSort.Click += new System.EventHandler(this.bt_MergeSort_Click);
            // 
            // cb_tempos
            // 
            this.cb_tempos.FormattingEnabled = true;
            this.cb_tempos.Items.AddRange(new object[] {
            "10000",
            "100000",
            "500000",
            "1000000"});
            this.cb_tempos.Location = new System.Drawing.Point(232, 59);
            this.cb_tempos.Name = "cb_tempos";
            this.cb_tempos.Size = new System.Drawing.Size(121, 21);
            this.cb_tempos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECIONE O TAMANHO DO VETOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo total (vetor crescente) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo total (vetor decrescente) : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo total (vetor aleatório) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo total (vetor semi ordenado) : ";
            // 
            // aux_semiOrdenado
            // 
            this.aux_semiOrdenado.AutoSize = true;
            this.aux_semiOrdenado.Location = new System.Drawing.Point(198, 202);
            this.aux_semiOrdenado.Name = "aux_semiOrdenado";
            this.aux_semiOrdenado.Size = new System.Drawing.Size(98, 13);
            this.aux_semiOrdenado.TabIndex = 13;
            this.aux_semiOrdenado.Text = "aux_semiOrdenado";
            this.aux_semiOrdenado.Visible = false;
            // 
            // aux_aleatorio
            // 
            this.aux_aleatorio.AutoSize = true;
            this.aux_aleatorio.Location = new System.Drawing.Point(198, 174);
            this.aux_aleatorio.Name = "aux_aleatorio";
            this.aux_aleatorio.Size = new System.Drawing.Size(70, 13);
            this.aux_aleatorio.TabIndex = 12;
            this.aux_aleatorio.Text = "aux_aleatorio";
            this.aux_aleatorio.Visible = false;
            // 
            // aux_decrescente
            // 
            this.aux_decrescente.AutoSize = true;
            this.aux_decrescente.Location = new System.Drawing.Point(198, 257);
            this.aux_decrescente.Name = "aux_decrescente";
            this.aux_decrescente.Size = new System.Drawing.Size(89, 13);
            this.aux_decrescente.TabIndex = 11;
            this.aux_decrescente.Text = "aux_decrescente";
            this.aux_decrescente.Visible = false;
            // 
            // aux_Crescente
            // 
            this.aux_Crescente.AutoSize = true;
            this.aux_Crescente.Location = new System.Drawing.Point(198, 229);
            this.aux_Crescente.Name = "aux_Crescente";
            this.aux_Crescente.Size = new System.Drawing.Size(78, 13);
            this.aux_Crescente.TabIndex = 10;
            this.aux_Crescente.Text = "aux_Crescente";
            this.aux_Crescente.Visible = false;
            // 
            // btn_insercao
            // 
            this.btn_insercao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_insercao.FlatAppearance.BorderSize = 3;
            this.btn_insercao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insercao.Location = new System.Drawing.Point(426, 107);
            this.btn_insercao.Name = "btn_insercao";
            this.btn_insercao.Size = new System.Drawing.Size(97, 37);
            this.btn_insercao.TabIndex = 14;
            this.btn_insercao.Text = "Inserção";
            this.btn_insercao.UseVisualStyleBackColor = true;
            this.btn_insercao.Click += new System.EventHandler(this.btn_insercao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 320);
            this.Controls.Add(this.btn_insercao);
            this.Controls.Add(this.aux_semiOrdenado);
            this.Controls.Add(this.aux_aleatorio);
            this.Controls.Add(this.aux_decrescente);
            this.Controls.Add(this.aux_Crescente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tempos);
            this.Controls.Add(this.bt_MergeSort);
            this.Controls.Add(this.bt_quickSort);
            this.Controls.Add(this.bt_selecao);
            this.Controls.Add(this.bt_bubbleSort);
            this.Name = "Form1";
            this.Text = "Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_bubbleSort;
        private System.Windows.Forms.Button bt_selecao;
        private System.Windows.Forms.Button bt_quickSort;
        private System.Windows.Forms.Button bt_MergeSort;
        private System.Windows.Forms.ComboBox cb_tempos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aux_semiOrdenado;
        private System.Windows.Forms.Label aux_aleatorio;
        private System.Windows.Forms.Label aux_decrescente;
        private System.Windows.Forms.Label aux_Crescente;
        private System.Windows.Forms.Button btn_insercao;
    }
}

