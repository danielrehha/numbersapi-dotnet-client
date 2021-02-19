using System;
using System.Collections.Generic;

namespace csharp_console_app.Models
{
    public class TriviaModel : AppEntity
    {
        public string Text { get; set; }
        public string Number { get; set; }

        public TriviaModel() : base("trivia")
        {

        }

        public void FromJson(Dictionary<string, dynamic> json)
        {
            Text = json["text"];
            Number = json["number"];
        }
    }
}
