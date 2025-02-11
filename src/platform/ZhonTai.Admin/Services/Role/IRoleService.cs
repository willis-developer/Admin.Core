﻿using System.Threading.Tasks;
using ZhonTai.Admin.Core.Dto;
using ZhonTai.Admin.Domain.Role.Dto;
using ZhonTai.Admin.Services.Role.Dto;

namespace ZhonTai.Admin.Services.Role
{
    /// <summary>
    /// 角色接口
    /// </summary>
    public interface IRoleService
    {
        Task<IResultOutput> GetAsync(long id);

        Task<IResultOutput> GetPageAsync(PageInput<RoleGetPageDto> input);

        Task<IResultOutput> AddAsync(RoleAddInput input);

        Task<IResultOutput> UpdateAsync(RoleUpdateInput input);

        Task<IResultOutput> DeleteAsync(long id);

        Task<IResultOutput> SoftDeleteAsync(long id);

        Task<IResultOutput> BatchSoftDeleteAsync(long[] ids);
    }
}