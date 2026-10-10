namespace ValidaçãoDeDados
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
            this.lbl_Tiulo = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tiulo
            // 
            this.lbl_Tiulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Tiulo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tiulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Tiulo.Name = "lbl_Tiulo";
            this.lbl_Tiulo.Size = new System.Drawing.Size(776, 38);
            this.lbl_Tiulo.TabIndex = 0;
            this.lbl_Tiulo.Text = "Validação de Dados no C# ";
            this.lbl_Tiulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(374, 96);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(57, 21);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(374, 162);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(53, 21);
            this.lbl_Idade.TabIndex = 2;
            this.lbl_Idade.Text = "Idade";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpf.Location = new System.Drawing.Point(374, 229);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(38, 21);
            this.lbl_Cpf.TabIndex = 3;
            this.lbl_Cpf.Text = "CPF";
            this.lbl_Cpf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(317, 120);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(166, 20);
            this.txt_Nome.TabIndex = 4;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(317, 186);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(166, 20);
            this.txt_Idade.TabIndex = 5;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(317, 253);
            this.txt_Cpf.MaxLength = 11;
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.PasswordChar = '*';
            this.txt_Cpf.Size = new System.Drawing.Size(166, 20);
            this.txt_Cpf.TabIndex = 6;
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cpf_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValidaçãoDeDados.Properties.Resources.duvida;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ValidaçãoDeDados.Properties.Resources.duvida2;
            this.pictureBox2.Location = new System.Drawing.Point(564, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_Enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(352, 307);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(94, 23);
            this.btn_Enviar.TabIndex = 9;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Tiulo);
            this.Name = "Form1";
            this.Text = "Validação de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tiulo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Enviar;
    }
}

