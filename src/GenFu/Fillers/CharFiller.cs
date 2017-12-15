using System;
using System.Collections.Generic;
using System.Text;

namespace GenFu.Fillers
{
    public class CharFiller : PropertyFiller<char>
    {

        public CharFiller(GenFuInstance genFu) : base(genFu, new[] { "object" }, new[] { "*" }, true)
        {

        }

        public CharFiller(GenFuInstance genFu, Type objectType, string propertyName) : base(genFu, new[] { objectType.FullName }, new[] { propertyName })
        {

        }

        public override object GetValue(object instance)
        {
            return (char)this.GenFu.Random.Next(char.MinValue, char.MaxValue);
        }
    }

    public class NullableCharFiller : PropertyFiller<char?>
    {

        public NullableCharFiller(GenFuInstance genFu) : base(genFu, new[] { "object" }, new[] { "*" }, true)
        {

        }

        public NullableCharFiller(GenFuInstance genFu, Type objectType, string propertyName) : base(genFu, new[] { objectType.FullName }, new[] { propertyName })
        {

        }

        public override object GetValue(object instance)
        {
            return new char?((char)GenFu.Random.Next(char.MinValue, char.MaxValue));
        }
    }
}
