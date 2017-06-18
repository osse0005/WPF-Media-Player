using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace Assignment3
{
public partial class MainWindow : Window
{

    private bool isPlaying;
    private PlayerStatus status;
    public MainWindow()
    {
        InitializeComponent();
        Status = PlayerStatus.Empty;
            
    }


    PlayerStatus Status
    {
        get { return status; }
        set
        {
            status = value;
            switch (value)
            {
                case PlayerStatus.Play:
                    player.Play();
                    Stop.IsEnabled = true;
                    Play.IsEnabled = true;
                    Back.IsEnabled = true;
                    Forward.IsEnabled = true;
                    Play.Content = "Pause";

                    break;
                case PlayerStatus.Stop:
                    player.Stop();
                    Stop.IsEnabled = false;
                    Play.IsEnabled = true;
                    Back.IsEnabled = false;
                    Forward.IsEnabled = false;
                    Play.Content = "Play";

                    break;
                case PlayerStatus.Pause:
                    player.Pause();
                    Stop.IsEnabled = true;
                    Play.IsEnabled = true;
                    Back.IsEnabled = false;
                    Forward.IsEnabled = false;
                    Play.Content = "Play";

                    break;
                case PlayerStatus.Empty:
                    player.Source = null;
                    Stop.IsEnabled = Play.IsEnabled = false;
                    Play.Content = "Play";
                    break;
            }
        }

    }


    private void openFile_Click(object sender, RoutedEventArgs e)
    {

        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        openFileDialog1.InitialDirectory = "C:\\Users\\Tim";
        openFileDialog1.DefaultExt = ".mp3";
        openFileDialog1.Filter = "AVI files (*.avi)|*.avi|MP3 files (*.mp3)|*.mp3";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;
        openFileDialog1.Multiselect = true;
        openFileDialog1.Title = "Add Files";

        try
        {
               
            if (openFileDialog1.ShowDialog().Value)
            {
                //First clear all the items before we add new ones
                openList.Items.Clear();
                foreach (var f in openFileDialog1.FileNames)
                {
                    openList.Items.Add(f);
                }

                string fileName = openFileDialog1.FileName;
                player.Source = new Uri(fileName);
                Play.IsEnabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }

    }

    private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
    {
        ListViewItem item = sender as ListViewItem;
        string sourceStr = String.Empty;
        if (item != null)
        {
            sourceStr = item.Content as String;
            player.Source = new Uri(sourceStr);
            Status = PlayerStatus.Play;
        }

        //label.Content = "Handler check";
        label.Content = String.Format("File being played:{0}", sourceStr);
    }

    private void Stop_Click(object sender, RoutedEventArgs e)
    {
        Status = PlayerStatus.Stop;

    }

    private void Play_Click(object sender, RoutedEventArgs e)
    {

        if (Status == PlayerStatus.Pause || Status == PlayerStatus.Stop)
        {
            //Current status is Pause or Stop switch to Play
            Status = PlayerStatus.Play;
        }
        else
        {
            //switch to Pause
            Status = PlayerStatus.Pause;
        }


    }
        
    private void Forward_Click(object sender, RoutedEventArgs e)
    {
        player.Position = player.Position + TimeSpan.FromSeconds(10);
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        player.Position = player.Position - TimeSpan.FromSeconds(10);
    }

    }

    public enum PlayerStatus
    {

        Empty,
        Stop,
        Play,
        Pause

    }
}
