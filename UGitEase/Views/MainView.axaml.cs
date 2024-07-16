using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace UGitEase.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        //tbFahrenheit.IsReadOnly = true;
        //tbFahrenheit.IsEnabled = false;

        Calc();
    }

    private void TextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e)
    {
        Debug.WriteLine("TextBox_TextChanged");
        Calc();
    }

    private void BtnCalc(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Debug.WriteLine("Click!");
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Calc();
    }

    public void Calc()
    {
        Debug.WriteLine("Click!");
        Debug.WriteLine($"Click! Celsius={tbCelsius.Text}");

        if (Double.TryParse(tbCelsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            tbCelsius.Text = C.ToString("0.0");
            tbFahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            tbCelsius.Text = "0.0";
            tbFahrenheit.Text = "0.0";
        }
    }

}
