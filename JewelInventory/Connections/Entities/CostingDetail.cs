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
    public partial class CostingDetail : IEntityBase
    {
        #region Primitive Properties
    
        public virtual int CostingDetailId
        {
            get;
            set;
        }
    
    
    	private CostingRates _properties = null;
    	
    	public virtual CostingRates Properties
    	{
    		get 
    		{
    			if ( _properties == null )
    				_properties = new CostingRates();
    				
    			return _properties;
    		}
    		
    		set { _properties = value; }
    	}
        private string CostingRates_Xml
        {
    		get { return this.Properties.Serialize<CostingRates>().ToString(); }
    		set { this.Properties = DataContractHelper.Deserialize<CostingRates>(value); }
        }
    
        public virtual System.DateTime AccessedDate
        {
            get;
            set;
        }
    
        public virtual int AccessedBy
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<JewelTransaction> PurchaseTransaction
        {
            get
            {
                if (_purchaseTransaction == null)
                {
                    var newCollection = new FixupCollection<JewelTransaction>();
                    newCollection.CollectionChanged += FixupPurchaseTransaction;
                    _purchaseTransaction = newCollection;
                }
                return _purchaseTransaction;
            }
            set
            {
                if (!ReferenceEquals(_purchaseTransaction, value))
                {
                    var previousValue = _purchaseTransaction as FixupCollection<JewelTransaction>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPurchaseTransaction;
                    }
                    _purchaseTransaction = value;
                    var newValue = value as FixupCollection<JewelTransaction>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPurchaseTransaction;
                    }
                }
            }
        }
        private ICollection<JewelTransaction> _purchaseTransaction;

        #endregion

        #region Association Fixup
    
        private void FixupPurchaseTransaction(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (JewelTransaction item in e.NewItems)
                {
                    item.CostingDetail = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (JewelTransaction item in e.OldItems)
                {
                    if (ReferenceEquals(item.CostingDetail, this))
                    {
                        item.CostingDetail = null;
                    }
                }
            }
        }

        #endregion

    }
}