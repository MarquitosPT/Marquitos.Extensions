using System.Collections;

namespace Marquitos.EntityFrameworkCore.Extensions
{
    /// <summary>
    /// Entity extension methods
    /// </summary>
    public static class EntityExtension
    {
        /// <summary>
        /// Fill created information
        /// </summary>
        /// <param name="entity">The entity that will be affected.</param>
        /// <param name="createdBy">The user who created the entity.</param>
        /// <param name="createdOn">Date of creation.</param>
        /// <param name="recursive">Recursively apply to all child entities.</param>
        /// <returns></returns>
        public static TEntity SetCreatedBy<TEntity>(this TEntity entity, string createdBy, DateTime createdOn, bool recursive = true) where TEntity : class, IEntityWithCreatedMeta
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (createdBy == null)
            {
                throw new ArgumentNullException(nameof(createdBy));
            }

            var interfaces = entity.GetType().GetInterfaces();

            if (interfaces.Contains(typeof(IEntityWithAllMeta)))
            {
                var prop = (IEntityWithAllMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn && prop.UpdatedBy == createdBy && prop.UpdatedOn == createdOn && prop.IsDeleted == false)
                {
                    return entity;
                }

                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
                prop.UpdatedBy = createdBy;
                prop.UpdatedOn = createdOn;
                prop.IsDeleted = false;
            }
            else if (interfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
            {
                var prop = (IEntityWithCreatedAndUpdatedMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn && prop.UpdatedBy == createdBy && prop.UpdatedOn == createdOn)
                {
                    return entity;
                }

                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
                prop.UpdatedBy = createdBy;
                prop.UpdatedOn = createdOn;
            }
            else if (interfaces.Contains(typeof(IEntityWithCreatedMeta)))
            {
                var prop = (IEntityWithCreatedMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn)
                {
                    return entity;
                }

                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
            }

            if (recursive)
            {
                SetPropertyEntitiesCreatedBy(entity, createdBy, createdOn);
            }

            return entity;
        }

        /// <summary>
        /// Fill created information
        /// </summary>
        /// <param name="entity">The entity that will be affected.</param>
        /// <param name="createdBy">The user who created the entity.</param>
        /// <param name="createdOn">Date of creation.</param>
        /// <param name="id">Default Key value.</param>
        /// <param name="recursive">Recursively apply to all child entities.</param>
        /// <returns></returns>
        public static TEntity SetCreatedBy<TEntity, TKey>(this TEntity entity, string createdBy, DateTime createdOn, TKey id = default!, bool recursive = true) where TEntity : class, IEntityWithCreatedMeta<TKey>
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (createdBy == null)
            {
                throw new ArgumentNullException(nameof(createdBy));
            }

            var interfaces = entity.GetType().GetInterfaces();

            if (interfaces.Contains(typeof(IEntityWithAllMeta<TKey>)))
            {
                var prop = (IEntityWithAllMeta<TKey>)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn && prop.UpdatedBy == createdBy && prop.UpdatedOn == createdOn && prop.IsDeleted == false)
                {
                    return entity;
                }

                prop.Id = id;
                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
                prop.UpdatedBy = createdBy;
                prop.UpdatedOn = createdOn;
                prop.IsDeleted = false;
            }
            else if (interfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta<TKey>)))
            {
                var prop = (IEntityWithCreatedAndUpdatedMeta<TKey>)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn && prop.UpdatedBy == createdBy && prop.UpdatedOn == createdOn)
                {
                    return entity;
                }

                prop.Id = id;
                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
                prop.UpdatedBy = createdBy;
                prop.UpdatedOn = createdOn;
            }
            else if (interfaces.Contains(typeof(IEntityWithCreatedMeta<TKey>)))
            {
                var prop = (IEntityWithCreatedMeta<TKey>)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.CreatedBy == createdBy && prop.CreatedOn == createdOn)
                {
                    return entity;
                }

                prop.Id = id;
                prop.CreatedBy = createdBy;
                prop.CreatedOn = createdOn;
            }

            if (recursive)
            {
                SetPropertyEntitiesCreatedBy(entity, createdBy, createdOn);
            }

            return entity;
        }


        /// <summary>
        /// Fill updated information
        /// </summary>
        /// <param name="entity">The entity that will be affected.</param>
        /// <param name="updatedBy">The user who updated the entity.</param>
        /// <param name="updatedOn">Date of update.</param>
        /// <param name="recursive">Recursively apply to all child entities.</param>
        /// <returns></returns>
        public static TEntity SetUpdatedBy<TEntity>(this TEntity entity, string updatedBy, DateTime updatedOn, bool recursive = true) where TEntity : class, IEntityWithCreatedAndUpdatedMeta
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (updatedBy == null)
            {
                throw new ArgumentNullException(nameof(updatedBy));
            }

            var interfaces = entity.GetType().GetInterfaces();

            if (interfaces.Contains(typeof(IEntityWithAllMeta)))
            {
                var prop = (IEntityWithAllMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.UpdatedBy == updatedBy && prop.UpdatedOn == updatedOn)
                {
                    return entity;
                }

                prop.UpdatedBy = updatedBy;
                prop.UpdatedOn = updatedOn;
            }
            else if (interfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
            {
                var prop = (IEntityWithCreatedAndUpdatedMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.UpdatedBy == updatedBy && prop.UpdatedOn == updatedOn)
                {
                    return entity;
                }

                prop.UpdatedBy = updatedBy;
                prop.UpdatedOn = updatedOn;
            }

            if (recursive)
            {
                SetPropertyEntitiesUpdatedBy(entity, updatedBy, updatedOn);
            }

            return entity;
        }

        /// <summary>
        /// Fill deleted information
        /// </summary>
        /// <param name="entity">The entity that will be affected.</param>
        /// <param name="deletedBy">The user who deleted the entity.</param>
        /// <param name="deletedOn">Date of delete.</param>
        /// <param name="recursive">Recursively apply to all child entities.</param>
        /// <returns></returns>
        public static TEntity SetDeletedBy<TEntity>(this TEntity entity, string deletedBy, DateTime deletedOn, bool recursive = true) where TEntity : class, IEntityWithDeletedMeta
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (deletedBy == null)
            {
                throw new ArgumentNullException(nameof(deletedBy));
            }

            var interfaces = entity.GetType().GetInterfaces();

            if (interfaces.Contains(typeof(IEntityWithAllMeta)))
            {
                var prop = (IEntityWithAllMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.IsDeleted && prop.UpdatedBy == deletedBy && prop.UpdatedOn == deletedOn)
                {
                    return entity;
                }

                prop.UpdatedBy = deletedBy;
                prop.UpdatedOn = deletedOn;
                prop.IsDeleted = true;
            }
            else if (interfaces.Contains(typeof(IEntityWithDeletedMeta)))
            {
                var prop = (IEntityWithDeletedMeta)entity;

                // Evitar as referencias circulares entre entidades
                if (prop.IsDeleted)
                {
                    return entity;
                }

                prop.IsDeleted = true;
            }

            if (recursive)
            {
                SetPropertyEntitiesDeletedBy(entity, deletedBy, deletedOn);
            }

            return entity;
        }

        #region Private

        private static void SetPropertyEntitiesCreatedBy(IEntityWithCreatedMeta entity, string createdBy, DateTime createdOn)
        {
            var properties = entity.GetType().GetProperties();

            foreach (var item in properties)
            {
                if (item.PropertyType.IsGenericType)
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEnumerable)))
                    {
                        var array = (IEnumerable)item.GetValue(entity)!;

                        foreach (var arrayItem in array)
                        {
                            var arrayItemInterfaces = arrayItem.GetType().GetInterfaces();

                            if (arrayItemInterfaces.Contains(typeof(IEntity)))
                            {
                                if (arrayItemInterfaces.Contains(typeof(IEntityWithAllMeta)))
                                {
                                    var obj = (IEntityWithAllMeta)arrayItem;

                                    obj?.SetCreatedBy(createdBy, createdOn);
                                }
                                else if (arrayItemInterfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
                                {
                                    var obj = (IEntityWithCreatedAndUpdatedMeta)arrayItem;

                                    obj?.SetCreatedBy(createdBy, createdOn);
                                }
                                else if (arrayItemInterfaces.Contains(typeof(IEntityWithCreatedMeta)))
                                {
                                    var obj = (IEntityWithCreatedMeta)arrayItem;

                                    obj?.SetCreatedBy(createdBy, createdOn);
                                }
                            }
                        }
                    }
                }
                else if (item.PropertyType.IsClass && item.PropertyType != typeof(string))
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEntity)))
                    {
                        if (interfaces.Contains(typeof(IEntityWithAllMeta)))
                        {
                            var prop = (IEntityWithAllMeta)item.GetValue(entity)!;

                            prop?.SetCreatedBy(createdBy, createdOn);
                        }
                        else if (interfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
                        {
                            var prop = (IEntityWithCreatedAndUpdatedMeta)item.GetValue(entity)!;

                            prop?.SetCreatedBy(createdBy, createdOn);
                        }
                        else if (interfaces.Contains(typeof(IEntityWithCreatedMeta)))
                        {
                            var prop = (IEntityWithCreatedMeta)item.GetValue(entity)!;

                            prop?.SetCreatedBy(createdBy, createdOn);
                        }
                    }
                }
            }
        }

        private static void SetPropertyEntitiesUpdatedBy(IEntityWithCreatedAndUpdatedMeta entity, string updatedBy, DateTime updatedOn)
        {
            var properties = entity.GetType().GetProperties();

            foreach (var item in properties)
            {
                if (item.PropertyType.IsGenericType)
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEnumerable)))
                    {
                        var array = (IEnumerable)item.GetValue(entity)!;

                        foreach (var arrayItem in array)
                        {
                            var arrayItemInterfaces = arrayItem.GetType().GetInterfaces();

                            if (arrayItemInterfaces.Contains(typeof(IEntity)))
                            {
                                if (arrayItemInterfaces.Contains(typeof(IEntityWithAllMeta)))
                                {
                                    var obj = (IEntityWithAllMeta)arrayItem;

                                    if (obj?.CreatedOn == default || obj?.CreatedBy == null)
                                    {
                                        obj?.SetCreatedBy(updatedBy, updatedOn);
                                    }
                                    else
                                    {
                                        obj?.SetUpdatedBy(updatedBy, updatedOn);
                                    }
                                }
                                else if (arrayItemInterfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
                                {
                                    var obj = (IEntityWithCreatedAndUpdatedMeta)arrayItem;

                                    if (obj?.CreatedOn == default || obj?.CreatedBy == null)
                                    {
                                        obj?.SetCreatedBy(updatedBy, updatedOn);
                                    }
                                    else
                                    {
                                        obj?.SetUpdatedBy(updatedBy, updatedOn);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (item.PropertyType.IsClass && item.PropertyType != typeof(string))
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEntity)))
                    {
                        if (interfaces.Contains(typeof(IEntityWithAllMeta)))
                        {
                            var prop = (IEntityWithAllMeta)item.GetValue(entity)!;

                            if (prop?.CreatedOn == default || prop?.CreatedBy == null)
                            {
                                prop?.SetCreatedBy(updatedBy, updatedOn);
                            }
                            else
                            {
                                prop?.SetUpdatedBy(updatedBy, updatedOn);
                            }
                        }
                        else if (interfaces.Contains(typeof(IEntityWithCreatedAndUpdatedMeta)))
                        {
                            var prop = (IEntityWithCreatedAndUpdatedMeta)item.GetValue(entity)!;

                            if (prop?.CreatedOn == default || prop?.CreatedBy == null)
                            {
                                prop?.SetCreatedBy(updatedBy, updatedOn);
                            }
                            else
                            {
                                prop?.SetUpdatedBy(updatedBy, updatedOn);
                            }
                        }
                    }
                }
            }
        }

        private static void SetPropertyEntitiesDeletedBy(IEntityWithDeletedMeta entity, string deletedBy, DateTime deletedOn)
        {
            var properties = entity.GetType().GetProperties();

            foreach (var item in properties)
            {
                if (item.PropertyType.IsGenericType)
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEnumerable)))
                    {
                        var array = (IEnumerable)item.GetValue(entity)!;

                        foreach (var arrayItem in array)
                        {
                            var arrayItemInterfaces = arrayItem.GetType().GetInterfaces();

                            if (arrayItemInterfaces.Contains(typeof(IEntity)))
                            {
                                if (arrayItemInterfaces.Contains(typeof(IEntityWithAllMeta)))
                                {
                                    var obj = (IEntityWithAllMeta)arrayItem;

                                    obj?.SetDeletedBy(deletedBy, deletedOn);
                                }
                                else if (arrayItemInterfaces.Contains(typeof(IEntityWithDeletedMeta)))
                                {
                                    var obj = (IEntityWithDeletedMeta)arrayItem;

                                    obj?.SetDeletedBy(deletedBy, deletedOn);
                                }
                            }
                        }
                    }
                }
                else if (item.PropertyType.IsClass && item.PropertyType != typeof(string))
                {
                    var interfaces = item.PropertyType.GetInterfaces();

                    if (interfaces.Contains(typeof(IEntity)))
                    {
                        if (interfaces.Contains(typeof(IEntityWithAllMeta)))
                        {
                            var prop = (IEntityWithAllMeta)item.GetValue(entity)!;

                            prop?.SetDeletedBy(deletedBy, deletedOn);
                        }
                        else if (interfaces.Contains(typeof(IEntityWithDeletedMeta)))
                        {
                            var prop = (IEntityWithDeletedMeta)item.GetValue(entity)!;

                            prop?.SetDeletedBy(deletedBy, deletedOn);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
