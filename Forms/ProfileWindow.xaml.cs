﻿using LandConquestDB.Entities;
using LandConquestDB.Models;
using System.Windows;
using System.Windows.Input;

namespace LandConquest.Forms
{

    public partial class ProfileWindow : Window
    {
        MainWindow window;
        Player player;
        User user;

        public ProfileWindow(MainWindow _window, Player _player, User _user)
        {
            InitializeComponent();
            window = _window;
            player = _player;
            user = _user;
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            user = new User();
            user = UserModel.GetUserInfo(player.PlayerId);

            player = new Player();
            player = PlayerModel.GetPlayerInfo(user, player);


            labelName.Content = player.PlayerName.ToString();
            labelTitle.Content = player.PlayerTitle.ToString();
            labelLand.Content = player.PlayerCurrentRegion.ToString();

            labelEmail.Content = user.UserEmail.ToString();
            labelLogin.Content = user.UserLogin.ToString();


        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonChangeName_Click(object sender, RoutedEventArgs e)
        {
            PlayerModel.UpdatePlayerName(player.PlayerId, newNameBox.Text);
            player.PlayerName = newNameBox.Text;
            this.Loaded += Window_Loaded;
            newNameBox.Visibility = Visibility.Hidden;
        }

        private void buttonChangeEmail_Click(object sender, RoutedEventArgs e)
        {
            UserModel.UpdateUserEmail(user.UserId, newEmailBox.Text);
            this.Loaded += Window_Loaded;
            newEmailBox.Visibility = Visibility.Hidden;
        }

        private void buttonChangePass_Click(object sender, RoutedEventArgs e)
        {
            UserModel.UpdateUserPass(user.UserId, newPassBox.Text);
            this.Loaded += Window_Loaded;
            newPassBox.Visibility = Visibility.Hidden;
        }

        private void buttonChangePass_MouseEnter(object sender, MouseEventArgs e)
        {
            newPassBox.Visibility = Visibility.Visible;
        }

        private void buttonChangeEmail_MouseEnter(object sender, MouseEventArgs e)
        {
            newEmailBox.Visibility = Visibility.Visible;
        }

        private void buttonChangeName_MouseEnter(object sender, MouseEventArgs e)
        {
            newNameBox.Visibility = Visibility.Visible;
        }
    }
}
