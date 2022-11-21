using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace szamlak
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
           
            connect = new MySqlConnection(builder.ConnectionString);

            try
            {
                //terv szerint
                connect.Open();
                cmd = connect.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //terv megbukott
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leált");
                Environment.Exit(0);
            }
            finally
            {
                connect.Close();
            }
            szamla_lista_update();
        }

        private void szamla_lista_update()
        {
            listBox1_adatok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`tulajdonosNeve`,`egyenleg`,`nyitasdatum` FROM `szamlak` ";
            connect.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    szamla uj = new szamla(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetDecimal("egyenleg"), dr.GetMySqlDateTime("nyitasdatum"));
                    listBox1_adatok.Items.Add(uj);
                }
                connect.Close();
            }

        }

        private void button1_new_Click(object sender, EventArgs e)
        {
            if (nincs_adat())
            {
                return;
            }

            cmd.CommandText = "INSERT INTO `szamlak`(`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`)  VALUES (NULL, @tulajdonosNeve, @egyenleg, @egyenleg);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBox1_tulajdonosNeve.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDown1_egyenleg.Text);
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker1_nyitasdatum.Text);
            connect.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeres adat rögzítés");
                    textBox1_id.Text = "";
                    textBox1_tulajdonosNeve.Text = "";
                    numericUpDown1_egyenleg.Value = numericUpDown1_egyenleg.Minimum;
                    dateTimePicker1_nyitasdatum.Text = "";

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connect.Close();
            szamla_lista_update();
        }

        private bool nincs_adat()
        {
            if (string.IsNullOrEmpty(textBox1_tulajdonosNeve.Text))
            {
                MessageBox.Show("Adjon meg a tulaj nevet");
                textBox1_tulajdonosNeve.Focus();
                return true;
            }
            if (numericUpDown1_egyenleg.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen egyenleg!");
                numericUpDown1_egyenleg.Value = numericUpDown1_egyenleg.Minimum;
                numericUpDown1_egyenleg.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(dateTimePicker1_nyitasdatum.Text))
            {
                MessageBox.Show("Nem adott meg dátumot!");
                textBox1_tulajdonosNeve.Focus();
                return true;
            }
            return false;
        }

        private void listBox1_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1_adatok.SelectedIndex < 0)
            {
                return;
            }
            szamla kivalasztott = (szamla)listBox1_adatok.SelectedItem;
            textBox1_id.Text = kivalasztott.Id.ToString();
            textBox1_tulajdonosNeve.Text = kivalasztott.TulajdonosNeve;
            numericUpDown1_egyenleg.Value = kivalasztott.Egyenleg;
            MySqlDateTime nyitasdatum = kivalasztott.Nyitasdatum;
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (listBox1_adatok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincsen kijelölve!");
            }
            szamla kivalasztott = (szamla)listBox1_adatok.SelectedItem;
            cmd.CommandText = "UPDATE `szamlak` SET tulajdonosNeve = @tulajdonosNeve, egyenleg = @egyenleg,nyitasdatum = @nyitasdatum WHERE id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", kivalasztott.Id);
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBox1_tulajdonosNeve.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDown1_egyenleg.Text);
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker1_nyitasdatum.Text);
            connect.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres");
                connect.Close();
                textBox1_id.Text = "";
                textBox1_tulajdonosNeve.Text = "";
                numericUpDown1_egyenleg.Value = numericUpDown1_egyenleg.Minimum;
                dateTimePicker1_nyitasdatum.Value = dateTimePicker1_nyitasdatum.MinDate;
                szamla_lista_update();
            }
            else
            {
                MessageBox.Show("Sikertelen adatmódosítás");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1_adatok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `szamlak` WHERE  id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox1_id.Text);

            connect.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A törlés sikeres!");
                connect.Close();
                textBox1_id.Text = "";
                textBox1_tulajdonosNeve.Text = ""; 
                numericUpDown1_egyenleg.Value = numericUpDown1_egyenleg.Minimum;
                dateTimePicker1_nyitasdatum.Value = dateTimePicker1_nyitasdatum.MinDate;
                szamla_lista_update();
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
        }
    }
}
