using Microsoft.Maui.Layouts;

namespace Ukazka.Classes;

public class Functions
{
    public static FlexDirection GetFlexDirection(string direction)
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
                return FlexDirection.RowReverse;
        }
    }

    public static FlexWrap GetFlexWrap(string wrap)
    {
        switch (wrap)
        {
            case "NoWrap":
                return FlexWrap.NoWrap;
            case "Wrap":
                return FlexWrap.Wrap;
            case "Reverse":
                return FlexWrap.Reverse;
            default:
                return FlexWrap.NoWrap;
        }
    }

    public static FlexJustify geFlexJustify(string justify)
    {
        switch (justify)
        {
            case "Start":
                return FlexJustify.Start;
            case "Center":
                return FlexJustify.Center;
            case "End":
                return FlexJustify.End;
            case "SpaceBetween":
                return FlexJustify.SpaceBetween;
            case "SpaceAround":
                return FlexJustify.SpaceAround;
            case "SpaceEvenly":
                return FlexJustify.SpaceEvenly;
            default:
                return FlexJustify.Start;
        }
    }

    public static FlexAlignItems GetFlexAlignItems(string alignItems)
    {
        switch (alignItems)
        {
            case "Start":
                return FlexAlignItems.Start;
            case "Center":
                return FlexAlignItems.Center;
            case "End":
                return FlexAlignItems.End;
            case "Stretch":
                return FlexAlignItems.Stretch;
            default:
                return FlexAlignItems.End;
        }
    }

    public static FlexAlignContent GetFlexAlignContent(string alignContent)
    {
        switch (alignContent)
        {
            case "Start":
                return FlexAlignContent.Start;
            case "Center":
                return FlexAlignContent.Center;
            case "End":
                return FlexAlignContent.End;
            case "Stretch":
                return FlexAlignContent.Stretch;
            case "SpaceBetween":
                return FlexAlignContent.SpaceBetween;
            case "SpaceAround":
                return FlexAlignContent.SpaceAround;
            case "SpaceEvenly":
                return FlexAlignContent.SpaceEvenly;
            default:
                return FlexAlignContent.Start;
        }
    }

    public static bool validateRadioBtn(RadioButton radioButton, FlexLayout layout)
    {
        if (!radioButton.IsChecked) return false;

        if(layout is null) return false;

        return true;
    }
}