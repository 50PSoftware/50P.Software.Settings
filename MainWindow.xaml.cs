using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using _50P.Software.Security.Password;

namespace _50P.Software.Settings.Dialogs
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Settings sett;
        public string Filename { get; private set; }
        public bool UseDatabase { get; private set; }
        public string Server { get; private set; }
        public string DatabaseName { get; private set; }
        public string Username { get; private set; }
        public byte[] Password { get; private set; }
        public string TypeOfStorage { get; private set; }

        private Window otherOptionsWindow;
        private string _filter;
        public string Filter { set => this._filter = (string)value; }
        private bool _newFile;
        public bool NewFile { get => this._newFile; }
        public MainWindow(in Settings settings = null, Window other = null)
        {
            InitializeComponent();
            sett = settings == null ? new Settings() : settings;
            btnOtherOptions.Visibility = other != null ? Visibility.Visible : Visibility.Hidden;
            otherOptionsWindow = other;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridFile.Visibility = gridDatabase.Visibility = Visibility.Hidden;
            switch(comboBox.SelectedIndex)
            {
                case 0:
                    this.UseDatabase = false;
                    gridFile.Visibility = Visibility.Visible;
                    gridDatabase.Visibility = Visibility.Hidden;
                    break;

                case 1:
                    this.UseDatabase = true;
                    gridFile.Visibility = Visibility.Hidden;
                    gridDatabase.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = string.IsNullOrEmpty(this._filter) ? "All Files (*.*)|*.*" : this._filter;
            if(openFileDialog.ShowDialog() == true)
            {
                FileInfo file = new FileInfo(openFileDialog.FileName);
                tbPath.Text = this.Filename = file.FullName;
                this.TypeOfStorage = file.Extension;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (this.UseDatabase)
            {
                this.sett.UseDatabase = true;
                this.sett.Server = this.Server = tbServerName.Text;
                this.sett.DatabaseName = this.DatabaseName = tbDatabaseName.Text;
                this.sett.Username = this.Username = tbUsername.Text;
                this.sett.Password = this.Password = SecurePassword.GetProtectedPassword(tbPassword.Password);
            }
            else
            {
                this.sett.UseDatabase = false;
                this.sett.Filename = this.Filename = tbPath.Text;
                this.sett.Type = this.TypeOfStorage;
            }
            this.sett.Save();
            this.DialogResult = true;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (sett != null)
            {
                Load();
            }
        }

        private void Load()
        {
            if (sett.UseDatabase)
            {
                comboBox.SelectedIndex = 1;
                this.DatabaseName = tbDatabaseName.Text = sett.DatabaseName;
                this.Server = tbServerName.Text = sett.Server;
                this.Username = tbUsername.Text = sett.Username;
                tbPassword.Password = SecurePassword.GetUnprotectedPassword(sett.Password);
                this.Password = sett.Password;
            }
            else
            {
                comboBox.SelectedIndex = 0;
                this.Filename = tbPath.Text = sett.Filename;
                this.TypeOfStorage = sett.Type;
            }
            this._newFile = false;
        }

        private void btnOtherOptions_Click(object sender, RoutedEventArgs e)
        {

            OpenSettings();
            //Close();
        }

        private void Window_Closing(object sender, EventArgs e)
        {
            if(otherOptionsWindow != null)
                otherOptionsWindow.Close();
        }

        private void btnResetSettings_Click(object sender, RoutedEventArgs e)
        {
            this.sett.Reset();
            Close();
        }

        private void OpenSettings()
        {
            bool isOK = false;
            if (otherOptionsWindow.ShowDialog() == true)
            {
                isOK = true;
                Type typo = otherOptionsWindow.GetType();
                otherOptionsWindow = null;
                otherOptionsWindow = (Window)Activator.CreateInstance(typo);
                sett.Reload();
                Load();
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = string.IsNullOrEmpty(this._filter) ? "All Files (*.*)|*.*" : this._filter;
            if(saveFileDialog.ShowDialog() == true)
            {
                FileInfo info = new FileInfo(saveFileDialog.FileName);
                tbPath.Text = this.Filename = info.FullName;
                this.TypeOfStorage = info.Extension;
                this._newFile = true;
            }
        }
    }
}
