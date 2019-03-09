using System;
using System.Collections.Generic;
using System.Text;

namespace Husky.Backend.Domain.ViewModels.Base
{
    public class DictionaryModel<TKey>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
    }
}
