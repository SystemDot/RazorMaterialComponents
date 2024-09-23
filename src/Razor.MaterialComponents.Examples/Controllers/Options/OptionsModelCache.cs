namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Options
{
    public class OptionsModelCache
    {
        private OptionsModel? model;
        public OptionsModel? Get()
        {
            return model;
        }
        public void Set(OptionsModel toSet)
        {
            model = toSet;
        }
    }
    }
