using DevIO.UI.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Data
{
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
