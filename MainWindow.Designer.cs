namespace Rock_Paper_Scissors
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MessageText = new System.Windows.Forms.Label();
            this.HumanScoresField = new System.Windows.Forms.Label();
            this.ComputerScoresField = new System.Windows.Forms.Label();
            this.HumanChoise = new System.Windows.Forms.PictureBox();
            this.ComputerChoice = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HumanChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(131, 13);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Click `Start` for new game!";
            // 
            // HumanScoresField
            // 
            this.HumanScoresField.AutoSize = true;
            this.HumanScoresField.Dock = System.Windows.Forms.DockStyle.Left;
            this.HumanScoresField.Location = new System.Drawing.Point(0, 13);
            this.HumanScoresField.Name = "HumanScoresField";
            this.HumanScoresField.Size = new System.Drawing.Size(75, 13);
            this.HumanScoresField.TabIndex = 1;
            this.HumanScoresField.Text = "Your scores: 0";
            // 
            // ComputerScoresField
            // 
            this.ComputerScoresField.AutoSize = true;
            this.ComputerScoresField.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComputerScoresField.Location = new System.Drawing.Point(737, 13);
            this.ComputerScoresField.Name = "ComputerScoresField";
            this.ComputerScoresField.Size = new System.Drawing.Size(63, 13);
            this.ComputerScoresField.TabIndex = 2;
            this.ComputerScoresField.Text = "AI scores: 0";
            // 
            // HumanChoise
            // 
            this.HumanChoise.Cursor = System.Windows.Forms.Cursors.Default;
            this.HumanChoise.Image = global::Rock_Paper_Scissors.Properties.Resources.Unknown;
            this.HumanChoise.Location = new System.Drawing.Point(12, 54);
            this.HumanChoise.Name = "HumanChoise";
            this.HumanChoise.Size = new System.Drawing.Size(370, 355);
            this.HumanChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HumanChoise.TabIndex = 3;
            this.HumanChoise.TabStop = false;
            this.HumanChoise.Click += new System.EventHandler(this.HumanChoise_Click);
            // 
            // ComputerChoice
            // 
            this.ComputerChoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComputerChoice.Image = global::Rock_Paper_Scissors.Properties.Resources.Unknown;
            this.ComputerChoice.Location = new System.Drawing.Point(418, 54);
            this.ComputerChoice.Name = "ComputerChoice";
            this.ComputerChoice.Size = new System.Drawing.Size(370, 355);
            this.ComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ComputerChoice.TabIndex = 4;
            this.ComputerChoice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your move";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AI move";
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartButton.Location = new System.Drawing.Point(160, 415);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComputerChoice);
            this.Controls.Add(this.HumanChoise);
            this.Controls.Add(this.ComputerScoresField);
            this.Controls.Add(this.HumanScoresField);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Rock paper scissors";
            ((System.ComponentModel.ISupportInitialize)(this.HumanChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Label HumanScoresField;
        private System.Windows.Forms.Label ComputerScoresField;
        private System.Windows.Forms.PictureBox HumanChoise;
        private System.Windows.Forms.PictureBox ComputerChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartButton;
    }
}

