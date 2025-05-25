using BancoSimple2T1.Data;
using BancoSimple2T1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple2T1
{
    public class CuentaService
    {

        //Definir la clase context
        public BancoSimpleContext context;

        public CuentaService()
        {

            context = new BancoSimpleContext();
        }

        //Agregar cuenta con los respectivos parametros y guardamos cambios
        public void AgregarCuenta(string numerocuenta, decimal saldo, int clienteid, bool activa)
        {
            var cuenta = new Cuenta
            {
                NumeroCuenta = numerocuenta,
                Saldo = saldo,
                ClienteId = clienteid,
                Activa = activa
            };
            context.Cuenta.Add(cuenta);
            context.SaveChanges();

        }

        //Muestra las cuentas almacenadas con filtro activo y lo devolvemos
        public List<object> CuentasActivas()
        {
            var cuenta = context.Cuenta.
               Include(c => c.cliente).Where(c => c.Activa).
               Select(c => new
               {
                   c.CuentaId,
                   c.NumeroCuenta,
                   c.Saldo,
                   NombreCliente = c.cliente.Nombre,
                   c.Activa,
                   c.ClienteId
               }).ToList<object>();
            return cuenta;


        }

    }
}
