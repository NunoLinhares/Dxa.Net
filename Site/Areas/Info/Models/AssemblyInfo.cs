namespace Sdl.Web.Site.Areas.Info.Models
{
    public class AssemblyInfo
    {
        public string Version { get; internal set; }
        public string Name { get; internal set; }

        public bool IsSdl
        {
            get
            {
                if (Name.ToLower().StartsWith("sdl") || Name.ToLower().StartsWith("tridion"))
                    return true;
                return false;
            }
        }

        public bool IsDd4t
        {
            get
            {
                if (Name.ToLower().StartsWith("dd4t"))
                    return true;
                return false;
            }
        }

    }
}