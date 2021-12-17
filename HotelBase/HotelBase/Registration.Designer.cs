
namespace HotelBase
{
    partial class Registration
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
            this.btn_reg = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_surname = new System.Windows.Forms.TextBox();
            this.lbl_conpas = new System.Windows.Forms.Label();
            this.tbox_conpas = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(323, 186);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(107, 38);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "registration";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(242, 72);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(68, 17);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(4, 59);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(71, 17);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "username";
            // 
            // tbox_user
            // 
            this.tbox_user.Location = new System.Drawing.Point(89, 54);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(131, 22);
            this.tbox_user.TabIndex = 3;
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(316, 69);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.Size = new System.Drawing.Size(131, 22);
            this.tbox_pass.TabIndex = 4;
            this.tbox_pass.UseSystemPasswordChar = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(4, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 17);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(4, 130);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(63, 17);
            this.lbl_surname.TabIndex = 6;
            this.lbl_surname.Text = "surname";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(89, 89);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(131, 22);
            this.tbox_name.TabIndex = 7;
            // 
            // tbox_surname
            // 
            this.tbox_surname.Location = new System.Drawing.Point(89, 125);
            this.tbox_surname.Name = "tbox_surname";
            this.tbox_surname.Size = new System.Drawing.Size(131, 22);
            this.tbox_surname.TabIndex = 8;
            // 
            // lbl_conpas
            // 
            this.lbl_conpas.AutoSize = true;
            this.lbl_conpas.Location = new System.Drawing.Point(242, 112);
            this.lbl_conpas.Name = "lbl_conpas";
            this.lbl_conpas.Size = new System.Drawing.Size(54, 17);
            this.lbl_conpas.TabIndex = 9;
            this.lbl_conpas.Text = "confirm";
            // 
            // tbox_conpas
            // 
            this.tbox_conpas.Location = new System.Drawing.Point(316, 107);
            this.tbox_conpas.Name = "tbox_conpas";
            this.tbox_conpas.Size = new System.Drawing.Size(131, 22);
            this.tbox_conpas.TabIndex = 10;
            this.tbox_conpas.UseSystemPasswordChar = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 186);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 38);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "back to login";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(413, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 236);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbox_conpas);
            this.Controls.Add(this.lbl_conpas);
            this.Controls.Add(this.tbox_surname);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.tbox_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.btn_reg);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox tbox_user;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_surname;
        private System.Windows.Forms.Label lbl_conpas;
        private System.Windows.Forms.TextBox tbox_conpas;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnExit;
    }
}