using GraphQL.Types;
using Umbraco.Core.Models;

namespace Our.Umbraco.GraphQL.Adapters.Types
{
    public class MediaWithCropsGraphType : ObjectGraphType<MediaWithCrops>
    {
        public MediaWithCropsGraphType()
        {
            Name = "MediaWithCrops";

            Field<PublishedContent.Types.PublishedContentGraphType>(nameof(MediaWithCrops.MediaItem));
            Field<ImageCropperValueGraphType>(nameof(MediaWithCrops.LocalCrops));
        }
    }
}
