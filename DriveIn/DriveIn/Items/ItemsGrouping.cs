using System;
using System.Collections.Generic;
using System.Text;

namespace DriveIn.Items
{
    public class ItemsGrouping : List<Info>
    {
        public string Title { get; set; }

        public ItemsGrouping(string title)
        {
            Title = title;
        }
    }
}