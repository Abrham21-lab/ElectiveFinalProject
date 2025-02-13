using EventDrivenAPI.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventDrivenAPI.Services
{
    public interface IHealthProfileServices
    {
        Task<GetHealthProfileDTO?> GetHealthProfileByIdAsync(string id);
        Task<List<GetHealthProfileDTO>> GetAllHealthProfilesAsync();
        Task<bool> CreateHealthProfileAsync(CreateHealthProfileDTO dto);
        Task<bool> EditHealthProfileAsync(EditHealthProfileDTO dto);
        Task<bool> DeleteHealthProfileAsync(string id);
    }
}