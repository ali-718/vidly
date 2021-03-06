﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer

    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MemberShipTypeId { get; set; }

        public Test TestTable { get; set; }
        public string birthDate { get; set; }
    }
}