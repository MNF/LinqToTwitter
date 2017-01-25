using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LinqToTwitter;

namespace ConsoleSamples
{
    public static class TwitterContextExtensions
    {
        //just for compiling, doesn't work
        public static async Task<Media> UploadMediaAsync(this TwitterContext thisContext, byte[] media, string mediaType, string mediaCategory, CancellationToken cancelToken = default(CancellationToken))
        {
            return await thisContext.UploadMediaAsync(media, mediaType, null, cancelToken);
        }
        public static async Task<Media> UploadMediaAsync(this TwitterContext thisContext, byte[] media, string mediaType, List<ulong>  ory, CancellationToken cancelToken = default(CancellationToken))
        {
            return await thisContext.UploadMediaAsync(media, mediaType, null, cancelToken);
        }
     
    }
}
