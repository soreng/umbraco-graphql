using GraphQL.Types;

namespace Our.Umbraco.GraphQL.Adapters.Types
{
    public class ImageCropperValueGraphType : ObjectGraphType<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ImageCropperValue> {

        public ImageCropperValueGraphType()
        {
            Name = nameof(global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ImageCropperValue);
        }

    }
}
