using System.Collections.Generic;

namespace NzbDrone.Core.MetadataSource.Custom.Models
{
    public class InternalScene
    {
        public string SceneId { get; set; }
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Url { get; set; }
        public string Date { get; set; }
        public List<string> Actors { get; set; }
        public string CoverUrl { get; set; }
    }
}
