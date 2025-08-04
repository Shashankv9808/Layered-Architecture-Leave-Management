namespace LeaveManagementSystem.Application.Services.UserManager
{
    public interface IUserService
    {
        Task<ApplicationUser?> GetCurrentUserAsync();
        Task<List<ApplicationUser>> GetUsersInRoleAsync(string role);
        Task<ApplicationUser> GetUserByID(string userId);
    }
}
