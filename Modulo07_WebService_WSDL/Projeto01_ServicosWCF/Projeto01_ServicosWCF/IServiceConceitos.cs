using Projeto01_ServicosWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projeto01_ServicosWCF
{
	[ServiceContract]
	public interface IServiceConceitos
	{
		[OperationContract]
		List<Aluno> ListarAlunos();

		[OperationContract]
		void AdicionarAluno(Aluno aluno);

		//Métodos adicionais
		[OperationContract]
		List<string> ListarNome();

		[OperationContract]
		double CalcularSoma(double x, double y);



	}

}
