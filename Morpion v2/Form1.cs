using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Morpion_Paint(object sender, PaintEventArgs e)
        {
            Graphics d = e.Graphics;
            d.DrawEllipse(Pens.Red, 10, 20, 100, 30);

            //    d.FillRectangle(Brushes.Blue, 10, 200, 20, 20);
        }


        private void ClicCase(object sender, EventArgs e)
        {
            ClicDansCase(sender as PictureBox);
        }

        private void ClicDansCase(PictureBox pictureBox)
        {
            if (rbtnJoueur1.Checked)
            {
                if (pictureBox.BackgroundImage == null)
                {
                    pictureBox.BackgroundImage = Properties.Resources.x;
                    pictureBox.Tag = "X";
                    Gagnant();
                    Victoire();
                    rbtnJoueur2.Checked = true;
                }
            }

            else if (rbtnJoueur2.Checked)
            {
                if (pictureBox.BackgroundImage == null)
                {
                    pictureBox.BackgroundImage = Properties.Resources.o;
                    pictureBox.Tag = "O";
                    Gagnant();
                    Victoire();
                    rbtnJoueur1.Checked = true;
                }
            }
            else
                MessageBox.Show("erreur innatendue");

        }

        int iWinner = 0;
        int iScoreJ1 = 0;
        int iScoreJ2 = 0;
        int iMax = 5;
        int iChangements = 0;

        private void Gagnant()
        {
            if (rbtnJoueur1.Checked)
            {
                iWinner = 1;
            }
            else if (rbtnJoueur2.Checked)
            {
                iWinner = 2;
            }
            else
            {
                MessageBox.Show("Erreur de gagnant");
            }

        }
        private void Victoire()
        {
            //vérifie si les images de fond sont égales, et si elles ne sont pas vides
            bool bWin1 = (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag) && (pictureBox1.Tag != null && pictureBox2.Tag != null && pictureBox3.Tag != null);
            bool bWin2 = (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag) && (pictureBox4.Tag != null && pictureBox5.Tag != null && pictureBox6.Tag != null);
            bool bWin3 = (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag) && (pictureBox7.Tag != null && pictureBox8.Tag != null && pictureBox9.Tag != null);
            bool bWin4 = (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag) && (pictureBox1.Tag != null && pictureBox4.Tag != null && pictureBox7.Tag != null);
            bool bWin5 = (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag) && (pictureBox2.Tag != null && pictureBox5.Tag != null && pictureBox8.Tag != null);
            bool bWin6 = (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag) && (pictureBox9.Tag != null && pictureBox6.Tag != null && pictureBox3.Tag != null);
            bool bWin7 = (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag) && (pictureBox1.Tag != null && pictureBox5.Tag != null && pictureBox9.Tag != null);
            bool bWin8 = (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag) && (pictureBox3.Tag != null && pictureBox5.Tag != null && pictureBox7.Tag != null);
            bool bWin00 = (bWin1 || bWin2 || bWin3 || bWin4 || bWin5 || bWin6 || bWin7 || bWin8);

            // égalité
            if (pictureBox1.Tag != null && pictureBox2.Tag != null && pictureBox3.Tag != null && pictureBox4.Tag != null && pictureBox5.Tag != null && pictureBox6.Tag != null && pictureBox7.Tag != null && pictureBox8.Tag != null && pictureBox9.Tag != null)
            {
                MessageBox.Show("It's a draw ! ", "Fin de la manche");
                Reset();
            }


            // gagnant
            if (bWin00)
            {
                Gagnant();
                MessageBox.Show("Victoire du joueur " + iWinner.ToString(), "Fin de la manche");
                if (iWinner == 1)
                {
                    iScoreJ1 += 1;
                    lblScoreJ1.Text = iScoreJ1.ToString();

                }
                else if (iWinner == 2)
                {
                    iScoreJ2 += 1;
                    lblScoreJ2.Text = iScoreJ2.ToString();
                }




                // fin du jeu
                if (iScoreJ1 >= iMax)
                {
                    MessageBox.Show("Le joueur 1 a gagné", "Fin du jeu");
                    Recommencer();
                }

                else if (iScoreJ2 >= iMax)
                {
                    MessageBox.Show("Le joueur 2 a gagné", "Fin du jeu");
                    Recommencer();
                }

                Reset();
            }

        }

        private void Recommencer()
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous recommencer ?", "Recommencer ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Reset();
                iScoreJ1 = 0;
                iScoreJ2 = 0;
                tbxNbManches.Text = "5";
                lblScoreJ1.Text = iScoreJ1.ToString();
                lblScoreJ2.Text = iScoreJ2.ToString();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void Reset()
        {
            iWinner = 0;
            pictureBox1.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox7.BackgroundImage = null;
            pictureBox8.BackgroundImage = null;
            pictureBox9.BackgroundImage = null;

            pictureBox1.Tag = null;
            pictureBox2.Tag = null;
            pictureBox3.Tag = null;
            pictureBox4.Tag = null;
            pictureBox5.Tag = null;
            pictureBox6.Tag = null;
            pictureBox7.Tag = null;
            pictureBox8.Tag = null;
            pictureBox9.Tag = null;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (iChangements <= 1)
            {
                tbxNbManches.Enabled = true;
                tbxNbManches.Focus();
                tbxNbManches.SelectAll();
                iChangements++;
            }
        }

        private void tbxNbManches_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iMax = Convert.ToInt16(tbxNbManches.Text);
                tbxNbManches.Enabled = false;
            }
            catch
            {
                MessageBox.Show("valeur non valide, veuillez saisir un nombre entre 1 et 9");
            }
        }


    }
}

