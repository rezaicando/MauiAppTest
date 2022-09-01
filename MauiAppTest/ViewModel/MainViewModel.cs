


using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel;



public partial class MainViewModel :ObservableObject
{
    public MainViewModel()
    {
        items= new ObservableCollection<string>();
    }


    [ObservableProperty]
    ObservableCollection<String> items;


    [ObservableProperty]
    public string text;

    [RelayCommand]
    void Add()
    {
        if(string.IsNullOrEmpty(text))
            return;

        Items.Add(text);
        Text=string.Empty;
    }
    [RelayCommand]
    void Delete(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }
    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        //await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}",new Dictionary<String, object>
        //{
        //    {nameof(DetailPage),s},
        //});
    }
   
}


//public class MainViewModel : INotifyPropertyChanged
//{
//    private string _text;
//    public string Text
//    {
//        get => _text;
//        set
//        {
//            _text = value;
//            OnPropertyChanged(nameof(Text));
//        }
//    }
//    void OnPropertyChanged(string name)=>
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

//    public event PropertyChangedEventHandler PropertyChanged;
//}