using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;


namespace FestivalCidade
{ 
	class Sistema
	{
		public string NomeFa { get; set; } = string.Empty;
        public int Dias { get; set; }
		public double PontosFidelidade { get; set; }
		public string CupomDesconto { get; set; } = string.Empty;

        public double CalcularCustoBruto()
		{
			double Taxa = 15;
			double CustoDia = 120;
			return Dias * CustoDia + Taxa;
		}
		public double CalcularDesconto()
		{
			if (CupomDesconto == "ROCK10")
			{
				return CalcularCustoBruto() - (CalcularCustoBruto() * 0.1);
			}
			else
			{
				return CalcularCustoBruto();
			}
		}
		public bool AcessoVip()
		{
			if (Dias > 2 && PontosFidelidade >= 500)
			{
				return true;
			}
			else {
				return false;
			}
		}
	}
}
