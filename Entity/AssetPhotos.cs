//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiForAndroid.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetPhotos
    {
        public long ID { get; set; }
        public long AssetID { get; set; }
        public byte[] AssetPhoto { get; set; }
    
        public virtual Assets Assets { get; set; }
    }
}