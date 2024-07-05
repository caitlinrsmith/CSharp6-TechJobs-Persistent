using System.Collections.Generic;

namespace MyMvcApp.Models
{
    public class OptionsViewModel
    {
        public List<Option> Options { get; set; }
        public List<int> SelectedOptionIds { get; set; }
    }
}
