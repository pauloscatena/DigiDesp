using System;

namespace DigiDesp.Drivers.Application.Dto
{
    public class DriverDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IdentificationDocument { get;  set; }
        public string SocialSecurityId { get;  set; }    
        public DateTime BirthDate { get;  set; }
        public string FatherName { get;  set; }
        public string MotherName { get;  set; }
        public string Permission { get;  set; }
        public string Acc { get;  set; }
        public string Category { get;  set; }
        public string RegisterNumber { get;  set; }
        public DateTime ValidTo { get;  set; }
        public string Remarks { get;  set; }
        public string Signature { get;  set; }
        public string Place { get;  set; }
        public string EmitDate { get;  set; }
        public string DirectorSignature { get;  set; }
        public string DetranState { get;  set; }       
    }
}