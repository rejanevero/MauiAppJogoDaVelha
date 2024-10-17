
using System;

namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
            Zerar();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                btn.TextColor = Colors.White;
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                btn.TextColor = Colors.White;
                vez = "X";
            }

           
            // Verificando se o X ganhou
            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") || // linha
                (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") || // linha
                (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") || // linha
                (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") || // coluna
                (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") || // coluna
                (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") || // coluna
                (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") || // diagonal
                (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X"))   // diagonal

            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            else if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") || // linha
                     (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") || // linha
                     (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") || // linha
                     (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") || // coluna
                     (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") || // coluna
                     (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") || // coluna
                     (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") || // diagonal
                     (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"))   // diagonal

            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            //empate
            else if (TodosBotoesClicados())
            {
                DisplayAlert("Empate!", "Deu velha!", "OK");
                Zerar();
            }
        } // Fecha método

        private bool TodosBotoesClicados()
        {
            return 
                   btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                   btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                   btn30.Text != "" && btn31.Text != "" && btn32.Text != "" ;
        }
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";


            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }

    } // Fecha Classe
} // Fecha Namespace
