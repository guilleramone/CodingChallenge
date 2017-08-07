using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Objeto que representa títulos pertenecientes al Mercado de Valores argentino.
    /// </summary>
    public class Titulo
    {
        /// <summary>
        /// Identificador numérico del título en DB.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Serie única de letras asignadas a una especie para su operatoria en la bolsa.
        /// </summary>
        public string Simbolo { get; set; }

        /// <summary>
        /// Descripción del papel.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Detalle de la empresa a la que pertenece la acción o bien la denominación del bono.
        /// </summary>
        public string Detalle { get; set; }

        /// <summary>
        /// Tipo de título de la especie en cuestión.
        /// </summary>
        public TipoTitulo Tipo { get; set; }

        /// <summary>
        /// Moneda en la cual se opera el papel.
        /// </summary>
        public Moneda Moneda { get; set; }

        /// <summary>
        /// Devuelve un resumen genérico con datos del título en formato HTML para mostrar en una vista. 
        /// 
        /// TODO:   Refactor. Qué pasaría si tuviera otro tipo de título en el listado además de Accion/Bono? 
        ///         Y si quiero imprimir en otro idioma?
        /// </summary>
        /// <param name="titulos"></param>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public static string ImprimirResumen(IList<Titulo> titulos, Idioma idioma)
        {
            var returnString = string.Empty;

            if (!titulos.Any())
            {
                if (idioma == Idioma.Castellano)
                    returnString = "<h1>¡Lista vacía de títulos!</h1>";
                else
                    returnString = "<h1>Empty list of securities!</h1>";
            }
            else
            {
                if (idioma == Idioma.Castellano)
                    returnString += "<h1>Resumen de títulos</h1>";
                else
                    returnString += "<h1>Securities report</h1>";

                var cantidadAcciones = 0;
                var cantidadBonos = 0;

                var detalleAcciones = string.Empty;
                var detalleBonos = string.Empty;

                foreach (var titulo in titulos)
                {
                    if (titulo.Tipo == TipoTitulo.Accion)
                    {
                        cantidadAcciones++;
                        if (idioma == Idioma.Castellano)
                            detalleAcciones += $"<span>Símbolo Acción: {titulo.Simbolo}</span>";
                        else
                            detalleAcciones += $"<span>Stock Symbol: {titulo.Simbolo}</span>";
                    }
                    else if (titulo.Tipo == TipoTitulo.Bono)
                    {
                        cantidadBonos++;
                        if (idioma == Idioma.Castellano)
                            detalleBonos += $"<span>Símbolo Bono: {titulo.Simbolo}</span>";
                        else
                            detalleBonos += $"<span>Bond Symbol: {titulo.Simbolo}</span>";
                    }
                }

                returnString += ResumenTipoTitulo(TipoTitulo.Accion, cantidadAcciones, idioma, detalleAcciones);
                returnString += ResumenTipoTitulo(TipoTitulo.Bono, cantidadBonos, idioma, detalleBonos);
            }
            
            return returnString;
        }

        private static string ResumenTipoTitulo(TipoTitulo tipo, int cantidad, Idioma idioma, string detalle)
        {
            if (cantidad > 0)
            {
                if (idioma == Idioma.Castellano)
                    return $"Detalle de {cantidad} {TraducirTipoTitulo(tipo, cantidad, idioma)}<br/>{detalle}<br/>";
                else
                    return $"Detail of {cantidad} {TraducirTipoTitulo(tipo, cantidad, idioma)}<br/>{detalle}<br/>";
            }

            return string.Empty;
        }

        private static string TraducirTipoTitulo(TipoTitulo tipo, int cantidad, Idioma idioma)
        {
            switch (tipo)
            {
                case TipoTitulo.Accion:
                    if (idioma == Idioma.Castellano)
                        return cantidad == 1 ? "Acción" : "Acciones";
                    else
                        return cantidad == 1 ? "Stock" : "Stocks";
                case TipoTitulo.Bono:
                    if (idioma == Idioma.Castellano)
                        return cantidad == 1 ? "Bono" : "Bonos";
                    else
                        return cantidad == 1 ? "Bond" : "Bonds";
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }
        }
    }
}
