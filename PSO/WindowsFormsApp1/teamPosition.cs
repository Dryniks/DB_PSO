//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class teamPosition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public teamPosition()
        {
            this.user = new HashSet<user>();
        }
    
        public int idTeam { get; set; }
        public Nullable<int> seniorLifeguard { get; set; }
        public Nullable<int> doctor { get; set; }
        public Nullable<int> paramedic { get; set; }
        public Nullable<int> driver { get; set; }
        public Nullable<int> pyrotechnist { get; set; }
        public Nullable<int> gasWelder { get; set; }
        public Nullable<int> craneOperator { get; set; }
        public Nullable<int> scubaDriver { get; set; }
        public Nullable<int> hydraulicEquipmentTechnician { get; set; }
        public Nullable<int> scout { get; set; }
        public Nullable<int> electrician { get; set; }
        public Nullable<int> rescuer { get; set; }
    
        public virtual coordinator coordinator { get; set; }
        public virtual team team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }
    }
}
