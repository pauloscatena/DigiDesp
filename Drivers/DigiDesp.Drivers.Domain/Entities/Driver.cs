using System;
using DigiDesp.Common.Types;

namespace DigiDesp.Drivers.Domain.Entities
{
    public class Driver
    {
           public Driver(
            Name name, 
            string identificationDocument, 
            string socialSecurityId, 
            DateTime birthDate, 
            string fatherName, 
            string motherName,          
            string permission, 
            string acc, 
            string category, 
            string registerNumber, 
            DateTime validTo, 
            string remarks, 
            string signature, 
            string place, 
            DateTime emitDate, 
            string directorSignature, 
            string detranState)
        {
            Id = GlobalId.NewId();
            Name = name;
            IdentificationDocument = identificationDocument;
            SocialSecurityId = socialSecurityId;
            BirthDate = birthDate;
            FatherName = fatherName;
            MotherName = motherName;
            Permission = permission;
            Acc = acc;
            Category = category;
            RegisterNumber = registerNumber;
            ValidTo = validTo;
            Remarks = remarks;
            Signature = signature;
            Place = place;
            EmitDate = emitDate;
            DirectorSignature = directorSignature;
            DetranState = detranState;
        }

        public Driver(
            GlobalId id,
            Name name, 
            string identificationDocument, 
            string socialSecurityId, 
            DateTime birthDate, 
            string fatherName, 
            string motherName, 
            string permission, 
            string acc, 
            string category, 
            string registerNumber, 
            DateTime validTo, 
            string remarks, 
            string signature, 
            string place, 
            DateTime emitDate, 
            string directorSignature, 
            string detranState): this(
                name, 
                identificationDocument, 
                socialSecurityId, 
                birthDate, 
                fatherName, 
                motherName, 
                permission, 
                acc, 
                category, 
                registerNumber, 
                validTo, 
                remarks, 
                signature, 
                place, 
                emitDate, 
                directorSignature, 
                detranState)
        {
            Id = id;
        }

        public GlobalId Id { get; private set; }
        public Name Name { get; private set; }
        public string IdentificationDocument { get; private set; }
        public string SocialSecurityId { get; private set; }    
        public DateTime BirthDate { get; private set; }
        public string FatherName { get; private set; }
        public string MotherName { get; private set; }
        public string Permission { get; private set; }
        public string Acc { get; private set; }
        public string Category { get; private set; }
        public string RegisterNumber { get; private set; }
        public DateTime ValidTo { get; private set; }
        public string Remarks { get; private set; }
        public string Signature { get; private set; }
        public string Place { get; private set; }
        public DateTime EmitDate { get; private set; }
        public string DirectorSignature { get; private set; }
        public string DetranState { get; private set; }        
    }
}