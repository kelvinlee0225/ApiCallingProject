using ApiCallingProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiCallingProject.Services
{
    public interface IAniAPIService
    {
        Task<Root> getAnimeSongListAsync();
    }
}
