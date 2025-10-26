using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MauiApp1;

public partial class MyViewModel : ObservableObject
{

    public MyViewModel()
    {
        integerForPodsoch = 0;
    }
    
//----------------------------------------------------------------------------------------------------------------------
    
     // Автогенерируемое свойство с INotifyPropertyChanged:
     [ObservableProperty]
     public ObservableCollection<string> spacesq = new ObservableCollection<string>(); // было поле, теперь свойство "Spaces"

     [ObservableProperty]
     public int integerForPodsoch;

     
     

     [RelayCommand]
     public async Task Plus()
     {
         IntegerForPodsoch++;
     }

     [RelayCommand]
     public async Task Minus()
     {
         IntegerForPodsoch--;
     }
     
}

public class HttpClass
{
    public async Task HttpLocalAnytype()
    {
        Thread.Sleep(10000);
         
        HttpClient httpClient = new HttpClient();

        const string apiS = "tOvGVpB0iUw+zqDhDRJx8LI5lBq2+YQYsbX8pRTOf5I=";
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiS}");
        httpClient.DefaultRequestHeaders.Add("Anytype-Version", "2025-05-20");

        string stringSpaces = "http://127.0.0.1:31009/v1/spaces/bafyreidquhlyswvgqvohopc4mdwmrdyrbpw7y3cbzuq3fdziu77w64ihae.qenaqgjnfwsy/objects";
        var rawObjects = await httpClient.GetAsync(stringSpaces);
        string objects = await rawObjects.Content.ReadAsStringAsync();
        JObject onThisClassSpaces = JObject.Parse(objects);
        var spacess = onThisClassSpaces["data"];

        int i = 0;
        foreach (var sp in spacess)
        {
            ObList.Add(sp["name"].ToString()[0..15]);
            i++;
            if (i >= 11) break;
        }
         
    }

    public List<string> ObList;
}
