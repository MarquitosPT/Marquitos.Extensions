using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marquitos.EntityFrameworkCore.Extensions
{
    /// <summary>
    /// EntityTypeBuilder Extensions
    /// </summary>
    public static class EntityTypeBuilderExtension
    {
        /// <summary>
        /// Configure Entity Created, Updated and Deleted Meta
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="createIndexes"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureAllMeta<TEntityType>(this EntityTypeBuilder<TEntityType> entity, bool createIndexes = false) where TEntityType : class, IEntityWithAllMeta
        {
            entity.Property(x => x.CreatedOn).IsRequired();
            entity.Property(x => x.CreatedBy).HasMaxLength(32).IsRequired();
            entity.Property(x => x.UpdatedOn).IsRequired();
            entity.Property(x => x.UpdatedBy).HasMaxLength(32).IsRequired();
            entity.Property(x => x.IsDeleted).IsRequired();

            if (createIndexes)
            {
                entity.HasIndex(x => x.CreatedOn).IsUnique(false);
                entity.HasIndex(x => x.UpdatedOn).IsUnique(false);
            }

            return entity;
        }

        /// <summary>
        /// Configure Entity Created and Updated Meta
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="createIndexes"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureCreatedAndUpdatedMeta<TEntityType>(this EntityTypeBuilder<TEntityType> entity, bool createIndexes = false) where TEntityType : class, IEntityWithCreatedAndUpdatedMeta
        {
            entity.Property(x => x.CreatedOn).IsRequired();
            entity.Property(x => x.CreatedBy).HasMaxLength(32).IsRequired();
            entity.Property(x => x.UpdatedOn).IsRequired();
            entity.Property(x => x.UpdatedBy).HasMaxLength(32).IsRequired();

            if (createIndexes)
            {
                entity.HasIndex(x => x.CreatedOn).IsUnique(false);
                entity.HasIndex(x => x.UpdatedOn).IsUnique(false);
            }

            return entity;
        }

        /// <summary>
        /// Configure Entity Created Meta
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="createIndexes"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureCreatedMeta<TEntityType>(this EntityTypeBuilder<TEntityType> entity, bool createIndexes = false) where TEntityType : class, IEntityWithCreatedMeta
        {
            entity.Property(x => x.CreatedOn).IsRequired();
            entity.Property(x => x.CreatedBy).HasMaxLength(32).IsRequired();

            if (createIndexes)
            {
                entity.HasIndex(x => x.CreatedOn).IsUnique(false);
            }

            return entity;
        }

        /// <summary>
        /// Configure Entity Deleted Meta
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureDeletedMeta<TEntityType>(this EntityTypeBuilder<TEntityType> entity) where TEntityType : class, IEntityWithDeletedMeta
        {
            entity.Property(x => x.IsDeleted).IsRequired();

            return entity;
        }

        /// <summary>
        /// Configure base properties of an Enum type Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureEnumEntity<TEntityType, TKey>(this EntityTypeBuilder<TEntityType> entity) where TEntityType : class, IEnumEntity<TKey> where TKey : struct
        {
            entity.HasAlternateKey(e => e.Code);
            entity.Property(x => x.Name).HasMaxLength(64).IsRequired();
            entity.Property(x => x.Description).HasMaxLength(128);

            return entity;
        }

        /// <summary>
        /// Configure base properties of an Enum type Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityTypeBuilder<TEntityType> ConfigureEnumEntityCreatedMeta<TEntityType, TKey>(this EntityTypeBuilder<TEntityType> entity) where TEntityType : class, IEnumEntityWithCreatedMeta<TKey> where TKey : struct
        {
            entity.HasAlternateKey(e => e.Code);
            entity.Property(x => x.Name).HasMaxLength(64).IsRequired();
            entity.Property(x => x.Description).HasMaxLength(128);
            entity.Property(x => x.CreatedOn).IsRequired();
            entity.Property(x => x.CreatedBy).HasMaxLength(32).IsRequired();

            return entity;
        }
    }
}
