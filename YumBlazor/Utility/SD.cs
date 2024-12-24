using YumBlazor.Data;

namespace YumBlazor.Utility
{
    public static class SD
    {
        public static string Role_Admin = "Admin";
        public static string Role_Customer = "Customer";
        public static string StatusPending = "Pending";
        public static string StatusReadyForPickup = "ReadyForPickUp";
        public static string StatusCompleted = "Completed";
        public static string StatusCancelled = "Cancelled";

        public static List<OrderDetail> ConvertShoppingCartListToOrderDetail(List<ShopingCart> shoppingCarts)

        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (var cart in shoppingCarts)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    ProductId = cart.ProductId,
                    Count = cart.Count,
                    Price = Convert.ToDouble(cart.prodcut!.Price),
                    ProductName = cart.prodcut.Name
                };
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
