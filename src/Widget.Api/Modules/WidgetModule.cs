using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widget.Api.Model;
using Nancy.ModelBinding;

namespace Widget.Api.Modules
{
    public class WidgetModule : NancyModule
    {
        private readonly IWidgetService service;

        public WidgetModule(IWidgetService service)
        {
            this.service = service;
            Post["/widget"] = PostWidget;
        }

        private dynamic PostWidget(dynamic request)
        {
            service.Add(this.Bind<Model.Widget>());
            return HttpStatusCode.NoContent;
        }
    }
}
