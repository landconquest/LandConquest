﻿using LandConquestDB.Entities;
using LandConquestDB.Models;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LandConquest.DialogWIndows
{

    public partial class EstablishStateDialog : Window
    {
        private Player player;
        private Land land;
        private LandModel landModel;
        private CountryModel countryModel;
        private Person selectedPerson;
        private List<Person> persons;
        private Ellipse selectedEllipse;

        public static string testText;

        public EstablishStateDialog(Player _player, Land _land)
        {
            InitializeComponent();
            player = _player;
            land = _land;
            Loaded += Window_Loaded;
        }

        private void EstablishState_Click(object sender, RoutedEventArgs e)
        {
            editUserInput();

            if (countryNameTextBox.Text.Length >= 3)
            {
                Country country = CountryModel.EstablishState(land, selectedPerson, StateColor.Color, countryNameTextBox.Text);
                LandModel.UpdateLandInfo(land, country);
                this.Close();
                WarningDialogWindow.CallWarningDialogNoResult(Languages.Resources.LocLabelTheStateWasFounded_Text);
            }
            else
            {
                WarningDialogWindow.CallWarningDialogNoResult(Languages.Resources.LocLabelCountryNameLengthValidation);
                countryNameTextBox.Focus();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            landModel = new LandModel();
            countryModel = new CountryModel();
            countryNameTextBox.Text = land.LandName;

            landDescriptionTextBlock.Text = String.Format(Languages.Resources.LocLabelThisLandIsIndependentDescription_Text, land.LandName);

            populatePersonList();
            populatePersonGrid();
        }

        private void populatePersonList()
        {
            persons = PersonModel.GetPlayerPersons(player.PlayerId);
        }

        private void populatePersonGrid()
        {          
            if (persons.Count > 0)
            {
                selectedPersonEllipse.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Pictures/Hero.png", UriKind.Absolute)));
                selectedPersonEllipse.Tag = persons[0].PersonId;
                selectedPersonNameText.Text = persons[0].Name + ' ' + persons[0].Surname;
                rulerDescriptionTextBlock.Text = String.Format(Languages.Resources.LocLabelPersonBecomeANewRuler_Text, persons[0].Name + ' ' + persons[0].Surname);
                selectedPerson = persons[0];

                createPersonEllipse();
            }
            else
            {
                //selectedPersonEllipse.Fill = new ImageBrush(new BitmapImage(new Uri("/Pictures/epic_brown_square.png", UriKind.Relative)));
                selectedPersonNameText.Text = "No person";
            }
        }

        private void createPersonEllipse()
        {
            personGrid.Children.Clear();

            for (int i = 0; i < persons.Count; i++)
            {
                Ellipse personEllipse = new Ellipse();
                personEllipse.Width = 60;
                personEllipse.Height = 60;
                personEllipse.MouseEnter += personEllipse_MouseEnter;
                personEllipse.MouseLeave += personEllipse_MouseLeave;
                personEllipse.MouseDown += personEllipse_MouseDown;
                personEllipse.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Pictures/Hero.png", UriKind.Absolute))); // person image
                personEllipse.Tag = persons[i].PersonId;

                ToolTip toolTip = new ToolTip();
                ToolTipService.SetInitialShowDelay(toolTip, 100);
                toolTip.Content = persons[i].Name + ' ' + persons[i].Surname + " [" + persons[i].Lvl + ']';
                personEllipse.ToolTip = toolTip;

                if (i == 0) // mark first ellipse as selected;
                {
                    selectedEllipse = personEllipse;
                    selectedEllipse.Stroke = Brushes.Brown;
                }

                personGrid.Children.Add(personEllipse);
            }
        }

        private void personEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse personEllipse = (Ellipse)sender;
            selectedPerson = persons.Find(o => o.PersonId == personEllipse.Tag.ToString());

            selectedPersonEllipse.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Pictures/Hero.png", UriKind.Absolute)));
            selectedPersonNameText.Text = selectedPerson.Name + ' ' + selectedPerson.Surname;

            selectedEllipse.Stroke = Brushes.Black;
            selectedEllipse = personEllipse;
            selectedEllipse.Stroke = Brushes.Brown;
            rulerDescriptionTextBlock.Text = String.Format(Languages.Resources.LocLabelPersonBecomeANewRuler_Text, selectedPerson.Name + ' ' + selectedPerson.Surname);
        }

        private void personEllipse_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void personEllipse_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void countryName_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            bool retH = !(IsValid(((TextBox)sender).Text + e.Text));

            editUserInput();

            e.Handled = retH;
        }

        private void editUserInput()
        {
            while (countryNameTextBox.Text.Contains("  "))
            {
                countryNameTextBox.Text = countryNameTextBox.Text.Replace("  ", " ");
            }

            countryNameTextBox.Select(countryNameTextBox.Text.Length, 0);
        }

        public static bool IsValid(string str)
        {
            char ch = str[str.Length - 1];

            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }
    }
}
