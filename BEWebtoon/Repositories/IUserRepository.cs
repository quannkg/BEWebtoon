﻿using BEWebtoon.DataTransferObject.UsersDto;
using BEWebtoon.Pagination;
using BEWebtoon.Requests;

namespace BEWebtoon.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserDto>> GetAll();
        Task<UserDto> GetById(int id);
        Task CreateUser(CreateUserDto user);
        Task UpdateUser(UpdateUserDto user);
        Task DeleteUser(int id);
        Task<PagedResult<UserDto>> GetUserPagination(SeacrhPagingRequest request);
    }
}
