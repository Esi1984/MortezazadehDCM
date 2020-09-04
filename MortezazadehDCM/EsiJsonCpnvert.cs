﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortezazadehDCM
{
    public class EsiJsonCpnvert
    {


    }


    //public class CreateEnvelopeModel : ICreateEnvelopeCommand
    //{
    //    [JsonConverter(typeof(EntityModelConverter<CreateEmailModel, ICreateEmailCommand>))]
    //    public ICreateEmailCommand Email { get; set; }
    //    [JsonConverter(typeof(CollectionEntityConverter<CreateFormModel, ICreateFormCommand>))]
    //    public IList<ICreateFormCommand> Forms { get; set; }
    //}


    public class EntityModelConverter<T, Tt> : JsonConverter where T : Tt
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Tt));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<T>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(T));
        }
    }

    public class CollectionEntityConverter<T, Tt> : JsonConverter where T : Tt
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IList<Tt>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            IList<Tt> items = serializer.Deserialize<List<T>>(reader).Cast<Tt>().ToList();
            return items;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(IList<T>));
        }
    }


}