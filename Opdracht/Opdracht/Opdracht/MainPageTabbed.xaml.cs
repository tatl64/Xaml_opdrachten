﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.Tabbed_Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageTabbed : TabbedPage
	{
		public MainPageTabbed ()
		{
			InitializeComponent ();

            new NavigationPage(new FotoOpdracht());
		}
	}
}