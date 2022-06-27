using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]

        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field is Required")]

        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]


        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }

    }
}
