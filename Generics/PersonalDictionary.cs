using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PersonalDictionary<TKey, TValue>
    {
        private TKey _key;
        private TValue _value;

        public void Add(TKey key, TValue value)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
