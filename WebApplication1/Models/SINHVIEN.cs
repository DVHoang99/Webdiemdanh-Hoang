
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
    
public partial class SINHVIEN
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SINHVIEN()
    {

        this.CHITIETMONHOCs = new HashSet<CHITIETMONHOC>();

        this.DIEMDANHs = new HashSet<DIEMDANH>();

    }


    public string ID { get; set; }

    public string TEN { get; set; }

    public string TENLOP { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CHITIETMONHOC> CHITIETMONHOCs { get; set; }

    public virtual LOP LOP { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DIEMDANH> DIEMDANHs { get; set; }

}

}
