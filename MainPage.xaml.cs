using System.Diagnostics;
using Microsoft.Maui.Layouts;
using Ukazka.Classes;

namespace Ukazka;

public partial class MainPage : ContentPage
{
    readonly List<Label> labels = [];
    readonly Random random = new();
    public MainPage()
    {
        GenerateItems(20);
        InitializeComponent();
        AddItemsToLayout();
    }

    private void GenerateItems(int numberOfItems)
    {
        labels.Clear();
        for (int i = 0; i < numberOfItems; i++)
        {
            Label label = new()
            {
                BackgroundColor = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                HeightRequest = 100,
                WidthRequest = 100,
                Text = (i + 1).ToString(),
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black
            };
            
            labels.Add(label);
        }
    }

    private void AddItemsToLayout()
    {
        ExampleLayout.Children.Clear();
        foreach (var box in labels)
        {
            ExampleLayout.Children.Add(box);
        }
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

    private  void SetNumBtn_OnClicked(object sender, EventArgs e)
    {
        if(!int.TryParse(numEntry.Text,out var numberOfItems)) return;

        GenerateItems(numberOfItems);
        AddItemsToLayout();
    }
}
