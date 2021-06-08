using System;
using System.Windows;

namespace EchoAPIVisual3
{
    public class ExpandedPlayerStats
    {
        private readonly WindowStats _windowStats = new WindowStats();

        private void ExpandedStats(int teamInt, int playerInt, Data data)
        {
            ExpandedStats expandedStats = (teamInt, playerInt) switch
            {
                // Blue
                (0, 0) => // BluePlayer1
                    _windowStats.bluePlayer1.IsLoaded == false ? _windowStats.bluePlayer1 : null,
                (0, 1) => // BluePlayer2
                    _windowStats.bluePlayer2.IsLoaded == false ? _windowStats.bluePlayer2 : null,
                (0, 2) => // BluePlayer3
                    _windowStats.bluePlayer3.IsLoaded == false ? _windowStats.bluePlayer3 : null,
                (0, 3) => // BluePlayer4
                    _windowStats.bluePlayer4.IsLoaded == false ? _windowStats.bluePlayer4 : null,
                (0, 4) => // BluePlayer5
                    _windowStats.bluePlayer5.IsLoaded == false ? _windowStats.bluePlayer5 : null,
                // Orange
                (1, 0) => // OrangePlayer1
                    _windowStats.orangePlayer1.IsLoaded == false ? _windowStats.orangePlayer1 : null,
                (1, 1) => // OrangePlayer2
                    _windowStats.orangePlayer2.IsLoaded == false ? _windowStats.orangePlayer2 : null,
                (1, 2) => // OrangePlayer3
                    _windowStats.orangePlayer3.IsLoaded == false ? _windowStats.orangePlayer3 : null,
                (1, 3) => // OrangePlayer4
                    _windowStats.orangePlayer4.IsLoaded == false ? _windowStats.orangePlayer4 : null,
                (1, 4) => // OrangePlayer5
                    _windowStats.orangePlayer5.IsLoaded == false ? _windowStats.orangePlayer5 : null,
                _ => null
            };

            // = new ExpandedStats {Name = data.teams[teamInt].players[playerInt].name};
            if (expandedStats == null) return;

            try
            {
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
            switch (_windowStats.bluePlayer1.IsLoaded)
            {
                case false:
                    _windowStats.bluePlayer1.Show();
                    break;
                case true:
                    _windowStats.bluePlayer1.Hide();
                    break;
            }
        }

        private void B2ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.bluePlayer2.IsLoaded)
            {
                case false:
                    _windowStats.bluePlayer2.Show();
                    break;
                case true:
                    _windowStats.bluePlayer2.Hide();
                    break;
            }
        }

        private void B3ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.bluePlayer3.IsLoaded)
            {
                case false:
                    _windowStats.bluePlayer3.Show();
                    break;
                case true:
                    _windowStats.bluePlayer3.Hide();
                    break;
            }
        }

        private void B4ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.bluePlayer4.IsLoaded)
            {
                case false:
                    _windowStats.bluePlayer4.Show();
                    break;
                case true:
                    _windowStats.bluePlayer4.Hide();
                    break;
            }
        }

        private void B5ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.bluePlayer5.IsLoaded)
            {
                case false:
                    _windowStats.bluePlayer5.Show();
                    break;
                case true:
                    _windowStats.bluePlayer5.Hide();
                    break;
            }
        }
        
        // Orange
        private void O1ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.orangePlayer1.IsLoaded)
            {
                case false:
                    _windowStats.orangePlayer1.Show();
                    break;
                case true:
                    _windowStats.orangePlayer1.Hide();
                    break;
            }
        }

        private void O2ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.orangePlayer2.IsLoaded)
            {
                case false:
                    _windowStats.orangePlayer2.Show();
                    break;
                case true:
                    _windowStats.orangePlayer2.Hide();
                    break;
            }
        }

        private void O3ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.orangePlayer3.IsLoaded)
            {
                case false:
                    _windowStats.orangePlayer3.Show();
                    break;
                case true:
                    _windowStats.orangePlayer3.Hide();
                    break;
            }
        }

        private void O4ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.orangePlayer4.IsLoaded)
            {
                case false:
                    _windowStats.orangePlayer4.Show();
                    break;
                case true:
                    _windowStats.orangePlayer4.Hide();
                    break;
            }
        }

        private void O5ExpandedPlayerStats(object sender, RoutedEventArgs e)
        {
            switch (_windowStats.orangePlayer5.IsLoaded)
            {
                case false:
                    _windowStats.orangePlayer5.Show();
                    break;
                case true:
                    _windowStats.orangePlayer5.Hide();
                    break;
            }
        }
    }

    public class WindowStats
    {
        public ExpandedStats bluePlayer1 { get; set; } = new ExpandedStats {Name = "Blue Player 1"};
        public ExpandedStats bluePlayer2 { get; set; } = new ExpandedStats {Name = "Blue Player 2"};
        public ExpandedStats bluePlayer3 { get; set; } = new ExpandedStats {Name = "Blue Player 3"};
        public ExpandedStats bluePlayer4 { get; set; } = new ExpandedStats {Name = "Blue Player 4"};
        public ExpandedStats bluePlayer5 { get; set; } = new ExpandedStats {Name = "Blue Player 5"};

        public ExpandedStats orangePlayer1 { get; set; } = new ExpandedStats {Name = "Orange Player 1"};
        public ExpandedStats orangePlayer2 { get; set; } = new ExpandedStats {Name = "Orange Player 2"};
        public ExpandedStats orangePlayer3 { get; set; } = new ExpandedStats {Name = "Orange Player 3"};
        public ExpandedStats orangePlayer4 { get; set; } = new ExpandedStats {Name = "Orange Player 4"};
        public ExpandedStats orangePlayer5 { get; set; } = new ExpandedStats {Name = "Orange Player 5"};
    }
}