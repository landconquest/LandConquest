﻿using LandConquestDB.Entities;
using LandConquestDB.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace LandConquest.Forms
{
    public partial class ChatWindow : Window
    {
        private Player              player;
        private List<ChatMessages>  messages;
        CancellationTokenSource     cancelTokenSource;
        CancellationToken           token;
        private string              playerTargetId;

        public ChatWindow(Player _player)
        {
            InitializeComponent();
            player = _player;
        }

        private void ButtonSendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (playerTargetId == "")
            {
                ChatModel.SendMessage(textBoxNewMessage.Text, player.PlayerId, "[all]");
            }
            else
            {
                ChatModel.SendMessage(textBoxNewMessage.Text, player.PlayerId, "["+ playerTargetId+"]");
            }
            textBoxNewMessage.Text = "";
            playerTargetId = "";
            buttonWhisper.IsEnabled = false;
        }

        public async void CallUpdateChatAsync()
        {
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            await Task.Run(() => UpdateChat(token));
        }

        private async Task UpdateChat(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {         
                await Dispatcher.BeginInvoke(new CrossAppDomainDelegate(delegate { messages = ChatModel.GetMessages(player.PlayerId); listViewChat.ItemsSource = messages; listViewChat.Items.Refresh();}));
                await Task.Delay(2000);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            cancelTokenSource.Cancel();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CallUpdateChatAsync();
            buttonWhisper.IsEnabled = false;
            playerTargetId = "";

        }

        private void listViewChat_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (listViewChat.SelectedItem != null)
            {
                ChatMessages message = (ChatMessages)listViewChat.SelectedItem;
                if (player.PlayerId == message.PlayerId)
                {
                    buttonWhisper.IsEnabled = false;
                }
                else
                {
                    buttonWhisper.IsEnabled = true;
                }
            }
        }

        private void buttonWhisper_Click(object sender, RoutedEventArgs e)
        {
            if(listViewChat.SelectedItem != null)
            {
                ChatMessages message = (ChatMessages)listViewChat.SelectedItem;
                if (player.PlayerId != message.PlayerId)
                {
                    playerTargetId = message.PlayerId;
                }
            }
        }

        private void buttonToAll_Click(object sender, RoutedEventArgs e)
        {
            playerTargetId = "";
            buttonWhisper.IsEnabled = false;
        }
    }
}
