using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Abp.Module.Basket.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
