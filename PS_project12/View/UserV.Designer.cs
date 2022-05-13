
namespace PS_project12.View
{
    partial class UserV
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.TrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListTrains = new System.Windows.Forms.Button();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrainNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainNo,
            this.OriginStation,
            this.DestinationStation,
            this.Duration,
            this.Seats,
            this.Price,
            this.TicketId});
            this.dgvUser.Location = new System.Drawing.Point(12, 62);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(738, 382);
            this.dgvUser.TabIndex = 0;
            // 
            // TrainNo
            // 
            this.TrainNo.HeaderText = "TRAIN NUMBER";
            this.TrainNo.Name = "TrainNo";
            // 
            // OriginStation
            // 
            this.OriginStation.HeaderText = "ORIGIN STATION";
            this.OriginStation.Name = "OriginStation";
            // 
            // DestinationStation
            // 
            this.DestinationStation.HeaderText = "DESTINATION STATION";
            this.DestinationStation.Name = "DestinationStation";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "DURATION";
            this.Duration.Name = "Duration";
            // 
            // Seats
            // 
            this.Seats.HeaderText = "SEATS";
            this.Seats.Name = "Seats";
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.Name = "Price";
            // 
            // TicketId
            // 
            this.TicketId.HeaderText = "TICKET ID";
            this.TicketId.Name = "TicketId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRAINS LIST";

            // 
            // cmbOrigin
            // 
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(769, 126);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(137, 23);
            this.cmbOrigin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(766, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "FROM";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(766, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TO";

            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(769, 180);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(137, 23);
            this.cmbDestination.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(769, 209);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListTrains
            // 
            this.btnListTrains.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListTrains.Location = new System.Drawing.Point(766, 61);
            this.btnListTrains.Name = "btnListTrains";
            this.btnListTrains.Size = new System.Drawing.Size(137, 34);
            this.btnListTrains.TabIndex = 7;
            this.btnListTrains.Text = "VIEW ALL TRAINS";
            this.btnListTrains.UseVisualStyleBackColor = true;
            this.btnListTrains.Click += new System.EventHandler(this.btnListTrains_Click);
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAuthentication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthentication.Location = new System.Drawing.Point(769, 393);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(137, 51);
            this.btnAuthentication.TabIndex = 8;
            this.btnAuthentication.Text = "AUTHENTICATION";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(766, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "SEARCH TRAIN";

            // 
            // txtTrainNo
            // 
            this.txtTrainNo.Location = new System.Drawing.Point(769, 298);
            this.txtTrainNo.Name = "txtTrainNo";
            this.txtTrainNo.Size = new System.Drawing.Size(137, 23);
            this.txtTrainNo.TabIndex = 10;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(769, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "ENTER TRAIN NUMBER";
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTrain.Location = new System.Drawing.Point(769, 327);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(137, 38);
            this.btnSearchTrain.TabIndex = 12;
            this.btnSearchTrain.Text = "SEARCH TRAIN";
            this.btnSearchTrain.UseVisualStyleBackColor = true;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // UserV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 477);
            this.Controls.Add(this.btnSearchTrain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrainNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.btnListTrains);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.Name = "UserV";
            this.Text = "AUTHENTICATION";

            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListTrains;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrainNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchTrain;
        protected System.Windows.Forms.Button btnAuthentication;
        protected System.Windows.Forms.DataGridView dgvUser;
        protected System.Windows.Forms.ComboBox cmbOrigin;
        protected System.Windows.Forms.ComboBox cmbDestination;
    }
}