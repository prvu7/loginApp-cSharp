namespace login_database_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.listBoxPass = new System.Windows.Forms.ListBox();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(261, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(636, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "La crearea contului, trebuie să furnizați informații exacte, complete și actualiz" +
    "ate.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox2.Location = new System.Drawing.Point(261, 309);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(586, 85);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Prin utilizarea Site-ului, consimțiți la colectarea și utilizarea informațiilor d" +
    "vs. personale în conformitate cu Politica noastră de Confidențialitate.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUser.Location = new System.Drawing.Point(421, 180);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(251, 27);
            this.textBoxUser.TabIndex = 3;
            this.textBoxUser.Text = "Email or username";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            this.textBoxUser.MouseEnter += new System.EventHandler(this.textBoxUser_MouseEnter);
            this.textBoxUser.MouseLeave += new System.EventHandler(this.textBoxUser_MouseLeave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPass.Location = new System.Drawing.Point(421, 225);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(251, 27);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            this.textBoxPass.MouseEnter += new System.EventHandler(this.textBoxPass_MouseEnter);
            this.textBoxPass.MouseLeave += new System.EventHandler(this.textBoxPass_MouseLeave);
            // 
            // listBoxUser
            // 
            this.listBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUser.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 20;
            this.listBoxUser.Location = new System.Drawing.Point(687, 135);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(298, 84);
            this.listBoxUser.TabIndex = 7;
            this.listBoxUser.Visible = false;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.Location = new System.Drawing.Point(440, 400);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(193, 54);
            this.buttonCreateAccount.TabIndex = 8;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // listBoxPass
            // 
            this.listBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPass.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxPass.FormattingEnabled = true;
            this.listBoxPass.ItemHeight = 20;
            this.listBoxPass.Location = new System.Drawing.Point(103, 159);
            this.listBoxPass.Name = "listBoxPass";
            this.listBoxPass.Size = new System.Drawing.Size(298, 104);
            this.listBoxPass.TabIndex = 9;
            this.listBoxPass.Visible = false;
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPass.Location = new System.Drawing.Point(687, 228);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(76, 24);
            this.checkBoxPass.TabIndex = 10;
            this.checkBoxPass.Text = "Show";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.listBoxPass);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.ListBox listBoxPass;
        private System.Windows.Forms.CheckBox checkBoxPass;
    }
}