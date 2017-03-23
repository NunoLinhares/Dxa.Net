using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Sdl.Web.Site.Areas.Info.Models
{
    public class AssemblyInfos
    {
        public List<AssemblyInfo> Assemblies { get; set; }

        public AssemblyInfos()
        {
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "bin");
            Assemblies = new List<AssemblyInfo>();
            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                Assembly asm = Assembly.LoadFile(dll);
                AssemblyInfo ai = new AssemblyInfo
                {
                    Name = asm.GetName().Name,
                    Version = Assembly.Load(asm.FullName).GetName().Version.ToString()
                };
                Assemblies.Add(ai);
            }

        }
    }
}
