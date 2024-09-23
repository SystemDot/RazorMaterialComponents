namespace SystemDot.Web.Razor.MaterialComponents.Examples.Controllers.Chips
{
    public class ChipModelCache
    {
        private ChipsModel? model;
        public ChipsModel? Get()
        {
            return model;
        }
        public void Set(ChipsModel toSet)
        {
            model = toSet;
        }
    }
    }
