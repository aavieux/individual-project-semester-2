using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
	public partial class userView : Form
	{
		int userId;
		public userView(int userId)
		{
			this.userId = userId;
			InitializeComponent();
			DisplayContent();
		}
		private void DisplayContent()
		{
			listBox1.Items.Clear();
			listBox1.Items.Add(GetStudentFromLocal(userId).GetFullName());
		}
	}
}
