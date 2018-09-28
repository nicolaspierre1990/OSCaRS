using OSCaRS.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OScaRS.Data.Contracts.Entities
{
    [Table(DatabaseNames.PRODUCT_TABLE, Schema = DatabaseNames.DAT_SCHEMA)]
    public class Product: DataObject<Product>
    {
        #region Fields

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double PriceSell { get; set; }

        #endregion

        #region Methods

        public override void InsertingEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public override void UpdatingEntity(Product entity, Product originalEntity)
        {
            throw new NotImplementedException();
        }

        public override void DeletingEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
