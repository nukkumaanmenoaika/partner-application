//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartnerApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partners
    {
        public int id { get; set; }
        public string PartnerType { get; set; }
        public string PartnerName { get; set; }
        public string Director { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LegalAddress { get; set; }
        public string INN { get; set; }
        public Nullable<int> Rating { get; set; }
    }
}