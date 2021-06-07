using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Timers;
using System.Windows;

namespace EchoAPIVisual3
{
    public partial class MainWindow
    {
        private WindowStats _windowStats = new WindowStats();
        private void ExpandedPlayerStats(int teamInt, int playerInt)
        {
            /*
            if (_windowStats.)
            {
                
            }
            */
            ExpandedStats expandedStats = new ExpandedStats {Name = data.teams[teamInt].players[playerInt].name};
            expandedStats.Show();

            string team = null;
            switch (teamInt)
            {
                case 0:
                    team = "Blue";
                    break;
                case 1:
                    team = "Orange";
                    break;
            }

            try
            {
                // TeamName
                expandedStats.TeamName.Text = team;
                // PlayerName
                expandedStats.PlayerName.Text = data.teams[teamInt].players[playerInt].name;
                // PlayerPoints
                expandedStats.PlayerPoints.Text = data.teams[teamInt].players[playerInt].stats.points.ToString();
                // PlayerAssists
                expandedStats.PlayerAssists.Text = data.teams[teamInt].players[playerInt].stats.assists.ToString();
                // PlayerShots
                expandedStats.PlayerShots.Text = data.teams[teamInt].players[playerInt].stats.shots_taken.ToString();
                // PlayerSaves
                expandedStats.PlayerSaves.Text = data.teams[teamInt].players[playerInt].stats.saves.ToString();
                // PlayerSteals
                expandedStats.PlayerSteals.Text = data.teams[teamInt].players[playerInt].stats.steals.ToString();
                // PlayerStuns
                expandedStats.PlayerStuns.Text = data.teams[teamInt].players[playerInt].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void B1ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats;
            switch (expandedStats.IsLoaded)
            {
                case false:
                    expandedStats = new ExpandedStats();
                    ExpandedPlayerStats(0, 0);
                    break;
                case true:
                    
                    break;
            }
        }

        private void B2ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Blue";
                // BluePlayer1Name
                expandedStats.PlayerName.Text = data.teams[0].players[1].name;
                // Blue1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[0].players[1].stats.points.ToString();
                // BluePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[0].players[1].stats.assists.ToString();
                // BluePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[0].players[1].stats.shots_taken.ToString();
                // BluePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[0].players[1].stats.saves.ToString();
                // BluePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[0].players[1].stats.steals.ToString();
                // BluePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[0].players[1].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void B3ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Blue";
                // BluePlayer1Name
                expandedStats.PlayerName.Text = data.teams[0].players[2].name;
                // Blue1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[0].players[2].stats.points.ToString();
                // BluePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[0].players[2].stats.assists.ToString();
                // BluePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[0].players[2].stats.shots_taken.ToString();
                // BluePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[0].players[2].stats.saves.ToString();
                // BluePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[0].players[2].stats.steals.ToString();
                // BluePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[0].players[2].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void B4ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Blue";
                // BluePlayer1Name
                expandedStats.PlayerName.Text = data.teams[0].players[3].name;
                // Blue1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[0].players[3].stats.points.ToString();
                // BluePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[0].players[3].stats.assists.ToString();
                // BluePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[0].players[3].stats.shots_taken.ToString();
                // BluePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[0].players[3].stats.saves.ToString();
                // BluePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[0].players[3].stats.steals.ToString();
                // BluePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[0].players[3].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void B5ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Blue";
                // BluePlayer1Name
                expandedStats.PlayerName.Text = data.teams[0].players[4].name;
                // Blue1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[0].players[4].stats.points.ToString();
                // BluePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[0].players[4].stats.assists.ToString();
                // BluePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[0].players[4].stats.shots_taken.ToString();
                // BluePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[0].players[4].stats.saves.ToString();
                // BluePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[0].players[4].stats.steals.ToString();
                // BluePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[0].players[4].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void O1ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Orange";
                // OrangePlayer1Name
                expandedStats.PlayerName.Text = data.teams[1].players[0].name;
                // Orange1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[1].players[0].stats.points.ToString();
                // OrangePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[1].players[0].stats.assists.ToString();
                // OrangePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[1].players[0].stats.shots_taken.ToString();
                // OrangePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[1].players[0].stats.saves.ToString();
                // OrangePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[1].players[0].stats.steals.ToString();
                // OrangePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[1].players[0].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void O2ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Orange";
                // OrangePlayer1Name
                expandedStats.PlayerName.Text = data.teams[1].players[1].name;
                // Orange1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[1].players[1].stats.points.ToString();
                // OrangePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[1].players[1].stats.assists.ToString();
                // OrangePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[1].players[1].stats.shots_taken.ToString();
                // OrangePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[1].players[1].stats.saves.ToString();
                // OrangePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[1].players[1].stats.steals.ToString();
                // OrangePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[1].players[1].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void O3ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Orange";
                // OrangePlayer1Name
                expandedStats.PlayerName.Text = data.teams[1].players[2].name;
                // Orange1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[1].players[2].stats.points.ToString();
                // OrangePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[1].players[2].stats.assists.ToString();
                // OrangePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[1].players[2].stats.shots_taken.ToString();
                // OrangePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[1].players[2].stats.saves.ToString();
                // OrangePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[1].players[2].stats.steals.ToString();
                // OrangePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[1].players[2].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void O4ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Orange";
                // OrangePlayer1Name
                expandedStats.PlayerName.Text = data.teams[1].players[3].name;
                // Orange1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[1].players[3].stats.points.ToString();
                // OrangePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[1].players[3].stats.assists.ToString();
                // OrangePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[1].players[3].stats.shots_taken.ToString();
                // OrangePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[1].players[3].stats.saves.ToString();
                // OrangePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[1].players[3].stats.steals.ToString();
                // OrangePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[1].players[3].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }

        private void O5ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            ExpandedStats expandedStats = new ExpandedStats();
            expandedStats.Show();

            try
            {
                // TeamName
                expandedStats.TeamName.Text = "Orange";
                // OrangePlayer1Name
                expandedStats.PlayerName.Text = data.teams[1].players[4].name;
                // Orange1Player1Points
                expandedStats.PlayerPoints.Text = data.teams[1].players[4].stats.points.ToString();
                // OrangePlayer1Assists
                expandedStats.PlayerAssists.Text = data.teams[1].players[4].stats.assists.ToString();
                // OrangePlayer1Shots
                expandedStats.PlayerShots.Text = data.teams[1].players[4].stats.shots_taken.ToString();
                // OrangePlayer1Saves
                expandedStats.PlayerSaves.Text = data.teams[1].players[4].stats.saves.ToString();
                // OrangePlayer1Steals
                expandedStats.PlayerSteals.Text = data.teams[1].players[4].stats.steals.ToString();
                // OrangePlayer1Stuns
                expandedStats.PlayerStuns.Text = data.teams[1].players[4].stats.stuns.ToString();
            }
            catch (NullReferenceException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
            catch (IndexOutOfRangeException)
            {
                // Reset Values
                expandedStats.PlayerName.Text = "--Unknown--";
                expandedStats.PlayerPoints.Text = "--Unknown--";
                expandedStats.PlayerAssists.Text = "--Unknown--";
                expandedStats.PlayerShots.Text = "--Unknown--";
                expandedStats.PlayerSaves.Text = "--Unknown--";
                expandedStats.PlayerSteals.Text = "--Unknown--";
                expandedStats.PlayerStuns.Text = "--Unknown--";
            }
        }
    }

    public class WindowStats
    {
        public bool BluePlayer1 { get; set; }
        public bool BluePlayer2 { get; set; }
        public bool BluePlayer3 { get; set; }
        public bool BluePlayer4 { get; set; }
        public bool BluePlayer5 { get; set; }

        public bool OrangePlayer1 { get; set; }
        public bool OrangePlayer2 { get; set; }
        public bool OrangePlayer3 { get; set; }
        public bool OrangePlayer4 { get; set; }
        public bool OrangePlayer5 { get; set; }
    }
}

}