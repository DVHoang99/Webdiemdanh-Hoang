
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebApplication1.Models
{

using System;
    using System.Collections.Generic;
    
public partial class GIANGVIEN
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public GIANGVIEN()
    {

        this.TKBs = new HashSet<TKB>();

        this.FORMLUUTRUs = new HashSet<FORMLUUTRU>();

        this.DIEMDANHs = new HashSet<DIEMDANH>();

    }


    public string ID { get; set; }

    public string TEN { get; set; }

    public string CHUCVU { get; set; }

    public string BANGCAP { get; set; }

    public Nullable<int> MADONVI { get; set; }



    public virtual DONVI DONVI { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TKB> TKBs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FORMLUUTRU> FORMLUUTRUs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DIEMDANH> DIEMDANHs { get; set; }

}

}
