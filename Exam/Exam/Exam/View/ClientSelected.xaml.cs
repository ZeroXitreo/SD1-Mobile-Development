using Exam.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientSelected : ContentPage
    {
        public User User { get; }

        public ClientSelected(User user)
        {
            User = user;
            BindingContext = this;

            InitializeComponent();

            Title = "Programs";

            ToolbarItems.Add(new ToolbarItem("Create new", "Resources/addIcon.png", CreateNewProgram));

            ListViewOfPrograms.ItemsSource = new List<Program> { new Program("Massage", "Some more info"), new Program("Træning", "Some more info"), new Program("Anjali Aron", "Some more info"), new Program("Træning2", "Some more info"), new Program("Træning3", "Some more info") };


        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.SelectedItem is Program program)
                {
                    Navigation.PushAsync(new ProgramSelected(program));
                }
                listView.SelectedItem = null; // de-select the row
            }
        }

        private void SearchProgram()
        {

        }

        private void CreateNewProgram()
        {

        }
    }
}