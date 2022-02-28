using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label1 = new Label()
            {
                Text = "Климов Андрей Сергеевич",
                FontSize = 18,
                TextColor = Color.Red
            };
            Label label2 = new Label()
            {
                Text = "Студент группы: ПКС-31",
                FontSize = 18,
                TextColor = Color.Red
            };

            Image1.Source = ImageSource.FromResource("HelloApp.Images.foot_k.jpg");

            Label label3 = new Label()
            {
                Text = "Я увлекаюсь футболом. Мне нравится этот спорт.",
                FontSize = 18,
                TextColor = Color.Black
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, label3, Image1 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;
            
        }

    }
}


