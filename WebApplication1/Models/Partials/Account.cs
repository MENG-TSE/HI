//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(Auth001MD))]
    public partial class Account
    {
        public class Auth001MD
        {
            public int Id { get; set; }

            [DisplayName("帳號")]
            [Required(ErrorMessage = "規則錯誤...")]
            [StringLength(5, MinimumLength = 1, ErrorMessage = "字數不是1~5")]
            [RegularExpression(@"[a-zA-Z]+[a-zA-Z0-9]*$", ErrorMessage = "密碼僅能有英文或數字，且開頭須為英文字母")]
            public string Username { get; set; }


            [DisplayName("密碼")]
            [StringLength(5, MinimumLength =1, ErrorMessage = "字數不是1~5")]
            [DataType(DataType.Password)]
            public string Password { get; set; }


            [DisplayName("姓名")]
            [StringLength(5, MinimumLength = 1, ErrorMessage = "字數不是1~5")]
            public string Name { get; set; }


            [DisplayName("E_mail")]
            [DataType(DataType.EmailAddress, ErrorMessage = "請輸入E-mail格式")]
            public string E_mail { get; set; }



        }
    }
}
