﻿using BikeGates.Models;
using BikeGates.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeGates.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameScreenTimeRace : ContentPage
    {
        public int _countSeconds = 0;
        public static List<int> listTime { get; set; } = new List<int>();


        private async void GetTimelogs()
        {
            List<TimeRace> list = await BikeGatesRepository.GetTimeRaceByName(ChoicePlayer.listNames[0].ToString());

            if (list.Count != 0)
            {
                if (list[0].Name == ChoicePlayer.listNames[0])
                {
                    if (list[0].isFinished == 1)
                    {
                        BikeGatesRepository.SetTimeRaceTime("{ 'name' : '" + ChoicePlayer.listNames[0] + "', 'isFinished' : 0, 'totalTime' : " + CountLabel.Text + "}");
                        // going to next page
                        listTime.Clear();
                        listTime.Add(_countSeconds);
                        Navigation.PushAsync(new EndScreenTimeRace());
                    }
                }
            }
        }   

        public GameScreenTimeRace()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _countSeconds++;
                CountLabel.Text = _countSeconds.ToString();

                GetTimelogs();
                return Convert.ToBoolean(_countSeconds);
            });

            

            //Responsive name on top of the page
            string Players = ChoicePlayer.listAmount[0];
            int amount = EndScreenTimeRace.listTimesHereTimeRace.Count();

            if (Players == "1")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "2")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "3")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "4")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 3)
                {
                    lblName.Text = ChoicePlayer.listNames[3].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = true;
                    imgPlayer5.IsVisible = false;
                }

            }
            else if (Players == "5")
            {
                if (amount == 0)
                {
                    lblName.Text = ChoicePlayer.listNames[0].ToString();
                    imgPlayer1.IsVisible = true;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 1)
                {
                    lblName.Text = ChoicePlayer.listNames[1].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = true;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 2)
                {
                    lblName.Text = ChoicePlayer.listNames[2].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = true;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 3)
                {
                    lblName.Text = ChoicePlayer.listNames[3].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = true;
                    imgPlayer5.IsVisible = false;
                }
                else if (amount == 4)
                {
                    lblName.Text = ChoicePlayer.listNames[4].ToString();
                    imgPlayer1.IsVisible = false;
                    imgPlayer2.IsVisible = false;
                    imgPlayer3.IsVisible = false;
                    imgPlayer4.IsVisible = false;
                    imgPlayer5.IsVisible = true;
                }
            }
        }

        private void PenaltySec(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new EndLeaderboard());
            _countSeconds = _countSeconds + 5;
        }
    }
}