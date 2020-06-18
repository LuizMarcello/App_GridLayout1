using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_GridLayout1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage1 : ContentPage
    {
        public GridPage1()
        {
            InitializeComponent();

            var grid = new Grid
            {
                BackgroundColor = Color.Yellow,
                RowSpacing = 20,
                ColumnSpacing = 20,
            };

            var label1 = new Label { Text = "Label1", BackgroundColor = Color.Aqua };
            var label2 = new Label { Text = "Label2", BackgroundColor = Color.Aqua };
            var label3 = new Label { Text = "Label3", BackgroundColor = Color.Aqua };
            var label4 = new Label { Text = "Label4", BackgroundColor = Color.Aqua };

            grid.Children.Add(label1, 0, 0);
            grid.Children.Add(label2, 0, 1);
            grid.Children.Add(label3, 1, 0);
            grid.Children.Add(label4, 1, 1);

            Content = grid;
        }
    }
}
