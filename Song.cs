//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUSICART_APP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public int SongID { get; set; }
        public string Song1 { get; set; }
        public string Title { get; set; }
        public int Album { get; set; }
        public string Genre { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public bool isOwned { get; set; }
    
        public virtual Album Album1 { get; set; }
    }
}
