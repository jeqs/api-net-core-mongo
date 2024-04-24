﻿namespace Mongo.Application.Common.Responses
{
    public class Response<T> where T : class
    {
        public Response()
        {
            Success = true;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
