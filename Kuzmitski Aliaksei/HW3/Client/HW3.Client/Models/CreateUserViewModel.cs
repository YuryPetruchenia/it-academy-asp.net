﻿using HW3.Domain.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW3.Client.Models
{
    public class CreateUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Title Title { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }


        [DisplayName("Country")]
        public Guid CountryId { get; set; }

        [DisplayName("City")]
        public Guid CityId { get; set; }
    }
}