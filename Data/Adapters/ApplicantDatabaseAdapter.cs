using Data.Context;
using Data.Models;
using Data.Ports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Adapters
{
    public class ApplicantDatabaseAdapter :IApplicantDatabasePort
    {
        private readonly ApplicationDbContext _context;

        public ApplicantDatabaseAdapter(ApplicationDbContext context)
        {
            context = _context;
        }

        public async Task<Applicant> AddApplicant(Applicant applicant, CancellationToken cancellationToken)
        {
           _context.Applicants.Add(applicant);
           await _context.SaveChangesAsync();

            return applicant;
        }

        public async Task<Applicant> GetApplicant(string applicantID, CancellationToken cancellationToken)
        {
            var applicant = await _context.Applicants
                    .Include(x => x.Guardians)
                   .Where(x => x.ApplicantId == applicantID && x.ApplicationState != "Complete")
                   .FirstOrDefaultAsync(cancellationToken);

            return applicant;
        }

        public Task<dynamic> IdNumberValidationCheck(string IdNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<Applicant> UpdateApplicant(Applicant applicant, CancellationToken cancellationToken)
        {
            var application = await _context.Applicants
                                    .Where(x => x.ApplicantId == applicant.ApplicantId)
                                    .FirstOrDefaultAsync(cancellationToken);

            application.FullName = applicant.FullName;
            application.IdnumberPassportNumber = applicant.IdnumberPassportNumber;
            application.MobileNumber =  applicant.MobileNumber;
            application.City = applicant.City;
            application.Race = applicant.Race;
            application.Gender = applicant.Gender;
            application.Country = applicant.Country;
            application.EducationLevel = application.EducationLevel;
            application.Email = applicant.Email;
            application.ApplicationState = applicant.ApplicationState;
            application.Guardians = applicant.Guardians;

            await _context.SaveChangesAsync();

            return application;
           
        }
    }
}
