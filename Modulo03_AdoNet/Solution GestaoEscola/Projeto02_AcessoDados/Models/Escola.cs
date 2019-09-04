using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.Models
{
	public class Escola
	{
		public string DescricaoEscola { get; set; }
		public string Endereco { get; set; }
		public int Id { get; set; }
		public string Telefone { get; set; }

        public List<Curso> Cursos { get; set; }

	}
}
