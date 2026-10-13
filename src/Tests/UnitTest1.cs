using Domain.Services;
using Domain.Entities;
using Application.UseCases;
    
    namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CrearPedido()
        {
            var cliente = "Diego";
            var producto = "Cafe";
            var cantidad = 2;
            var precio = 3.40m;

            var pedido = OrderService.CreateTerribleOrder(cliente, producto, cantidad, precio);

            Assert.Equal(cliente, pedido.CustomerName);
            Assert.Contains(pedido, OrderService.LastOrders);
        }
        [Fact]
        public void CasoDeUso() 
        {
            var cliente = "Diego";
            var producto = "Cafe";
            var cantidad = 2;
            var precio = 3.40m;

            var pedido = CreateOrderUseCase.Execute(cliente, producto, cantidad, precio);

            Assert.Equal(cliente, pedido.CustomerName);
        }
    }
}
