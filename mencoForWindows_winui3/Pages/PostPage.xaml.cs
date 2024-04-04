using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace mencoForWindows_winui3.Pages
{
    public sealed partial class PostPage : Page
    {
        public PostPage()
        {
            this.InitializeComponent();
            vm.Init();
        }

        private void ContentSettings_FontSize_Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            vm.fontSize = (int)e.NewValue;
        }

        private void PipsPager_SelectedIndexChanged(PipsPager sender, PipsPagerSelectedIndexChangedEventArgs args)
        {
            vm.ChangePage(sender.SelectedPageIndex);
        }

        private void PostPage_PostCardList_Loaded(object sender, RoutedEventArgs e)
        {
            vm.LoadPostCardList();
        }
    }
}
