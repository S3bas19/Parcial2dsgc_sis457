using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadParcial2dsgc;

namespace ClnParcial2dsgc
{
	public class ClnSerie
	{
		public static int insertar(Serie serie)
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				context.Serie.Add(serie);
				context.SaveChanges();
				return serie.id;
			}
		}
		public static int actualizar(Serie serie)
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				var existente = context.Serie.Find(serie.id);
				existente.titulo = serie.titulo;
				existente.director = serie.director;
				existente.sinopsis = serie.sinopsis;
				existente.episodios = serie.episodios;
				existente.fechaEstreno = serie.fechaEstreno;
				existente.tipoClasificacion = serie.tipoClasificacion;
				return context.SaveChanges();
			}
		}
		public static int eliminar(int id)
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				var series = context.Serie.Find(id);
				series.estado = -1;
				return context.SaveChanges();
			}
		}
		public static Serie obtenerUno(int id)
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				return context.Serie.Find(id);
			}
		}
		public static List<Serie> listar()
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				return context.Serie.Where(x => x.estado != -1).ToList();
			}
		}
		public static List<paSerieListar_Result> listarPa(string parametro)
		{
			using (var context = new Parcial2dsgcEntities1())
			{
				return context.paSerieListar(parametro).ToList();
			}
		}
	}
}
