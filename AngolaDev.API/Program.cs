using AngolaDev.Pagamentos.Configuration;
using AngolaDev.Pagamentos.Contracts;
using AngolaDev.Pedidos.Configuration;
using AngolaDev.Pedidos.Contracts;
using AngolaDev.Pedidos.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPedidoContext(builder.Configuration);
builder.Services.AddPedidoDependencyInjection();

builder.Services.AddPagamentoContext(builder.Configuration);
builder.Services.AddPagamentoDependencyInjection();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/adicionar-pedido", (IPedidoContract pedidoContract, Pedido pedido) =>
{
    pedidoContract.Adicionar(pedido);
})
.WithName("AdicionarPedido");

app.MapGet("/obter-pedidos", (IPedidoContract pedidoContract) =>
{
   return pedidoContract.ObterTodos();
})
.WithName("ObterPedidos");

app.MapGet("/obter-pagamentos", (IPagamentoContract pagamentoContract) =>
{
    return pagamentoContract.ObterPagamentos();
})
.WithName("ObterPagamentos");

app.Run();
