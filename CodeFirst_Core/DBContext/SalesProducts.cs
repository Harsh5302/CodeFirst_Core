using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Core.DBContext
{
    public class SalesProducts
    {
        public int Id { get; set; }
        [Column("ProductName")]
        public int ProductName { get; set; }
    }
}
