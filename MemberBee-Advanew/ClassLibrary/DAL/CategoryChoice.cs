
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClassLibrary.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class CategoryChoice
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CategoryChoice()
    {

        this.Customers = new HashSet<Customer>();

    }


    public int CategoryChoiceNo { get; set; }

    public string CategoryChoiceName { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Customer> Customers { get; set; }

}

}