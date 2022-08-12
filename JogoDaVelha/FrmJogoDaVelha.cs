namespace JogoDaVelha
{
    public partial class frmJogoDaVelha : Form
    {
        int count = 0;
        int[,] matriz = new int[3, 3];
        bool fimDeJogo = false;

        public frmJogoDaVelha()
        {
            InitializeComponent();
        }

        private void txbNome1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbNome1.Text != "" && ((e.KeyChar == (char)Keys.Enter)))
            {
                lblSimboloX.Text = $"{txbNome1.Text},\nvocê é o 'X'";
                txbNome1.ReadOnly = true;
                txbNome2.Focus();
            }

            if (lblSimboloX.Text != "" && lblSimboloO.Text != "")
            {
                lblNomes.Text = "Vamos jogar!\nClique em\numa posição";
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
            }
        }

        private void txbNome2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbNome2.Text != "" && ((e.KeyChar == (char)Keys.Enter)))
            {
                lblSimboloO.Text = $"{txbNome2.Text},\nvocê é o 'O'";
                txbNome2.ReadOnly = true;
            }

            if (lblSimboloX.Text != "" && lblSimboloO.Text != "")
            {
                lblNomes.Text = "Vamos jogar!\nClique em\numa posição";
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn1.Text);
            if (count % 2 == 0 && EstaVazio(btn1.Text) && !fimDeJogo)
            {
                btn1.Text = "X";
                matriz[0, 0] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn1.Text) && !fimDeJogo)
            {
                btn1.Text = "O";
                matriz[0, 0] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn2.Text);
            if (count % 2 == 0 && EstaVazio(btn2.Text) && !fimDeJogo)
            {
                btn2.Text = "X";
                matriz[0, 1] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn2.Text) && !fimDeJogo)
            {
                btn2.Text = "O";
                matriz[0, 1] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn3.Text);
            if (count % 2 == 0 && EstaVazio(btn3.Text) && !fimDeJogo)
            {
                btn3.Text = "X";
                matriz[0, 2] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn3.Text) && !fimDeJogo)
            {
                btn3.Text = "O";
                matriz[0, 2] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn4.Text);
            if (count % 2 == 0 && EstaVazio(btn4.Text) && !fimDeJogo)
            {
                btn4.Text = "X";
                matriz[1, 0] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn4.Text) && !fimDeJogo)
            {
                btn4.Text = "O";
                matriz[1, 0] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn5.Text);
            if (count % 2 == 0 && EstaVazio(btn5.Text) && !fimDeJogo)
            {
                btn5.Text = "X";
                matriz[1, 1] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn5.Text) && !fimDeJogo)
            {
                btn5.Text = "O";
                matriz[1, 1] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn6.Text);
            if (count % 2 == 0 && EstaVazio(btn6.Text) && !fimDeJogo)
            {
                btn6.Text = "X";
                matriz[1, 2] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn6.Text) && !fimDeJogo)
            {
                btn6.Text = "O";
                matriz[1, 2] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn7.Text);
            if (count % 2 == 0 && EstaVazio(btn7.Text) && !fimDeJogo)
            {
                btn7.Text = "X";
                matriz[2, 0] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn7.Text) && !fimDeJogo)
            {
                btn7.Text = "O";
                matriz[2, 0] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn8.Text);
            if (count % 2 == 0 && EstaVazio(btn8.Text) && !fimDeJogo)
            {
                btn8.Text = "X";
                matriz[2, 1] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn8.Text) && !fimDeJogo)
            {
                btn8.Text = "O";
                matriz[2, 1] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            ChecaSelecao(btn9.Text);
            if (count % 2 == 0 && EstaVazio(btn9.Text) && !fimDeJogo)
            {
                btn9.Text = "X";
                matriz[2, 2] = 1;
                lblVez.Text = $"É a sua vez,\n{txbNome2.Text}";
                count++;
            }
            if (count % 2 != 0 && EstaVazio(btn9.Text) && !fimDeJogo)
            {
                btn9.Text = "O";
                matriz[2, 2] = 2;
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
                count++;
            }
            ChecaVitoria();
        }

        private void ComecaJogo() //será que precisa?
        {
            if (lblSimboloX.Text == "")
            {
                txbNome1.Focus();
            }
            if (lblSimboloX.Text != "" && lblSimboloX.Text == "")
            {
                txbNome2.Focus();
            }
        }

        private void ChecaSelecao(string botao)
        {
            if (botao != "")
            {
                lblVez.Text = "Esse espaço já \nfoi preenchido.";
            }
        }

        private bool EstaVazio(string botao)
        {
            if (botao == "" && lblSimboloX.Text != "" && lblSimboloO.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChecaVitoria()
        {
            if (count >= 5 && fimDeJogo == false)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2] && matriz[i, 0] != 0)
                    {
                        if (matriz[i, 0] == 1)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome1.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }
                        if (matriz[i, 0] == 2)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome2.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }

                    }
                    else if (matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i] && matriz[0, i] != 0)
                    {
                        if (matriz[0, i] == 1)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome1.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }
                        if (matriz[0, i] == 2)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome2.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }

                    }
                    else if (((matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2]) ||
                        (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]))
                        && i != 1 && matriz[1, 1] != 0)
                    {
                        if (matriz[1, 1] == 1)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome1.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }
                        if (matriz[1, 1] == 2)
                        {
                            lblVez.Text = $"Fim de Jogo!\n{txbNome2.Text} venceu!";
                            fimDeJogo = true;
                            break;
                        }

                    }
                }
                if (count == 9 && fimDeJogo == false)
                {
                    lblVez.Text = $"Fim de Jogo!\nEMPATE";
                    fimDeJogo = true;
                }
            }
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmJogoDaVelha();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNome2_Click(object sender, EventArgs e)
        {
            if (txbNome1.Text != "")
            {
                lblSimboloX.Text = $"{txbNome1.Text},\nvocê é o 'X'";
                txbNome1.ReadOnly = true;
                txbNome2.Focus();
            }

            if (lblSimboloX.Text != "" && lblSimboloO.Text != "")
            {
                lblNomes.Text = "Vamos jogar!\nClique em\numa posição";
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
            }
        }

        private void txbNome1_Click(object sender, EventArgs e)
        {
            if (txbNome2.Text != "")
            {
                lblSimboloO.Text = $"{txbNome2.Text},\nvocê é o 'O'";
                txbNome2.ReadOnly = true;
            }

            if (lblSimboloX.Text != "" && lblSimboloO.Text != "")
            {
                lblNomes.Text = "Vamos jogar!\nClique em\numa posição";
                lblVez.Text = $"É a sua vez,\n{txbNome1.Text}";
            }
        }
    }
}