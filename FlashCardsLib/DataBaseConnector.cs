namespace FlashCardsLib
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Data.SqlClient;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;



	namespace DemoApplication1
	{
		public partial class Form1 : Form
		{
			public Form1()
			{
				InitializeComponent();
			}

			private void button1_Click(object sender, EventArgs e)
			{
				string connetionString;
				SqlConnection cnn;
				connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
				cnn = new SqlConnection(connetionString);
				cnn.Open();
				MessageBox.Show("Connection Open  !");
				cnn.Close();
			}
		}
	}
}