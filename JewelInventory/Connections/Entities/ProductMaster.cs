//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using JetCoders.Shared;

namespace Connections
{
    [Serializable]
    public partial class ProductMaster : IEntityBase
    {
        #region Primitive Properties
    
        public virtual int ProductId
        {
            get;
            set;
        }
    
        public virtual string ProductName
        {
            get;
            set;
        }
    
        public virtual bool Active
        {
            get;
            set;
        }

        #endregion

    }
}
