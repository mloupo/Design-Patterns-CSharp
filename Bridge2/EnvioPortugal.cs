namespace Bridge2
{
    internal class EnvioPortugal : InterfaceEnvio
    {
        public EnvioPortugal()
        { }

        public string Entregar()
        {
            return "Pedido entregado Portugal";
        }

        public string Enviar()
        {
            return "Pedido enviado Portugal";
        }

        public string ProcesarPedido()
        {
            return "Pedido procesado Portugal";
        }
    }
}
