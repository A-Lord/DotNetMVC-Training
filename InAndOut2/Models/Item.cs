using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace InAndOut2.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; } //Id is by default the key

        public string Borrower { get; set; }

        public string Lender { get; set; }

        [DisplayName("Item name")]
        public string ItemName { get; set; }


        // Code First approach, create code firs rather then Database activity ,
        // 1 Create/modify domain classes 
        // 2 Configure Domain classes
        // 3 Automated/Code-Based Migration
        // 4 Database
        // Reson is that model is likely to change often as new requirements come to light. 
        // Database needs to be in sync with the Model, so migration keeps the database schema
        // in sync with the EF core model.

    }
}
