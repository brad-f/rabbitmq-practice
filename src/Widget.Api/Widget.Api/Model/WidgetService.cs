using System;

namespace Widget.Api.Model
{
    public class WidgetService : IWidgetService
    {
        public void Add(Widget widget)
        {
            Console.WriteLine("Widget");
        }
    }
}
