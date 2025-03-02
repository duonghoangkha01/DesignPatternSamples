﻿using System.Text;

namespace DesignPatternSamples.Creation.BuilderPattern
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < _parts.Count; i++)
            {
                str.Append(_parts[i]).Append(", ");
            }

            str.Remove(str.Length - 2, 2); // removing last ", "
            str.Insert(0, "Product parts: ").Append(Environment.NewLine);
            return str.ToString();
        }
    }
}