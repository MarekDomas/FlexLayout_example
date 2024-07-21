using System.Diagnostics;
using Microsoft.Maui.Layouts;
using Ukazka.Classes;

namespace Ukazka;

public partial class MainPage : ContentPage
{
    readonly List<BoxView> boxes = [];
    readonly Random random = new();
    public MainPage()
    {
        GenerateItems(20);
        InitializeComponent();
        AddItemsToLayout();
    }

    private async Task GenerateItems(int numberOfItems)
    {
        boxes.Clear();
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

    private void AddItemsToLayout()
    {
        ExampleLayout.Children.Clear();
        foreach (var box in boxes)
        {
            ExampleLayout.Children.Add(box);
        }
    }

    private void RefreshButton_Clicked(object sender, EventArgs e)
    {
        //GenerateItems(200);
    }

    private void Direction_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;

        if(!Functions.validateRadioBtn(radioButton,ExampleLayout)) return;
        
        ExampleLayout.Direction = Functions.GetFlexDirection( radioButton.Content.ToString());
        Debug.Print($"{ExampleLayout.Direction}");
    }

    

    private void WrapButton_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;

        if (!Functions.validateRadioBtn(radioButton,ExampleLayout)) return;

        ExampleLayout.Wrap = Functions.GetFlexWrap(radioButton.Content.ToString());
        Debug.Print($"{ExampleLayout.Wrap}");
    }

    private void JustifyContentButton_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;

        if (!Functions.validateRadioBtn(radioButton, ExampleLayout)) return;

        ExampleLayout.JustifyContent = Functions.geFlexJustify(radioButton.Content.ToString());
        Debug.Print($"{ExampleLayout.JustifyContent}");
    }


    private void AlignItemsButton_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;

        if (!Functions.validateRadioBtn(radioButton, ExampleLayout)) return;

        ExampleLayout.AlignItems = Functions.GetFlexAlignItems(radioButton.Content.ToString());
        Debug.Print($"{ExampleLayout.AlignItems}");
    }

    private void AlignContentButton_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        var radioButton = sender as RadioButton;

        if (!Functions.validateRadioBtn(radioButton, ExampleLayout)) return;

        ExampleLayout.AlignContent = Functions.GetFlexAlignContent(radioButton.Content.ToString());
        Debug.Print($"{ExampleLayout.AlignContent}");
    }

    private async void SetNumBtn_OnClicked(object sender, EventArgs e)
    {
        if(!int.TryParse(numEntry.Text,out var numberOfItems)) return;

        await GenerateItems(numberOfItems);
        AddItemsToLayout();
    }
}
