using System;
namespace FromTheStart.Models
{
    class Note
    {
        public string Filename { get; set; }
public string Text { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return Text;

        }
    }
}
