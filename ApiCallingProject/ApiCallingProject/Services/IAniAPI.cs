using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiCallingProject.Services
{
    public interface IAniAPI
    {
        [Get("/v1/song")]
        Task<HttpResponseMessage> GetAnimeSongAsync();
    }
}
