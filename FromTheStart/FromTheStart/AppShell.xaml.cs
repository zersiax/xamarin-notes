using FromTheStart.Views;

using Xamarin.Forms;

namespace FromTheStart
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));

        }

    }
}
