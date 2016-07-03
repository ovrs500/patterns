using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void addItem(IItem item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            var cost = 0.0f;

            foreach (var item in items)
            {
                cost += item.price();
            }

            return cost;
        }

        public string showItems()
        {
            var output = new StringBuilder();

            foreach (var item in items)
            {
                output.Append("Item: " + item.name());
                output.Append(Environment.NewLine);
                output.Append("Packing: " + item.packing().pack());
                output.Append(Environment.NewLine);
                output.Append("Price: " + item.price());
            }

            return output.ToString();
        }
    }
}