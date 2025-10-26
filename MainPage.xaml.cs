namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private MyViewModel myViewModel;
    public MainPage(MyViewModel vm)
    {
        myViewModel = vm;
        InitializeComponent();
        BindingContext = vm;
    }
    

}