﻿using System.Threading.Tasks;
using Mollie.Api.Models.List;

using Mollie.Api.Models.Profile.Request;
using Mollie.Api.Models.Profile.Response;

namespace Mollie.Api.Client.Abstract {
    public interface IProfileClient {
        Task<ProfileResponse> CreateProfileAsync(ProfileRequest request);
        Task<ProfileResponse> GetProfileAsync(string profileId);
        Task<ListResponse<ProfileResponse>> GetProfileListAsync(string from = null, int? limit = null);
        Task<ProfileResponse> UpdateProfileAsync(string profileId, ProfileRequest request);
        Task DeleteProfileAsync(string profileId);
    }
}