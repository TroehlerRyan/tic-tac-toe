namespace Morpion_v2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbxNbManches = new System.Windows.Forms.TextBox();
            this.lblNbManches = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnJoueur2 = new System.Windows.Forms.RadioButton();
            this.rbtnJoueur1 = new System.Windows.Forms.RadioButton();
            this.lblScoreJ2 = new System.Windows.Forms.Label();
            this.lblScoreJ1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(392, 10);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 31;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tbxNbManches
            // 
            this.tbxNbManches.Enabled = false;
            this.tbxNbManches.Location = new System.Drawing.Point(357, 12);
            this.tbxNbManches.Name = "tbxNbManches";
            this.tbxNbManches.Size = new System.Drawing.Size(29, 20);
            this.tbxNbManches.TabIndex = 30;
            this.tbxNbManches.Text = "5";
            this.tbxNbManches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNbManches.TextChanged += new System.EventHandler(this.tbxNbManches_TextChanged);
            // 
            // lblNbManches
            // 
            this.lblNbManches.AutoSize = true;
            this.lblNbManches.Location = new System.Drawing.Point(246, 15);
            this.lblNbManches.Name = "lblNbManches";
            this.lblNbManches.Size = new System.Drawing.Size(105, 13);
            this.lblNbManches.TabIndex = 29;
            this.lblNbManches.Text = "Nombre de manches";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnJoueur2);
            this.panel3.Controls.Add(this.rbtnJoueur1);
            this.panel3.Controls.Add(this.lblScoreJ2);
            this.panel3.Controls.Add(this.lblScoreJ1);
            this.panel3.Location = new System.Drawing.Point(8, 99);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 67);
            this.panel3.TabIndex = 28;
            // 
            // rbtnJoueur2
            // 
            this.rbtnJoueur2.AutoSize = true;
            this.rbtnJoueur2.Enabled = false;
            this.rbtnJoueur2.Location = new System.Drawing.Point(3, 25);
            this.rbtnJoueur2.Name = "rbtnJoueur2";
            this.rbtnJoueur2.Size = new System.Drawing.Size(66, 17);
            this.rbtnJoueur2.TabIndex = 5;
            this.rbtnJoueur2.Text = "Joueur 2";
            this.rbtnJoueur2.UseVisualStyleBackColor = true;
            // 
            // rbtnJoueur1
            // 
            this.rbtnJoueur1.AutoSize = true;
            this.rbtnJoueur1.Checked = true;
            this.rbtnJoueur1.Enabled = false;
            this.rbtnJoueur1.Location = new System.Drawing.Point(3, 2);
            this.rbtnJoueur1.Name = "rbtnJoueur1";
            this.rbtnJoueur1.Size = new System.Drawing.Size(66, 17);
            this.rbtnJoueur1.TabIndex = 4;
            this.rbtnJoueur1.TabStop = true;
            this.rbtnJoueur1.Text = "Joueur 1";
            this.rbtnJoueur1.UseVisualStyleBackColor = true;
            // 
            // lblScoreJ2
            // 
            this.lblScoreJ2.AutoSize = true;
            this.lblScoreJ2.Location = new System.Drawing.Point(72, 28);
            this.lblScoreJ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreJ2.Name = "lblScoreJ2";
            this.lblScoreJ2.Size = new System.Drawing.Size(13, 13);
            this.lblScoreJ2.TabIndex = 6;
            this.lblScoreJ2.Text = "0";
            // 
            // lblScoreJ1
            // 
            this.lblScoreJ1.AutoSize = true;
            this.lblScoreJ1.Location = new System.Drawing.Point(72, 4);
            this.lblScoreJ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreJ1.Name = "lblScoreJ1";
            this.lblScoreJ1.Size = new System.Drawing.Size(13, 13);
            this.lblScoreJ1.TabIndex = 7;
            this.lblScoreJ1.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(149, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 237);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Location = new System.Drawing.Point(0, 162);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 75);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox8.Location = new System.Drawing.Point(81, 162);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 75);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox9.Location = new System.Drawing.Point(162, 162);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 75);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Location = new System.Drawing.Point(81, 81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.Location = new System.Drawing.Point(162, 81);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 75);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(0, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(162, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(81, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ClicCase);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ClicCase);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 430);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(57, 45);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(140, 37);
            this.lblTitre.TabIndex = 25;
            this.lblTitre.Text = "Morpion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 430);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxNbManches);
            this.Controls.Add(this.lblNbManches);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblTitre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxNbManches;
        private System.Windows.Forms.Label lblNbManches;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnJoueur2;
        private System.Windows.Forms.RadioButton rbtnJoueur1;
        private System.Windows.Forms.Label lblScoreJ2;
        private System.Windows.Forms.Label lblScoreJ1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblTitre;
    }
}

