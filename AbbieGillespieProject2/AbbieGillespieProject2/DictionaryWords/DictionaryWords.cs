using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbieGillespieProject2.DictionaryWords
{
    public class DictionaryWords
    {
        public required string letter { get; set; }

        public required List<string> words { get; set; }
    }
}
