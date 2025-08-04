using LeaveManagementSystem.Application.Models.LeaveRequests;

namespace LeaveManagementSystem.Application.Services.LeaveRequests
{
    public interface ILeaveRequestService
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<List<LeaveReqestReadOnlyVM>> GetEmployeeLeaveRequests();
        Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequests();
        Task CancelLeaveRequest(int leaveRequestId);
        Task ReviewLeaveRequest(int leaveRequestId, bool approved);
        Task<bool> RequestDatesExceedAllocation(LeaveRequestCreateVM leaveRequestCreateVM);
        Task<ReviewLeaveRequestVM> GetLeaveRequestForReview(int leaveRequestId);
    }
}