//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_20._101_Avdeev_4.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Criteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criteria()
        {
            this.StudentResult = new HashSet<StudentResult>();
        }
    
        public int IdCriteria { get; set; }
        public int IdDiscipline { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NumberOfPionts { get; set; }
        public string WithdrawPercent { get; set; }
        public string RemoveAPoint { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentResult> StudentResult { get; set; }
    }
}
