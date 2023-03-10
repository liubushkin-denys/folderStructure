using System.ComponentModel.DataAnnotations;

namespace TestTaskNoSSL.Models
{
    public class Dir
    {
        [Key]
        public int Id { get; set; }
        public string DirName { get; set; }

        public int? ParentDirId { get; set; }
    }
}
