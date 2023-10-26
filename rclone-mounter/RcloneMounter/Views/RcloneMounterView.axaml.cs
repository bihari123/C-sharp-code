using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Microsoft.Data.Sqlite;

namespace RcloneMounter.Views;

public partial class RcloneMounterView : UserControl
{
    private TextBox AccessKeyTextBoxInput;
    private TextBox SecretKeyTextBoxInput;

    public RcloneMounterView()
    {
        InitializeComponent();
        // #if DEBUG
        // this.AttachDevTools();
        // #endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        AccessKeyTextBoxInput = this.FindControl<TextBox>("AccessKeyTextBox");
        SecretKeyTextBoxInput = this.FindControl<TextBox>("SecretKeyTextBox");

        // Create a connection to the SQLite database
        using (var connection =
                   new SqliteConnection("Data Source=credentials.db"))
        {
            connection.Open();

            // Insert data into the 'Credentials' table
            var command = connection.CreateCommand();
            command.CommandText =
                "CREATE TABLE IF NOT EXISTS  Credentials ( Id INTEGER PRIMARY KEY AUTOINCREMENT, SourceName TEXT NOT NULL, AccessKey TEXT NOT NULL, SecretKey TEXT NOT NULL );";
            command.ExecuteNonQuery();

            connection.Close();
        }
    }

    public void button_Click(object sender, RoutedEventArgs e)
    {
        // Change button text when button is clicked.
        var button = (Button)sender;
        button.Content = "Hello, Avalonia!";
    }

    private void SubmitButton_Click(object sender,
                                    Avalonia.Interactivity.RoutedEventArgs e)
    {
        string accessKey = AccessKeyTextBoxInput.Text;
        string secretKey = SecretKeyTextBoxInput.Text;

        // Now you can use accessKey and secretKey for further processing, such as
        // making API calls. For example: CallYourApi(accessKey, secretKey);

        // Create a connection to the SQLite database
        using (var connection =
                   new SqliteConnection("Data Source=credentials.db"))
        {
            connection.Open();

            // Insert data into the 'Credentials' table
            var command = connection.CreateCommand();
            command.CommandText =
                "INSERT INTO Credentials (AccessKey, SecretKey) VALUES (@accessKey, @secretKey)";
            command.Parameters.AddWithValue("@accessKey", accessKey);
            command.Parameters.AddWithValue("@secretKey", secretKey);
            command.ExecuteNonQuery();

            connection.Close();
        }

        ShowMessage("Credentials saved successfully!");
    }

    private void ShowMessage(string message)
    {
        // You can use MessageBox to display a message box, or any other UI element
        // to show the message.
        // MessageBox.Show(message, "Success", MessageBoxButton.OK,
        // MessageBoxImage.Information);
    }
}
