﻿using System;
using System.Collections.Generic;
using NETCore_Angular_AwesomeApps.Models.CareerCloud.Poco;

namespace NETCore_Angular_AwesomeApps.Service.CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {

        }
        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Major) || (!string.IsNullOrEmpty(poco.Major) && poco.Major.Length < 3))
                {
                    exceptions.Add(new ValidationException(107, $"{poco.Major} Cannot be empty or less than 3 characters"));
                }

                if (poco.StartDate > DateTime.Today)
                {
                    exceptions.Add(new ValidationException(108, $"{poco.StartDate} Cannot be greater than todays date "));
                }

                if (poco.CompletionDate < poco.StartDate)
                {

                    exceptions.Add(new ValidationException(109, $"{poco.CompletionDate} must be greater than start date"));
                }

            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }
        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }
}
