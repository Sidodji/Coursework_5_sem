
namespace HotelBase
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.btnBron = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.DGVRooms = new System.Windows.Forms.DataGridView();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_Tem = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit_2 = new System.Windows.Forms.Button();
            this.tboxNewPass = new System.Windows.Forms.TextBox();
            this.tboxNewPass2 = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxUser.Controls.Add(this.lblPass);
            this.groupBoxUser.Controls.Add(this.tboxNewPass2);
            this.groupBoxUser.Controls.Add(this.tboxNewPass);
            this.groupBoxUser.Controls.Add(this.btnBron);
            this.groupBoxUser.Controls.Add(this.btnReserve);
            this.groupBoxUser.Controls.Add(this.DGVRooms);
            this.groupBoxUser.Controls.Add(this.lblSurname);
            this.groupBoxUser.Controls.Add(this.lblName);
            this.groupBoxUser.Controls.Add(this.btnSave);
            this.groupBoxUser.Controls.Add(this.btnExit);
            this.groupBoxUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUser.Location = new System.Drawing.Point(12, 71);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(776, 367);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            this.groupBoxUser.Enter += new System.EventHandler(this.groupBoxUser_Enter);
            // 
            // btnBron
            // 
            this.btnBron.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBron.Location = new System.Drawing.Point(10, 268);
            this.btnBron.Name = "btnBron";
            this.btnBron.Size = new System.Drawing.Size(204, 93);
            this.btnBron.TabIndex = 9;
            this.btnBron.Text = "Reservation";
            this.btnBron.UseVisualStyleBackColor = true;
            this.btnBron.Click += new System.EventHandler(this.btnBron_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(357, 312);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(129, 51);
            this.btnReserve.TabIndex = 8;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // DGVRooms
            // 
            this.DGVRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRooms.Location = new System.Drawing.Point(220, 32);
            this.DGVRooms.Name = "DGVRooms";
            this.DGVRooms.RowHeadersWidth = 51;
            this.DGVRooms.RowTemplate.Height = 24;
            this.DGVRooms.Size = new System.Drawing.Size(550, 270);
            this.DGVRooms.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(6, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(84, 24);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(6, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save pass";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(623, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Back to login";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // lbl_Tem
            // 
            this.lbl_Tem.AutoSize = true;
            this.lbl_Tem.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tem.Location = new System.Drawing.Point(296, 9);
            this.lbl_Tem.Name = "lbl_Tem";
            this.lbl_Tem.Size = new System.Drawing.Size(202, 38);
            this.lbl_Tem.TabIndex = 1;
            this.lbl_Tem.Text = "User view";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit_2
            // 
            this.btnExit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit_2.Location = new System.Drawing.Point(750, 9);
            this.btnExit_2.Name = "btnExit_2";
            this.btnExit_2.Size = new System.Drawing.Size(38, 38);
            this.btnExit_2.TabIndex = 2;
            this.btnExit_2.Text = "X";
            this.btnExit_2.UseVisualStyleBackColor = true;
            this.btnExit_2.Click += new System.EventHandler(this.btnExit_2_Click);
            // 
            // tboxNewPass
            // 
            this.tboxNewPass.Location = new System.Drawing.Point(6, 150);
            this.tboxNewPass.Name = "tboxNewPass";
            this.tboxNewPass.Size = new System.Drawing.Size(100, 32);
            this.tboxNewPass.TabIndex = 10;
            this.tboxNewPass.UseSystemPasswordChar = true;
            // 
            // tboxNewPass2
            // 
            this.tboxNewPass2.Location = new System.Drawing.Point(114, 150);
            this.tboxNewPass2.Name = "tboxNewPass2";
            this.tboxNewPass2.Size = new System.Drawing.Size(100, 32);
            this.tboxNewPass2.TabIndex = 11;
            this.tboxNewPass2.UseSystemPasswordChar = true;
            this.tboxNewPass2.TextChanged += new System.EventHandler(this.tboxNewPass2_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(29, 110);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(158, 24);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Change Password";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnExit_2);
            this.Controls.Add(this.lbl_Tem);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label lbl_Tem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit_2;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DataGridView DGVRooms;
        private System.Windows.Forms.Button btnBron;
        private System.Windows.Forms.TextBox tboxNewPass2;
        private System.Windows.Forms.TextBox tboxNewPass;
        private System.Windows.Forms.Label lblPass;
    }
}