
namespace HotelBase
{
    partial class Reservation
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
            this.GBReserve = new System.Windows.Forms.GroupBox();
            this.DGReservation = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblView = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeRes = new System.Windows.Forms.Button();
            this.GBReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // GBReserve
            // 
            this.GBReserve.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GBReserve.Controls.Add(this.DGReservation);
            this.GBReserve.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBReserve.Location = new System.Drawing.Point(12, 62);
            this.GBReserve.Name = "GBReserve";
            this.GBReserve.Size = new System.Drawing.Size(663, 376);
            this.GBReserve.TabIndex = 0;
            this.GBReserve.TabStop = false;
            this.GBReserve.Text = "User";
            // 
            // DGReservation
            // 
            this.DGReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGReservation.Location = new System.Drawing.Point(6, 26);
            this.DGReservation.Name = "DGReservation";
            this.DGReservation.RowHeadersWidth = 51;
            this.DGReservation.RowTemplate.Height = 24;
            this.DGReservation.Size = new System.Drawing.Size(469, 344);
            this.DGReservation.TabIndex = 0;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblView.Location = new System.Drawing.Point(321, 9);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(187, 29);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "User\'s booking";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(744, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(681, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeRes
            // 
            this.btnDeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeRes.Location = new System.Drawing.Point(681, 339);
            this.btnDeRes.Name = "btnDeRes";
            this.btnDeRes.Size = new System.Drawing.Size(107, 41);
            this.btnDeRes.TabIndex = 4;
            this.btnDeRes.Text = "de-reserve";
            this.btnDeRes.UseVisualStyleBackColor = true;
            this.btnDeRes.Click += new System.EventHandler(this.btnDeRes_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeRes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.GBReserve);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.GBReserve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox GBReserve;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView DGReservation;
        private System.Windows.Forms.Button btnDeRes;
    }
}