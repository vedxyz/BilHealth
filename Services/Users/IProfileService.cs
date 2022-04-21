using BilHealth.Model;
using BilHealth.Model.Dto;

namespace BilHealth.Services.Users
{
    public interface IProfileService
    {
        Task<UserProfileDto> GetFilteredUser(DomainUser requestingUser, Guid requestedUserId);

        Task<List<Case>> GetPastCases(DomainUser user);
        Task<List<Case>> GetOpenCases(DomainUser user);

        Task UpdateProfile(DomainUser user, UserProfileDto newProfile);
        Task UpdateProfile(Guid userId, UserProfileDto newProfile);
        Task SetPatientBlacklistState(Guid patientUserId, bool newState);

        Task AddVaccination(VaccinationDto details);
        Task<bool> UpdateVaccination(VaccinationDto details);
        Task<bool> RemoveVaccination(Guid vaccinationId);
    }
}