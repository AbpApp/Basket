using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Abp.Module.Basket.EntityFrameworkCore
{
    public static class BasketDbContextModelCreatingExtensions
    {
        public static void ConfigureBasket(
            this ModelBuilder builder,
            Action<BasketModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BasketModelBuilderConfigurationOptions(
                BasketDbProperties.DbTablePrefix,
                BasketDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}