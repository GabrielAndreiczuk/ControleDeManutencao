using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class TelaOrdensAberto : Form
    {
        public TelaOrdensAberto()
        {
            InitializeComponent();
            AdicionarComponentes();
        }

        private void AdicionarComponentes()
        {
            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
            List<string> ordens = new List<string>();
            

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT ID_Abertura from abertura_ordem";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordens.Add(reader["ID_Abertura"].ToString());
                        }
                    }
                }                                      
            }
            int yOffset = 10;

            foreach (var id in ordens)
            {
                Label label = new Label()
                {
                    Text = $"ID: {id}",
                    Location = new System.Drawing.Point(10, yOffset),
                    AutoSize = true
                };
                this.panel3.Controls.Add(label);
                yOffset += 30;
            }
        }
    }
}
