using Microsoft.AspNetCore.Builder;

namespace MinhaAppVS
{
    public interface IApplicationBilder
    {
        IApplicationBuilder UseMeuMiddleware<T>();
    }
}