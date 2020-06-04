using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string forras = txtbox_word.Text;
                string kulcsSzo = txtbox_key.Text;
                forras.Trim();
                forras = forras.Replace(" ", String.Empty);
                kulcsSzo.Trim();
                if (forras.Length < kulcsSzo.Length)
                {
                    throw new Exception("A titkosítani kívánt szó nem lehet rövidebb a kulcsnál!");
                }
                int forrasHossz = forras.Length;
                string kulcs = kulcsSzo + forras.Substring(0, forrasHossz - kulcsSzo.Length);

                char[,] matrix = new char[26, 26];

                for (int i = 0; i < 26; i++)
                {
                    int _char = 65 + i;
                    for (int j = 0; j < 26; j++)
                    {
                        if (_char> 90)
                        {
                            _char = 65;
                        }
                        matrix[i, j] = (char)_char;
                        _char++;
                    }
                }
                create_Alphabetic(matrix);

                forras = forras.ToUpper();
                kulcs = kulcs.ToUpper();

                explain(forras, kulcs, matrix);

                lbl_srcszoveg.Text = forras;
                lbl_srckulcs.Text = kulcs;
                int x;
                int y;
                string titkositott = "";
                
                for (int i = 0; i < forras.Length; i++)
                {
                    x = 0;
                    y = 0;
                    while (forras[i] != matrix[0, y])
                    {
                        y++;
                        if (y == 26)
                            throw new Exception("Csak az angol ABC betűit használhatjuk (A-Z)!");
                    }

                    while (kulcs[i] != matrix[x, 0])
                    {
                        x++;
                        if (x == 26)
                            throw new Exception("Csak az angol ABC betűit használhatjuk (A-Z)!");
                    }
                    titkositott = titkositott + matrix[x, y];
                }

                lbl_srctitok.Text = titkositott;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Restart();
            }
        }

        private void create_Alphabetic(char[,] matrix)
        {
            dgv_alphabetic.ColumnCount = matrix.GetLength(1);
            dgv_alphabetic.Rows.Clear();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dgv_alphabetic);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row.Cells[j].Value = matrix[i, j];
                }

                dgv_alphabetic.Rows.Add(row);
            }
        }

        private async void explain(string forras, string kulcs, char[,] matrix)
        {
            dgv_alphabetic.ClearSelection();
            lstbox_steps.Items.Clear();
            btn_create.Enabled = false;
            for (int i = 0; i < forras.Length; i++)
            {
                await Task.Delay(2000);

                int x = 0;
                int y = 0;
                string explanation;

                while (kulcs[i] != matrix[x, 0])
                {
                    x++;
                }
                while (forras[i] != matrix[0, y])
                {
                    y++;
                }

                explanation = String.Format("A(z) {0}-ik sort választom ki.", matrix[x, 0]);
                lstbox_steps.Items.Add(explanation);
                for (int j = 0; j <= y; j++)
                {
                    dgv_alphabetic.Rows[x].Cells[j].Style.BackColor = Color.DeepSkyBlue;
                }
                await Task.Delay(2000);

                explanation = String.Format("A(z) {0}-ik oszlopot választom ki.", matrix[0, y]);
                lstbox_steps.Items.Add(explanation);
                for (int j = 0; j <= x; j++)
                {
                    dgv_alphabetic.Rows[j].Cells[y].Style.BackColor = Color.Yellow;
                }

                dgv_alphabetic.Rows[x].Cells[y].Style.BackColor = Color.ForestGreen;
                await Task.Delay(1000);
                explanation = String.Format("A titkosított karakter: {0} ({1}-ik sor {2}-edik eleme)", matrix[x, y], matrix[x, 0], matrix[0, y]);
                lstbox_steps.Items.Add(explanation);
                await Task.Delay(3000);

                for (int j = 0; j <= y; j++)
                {
                    dgv_alphabetic.Rows[x].Cells[j].Style.BackColor = Color.White;
                }
                for (int j = 0; j <= x; j++)
                {
                    dgv_alphabetic.Rows[j].Cells[y].Style.BackColor = Color.White;
                }

                lstbox_steps.Items.Add("                    ");
            }
            btn_create.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
