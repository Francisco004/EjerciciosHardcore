using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copiar
{
    public class Codigo
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////// == CLASE NO HEREDADA ////////////////////

        // public static bool operator ==(Lavadero Lava, Vehiculo Vehi)
        //{
        //    bool retorno = false;

        //    if (((object)Lava) == null && ((object)Vehi) == null)
        //    {
        //        retorno = true;
        //    }
        //    else
        //    {
        //        if (((object)Lava) != null && ((object)Vehi) != null)
        //        {
        //            foreach (Vehiculo vehiculito in Lava.vehiculos)
        //            {
        //                if (vehiculito == Vehi)
        //                {
        //                    retorno = true;
        //                } 
        //            }
        //        }
        //    }

        //    return retorno;
        //}

        //public static bool operator !=(Lavadero Lava, Vehiculo Vehi)
        //{
        //    return !(Lava == Vehi);
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////// == CLASE HEREDADA ////////////////////

        //public static bool operator ==(Vehiculo veh1, Vehiculo veh2)
        //{
        //    bool retorno = false;

        //    if (((object)veh1) == null && ((object)veh2) == null)
        //    {
        //        retorno = true;
        //    }
        //    else
        //    {
        //        if (((object)veh1) != null && ((object)veh2) != null)
        //        {
        //            if (veh1.patente == veh2.patente && veh1.marca == veh2.marca)
        //            {
        //                retorno = true;
        //            }
        //        }
        //    }

        //    return retorno;
        //}

        //public static bool operator !=(Lavadero Lava, Vehiculo Vehi)
        //{
        //    return !(Lava == Vehi);
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //StringBuilder sb = new StringBuilder();
        //sb.AppendLine("\n******************** PRECIO POR VEHICULO ********************\n");

        //        sb.AppendLine("Precio auto: " + this.precioAutos);
        //        sb.AppendLine("Precio camion: " + this.precioCamnion);
        //        sb.AppendLine("Precio moto: " + this.precioMoto);

        //        sb.AppendLine("\n******************** LISTA DE VEHICULOS ********************\n");

        //        foreach (Vehiculo item in Vehiculos)
        //        {
        //            sb.AppendLine(item.Mostrar());
        //        }

        //        return sb.ToString();

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //private List<Vehiculo> vehiculos;


        //private Lavadero()
        //{
        //    vehiculos = new List<Vehiculo>();
        //

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public static Lavadero operator +(Lavadero Lava, Vehiculo Vehi)
        //{
        //    if (Lava != Vehi)
        //    {
        //        Console.WriteLine("Se dio de alta el vehiculo...");
        //        Lava.vehiculos.Add(Vehi);
        //    }

        //    return Lava;
        //}

        //public static Lavadero operator -(Lavadero Lava, Vehiculo Vehi)
        //{
        //    if (Lava == Vehi)
        //    {
        //        Console.WriteLine("Se dio de baja el vehiculo...");
        //        Lava.vehiculos.Remove(Vehi);
        //    }

        //    return Lava;
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //TimeSpan diferencia;
        //diferencia = nuevoVencimiento - this.Vencimiento;

        //this.porcentajeInteres = this.porcentajeInteres + (float) (0.25 * (float) Convert.ToInt32(diferencia.Days));

        //this.Vencimiento = nuevoVencimiento;
    }
}
