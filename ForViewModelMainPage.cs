using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage
{
    private async void SobitieHttpLocalAnytype(object? sender, EventArgs eventArgs)
    {
        HttpClass httpClass = new HttpClass();

        Task task = new Task(() => httpClass.HttpLocalAnytype());
        task.Start();

        await task;
        foreach (var i in httpClass.ObList)
        {
            myViewModel.Spacesq.Add(i);
        }


    }
    
    
}

