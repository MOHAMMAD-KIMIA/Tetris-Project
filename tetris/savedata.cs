// ﻿using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Windows;
// using System.Data.SqlClient;

// namespace tetris
// {
//     public partial class savedata
//     {
//         private void save_Click(object sender, RoutedEventArgs e)
//         {
//             string connectionString =
//                 @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tetris\tetris\Tetris.mdf;Integrated Security=True";

//             try
//             {
//                 using (SqlConnection conn = new SqlConnection(connectionString))
//                 {
//                     conn.Open();

//                     string query = "INSERT INTO UserTab VALUES (@score)";

//                     using (SqlCommand comm = new SqlCommand(query, conn))
//                     {
//                         comm.Parameters.AddWithValue(
//                             "@score",
//                             $"Score: {gameState.Score}"
//                         );

//                         comm.ExecuteNonQuery();
//                     }
//                 }

//                 MessageBox.Show(
//                     "Score saved successfully!",
//                     "Success",
//                     MessageBoxButton.OK,
//                     MessageBoxImage.Information
//                 );
//             }
//             catch (Exception ex)
//             {
//                 MessageBox.Show(
//                     $"Failed to save score:\n{ex.Message}",
//                     "Database Error",
//                     MessageBoxButton.OK,
//                     MessageBoxImage.Error
//                 );
//             }
//         }
//     }
// }


namespace tetris
{
    public partial class savedata
    {
    }
}

