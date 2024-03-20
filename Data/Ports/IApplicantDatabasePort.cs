using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Ports
{
    public interface IApplicantDatabasePort
    {
        Task<Applicant> AddApplicant(Applicant applicant, CancellationToken cancellationToken);

        Task<Applicant> UpdateApplicant(Applicant applicant, CancellationToken cancellationToken);

        Task<Applicant> GetApplicant(string applicantID, CancellationToken cancellationToken);

        Task<dynamic> IdNumberValidationCheck(string IdNumber);
    }
}
