﻿using System;

namespace WebApp.Services.DTOs
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public AddressDTO Address { get; set; }
    }
}
