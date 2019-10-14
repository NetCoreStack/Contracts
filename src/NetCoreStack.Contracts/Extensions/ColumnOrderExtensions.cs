using System;

namespace NetCoreStack.Contracts
{
    public static class ColumnOrderExtensions
    {
        public static ColumnOrderDescriptor ConvertToDescriptor(this ColumnOrder order, string columnName)
        {
            if(order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            var columnIndex = order.Column;
            var direction = order.Dir.ToLowerInvariant();
            ListSortDirection sortDirection = direction == "asc" || direction == nameof(ListSortDirection.Ascending).ToLowerInvariant() ?
                    ListSortDirection.Ascending :
                    ListSortDirection.Descending;

            return new ColumnOrderDescriptor
            {
                Name = columnName,
                ColumnIndex = columnIndex,
                Direction = sortDirection
            };
        }
    }
}
