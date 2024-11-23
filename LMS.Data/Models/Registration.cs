using System;
using System.Collections.Generic;

namespace LMS.Data
{
    public class Registration
    {
        public Registration()
        {
            PageLinkAssign = new HashSet<PageLinkAssign>();
        }

        public int RegistrationId { get; set; }
        public string UserName { get; set; }
        public bool? Validation { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Designation { get; set; }
        public string DateofBirth { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string Ps { get; set; }
        public decimal Balance { get; set; }

        public virtual ICollection<PageLinkAssign> PageLinkAssign { get; set; }

    }
}
