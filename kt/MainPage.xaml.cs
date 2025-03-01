﻿namespace kt
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            
            int diceRoll = r.Next(1, 7);

            CounterBtn.Text = "Wysolowany rzut: " + diceRoll.ToString();
           
            RollValueLabel.Text = "Wysolowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
