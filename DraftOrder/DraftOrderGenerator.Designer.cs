namespace DraftOrder
{
    partial class DraftOrderGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRandomDraft = new System.Windows.Forms.Button();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnCancelTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomDraft
            // 
            this.btnRandomDraft.BackColor = System.Drawing.Color.Lime;
            this.btnRandomDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomDraft.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomDraft.Location = new System.Drawing.Point(12, 526);
            this.btnRandomDraft.Name = "btnRandomDraft";
            this.btnRandomDraft.Size = new System.Drawing.Size(75, 23);
            this.btnRandomDraft.TabIndex = 0;
            this.btnRandomDraft.Text = "Reset";
            this.btnRandomDraft.UseVisualStyleBackColor = false;
            this.btnRandomDraft.Click += new System.EventHandler(this.btnRandomDraft_Click);
            // 
            // grdResults
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            this.grdResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdResults.BackgroundColor = System.Drawing.Color.Lime;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(-2, 55);
            this.grdResults.Name = "grdResults";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResults.Size = new System.Drawing.Size(1154, 434);
            this.grdResults.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Lime;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(1065, 524);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(251, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(661, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Random Draft Order Generator";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Lime;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(1065, 17);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(487, 492);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 29);
            this.lblTimer.TabIndex = 5;
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Lime;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.Location = new System.Drawing.Point(480, 526);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(167, 23);
            this.btnTimer.TabIndex = 6;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnCancelTimer
            // 
            this.btnCancelTimer.BackColor = System.Drawing.Color.Red;
            this.btnCancelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTimer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTimer.Location = new System.Drawing.Point(653, 526);
            this.btnCancelTimer.Name = "btnCancelTimer";
            this.btnCancelTimer.Size = new System.Drawing.Size(167, 23);
            this.btnCancelTimer.TabIndex = 7;
            this.btnCancelTimer.Text = "Cancel Timer";
            this.btnCancelTimer.UseVisualStyleBackColor = false;
            this.btnCancelTimer.Visible = false;
            this.btnCancelTimer.Click += new System.EventHandler(this.btnCancelTimer_Click);
            // 
            // DraftOrderGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1152, 560);
            this.Controls.Add(this.btnCancelTimer);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.btnRandomDraft);
            this.Name = "DraftOrderGenerator";
            this.Text = "Draft Order Generator";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomDraft;
        private System.Windows.Forms.DataGridView grdResults;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnCancelTimer;
    }
}