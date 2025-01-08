using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Client : Form
    {
        private DatabaseConnection dbConnection;
        private Panel actoriPan, utilizatoriPan, fisierePan;
        private ListView actoriListView, fisierelistView;
  
        private void ConfigureActoriContent ( )
        {
            actoriPan = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add (actoriPan);

            Label title = new Label
            {
                Text = "Actori",
                Font = new System.Drawing.Font ("Bernard MT Condensed", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (280, 20),
                AutoSize = true
            };
            actoriPan.Controls.Add (title);

            Label cautareLabel = new Label
            {
                Text = "Selecteaza un film:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 90),
                AutoSize = true
            };
            actoriPan.Controls.Add (cautareLabel);

            ComboBox comboFilme = new ComboBox
            {
                Location = new System.Drawing.Point (40, 120),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            actoriPan.Controls.Add (comboFilme);

            Label ordoneazaLabel = new Label
            {
                Text = "Ordoneaza dupa tipul rolului",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 150),
                AutoSize = true
            };
            actoriPan.Controls.Add (ordoneazaLabel);

            CheckBox ordoneaza = new CheckBox
            {
                Location = new System.Drawing.Point (210, 146),
                Width = 200
            };
            actoriPan.Controls.Add (ordoneaza);

            Button cautaActori = new Button
            {
                Text = "Cauta",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (300, 120),
                Width = 100
            };
            cautaActori.Click += ( s, e ) => cautaActori_Click (comboFilme, ordoneaza);
            actoriPan.Controls.Add (cautaActori);

            actoriListView = new ListView
            {
                Location = new System.Drawing.Point (40, 180),
                Size = new System.Drawing.Size (600, 250),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };

            actoriListView.Columns.Add ("Film", 200);
            actoriListView.Columns.Add ("Nume", 200);
            actoriListView.Columns.Add ("Personaj", 200);
            actoriListView.Columns.Add ("Rol", 100);

            actoriPan.Controls.Add (actoriListView);

            try
            {
                string select = @"SELECT m.movie_title, a.actor_name, a.played_role, a.role_type
                                 FROM actors a INNER JOIN movies m ON a.movie_id = m.movie_id
                                 ORDER BY m.movie_id";

                DataTable actori = dbConnection.ExecuteQuery (select, null);
                PopulateActoriListView (actori);
                PopulateActoriComboBox (comboFilme);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la afisarea actorilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateActoriComboBox (ComboBox comboFilme)
        {
            try
            { 
                string selectFilme = "SELECT DISTINCT movie_title FROM movies ORDER BY movie_title";
                DataTable filme = dbConnection.ExecuteQuery (selectFilme, null);
                foreach (DataRow row in filme.Rows)
                {
                    comboFilme.Items.Add(row [ "movie_title" ].ToString ( ));
                }

                if (comboFilme.Items.Count > 0)
                {
                    comboFilme.SelectedIndex = 0;
                }

                string selectActori = @"SELECT m.movie_title, a.actor_name, a.played_role, a.role_type
                                        FROM actors a INNER JOIN movies m ON a.movie_id = m.movie_id
                                        ORDER BY m.movie_id";

                DataTable actori = dbConnection.ExecuteQuery (selectActori, null);
                PopulateActoriListView (actori);
             }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afisarea actorilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        private void PopulateActoriListView ( DataTable actori )
        {
            actoriListView.Items.Clear ();

            foreach ( DataRow row in actori.Rows )
            {
                ListViewItem item = new ListViewItem (row [ "movie_title" ].ToString ());
                item.SubItems.Add (row [ "actor_name" ].ToString ());
                item.SubItems.Add (row [ "played_role" ].ToString ());                 
                item.SubItems.Add (row [ "role_type" ].ToString ());           
                         
                actoriListView.Items.Add (item);
            }
        }
        private void ConfigureUsersContent ( )
        {
            utilizatoriPan = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add (utilizatoriPan);

            Label utilTitle = new Label
            {
                Text = "Utilizatori",
                Font = new System.Drawing.Font ("Bernard MT Condensed", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (260, 20),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (utilTitle);

            Label title = new Label
            {
                Text = "Lista utilizatori:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (80, 80),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (title);

            ComboBox comboUtilizatori = new ComboBox
            {
                Location = new System.Drawing.Point (190, 80),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            utilizatoriPan.Controls.Add (comboUtilizatori);

            Label numeLabel = new Label
            {
                Text = "Nume utilizator:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (80, 120),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (numeLabel);

            TextBox nume = new TextBox
            {
                Location = new System.Drawing.Point (190, 120),
                Width = 200
            };
            utilizatoriPan.Controls.Add (nume);

            Label parolaLabel = new Label
            {
                Text = "Parola:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (80, 160),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (parolaLabel);

            TextBox parola = new TextBox
            {
                Location = new System.Drawing.Point (190, 160),
                Width = 200
            };
            utilizatoriPan.Controls.Add (parola);

            Label inregistrareLabel = new Label
            {
                Text = "Data inregistrare:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (80, 200),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (inregistrareLabel);

            DateTimePicker inregistrare = new DateTimePicker
            {
                Location = new System.Drawing.Point (190, 200),
                Width = 200,
                Format = DateTimePickerFormat.Long
            };
            utilizatoriPan.Controls.Add (inregistrare);

            Label taraLabel = new Label
            {
                Text = "Tara:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (80, 240),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (taraLabel);

            TextBox tara = new TextBox
            {
                Location = new System.Drawing.Point (190, 240),
                Width = 200
            };
            utilizatoriPan.Controls.Add (tara);

            Label idLabel = new Label
            {
                Text = "ID:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (100, 323),
                AutoSize = true
            };
            utilizatoriPan.Controls.Add (idLabel);

            TextBox id = new TextBox
            {
                Location = new System.Drawing.Point (150, 320),
                Width = 200
            };
            utilizatoriPan.Controls.Add (id);

            Button adaugaUtil = new Button
            {
                Text = "Adauga",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (180, 270),
                Width = 100
            };
            adaugaUtil.Click += ( s, e ) => adaugaUtil_Click (comboUtilizatori, id, nume, parola, inregistrare, tara);
            utilizatoriPan.Controls.Add (adaugaUtil);

            Button modificaUtil = new Button
            {
                Text = "Modifica",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (100, 360),
                Width = 100
            };
            modificaUtil.Click += ( s, e ) => modificaUtil_Click (comboUtilizatori, id, nume, parola, tara);
            utilizatoriPan.Controls.Add (modificaUtil);

            Button stergeUtil = new Button
            {
                Text = "Sterge",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (250, 360),
                Width = 100
            };
            stergeUtil.Click += ( s, e ) => stergeUtil_Click (comboUtilizatori, id);
            utilizatoriPan.Controls.Add (stergeUtil);

            PopulateUserComboBox (comboUtilizatori);
            comboUtilizatori.SelectedIndexChanged += ( s, e ) => LoadUserDetails (comboUtilizatori, id, nume, parola, inregistrare, tara);
        }
        private void PopulateUserComboBox ( ComboBox comboUtilizatori )
        {
            try
            {
                string query = "SELECT user_name FROM Users"; 
                DataTable utilizatori = dbConnection.ExecuteQuery (query);

                comboUtilizatori.Items.Clear ();

                foreach ( DataRow row in utilizatori.Rows )
                {
                    comboUtilizatori.Items.Add (row [ "user_name" ].ToString ());
                }

                if ( comboUtilizatori.Items.Count > 0 )
                {
                    comboUtilizatori.SelectedIndex = 0; 
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la încărcarea utilizatorilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUserDetails ( ComboBox comboUtilizatori, TextBox id, TextBox nume, TextBox parola, DateTimePicker inregistrare, TextBox tara )
        {
            if ( comboUtilizatori.SelectedItem == null ) return;

            try
            {
                string selectedUsername = comboUtilizatori.SelectedItem.ToString ();
                string query = "SELECT * FROM Users WHERE user_name = @user_name";
                SqlParameter [ ] parameters = { new SqlParameter("@user_name", selectedUsername) };

                DataTable userDetails = dbConnection.ExecuteQuery (query, parameters);

                if ( userDetails.Rows.Count > 0 )
                {
                    DataRow row = userDetails.Rows [ 0 ];
                    id.Text = row [ "user_id" ].ToString ();
                    nume.Text = row [ "user_name" ].ToString ();
                    parola.Text = row [ "user_pass" ].ToString ();
                    inregistrare.Value = DateTime.Parse (row [ "user_register_date" ].ToString ());
                    tara.Text = row [ "user_country_code" ].ToString ();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la încărcarea detaliilor utilizatorului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateFilesList ( DataTable filesTable )
        {

            fisierelistView.Items.Clear ();

            foreach ( DataRow row in filesTable.Rows )
            {
                ListViewItem item = new ListViewItem (row [ "file_id" ].ToString ());
                item.SubItems.Add (row [ "file_name" ].ToString ());
                item.SubItems.Add (row [ "file_size" ].ToString ());
                item.SubItems.Add (row [ "file_type" ].ToString ());
                item.SubItems.Add (row [ "uploader_id" ].ToString ());

                fisierelistView.Items.Add (item);
            }
        }
        private void ConfigureFilesContent ( )
        {
            fisierePan = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add (fisierePan);

            Label title = new Label
            {
                Text = "Lista Fisere",
                Font = new System.Drawing.Font ("Bernard MT Condensed", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (240, 20),
                AutoSize = true
            }; 
            fisierePan.Controls.Add (title);

            Label numeLabel = new Label
            {
                Text = "Nume fisier:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 80),
                AutoSize = true
            };
            fisierePan.Controls.Add (numeLabel);

            TextBox nume = new TextBox
            {
                Location = new System.Drawing.Point (130, 80),
                Width = 200
            };
            fisierePan.Controls.Add (nume);

            Label dimensiuneLabel = new Label
            {
                Text = "Dimensiune:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 120),
                AutoSize = true
            };
            fisierePan.Controls.Add (dimensiuneLabel);

            TextBox dimensiune = new TextBox
            {
                Location = new System.Drawing.Point (130, 120),
                Width = 200
            };
            fisierePan.Controls.Add (dimensiune);

            Label tipLabel = new Label
            {
                Text = "Tip fisier:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 160),
                AutoSize = true
            };
            fisierePan.Controls.Add (tipLabel);

            TextBox tip = new TextBox
            {
                Location = new System.Drawing.Point (130, 160),
                Width = 200
            };
            fisierePan.Controls.Add (tip);

            Label utilizatorLabel = new Label
            {
                Text = "ID uploader:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 200),
                AutoSize = true
            };
            fisierePan.Controls.Add (utilizatorLabel);

            TextBox utilizator = new TextBox
            {
                Location = new System.Drawing.Point (130, 200),
                Width = 200
            };
            fisierePan.Controls.Add (utilizator);

            Label idLabel = new Label
            {
                Text = "ID fisier:",
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (40, 240),
                AutoSize = true
            };
            fisierePan.Controls.Add (idLabel);

            TextBox id = new TextBox
            {
                Location = new System.Drawing.Point (130, 240),
                Width = 200
            };
            fisierePan.Controls.Add (id);

            Button adaugaFisier = new Button
            {
                Text = "Adauga",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (350, 100),
                Width = 100
            };
            adaugaFisier.Click += ( s, e ) => adaugaFisier_Click (nume, dimensiune, tip, utilizator);
            fisierePan.Controls.Add (adaugaFisier);

            Button modificaFisier = new Button
            {
                Text = "Modifica",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (350, 240),
                Width = 100
            };
            modificaFisier.Click += ( s, e ) => modificaFisier_Click (id, nume, dimensiune, tip, utilizator);
            fisierePan.Controls.Add (modificaFisier);

            Button stergeFisier = new Button
            {
                Text = "Sterge",
                BackColor = System.Drawing.Color.Thistle,
                Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0))),
                Location = new System.Drawing.Point (460, 240),
                Width = 100
            };
            stergeFisier.Click += ( s, e ) => stergeFisier_Click (id);
            fisierePan.Controls.Add (stergeFisier);

            fisierelistView = new ListView
            {
                Location = new System.Drawing.Point (20, 280),
                Size = new System.Drawing.Size (540, 180),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };

            fisierelistView.Columns.Add ("ID Fisier", 100);
            fisierelistView.Columns.Add ("Nume Fisier", 150);
            fisierelistView.Columns.Add ("Dimensiune", 100);
            fisierelistView.Columns.Add ("Tip", 100);
            fisierelistView.Columns.Add ("ID Utilizator", 100);

            fisierePan.Controls.Add (fisierelistView);
            try
            {
                DataTable filesTable = dbConnection.ExecuteQuery ("SELECT * FROM Files", null);
                PopulateFilesList (filesTable);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la afisarea fisierelor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
