
namespace KoPapirOlloGyak
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
            this.rdbStone = new System.Windows.Forms.RadioButton();
            this.rdbPaper = new System.Windows.Forms.RadioButton();
            this.rdbScissors = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBeatLast = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbRandom = new System.Windows.Forms.RadioButton();
            this.numSetRnds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPlayedRnds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreBoard = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComputerHit = new System.Windows.Forms.TextBox();
            this.txtScores = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetRnds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayedRnds)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbStone
            // 
            this.rdbStone.AutoSize = true;
            this.rdbStone.Location = new System.Drawing.Point(52, 203);
            this.rdbStone.Name = "rdbStone";
            this.rdbStone.Size = new System.Drawing.Size(53, 17);
            this.rdbStone.TabIndex = 0;
            this.rdbStone.TabStop = true;
            this.rdbStone.Text = "Stone";
            this.rdbStone.UseVisualStyleBackColor = true;
            // 
            // rdbPaper
            // 
            this.rdbPaper.AutoSize = true;
            this.rdbPaper.Location = new System.Drawing.Point(121, 203);
            this.rdbPaper.Name = "rdbPaper";
            this.rdbPaper.Size = new System.Drawing.Size(53, 17);
            this.rdbPaper.TabIndex = 1;
            this.rdbPaper.TabStop = true;
            this.rdbPaper.Text = "Paper";
            this.rdbPaper.UseVisualStyleBackColor = true;
            // 
            // rdbScissors
            // 
            this.rdbScissors.AutoSize = true;
            this.rdbScissors.Location = new System.Drawing.Point(196, 203);
            this.rdbScissors.Name = "rdbScissors";
            this.rdbScissors.Size = new System.Drawing.Size(64, 17);
            this.rdbScissors.TabIndex = 2;
            this.rdbScissors.TabStop = true;
            this.rdbScissors.Text = "Scissors";
            this.rdbScissors.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBeatLast);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Controls.Add(this.rdbRandom);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strategy";
            // 
            // rdbBeatLast
            // 
            this.rdbBeatLast.AutoSize = true;
            this.rdbBeatLast.Location = new System.Drawing.Point(23, 77);
            this.rdbBeatLast.Name = "rdbBeatLast";
            this.rdbBeatLast.Size = new System.Drawing.Size(65, 17);
            this.rdbBeatLast.TabIndex = 2;
            this.rdbBeatLast.TabStop = true;
            this.rdbBeatLast.Text = "beat last";
            this.rdbBeatLast.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(23, 54);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(35, 17);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "all";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbRandom
            // 
            this.rdbRandom.AutoSize = true;
            this.rdbRandom.Location = new System.Drawing.Point(23, 31);
            this.rdbRandom.Name = "rdbRandom";
            this.rdbRandom.Size = new System.Drawing.Size(60, 17);
            this.rdbRandom.TabIndex = 0;
            this.rdbRandom.TabStop = true;
            this.rdbRandom.Text = "random";
            this.rdbRandom.UseVisualStyleBackColor = true;
            // 
            // numSetRnds
            // 
            this.numSetRnds.Location = new System.Drawing.Point(250, 43);
            this.numSetRnds.Name = "numSetRnds";
            this.numSetRnds.Size = new System.Drawing.Size(49, 20);
            this.numSetRnds.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "set rounds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "played rounds";
            // 
            // numPlayedRnds
            // 
            this.numPlayedRnds.Location = new System.Drawing.Point(250, 66);
            this.numPlayedRnds.Name = "numPlayedRnds";
            this.numPlayedRnds.Size = new System.Drawing.Size(49, 20);
            this.numPlayedRnds.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "score board";
            // 
            // txtScoreBoard
            // 
            this.txtScoreBoard.Location = new System.Drawing.Point(94, 162);
            this.txtScoreBoard.Name = "txtScoreBoard";
            this.txtScoreBoard.Size = new System.Drawing.Size(205, 20);
            this.txtScoreBoard.TabIndex = 9;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(111, 237);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "computer hit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "scores";
            // 
            // txtComputerHit
            // 
            this.txtComputerHit.Location = new System.Drawing.Point(94, 136);
            this.txtComputerHit.Name = "txtComputerHit";
            this.txtComputerHit.Size = new System.Drawing.Size(91, 20);
            this.txtComputerHit.TabIndex = 13;
            // 
            // txtScores
            // 
            this.txtScores.Location = new System.Drawing.Point(235, 136);
            this.txtScores.Name = "txtScores";
            this.txtScores.Size = new System.Drawing.Size(64, 20);
            this.txtScores.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 283);
            this.Controls.Add(this.txtScores);
            this.Controls.Add(this.txtComputerHit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtScoreBoard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPlayedRnds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSetRnds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbScissors);
            this.Controls.Add(this.rdbPaper);
            this.Controls.Add(this.rdbStone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetRnds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayedRnds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbStone;
        private System.Windows.Forms.RadioButton rdbPaper;
        private System.Windows.Forms.RadioButton rdbScissors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRandom;
        private System.Windows.Forms.RadioButton rdbBeatLast;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.NumericUpDown numSetRnds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPlayedRnds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreBoard;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComputerHit;
        private System.Windows.Forms.TextBox txtScores;
    }
}

