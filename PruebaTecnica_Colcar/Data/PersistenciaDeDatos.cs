using PruebaTecnica_Colcar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica_Colcar.Data
{
    public static class PersistenciaDeDatos
    {
        public static List<Multa> listaMultas { get; set; } = new List<Multa>
        {

            new Multa
            {
                identificador_infraccion = "A-001",
                dni = 34131648,
                fecha_infraccion = DateTime.Parse("2023-09-01"),
                importe = 50000,
                fecha_pago = null
            },

            new Multa
            {
                identificador_infraccion = "A-032",
                dni = 2020200,
                fecha_infraccion = DateTime.Parse("2020-09-01"),
                importe = 35000,
                fecha_pago = DateTime.Parse("2021-03-11")
            },

            new Multa
            {
                identificador_infraccion = "A-093",
                dni = 34131648,
                fecha_infraccion = DateTime.Parse("2020-01-01"),
                importe = 17000,
                fecha_pago = null
            },

            new Multa
            {
                identificador_infraccion = "A-046",
                dni = 1010100,
                fecha_infraccion = DateTime.Parse("2022-12-12"),
                importe = 75000,
                fecha_pago = DateTime.Parse("2022-12-13")
            },

            new Multa
            {
                identificador_infraccion = "A-125",
                dni = 8080800,
                fecha_infraccion = DateTime.Parse("2015-04-05"),
                importe = 22000,
                fecha_pago = DateTime.Parse("2019-07-11")
            },

            new Multa
            {
                identificador_infraccion = "A-436",
                dni = 34131648,
                fecha_infraccion = DateTime.Parse("2020-06-18"),
                importe = 88000,
                fecha_pago = DateTime.Parse("2022-06-06")
            },

            new Multa
            {
                identificador_infraccion = "A-078",
                dni = 34131648,
                fecha_infraccion = DateTime.Parse("2020-06-18"),
                importe = 40000,
                fecha_pago = null
            },

            new Multa
             {
                 identificador_infraccion = "A-806",
                 dni = 2020200,
                 fecha_infraccion = DateTime.Parse("2020-02-26"),
                 importe = 50000,
                 fecha_pago = null
             },


            new Multa
            {
                identificador_infraccion = "A-219",
                dni = 20230128,
                fecha_infraccion = DateTime.Parse("2018-09-01"),
                importe = 130000,
                fecha_pago = null
            },


            new Multa
             {
                 identificador_infraccion = "A-210",
                 dni = 1010100,
                 fecha_infraccion = DateTime.Parse("2018-09-01"),
                 importe = 55000,
                 fecha_pago = DateTime.Parse("2021-08-14")
             },

             new Multa
             {
                 identificador_infraccion = "A-921",
                 dni = 3030300,
                 fecha_infraccion = DateTime.Parse("2023-03-01"),
                 importe = 22000,
                 fecha_pago = DateTime.Parse("2023-06-12")
             },

           new Multa
           {
               identificador_infraccion = "A-063",
               dni = 3030300,
               fecha_infraccion = DateTime.Parse("2021-09-01"),
               importe = 78000,
               fecha_pago = DateTime.Parse("2023-10-01")
           },

            new Multa
             {
                 identificador_infraccion = "A-551",
                 dni = 2020200,
                 fecha_infraccion = DateTime.Parse("2020-09-01"),
                 importe = 50000,
                 fecha_pago = null
             },

            new Multa
            {
                identificador_infraccion = "A-041",
                dni = 2020200,
                fecha_infraccion = DateTime.Parse("2017-07-23"),
                importe = 50000,
                fecha_pago = null
            },

            new Multa
             {
                 identificador_infraccion = "A-651",
                 dni = 15121369,
                 fecha_infraccion = DateTime.Parse("2022-06-17"),
                 importe = 120000,
                 fecha_pago = DateTime.Parse("2023-08-21")
             }


        };
        public static List<Multa> OrdenarPorFechaDescendente()
        {
            List<Multa> multasOrdenadas = listaMultas.OrderByDescending(multa => multa.fecha_infraccion).ToList();
            return multasOrdenadas;
        }

        public static List<Multa> FiltrarYOrdenarPorDNI(int dni)
        {
            List<Multa> multasFiltradasYOrdenadas = listaMultas
                .Where(multa => multa.dni == dni)
                .OrderByDescending(multa => multa.fecha_infraccion)
                .ToList();
            return multasFiltradasYOrdenadas;
        }

       

    }
}
