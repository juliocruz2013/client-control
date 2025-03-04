﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services.DTOs;

namespace WebApp.Models.Client
{
    public class ClientViewModel
    {
        [DisplayName("Identificador")]
        public Guid Id { get; set; }
        [DisplayName("Data de Criação")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Primeiro Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string FirstName { get; set; }
        [DisplayName("Último Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string LastName { get; set; }
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }
        [DisplayName("Documento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DocumentNumber { get; set; }
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime BirthDate { get; set; }
        public AddressViewModel Address { get; set; }

        public ClientViewModel()
        {

        }

        public ClientViewModel(ClientDTO dto)
        {
            Id = dto.Id;
            CreatedAt = dto.CreatedAt;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            PhoneNumber = dto.PhoneNumber;
            Email = dto.Email;
            DocumentNumber = dto.DocumentNumber;
            BirthDate = dto.BirthDate;
            Address = new AddressViewModel(dto.Address);
        }

        public ClientDTO ToDTO()
        {
            return new ClientDTO
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Email = Email,
                DocumentNumber = DocumentNumber,
                BirthDate = BirthDate,
                Address = Address.ToDTO()
            };
        }
    }
}
