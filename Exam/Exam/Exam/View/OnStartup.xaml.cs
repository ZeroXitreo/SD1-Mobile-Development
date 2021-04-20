using Exam.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Exam.View
{
    public partial class OnStartup : ContentPage
    {
        public OnStartup()
        {
            InitializeComponent();

            Title = "Clients";

            ToolbarItems.Add(new ToolbarItem("Create new", "Resources/addIcon.png", CreateNewUser));

            ListViewOfUsers.ItemsSource = new ObservableCollection<User> { new User("Simon Hansen", "Some more info"), new User("Kevin Kennedy", "Some more info"), new User("Anjali Aron", "Some more info"), new User("Jakob Bach", "Some more info"), new User("Henrik Langer", "Some more info") };
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.SelectedItem is User user)
                {
                    Navigation.PushAsync(new ClientSelected(user));
                }
                listView.SelectedItem = null; // de-select the row
            }
        }

        private void SearchUser()
        {

        }

        private void CreateNewUser()
        {

        }
    }
}
