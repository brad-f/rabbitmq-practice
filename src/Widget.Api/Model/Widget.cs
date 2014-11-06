using System;

namespace Widget.Api.Model
{
    public class Widget
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Widget()
        {
            Id = Guid.NewGuid();
        }
    }
}
