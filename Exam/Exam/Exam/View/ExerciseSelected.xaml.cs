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
    public partial class ExerciseSelected : ContentPage
    {
        public Exercise Exercise { get; }

        public ExerciseSelected(Exercise exercise)
        {
            Exercise = exercise;

            BindingContext = this;

            InitializeComponent();
        }
    }
}