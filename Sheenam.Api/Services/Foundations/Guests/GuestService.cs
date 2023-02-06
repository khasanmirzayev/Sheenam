﻿//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free to Use To Find Comfort and Peace
//=================================================

using Sheenam.Api.Brokers.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using System;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
            throw new NotImplementedException();
     }
}
