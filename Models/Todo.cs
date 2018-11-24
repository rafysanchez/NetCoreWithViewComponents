using System.ComponentModel.DataAnnotations;

namespace NetCoreComponent.Models
{
    public class TodoList
    {

        [Key]
        public int id { get; set; }
        public string task { get; set; }
        public bool done { get; set; }
    }



}