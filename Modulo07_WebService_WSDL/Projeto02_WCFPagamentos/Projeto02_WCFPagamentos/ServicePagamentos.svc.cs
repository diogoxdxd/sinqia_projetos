using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Projeto02_WCFPagamentos.Models;

namespace Projeto02_WCFPagamentos
{
	public class ServicePagamentos : IServicePagamentos
	{
		public int EfetuarPagamento(PagamentoContract pagamento)
		{
			/*
				Valores de retorno:
					0 - Pagamento OK
					1 - Cartão Inexistente
					2 - Pedido já pago
					3 - Limite indisponível no cartão
			 */

			using (var context = new DB_PAGAMENTOSEntities())
			{
				//Verificação de existência do cartão
				var cartao = context.Cartoes
					.FirstOrDefault(c => c.NumeroCartao == pagamento.NumeroCartao);
				if(cartao == null)
				{
					return 1;
				}

				//Verificação do Pedido
				var pedido = context.Pagamentos
					.FirstOrDefault(p => p.NumeroPedido == pagamento.NumeroPedido);
				if (pedido != null)
				{
					return 2;
				}

				//Verificação do Limite disponível
				double valorPedidos = pagamento.Valor;

				var pagamentosRealizados = context.Pagamentos
					.Where(p => p.NumeroCartao == pagamento.NumeroCartao);
				if(pagamentosRealizados.Count() > 0)
				{
					valorPedidos += pagamentosRealizados.Sum(s => s.Valor);
				}
				if(valorPedidos > cartao.Limite)
				{
					//Limite insdisponível
					return 3;
				}

				//Pagamento realizado
				Pagamento pagto = new Pagamento();
				pagto.NumeroCartao = pagamento.NumeroCartao;
				pagto.NumeroPedido = pagamento.NumeroPedido;
				pagto.Valor = pagamento.Valor;

				context.Pagamentos.Add(pagto);
				context.SaveChanges();
				return 0;

			}
		}


		public List<CartaoContract> ListarCartoes()
		{
			using (var context = new DB_PAGAMENTOSEntities())
			{
				var cartoes = context.Cartoes;
				List<CartaoContract> lista = new List<CartaoContract>();

				foreach (var item in cartoes)
				{
					lista.Add(new CartaoContract()
					{
						Id = item.Id,
						NumeroCartao = item.NumeroCartao,
						Limite = item.Limite
					});
				}
				return lista;
			}
		}

		public List<PagamentoContract> ListarPagamentos()
		{
			using (var context = new DB_PAGAMENTOSEntities())
			{
				var pagamentos = context.Pagamentos;
				List<PagamentoContract> lista = new List<PagamentoContract>();

				foreach (var item in pagamentos)
				{
					lista.Add(new PagamentoContract()
					{
						Id = item.Id,
						NumeroCartao = item.NumeroCartao,
						NumeroPedido = item.NumeroPedido,
						Valor = item.Valor
					
					});
				}
				return lista;
			}
		}
	}
}
