using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FromTheStart.Models;
using Xamarin.Forms;

namespace FromTheStart.Views
{
    public partial class NotesPage : ContentPage
    {
        

        public NotesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var notes = new List<Note>();
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                notes.Add(new Note
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename),

                });
            }
            collectionView.ItemsSource = notes
                .OrderBy(d => d.Date).ToList();


        }




        async void OnAddClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NoteEntryPage));

        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.CurrentSelection != null)
            {
                Note note = (Note)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(NoteEntryPage)}?{nameof(NoteEntryPage.ItemId)}={note.Filename}");

            }
        }
    }
}