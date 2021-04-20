using Exam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramSelected : ContentPage
    {
        public Program Program { get; }

        public ProgramSelected(Program program)
        {
            Program = program;
            BindingContext = this;

            InitializeComponent();

            Title = "Exercises";

            ToolbarItems.Add(new ToolbarItem("Create new", "Resources/addIcon.png", CreateNewProgram));

            ListViewOfUsers.ItemsSource = new List<Exercise> { new Exercise("Massage", "Some more info"), new Exercise("Træning", "Some more info"), new Exercise("Anjali Aron", "Some more info"), new Exercise("Træning2", "Some more info"), new Exercise("Træning3", "Some more info") };
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.SelectedItem is Exercise exercise)
                {
                    Navigation.PushAsync(new ExerciseSelected(exercise));
                }
                listView.SelectedItem = null; // de-select the row
            }
        }

        private void CreateNewProgram()
        {
        }
    }
}