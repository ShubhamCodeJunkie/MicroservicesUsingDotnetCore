using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Inventory.Service
{
    public class Dtos
    {
        public record GrantItemDtos(Guid UserId, Guid CatalogItemId, int Quantity);

        public record InventoryItemDto(Guid CatalogItemId,string Name,string description, int Quantity, DateTimeOffset AcquiredDate);

        public record CatalogItemDto(Guid Id, string Name, string Description); 
    }
}