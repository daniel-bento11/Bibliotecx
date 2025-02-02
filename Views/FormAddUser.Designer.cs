namespace Views
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgErrConfSenha = new System.Windows.Forms.PictureBox();
            this.imgErrSenha = new System.Windows.Forms.PictureBox();
            this.imgErrNome = new System.Windows.Forms.PictureBox();
            this.imgErrUser = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnPassChar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrConfSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPassChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastrar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(36, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 5);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.imgErrConfSenha);
            this.panel1.Controls.Add(this.imgErrSenha);
            this.panel1.Controls.Add(this.imgErrNome);
            this.panel1.Controls.Add(this.imgErrUser);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.btnPassChar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtConfSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 346);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imgErrConfSenha
            // 
            this.imgErrConfSenha.Image = global::Views.Properties.Resources.obrigatorio;
            this.imgErrConfSenha.Location = new System.Drawing.Point(620, 208);
            this.imgErrConfSenha.Name = "imgErrConfSenha";
            this.imgErrConfSenha.Size = new System.Drawing.Size(28, 29);
            this.imgErrConfSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgErrConfSenha.TabIndex = 26;
            this.imgErrConfSenha.TabStop = false;
            this.imgErrConfSenha.Visible = false;
            // 
            // imgErrSenha
            // 
            this.imgErrSenha.Image = global::Views.Properties.Resources.obrigatorio;
            this.imgErrSenha.Location = new System.Drawing.Point(329, 208);
            this.imgErrSenha.Name = "imgErrSenha";
            this.imgErrSenha.Size = new System.Drawing.Size(28, 29);
            this.imgErrSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgErrSenha.TabIndex = 25;
            this.imgErrSenha.TabStop = false;
            this.imgErrSenha.Visible = false;
            // 
            // imgErrNome
            // 
            this.imgErrNome.Image = global::Views.Properties.Resources.obrigatorio;
            this.imgErrNome.Location = new System.Drawing.Point(287, 121);
            this.imgErrNome.Name = "imgErrNome";
            this.imgErrNome.Size = new System.Drawing.Size(28, 29);
            this.imgErrNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgErrNome.TabIndex = 24;
            this.imgErrNome.TabStop = false;
            this.imgErrNome.Visible = false;
            // 
            // imgErrUser
            // 
            this.imgErrUser.Image = global::Views.Properties.Resources.obrigatorio;
            this.imgErrUser.Location = new System.Drawing.Point(287, 51);
            this.imgErrUser.Name = "imgErrUser";
            this.imgErrUser.Size = new System.Drawing.Size(28, 29);
            this.imgErrUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgErrUser.TabIndex = 23;
            this.imgErrUser.TabStop = false;
            this.imgErrUser.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(287, 270);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 46);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FloralWhite;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(70, 208);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(211, 29);
            this.txtSenha.TabIndex = 15;
            // 
            // btnPassChar
            // 
            this.btnPassChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassChar.Image = global::Views.Properties.Resources.esconder_senha;
            this.btnPassChar.Location = new System.Drawing.Point(287, 208);
            this.btnPassChar.Name = "btnPassChar";
            this.btnPassChar.Size = new System.Drawing.Size(37, 29);
            this.btnPassChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPassChar.TabIndex = 21;
            this.btnPassChar.TabStop = false;
            this.btnPassChar.Click += new System.EventHandler(this.btnPassChar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(368, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Confirmar Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.FloralWhite;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.Location = new System.Drawing.Point(403, 208);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(211, 29);
            this.txtConfSenha.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usuário";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(70, 121);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(211, 29);
            this.txtNome.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FloralWhite;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(70, 51);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 29);
            this.txtUser.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(801, 5);
            this.panel5.TabIndex = 12;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::Views.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(738, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(66, 33);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 5;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrConfSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErrUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPassChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnPassChar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox imgErrUser;
        private System.Windows.Forms.PictureBox imgErrConfSenha;
        private System.Windows.Forms.PictureBox imgErrSenha;
        private System.Windows.Forms.PictureBox imgErrNome;
    }
}