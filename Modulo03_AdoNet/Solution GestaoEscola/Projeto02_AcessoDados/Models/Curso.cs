using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.Models
{
	public class Curso
	{
		public int Codigo { get; set; }
		public int CargaHoraria { get; set; }
		public double Preco { get; set; }
		public string DescricaoCurso { get; set; }

        public Escola EscolaInfo { get; set; }


	}
}
