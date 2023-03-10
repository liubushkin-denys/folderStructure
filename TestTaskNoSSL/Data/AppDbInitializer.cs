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
                            //Id = 1,
                            DirName = "Creating Digital Images",
                            ParentDirId = null
                        },
                        new Dir()
                        {
                            //Id = 2,
                            DirName = "Resources",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            //Id = 3,
                            DirName = "Evidence",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            //Id = 4,
                            DirName = "Graphic Products",
                            ParentDirId = 1
                        },
                        new Dir()
                        {
                            //Id = 5,
                            DirName = "Primary Sources",
                            ParentDirId = 2
                        },
                        new Dir()
                        {
                            //Id = 6,
                            DirName = "Secondary Sources",
                            ParentDirId = 2
                        },
                        new Dir()
                        {
                            //Id = 7,
                            DirName = "Process",
                            ParentDirId = 4
                        },
                        new Dir()
                        {
                            //Id = 8,
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
