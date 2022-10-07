namespace Patterns.Structural.Proxy
{
    public class ThirdPartyYouTube : IThirdPartyYouTube
    {
        public string DownloadVideo(Reference reference)
        {
            switch (reference)
            {
                case Reference.CatVideo:
                    return "CatVideo";
                case Reference.ParrotVideo:
                    return "ParrotVideo";
                case Reference.OmgVideo:
                    return "OmgVideo";
                default:
                    return "None";
            }
        }
    }
}
