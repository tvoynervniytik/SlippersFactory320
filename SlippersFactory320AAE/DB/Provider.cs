//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlippersFactory320AAE.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Id_TypeProvider { get; set; }
    
        public virtual TypeProvider TypeProvider { get; set; }
    }
}
