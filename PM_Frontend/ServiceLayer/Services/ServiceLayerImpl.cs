using ServiceLayer.Services.LoginEntryService;
using ServiceLayer.Services.MasterUserService;
using Shared.CommunicationObjects;
using Shared.Dtos;

namespace ServiceLayer.Services;

public class ServiceLayerImpl : IServiceLayer
{
    private readonly ILoginEntryService _loginEntryService;
    private readonly IMasterUserService _masterUserService;

    public ServiceLayerImpl(ILoginEntryService loginEntryService, IMasterUserService masterUserService)
    {
        _loginEntryService = loginEntryService;
        _masterUserService = masterUserService;
    }

    public async Task<ServerResponse> CreateMasterUserAsync(
        MasterUserDTO masterUserDto)
    {
        return await _masterUserService.CreateMasterUserAsync(masterUserDto);
    }

    public async Task<ServerResponse> ReadMasterUserAsync(int masterUserId)
    {
        return await _masterUserService.ReadMasterUserAsync(masterUserId);
    }
    
    // TODO: Marcus, commented out due to errors.
    /*public async Task<ServerResponse> AuthenticateUserAsync(MasterUserDTO masterUserDto)
    {
        return await _masterUserService.AuthenticateUserAsync(masterUserDto);
    }*/

    public async Task<ServerResponse> ReadLoginEntriesAsync()
    {
        return await _loginEntryService.ReadLoginEntriesAsync();
    }

    public async Task<ServerResponse> CreateLoginEntryAsync(
        LoginEntryDTO newEntry)
    {
        return await _loginEntryService.CreateLoginEntryAsync(newEntry);
    }

    public async Task<LoginEntryDTO> UpdateLoginEntryAsync(LoginEntryDTO updatedEntry)
    {
        return await _loginEntryService.UpdateLoginEntryAsync(updatedEntry);
    }

    public async Task<bool> DeleteLoginEntryAsync(LoginEntryDTO entryToDelete)
    {
        return await _loginEntryService.DeleteLoginEntryAsync(entryToDelete);
    }
}