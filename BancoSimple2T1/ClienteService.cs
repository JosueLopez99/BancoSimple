using BancoSimple2T1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoSimple2T1.Data;

namespace BancoSimple2T1
{
    public class ClienteService
    {
        //Definir la clase context
        public BancoSimpleContext context { get; set; }


        public ClienteService()
        {

            context = new BancoSimpleContext();
        }

        // Mandar a llamar la lista de clientes
        public List<Cliente> ObtenerClientes()
        {
            return context.Cliente.ToList();

        }
        //Agregar Cliente con los respectivos parametros y guardamos cambios
        public void AgregarCliente(string nombre, string identificacion)
        {
            var cliente = new Cliente
            {

                Nombre = nombre,
                Identificacion = identificacion

            };
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }
    }
}
