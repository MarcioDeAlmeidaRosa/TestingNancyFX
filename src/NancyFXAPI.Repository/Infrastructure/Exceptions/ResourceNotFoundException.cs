﻿using System;

namespace NancyFXAPI.Repository.Infrastructure.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException()
        {

        }

        public ResourceNotFoundException(string message)
            : base(message)
        {

        }
    }
}
