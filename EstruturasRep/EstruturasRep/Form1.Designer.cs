namespace EstruturasRep
{
    partial class Repetidores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlRepeticao = new Panel();
            btnContinue = new Button();
            btnFor = new Button();
            btnBreak = new Button();
            btnDoWhile = new Button();
            btnForEach = new Button();
            btnWhile = new Button();
            lblRepetidores = new Label();
            lsbMostra = new ListBox();
            pnlRepeticao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRepeticao
            // 
            pnlRepeticao.BorderStyle = BorderStyle.Fixed3D;
            pnlRepeticao.Controls.Add(btnContinue);
            pnlRepeticao.Controls.Add(btnFor);
            pnlRepeticao.Controls.Add(btnBreak);
            pnlRepeticao.Controls.Add(btnDoWhile);
            pnlRepeticao.Controls.Add(btnForEach);
            pnlRepeticao.Controls.Add(btnWhile);
            pnlRepeticao.Location = new Point(40, 99);
            pnlRepeticao.Margin = new Padding(4, 5, 4, 5);
            pnlRepeticao.Name = "pnlRepeticao";
            pnlRepeticao.Size = new Size(390, 326);
            pnlRepeticao.TabIndex = 8;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(209, 217);
            btnContinue.Margin = new Padding(4, 5, 4, 5);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(130, 67);
            btnContinue.TabIndex = 10;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(46, 217);
            btnFor.Margin = new Padding(4, 5, 4, 5);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(130, 67);
            btnFor.TabIndex = 9;
            btnFor.Text = "For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnBreak
            // 
            btnBreak.Location = new Point(210, 113);
            btnBreak.Margin = new Padding(4, 5, 4, 5);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(130, 67);
            btnBreak.TabIndex = 8;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = true;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(47, 113);
            btnDoWhile.Margin = new Padding(4, 5, 4, 5);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(130, 67);
            btnDoWhile.TabIndex = 7;
            btnDoWhile.Text = "Do...While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnForEach
            // 
            btnForEach.Location = new Point(209, 17);
            btnForEach.Margin = new Padding(4, 5, 4, 5);
            btnForEach.Name = "btnForEach";
            btnForEach.Size = new Size(130, 67);
            btnForEach.TabIndex = 6;
            btnForEach.Text = "ForEach";
            btnForEach.UseVisualStyleBackColor = true;
            btnForEach.Click += btnForEach_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(46, 17);
            btnWhile.Margin = new Padding(4, 5, 4, 5);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(130, 67);
            btnWhile.TabIndex = 5;
            btnWhile.Text = "While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // lblRepetidores
            // 
            lblRepetidores.AutoSize = true;
            lblRepetidores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRepetidores.Location = new Point(40, 40);
            lblRepetidores.Margin = new Padding(4, 0, 4, 0);
            lblRepetidores.Name = "lblRepetidores";
            lblRepetidores.Size = new Size(150, 32);
            lblRepetidores.TabIndex = 9;
            lblRepetidores.Text = "Repetidores";
            // 
            // lsbMostra
            // 
            lsbMostra.BackColor = Color.White;
            lsbMostra.BorderStyle = BorderStyle.FixedSingle;
            lsbMostra.FormattingEnabled = true;
            lsbMostra.Location = new Point(543, 99);
            lsbMostra.Margin = new Padding(4, 5, 4, 5);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(332, 377);
            lsbMostra.TabIndex = 10;
            lsbMostra.SelectedIndexChanged += lsbMostra_SelectedIndexChanged;
            // 
            // Repetidores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 657);
            Controls.Add(lsbMostra);
            Controls.Add(lblRepetidores);
            Controls.Add(pnlRepeticao);
            Name = "Repetidores";
            Text = "Repetidores";
            pnlRepeticao.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRepeticao;
        private Button btnContinue;
        private Button btnFor;
        private Button btnBreak;
        private Button btnDoWhile;
        private Button btnForEach;
        private Button btnWhile;
        private Label lblRepetidores;
        private ListBox lsbMostra;
    }
}
