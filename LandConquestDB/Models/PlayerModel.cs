﻿using LandConquestDB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace LandConquestDB.Models
{
    public class PlayerModel
    {
        public static int CreatePlayer(string login, string email, string pass, string userId, User registeredUser)
        {
            registeredUser.UserId = userId;
            registeredUser.UserLogin = login;
            registeredUser.UserEmail = email;
            registeredUser.UserPass = pass;

            string playerQuery = "INSERT INTO dbo.PlayerData (player_id,player_name,player_exp,player_lvl, player_money, player_donation, player_title, player_current_region) " +
                "VALUES (@player_id,@player_name,@player_exp,@player_lvl, @player_money, @player_donation, @player_title, @player_current_region)";
            var playerCommand = new SqlCommand(playerQuery, DbContext.GetSqlConnection());

            playerCommand.Parameters.AddWithValue("@player_id", registeredUser.UserId);
            playerCommand.Parameters.AddWithValue("@player_name", registeredUser.UserLogin);
            playerCommand.Parameters.AddWithValue("@player_exp", 0);
            playerCommand.Parameters.AddWithValue("@player_lvl", 1);
            playerCommand.Parameters.AddWithValue("@player_money", 1);
            playerCommand.Parameters.AddWithValue("@player_donation", 2);

            //playerCommand.Parameters.AddWithValue("@player_image", image);
            playerCommand.Parameters.AddWithValue("@player_title", 1);

            playerCommand.Parameters.AddWithValue("@player_current_region", 1);

            int playerResult = playerCommand.ExecuteNonQuery();
            playerCommand.Dispose();

            return playerResult;
        }

        public static void CreatePlayerResources(string userId, User registeredUser)
        {
            // create storage for new player
            string storageQuery = "INSERT INTO dbo.StorageData (player_id) VALUES (@player_id)";
            var storageCommand = new SqlCommand(storageQuery, DbContext.GetSqlConnection());


            storageCommand.Parameters.AddWithValue("@player_id", userId);

            storageCommand.ExecuteNonQuery();
            storageCommand.Dispose();

            string equipmentQuery = "INSERT INTO dbo.PlayerEquipment (player_id) VALUES (@player_id)";
            var equipmentCommand = new SqlCommand(equipmentQuery, DbContext.GetSqlConnection());


            equipmentCommand.Parameters.AddWithValue("@player_id", userId);

            equipmentCommand.ExecuteNonQuery();
            equipmentCommand.Dispose();

            // create default manufactures for new player
            string manufactureQuery = "INSERT INTO dbo.ManufactureData (player_id,manufacture_id,manufacture_name,manufacture_type) VALUES (@player_id, @manufacture_id, @manufacture_name, @manufacture_type)";

            //wood
            var woodCommand = new SqlCommand(manufactureQuery, DbContext.GetSqlConnection());


            woodCommand.Parameters.AddWithValue("@player_id", userId);
            woodCommand.Parameters.AddWithValue("@manufacture_id", GenerateUserId());
            woodCommand.Parameters.AddWithValue("@manufacture_name", "Sawmill");
            woodCommand.Parameters.AddWithValue("@manufacture_type", 1);

            woodCommand.ExecuteNonQuery();
            woodCommand.Dispose();

            //stone
            var stoneCommand = new SqlCommand(manufactureQuery, DbContext.GetSqlConnection());

            stoneCommand.Parameters.AddWithValue("@player_id", userId);
            stoneCommand.Parameters.AddWithValue("@manufacture_id", GenerateUserId());
            stoneCommand.Parameters.AddWithValue("@manufacture_name", "Quarry");
            stoneCommand.Parameters.AddWithValue("@manufacture_type", 2);

            stoneCommand.ExecuteNonQuery();
            stoneCommand.Dispose();

            //food
            var foodCommand = new SqlCommand(manufactureQuery, DbContext.GetSqlConnection());
            foodCommand.Parameters.AddWithValue("@player_id", userId);
            foodCommand.Parameters.AddWithValue("@manufacture_id", GenerateUserId());
            foodCommand.Parameters.AddWithValue("@manufacture_name", "Windmill");
            foodCommand.Parameters.AddWithValue("@manufacture_type", 3);

            foodCommand.ExecuteNonQuery();
            foodCommand.Dispose();

            // create peasants data for player

            string peasantsQuery = "INSERT INTO dbo.PeasantsData (player_id) VALUES (@player_id)";
            var peasantsCommand = new SqlCommand(peasantsQuery, DbContext.GetSqlConnection());

            peasantsCommand.Parameters.AddWithValue("@player_id", userId);

            peasantsCommand.ExecuteNonQuery();
            peasantsCommand.Dispose();
        }

        public static Player GetPlayerInfo(User user, Player player)
        {
            string query = "SELECT * FROM dbo.PlayerData WHERE player_id = @player_id";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", user.UserId);

            using (var reader = command.ExecuteReader())
            {
                var playerId = reader.GetOrdinal("player_id");
                var playerName = reader.GetOrdinal("player_name");
                var playerExp = reader.GetOrdinal("player_exp");
                var playerLvl = reader.GetOrdinal("player_lvl");
                var playerMoney = reader.GetOrdinal("player_money");
                var playerDonation = reader.GetOrdinal("player_donation");
                var playerImage = reader.GetOrdinal("player_image");
                var playerTitle = reader.GetOrdinal("player_title");
                var playerCurrentRegion = reader.GetOrdinal("player_current_region");

                while (reader.Read())
                {
                    player.PlayerId = reader.GetString(playerId);
                    player.PlayerName = reader.GetString(playerName);
                    player.PlayerExp = reader.GetInt64(playerExp);
                    player.PlayerLvl = reader.GetInt32(playerLvl);
                    player.PlayerMoney = reader.GetInt64(playerMoney);
                    player.PlayerDonation = reader.GetInt64(playerDonation);
                    // player.PlayerImage = reader.GetSqlBytes(playerId);
                    player.PlayerImage = null;
                    player.PlayerTitle = reader.GetInt32(playerTitle);
                    player.PlayerCurrentRegion = reader.GetInt32(playerCurrentRegion);
                }
                reader.Close();
            }
            command.Dispose();

            return player;
        }

        public static Player GetPlayerById(string _playerId)
        {
            Player player = new Player();
            string query = "SELECT * FROM dbo.PlayerData WHERE player_id = @player_id";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", _playerId);

            using (var reader = command.ExecuteReader())
            {
                var playerId = reader.GetOrdinal("player_id");
                var playerName = reader.GetOrdinal("player_name");
                var playerExp = reader.GetOrdinal("player_exp");
                var playerLvl = reader.GetOrdinal("player_lvl");
                var playerMoney = reader.GetOrdinal("player_money");
                var playerDonation = reader.GetOrdinal("player_donation");
                var playerImage = reader.GetOrdinal("player_image");
                var playerTitle = reader.GetOrdinal("player_title");
                var playerCurrentRegion = reader.GetOrdinal("player_current_region");

                while (reader.Read())
                {
                    player.PlayerId = reader.GetString(playerId);
                    player.PlayerName = reader.GetString(playerName);
                    player.PlayerExp = reader.GetInt64(playerExp);
                    player.PlayerLvl = reader.GetInt32(playerLvl);
                    player.PlayerMoney = reader.GetInt64(playerMoney);
                    player.PlayerDonation = reader.GetInt64(playerDonation);
                    player.PlayerImage = null;
                    player.PlayerTitle = reader.GetInt32(playerTitle);
                    player.PlayerCurrentRegion = reader.GetInt32(playerCurrentRegion);
                }
                reader.Close();
            }
            command.Dispose();
            return player;
        }

        public static string GetPlayerNameById(string id)
        {
            string playerName = "";
            string query = "SELECT player_name FROM dbo.PlayerData WHERE player_id = @player_id ";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", id);

            using (var reader = command.ExecuteReader())
            {
                var _playerName = reader.GetOrdinal("player_name");

                while (reader.Read())
                {
                    playerName = reader.GetString(_playerName);
                }
                reader.Close();
            }
            command.Dispose();
            return playerName;
        }        

        public static Player UpdatePlayerMoney(Player player)
        {
            string taxesQuery = "UPDATE dbo.PlayerData SET player_money = @player_money WHERE player_id = @player_id ";

            var taxesCommand = new SqlCommand(taxesQuery, DbContext.GetSqlConnection());
            taxesCommand.Parameters.AddWithValue("@player_money", player.PlayerMoney);
            taxesCommand.Parameters.AddWithValue("@player_id", player.PlayerId);

            taxesCommand.ExecuteNonQuery();

            taxesCommand.Dispose();

            return player;
        }

        public static Player UpdatePlayerMoney(Player player, SqlConnection connection)
        {
            string taxesQuery = "UPDATE dbo.PlayerData SET player_money = @player_money WHERE player_id = @player_id ";

            var taxesCommand = new SqlCommand(taxesQuery, connection);
            taxesCommand.Parameters.AddWithValue("@player_money", player.PlayerMoney);
            taxesCommand.Parameters.AddWithValue("@player_id", player.PlayerId);

            taxesCommand.ExecuteNonQuery();

            taxesCommand.Dispose();

            return player;
        }

        public static Player UpdatePlayerLand(Player player, Land land)
        {
            string taxesQuery = "UPDATE dbo.PlayerData SET player_current_region = @player_current_region WHERE player_id = @player_id ";

            var taxesCommand = new SqlCommand(taxesQuery, DbContext.GetSqlConnection());
            taxesCommand.Parameters.AddWithValue("@player_current_region", land.LandId);
            taxesCommand.Parameters.AddWithValue("@player_id", player.PlayerId);

            player.PlayerCurrentRegion = land.LandId;

            taxesCommand.ExecuteNonQuery();

            taxesCommand.Dispose();

            return player;
        }

        public static void UpdatePlayerName(string playerId, string newPlayerName)
        {
            string userQuery = "UPDATE dbo.PlayerData SET player_name = @player_name WHERE player_id = @player_id";
            var userCommand = new SqlCommand(userQuery, DbContext.GetSqlConnection());


            userCommand.Parameters.AddWithValue("@player_id", playerId);
            userCommand.Parameters.AddWithValue("@player_name", newPlayerName);

            userCommand.ExecuteNonQuery();
            userCommand.Dispose();
        }


        public static List<Player> GetXpInfo(List<Player> players, User user)
        {
            string query = "SELECT * FROM dbo.PlayerData ORDER BY player_exp desc";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            using (var reader = command.ExecuteReader())
            {

                var playerId = reader.GetOrdinal("player_id");
                var playerExp = reader.GetOrdinal("player_exp");
                var playerName = reader.GetOrdinal("player_name");

                while (reader.Read())
                {
                    Player player = new Player();
                    player.PlayerId = reader.GetString(playerId);
                    player.PlayerExp = reader.GetInt64(playerExp);
                    player.PlayerName = reader.GetString(playerName);
                    players.Add(player);
                }
                reader.Close();
            }
            command.Dispose();

            return players;
        }

        public static List<Player> GetCoinsInfo(List<Player> players, User user)
        {
            string query = "SELECT * FROM dbo.PlayerData ORDER BY player_money desc";

            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            using (var reader = command.ExecuteReader())
            {

                var playerId = reader.GetOrdinal("player_id");
                var playerMoney = reader.GetOrdinal("player_money");
                var playerName = reader.GetOrdinal("player_name");

                while (reader.Read())
                {
                    Player player = new Player();
                    player.PlayerId = reader.GetString(playerId);
                    player.PlayerMoney = reader.GetInt64(playerMoney);
                    player.PlayerName = reader.GetString(playerName);
                    players.Add(player);
                }
                reader.Close();
            }
            command.Dispose();

            return players;
        }

        public static void UpdatePlayerExpAndLvl(Player player)
        {
            string Query = "UPDATE dbo.PlayerData SET player_exp = @player_exp, player_lvl = @player_lvl WHERE player_id = @player_id ";

            var Command = new SqlCommand(Query, DbContext.GetSqlConnection());
            Command.Parameters.AddWithValue("@player_exp", player.PlayerExp);
            Command.Parameters.AddWithValue("@player_lvl", player.PlayerLvl);
            Command.Parameters.AddWithValue("@player_id", player.PlayerId);

            Command.ExecuteNonQuery();

            Command.Dispose();
        }

        public static List<int> DeletePlayerManufactureLandData(Peasants peasants, Player player)
        {
            string Query = "SELECT manufacture_peasant_work FROM dbo.PlayerLandManufactureData WHERE player_id = @player_id";

            List<int> listPeasantsWork = new List<int>();

            var command = new SqlCommand(Query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", player.PlayerId);

            using (var reader = command.ExecuteReader())
            {

                var manufacturePeasantsWork = reader.GetOrdinal("manufacture_peasant_work");

                while (reader.Read())
                {
                    listPeasantsWork.Add(reader.GetInt32(manufacturePeasantsWork));
                }
                reader.Close();
            }
            command.Dispose();

            List<int> list = new List<int>();
            if (listPeasantsWork.Count == 2)
            {
                for (int i = 0; i < listPeasantsWork.Count; i++)
                {
                    list.Add(new int());
                }

                for (int i = 0; i < listPeasantsWork.Count; i++)
                {
                    list[i] = listPeasantsWork[i];
                    peasants.PeasantsWork -= listPeasantsWork[i];
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    list.Add(0);
                }
            }


            string QueryDelete = "DELETE FROM dbo.PlayerLandManufactureData WHERE player_id = @player_id ";

            var Command = new SqlCommand(QueryDelete, DbContext.GetSqlConnection());

            Command.Parameters.AddWithValue("@player_id", player.PlayerId);

            Command.ExecuteNonQuery();

            Command.Dispose();

            //String QueryLandManufactures = "UPDATE dbo.LandManufacturesData SET manufacture_peasant_work = @manufacture_peasant_work WHERE land_id = @land_id ";

            //var CommandLandManufactures = new SqlCommand(QueryLandManufactures, connection);

            //for (int i = 0; i < 2; i++)
            //{
            //    CommandLandManufactures.Parameters.AddWithValue("@manufacture_peasant_work", );
            //    CommandLandManufactures.Parameters.AddWithValue("@player_id", player.PlayerId);

            //    CommandLandManufactures.ExecuteNonQuery();
            //}
            //CommandLandManufactures.Dispose();
            Console.WriteLine(peasants.PeasantsWork);

            return list;
        }

        public static Player UpdatePlayerDonationMoney(Player player)
        {
            string taxesQuery = "UPDATE dbo.PlayerData SET player_donation = @player_donation WHERE player_id = @player_id ";

            var taxesCommand = new SqlCommand(taxesQuery, DbContext.GetSqlConnection());
            taxesCommand.Parameters.AddWithValue("@player_donation", player.PlayerDonation);
            taxesCommand.Parameters.AddWithValue("@player_id", player.PlayerId);

            taxesCommand.ExecuteNonQuery();

            taxesCommand.Dispose();

            return player;
        }

        private static Random random;
        private static string GenerateUserId()
        {
            Thread.Sleep(15);
            random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvmxyz0123456789";
            return new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //public static Player UpdatePlayerImage(Player player)
        //{
        //    String taxesQuery = "UPDATE dbo.PlayerData SET player_image = @player_image WHERE player_id = @player_id ";

        //    var taxesCommand = new SqlCommand(taxesQuery, DbContext.GetConnection());
        //    taxesCommand.Parameters.AddWithValue("@player_image", player.PlayerImage);
        //    taxesCommand.Parameters.AddWithValue("@player_id", player.PlayerId);

        //    taxesCommand.ExecuteNonQuery();

        //    taxesCommand.Dispose();

        //    return player;
        //}

        public static int GetPlayerResourceAmount(Player _player, string resourceName)
        {
            string Query = "SELECT " + resourceName + " FROM dbo.StorageData WHERE player_id = @player_id";
        
            var command = new SqlCommand(Query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@player_id", _player.PlayerId);

            int resourceAmount = 0;
            using (var reader = command.ExecuteReader())
            {

                var resourceAmountFromDb = reader.GetOrdinal(resourceName);

                while (reader.Read())
                {
                    resourceAmount = reader.GetInt32(resourceAmountFromDb);
                }
                reader.Close();
            }
            command.Dispose();
            return resourceAmount;
        }
    }
}
