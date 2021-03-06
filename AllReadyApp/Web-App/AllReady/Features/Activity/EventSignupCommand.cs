﻿using AllReady.ViewModels;
using MediatR;

namespace AllReady.Features.Event
{
    public class EventSignupCommand : IAsyncRequest
    {
        public EventSignupViewModel EventSignup { get; set; }
    }
}
