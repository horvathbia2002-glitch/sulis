using System.Collections.Generic;

namespace QuizApp.Models
{
    public class QuizItem
    {
        public string Text { get; set; } = "";
        public List<string> Options { get; set; } = new();
        public int CorrectIndex { get; set; }
        public string Explanation { get; set; } = "";
        public int SelectedIndex { get; set; } = -1;
    }
}
