using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSCaRS.Core
{
    /// <summary>
    /// Abstract base class that handles validation for <see cref="TEntity"/>
    /// </summary>
    public abstract class DataObject<TEntity>
    {
        #region Fields

        /// <summary>
        /// Indicates if the operation that is preformed is valid
        /// </summary>
        [NotMapped]
        public bool IsValid { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        #endregion


        #region Methods

        /// <summary>
        /// Called for each entity that will be inserted
        /// </summary>
        /// <param name="entity">Entity that will be inserted</param>
        public abstract void InsertingEntity(TEntity entity);

        /// <summary>
        /// Called for each entity that will be updated
        /// </summary>
        /// <param name="entity">Entity that contains the updated member values</param>
        /// <param name="originalEntity">Entity that contains the original member values</param>
        public abstract void UpdatingEntity(TEntity entity, TEntity originalEntity);

        /// <summary>
        /// Called for each entity that will be deleted
        /// </summary>
        /// <param name="entity">Entity that will be deleted</param>
        public abstract void DeletingEntity(TEntity entity);

        #endregion
    }
}
