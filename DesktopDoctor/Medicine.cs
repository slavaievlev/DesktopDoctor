//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopDoctor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        public Medicine()
        {
            this.ReceptionsMedicines = new HashSet<ReceptionMedicine>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<ReceptionMedicine> ReceptionsMedicines { get; set; }
    }
}