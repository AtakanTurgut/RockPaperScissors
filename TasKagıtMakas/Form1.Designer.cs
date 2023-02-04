namespace TasKagıtMakas
{
    partial class Form1
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
            this.btnRock = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblCScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCRock = new System.Windows.Forms.Button();
            this.btnCPaper = new System.Windows.Forms.Button();
            this.btnCScissors = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRock.Location = new System.Drawing.Point(144, 326);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(200, 65);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(479, 326);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(81, 29);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblCScore
            // 
            this.lblCScore.AutoSize = true;
            this.lblCScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCScore.Location = new System.Drawing.Point(428, 105);
            this.lblCScore.Name = "lblCScore";
            this.lblCScore.Size = new System.Drawing.Size(42, 58);
            this.lblCScore.TabIndex = 8;
            this.lblCScore.Text = "-";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(428, 404);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 58);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(172, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 58);
            this.lblStatus.TabIndex = 6;
            // 
            // btnCRock
            // 
            this.btnCRock.BackColor = System.Drawing.Color.White;
            this.btnCRock.Enabled = false;
            this.btnCRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCRock.Location = new System.Drawing.Point(144, 27);
            this.btnCRock.Name = "btnCRock";
            this.btnCRock.Size = new System.Drawing.Size(200, 65);
            this.btnCRock.TabIndex = 3;
            this.btnCRock.Text = "Rock";
            this.btnCRock.UseVisualStyleBackColor = false;
            // 
            // btnCPaper
            // 
            this.btnCPaper.BackColor = System.Drawing.Color.White;
            this.btnCPaper.Enabled = false;
            this.btnCPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCPaper.Location = new System.Drawing.Point(144, 98);
            this.btnCPaper.Name = "btnCPaper";
            this.btnCPaper.Size = new System.Drawing.Size(200, 65);
            this.btnCPaper.TabIndex = 4;
            this.btnCPaper.Text = "Paper";
            this.btnCPaper.UseVisualStyleBackColor = false;
            this.btnCPaper.Click += new System.EventHandler(this.btnCPaper_Click);
            // 
            // btnCScissors
            // 
            this.btnCScissors.BackColor = System.Drawing.Color.White;
            this.btnCScissors.Enabled = false;
            this.btnCScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCScissors.Location = new System.Drawing.Point(144, 169);
            this.btnCScissors.Name = "btnCScissors";
            this.btnCScissors.Size = new System.Drawing.Size(200, 65);
            this.btnCScissors.TabIndex = 5;
            this.btnCScissors.Text = "Scissors";
            this.btnCScissors.UseVisualStyleBackColor = false;
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnScissors.Location = new System.Drawing.Point(144, 468);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(200, 65);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaper.Location = new System.Drawing.Point(144, 397);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(200, 65);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 561);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCScissors);
            this.Controls.Add(this.btnCPaper);
            this.Controls.Add(this.btnCRock);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblCScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCRock;
        private System.Windows.Forms.Button btnCPaper;
        private System.Windows.Forms.Button btnCScissors;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
    }
}

