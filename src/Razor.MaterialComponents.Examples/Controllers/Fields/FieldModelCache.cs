namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Fields
{
    public class FieldModelCache
    {
        private FieldsModel? model;
        public FieldsModel? Get()
        {
            return model;
        }
        public void Set(FieldsModel toSet)
        {
            model = toSet;
        }
    }
    }
