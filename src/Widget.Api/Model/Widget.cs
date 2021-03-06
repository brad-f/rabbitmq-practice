﻿using Newtonsoft.Json;
using System;
using System.Text;

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

        public byte[] GetBytes()
        {
            return Encoding.UTF8.GetBytes(ToJson());
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Widget FromBytes(byte[] bytes)
        {
            var json = Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<Widget>(json);
        }
    }
}
