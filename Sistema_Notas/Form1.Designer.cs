
namespace Sistema_Notas
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(47, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(181, 174);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(94, 34);
            this.btnCanc.TabIndex = 1;
            this.btnCanc.Text = "cancel";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(47, 57);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(228, 20);
            this.textLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(47, 113);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(228, 20);
            this.textPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label2;
    }
}

