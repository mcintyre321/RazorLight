using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorLight.Tests
{
	public class TestViewModel
	{
        [Display(Name = "The Title")]
		public string Title { get; set; } = "wefefwef";
	}
}
