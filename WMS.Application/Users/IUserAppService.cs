using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WMS.Roles.Dto;
using WMS.Users.Dto;

namespace WMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}