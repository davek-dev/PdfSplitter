using System.Windows.Input;

namespace PdfSplitter.Controls;

public partial class PdfSaveControl : ContentView
{
    public static readonly BindableProperty SaveCommandProperty = BindableProperty.Create(nameof(SaveCommand), typeof(ICommand), typeof(PdfSaveControl), default(ICommand));
    public PdfSaveControl()
    {
        InitializeComponent();
    }

    public ICommand SaveCommand
    {
        get => (ICommand)GetValue(SaveCommandProperty);
        set => SetValue(SaveCommandProperty, value);
    }    
}