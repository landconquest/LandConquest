﻿using LandConquest.Models;
using LandConquestDB.Entities;
using LandConquestDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;


namespace LandConquest.Forms
{
    /// <summary>
    /// Логика взаимодействия для CountryWindow.xaml
    /// </summary>
    public partial class CountryWindow : Window
    {
        Player player;
        List<Land> countryLands;
        List<Land> countryLandsToFight;
        List<Country> countries;
        Land selectedLand;
        Country transferCountry;
        Land countryLandDefender;
        int operation = 0;
        bool f = true;
        public CountryWindow(Player _player)
        {
            player = _player;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Country country = CountryModel.GetCountryById(CountryModel.GetCountryId(player));
            Player ruler = new Player();
            User rulerUser = new User();
            rulerUser.UserId = country.CountryRuler;
            ruler = PlayerModel.GetPlayerInfo(rulerUser, ruler);
            RulerNameLbl.Content = ruler.PlayerName;
            CountryNameLbl.Content = country.CountryName;

            countryLands = LandModel.GetCountryLands(country);

            int count = CountryModel.SelectLastIdOfStates();

            countries = new List<Country>();
            for (int i = 0; i < count; i++)
            {
                countries.Add(new Country());
            }
            countries = CountryModel.GetCountriesInfo(countries);
        }

        private void CbAct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //MessageBox.Show(selectedItem.Content.ToString());

            if (selectedItem.Content.ToString() == "Land transfer")
            {
                operation = 1;
                for (int i = 0; i < countryLands.Count; i++)
                {
                    CbLandToTransfer.Items.Add(countryLands[i].LandName);
                }

                for (int i = 0; i < countries.Count; i++)
                {
                    CbCountryToTransfer.Items.Add(countries[i].CountryName);
                }
            }
            if (selectedItem.Content.ToString() == "Declare a war")
            {
                operation = 2;
                for (int i = 0; i < countryLands.Count; i++)
                {
                    CbLandToTransfer.Items.Add(countryLands[i].LandName);
                }

                for (int i = 0; i < countries.Count; i++)
                {
                    CbCountryToTransfer.Items.Add(countries[i].CountryName);
                }

                CbCountryWarLand.Visibility = Visibility.Visible;
            }

        }

        private void IssueALaw_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case 1:
                    {
                        Player player = new Player();
                        player.PlayerCurrentRegion = selectedLand.LandId;
                        Country ThisCountry = CountryModel.GetCountryById(CountryModel.GetCountryId(player));

                        LandModel.UpdateLandInfo(selectedLand, transferCountry);

                        countryLands = LandModel.GetCountryLands(ThisCountry);
                        if (countryLands.Count == 0)
                        {
                            CountryModel.DisbandCountry(ThisCountry);
                        }
                        //тут нужно написать функцию на чек пустых государств. Если гос-во пустое - король теряет свой титул.
                        break;
                    }
                case 2:
                    {
                        WarModel warModel = new WarModel();
                        WarModel.DeclareAWar(GenerateId(), selectedLand, countryLandDefender);

                        break;
                    }
            }


        }

        private void CbLandToTransfer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedLand = new Land();
            selectedLand = countryLands[CbLandToTransfer.SelectedIndex];
        }

        private void CbCountryToTransfer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            transferCountry = new Country();

            transferCountry = countries[CbCountryToTransfer.SelectedIndex];
            Console.WriteLine(transferCountry.CountryName);

            if (operation == 2)
            {
                CbCountryWarLand.Items.Clear();

                countryLandsToFight = LandModel.GetCountryLands(transferCountry);

                for (int i = 0; i < countryLandsToFight.Count; i++)
                {
                    CbCountryWarLand.Items.Add(countryLandsToFight[i].LandName);
                    Console.WriteLine(i);
                }
            }
        }

        private void CbCountryWarLand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //countryLandsToFight = new List<Land>();
            if (CbCountryWarLand.SelectedIndex != -1)
                countryLandDefender = countryLandsToFight[CbCountryWarLand.SelectedIndex]; // STAR!
        }

        private static Random random;
        public static string GenerateId()
        {
            Thread.Sleep(15);
            random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvmxyz0123456789";
            return new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
