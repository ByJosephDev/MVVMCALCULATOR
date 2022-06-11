using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MVVMCalculator.Views
{	
	public partial class Calculator : ContentPage
	{	
		public Calculator ()
		{
			InitializeComponent ();
			this.BindingContext = new MVVMCalculator.ViewModels.CalculatorViewModel();
		}
	}
}

