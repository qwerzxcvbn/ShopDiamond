//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf_shop.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public int UserRole { get; set; }
        public string UserFullName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
