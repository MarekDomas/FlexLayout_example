using System.Diagnostics;
using Microsoft.Maui.Layouts;


namespace Ukazka;

public partial class MainPage : ContentPage
{
    List<BoxView> boxes = new();
    Random random = new();
    public MainPage()
    {
        //GenerateItems(200);
        InitializeComponent();
    }

    void GenerateItems(int numberOfItems)
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            BoxView box = new()
            {
                Color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                HeightRequest = 100,
                WidthRequest = 100
            };

            boxes.Add(box);
        }
    }

    private void RefreshButton_Clicked(object sender, EventArgs e)
    {
        //GenerateItems(200);
    }

    private void Orientation_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;
        if (radioButton.IsChecked)
        {
            Debug.Print($"{radioButton.Content}");
            if (exampleLayout is not null) 
            {
                exampleLayout.Direction = GetFlexDirection( radioButton.Content.ToString());
            }
        }
    }

    private FlexDirection GetFlexDirection(string direction)
    {
        switch (direction)
        {
            case "Column":
                return FlexDirection.Column;
            case "ColumnReverse":
                return FlexDirection.ColumnReverse;
            case "Row":
                return FlexDirection.Row;
            case "RowReverse":
                return FlexDirection.RowReverse;
            default:
                return FlexDirection.Column;
        }
    }
}
