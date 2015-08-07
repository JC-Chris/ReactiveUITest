using System.Threading.Tasks;
using Refit;

namespace ReactiveUITest
{
    public interface IInstagramApi
    {
        //[Get("/v1/media/search")]
        //Task<IntragramMediaResponse> GetMediaNear(
        //    [AliasAs("client_id")] string clientId,
        //    [AliasAs("lat")] double latitude, 
        //    [AliasAs("lng")] double longitude);

        [Get("/v1/media/search")]
        Task<IntragramMediaResponse> GetMediaNear(
            [AliasAs("client_id")] string clientId,
            [AliasAs("lat")] double latitude,
            [AliasAs("lng")] double longitude,
            [AliasAs("max_timestamp")] string before = null);
    }
}

