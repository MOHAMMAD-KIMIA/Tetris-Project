using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tetris
{
    public partial class savedata
    {
        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm; 
            SqlDataReader dreader;
            conn = new SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tetris\tetris\Tetris.mdf;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("insert into UserTab values (@score", conn);
            comm.Parameters.AddWithValue("@score", $"Score: { gameState.Score}");
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
