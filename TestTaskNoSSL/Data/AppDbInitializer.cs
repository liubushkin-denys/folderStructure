using TestTaskNoSSL.Data;
using TestTaskNoSSL.Models;

namespace TestTask_aspnet_mvc.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Dirs.Any())
                {
                    context.Dirs.AddRange(new List<Dir>()
                    {
                        new Dir()
                        {
                            DirName = "Creating Digital Images",
                            ParentDirId = null
                        },
                        new Dir()
                        {
                            DirName = "Resources",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            DirName = "Evidence",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            DirName = "Graphic Products",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            DirName = "Primary Sources",
                            ParentDirId = 2
                        },
                        new Dir()
                        {
                            DirName = "Secondary Sources",
                            ParentDirId = 2
                        },
                        new Dir()
                        {
                            DirName = "Process",
                            ParentDirId = 4
                        },
                        new Dir()
                        {
                            DirName = "Final Product",
                            ParentDirId = 4
                        }
                    }) ;
                    context.SaveChanges();
                }
            }
        }
    }
}
