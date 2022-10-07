using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Structural.Proxy
{
    public class CachedYouTube : IThirdPartyYouTube
    {
        private ThirdPartyYouTube _thirdPartyYouTube;
        private List<string> _cache = new List<string>();

        public CachedYouTube(ThirdPartyYouTube thirdPartyYouTube)
        {
            _thirdPartyYouTube = thirdPartyYouTube;
        }

        public string DownloadVideo(Reference reference)
        {
            if (IsDownloading(reference))
            {
                return "Cached " + _cache.FirstOrDefault(v => v.Equals(reference.ToString()));
            }
            else
            {
                var video = _thirdPartyYouTube.DownloadVideo(reference);
                _cache.Add(video);
                return video;
            }

        }

        public bool IsDownloading(Reference reference)
        {
            var str = reference.ToString();
            var exist = _cache.FirstOrDefault(v => v.Equals(reference.ToString()));

            return exist != null;
        }
    }
}
