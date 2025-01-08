using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace IMDB
{
    partial class Client
    {
        private System.ComponentModel.IContainer components = null;
        public Client ( )
        {
            InitializeComponent ();
            this.FormBorderStyle = FormBorderStyle.None;
            string connection = "Data Source=localhost; Initial Catalog=IMDB; Integrated Security=SSPI;"; 
            dbConnection = new DatabaseConnection (connection);
        }
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.leftbar = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.fisiere = new System.Windows.Forms.Button();
            this.utilizatori = new System.Windows.Forms.Button();
            this.actori = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.leftbar.SuspendLayout();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftbar
            // 
            this.leftbar.BackColor = System.Drawing.Color.PeachPuff;
            this.leftbar.Controls.Add(this.logout);
            this.leftbar.Controls.Add(this.fisiere);
            this.leftbar.Controls.Add(this.utilizatori);
            this.leftbar.Controls.Add(this.actori);
            this.leftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftbar.Location = new System.Drawing.Point(0, 59);
            this.leftbar.Name = "leftbar";
            this.leftbar.Size = new System.Drawing.Size(162, 501);
            this.leftbar.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.PeachPuff;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(0, 425);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(162, 76);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // fisiere
            // 
            this.fisiere.BackColor = System.Drawing.Color.PeachPuff;
            this.fisiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.fisiere.FlatAppearance.BorderSize = 0;
            this.fisiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fisiere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fisiere.ForeColor = System.Drawing.Color.Black;
            this.fisiere.Image = ((System.Drawing.Image)(resources.GetObject("fisiere.Image")));
            this.fisiere.Location = new System.Drawing.Point(0, 179);
            this.fisiere.Name = "fisiere";
            this.fisiere.Size = new System.Drawing.Size(162, 93);
            this.fisiere.TabIndex = 1;
            this.fisiere.Text = "Fisiere";
            this.fisiere.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fisiere.UseVisualStyleBackColor = false;
            this.fisiere.Click += new System.EventHandler(this.fisiere_Click);
            // 
            // utilizatori
            // 
            this.utilizatori.BackColor = System.Drawing.Color.PeachPuff;
            this.utilizatori.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilizatori.FlatAppearance.BorderSize = 0;
            this.utilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilizatori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.utilizatori.ForeColor = System.Drawing.Color.Black;
            this.utilizatori.Image = ((System.Drawing.Image)(resources.GetObject("utilizatori.Image")));
            this.utilizatori.Location = new System.Drawing.Point(0, 88);
            this.utilizatori.Name = "utilizatori";
            this.utilizatori.Size = new System.Drawing.Size(162, 91);
            this.utilizatori.TabIndex = 2;
            this.utilizatori.Text = "Utilizatori";
            this.utilizatori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.utilizatori.UseVisualStyleBackColor = false;
            this.utilizatori.Click += new System.EventHandler(this.utilizatori_Click);
            // 
            // actori
            // 
            this.actori.BackColor = System.Drawing.Color.PeachPuff;
            this.actori.Dock = System.Windows.Forms.DockStyle.Top;
            this.actori.FlatAppearance.BorderSize = 0;
            this.actori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.actori.ForeColor = System.Drawing.Color.Black;
            this.actori.Image = ((System.Drawing.Image)(resources.GetObject("actori.Image")));
            this.actori.Location = new System.Drawing.Point(0, 0);
            this.actori.Name = "actori";
            this.actori.Size = new System.Drawing.Size(162, 88);
            this.actori.TabIndex = 3;
            this.actori.Text = "Actori";
            this.actori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.actori.UseVisualStyleBackColor = false;
            this.actori.Click += new System.EventHandler(this.actori_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.MistyRose;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(162, 59);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(689, 501);
            this.content.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.Firebrick;
            this.topbar.Controls.Add(this.title);
            this.topbar.Controls.Add(this.exit);
            this.topbar.Controls.Add(this.minimize);
            this.topbar.Controls.Add(this.maximize);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(851, 59);
            this.topbar.TabIndex = 2;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Maroon;
            this.title.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 59);
            this.title.TabIndex = 0;
            this.title.Text = "Movie Cast";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Firebrick;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(799, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 30);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Firebrick;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(687, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 30);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Firebrick;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.maximize.ForeColor = System.Drawing.Color.White;
            this.maximize.Location = new System.Drawing.Point(743, 12);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(40, 30);
            this.maximize.TabIndex = 3;
            this.maximize.Text = "O";
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(851, 560);
            this.Controls.Add(this.content);
            this.Controls.Add(this.leftbar);
            this.Controls.Add(this.topbar);
            this.Name = "Client";
            this.leftbar.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void exit_Click ( object sender, EventArgs e )
        {
            Application.Exit ();
        }
        private void minimize_Click ( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void maximize_Click ( object sender, EventArgs e )
        {
            if ( this.WindowState == FormWindowState.Normal )
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void actori_Click ( object sender, EventArgs e )
        {
            this.content.Controls.Clear ();
            if ( actoriPan == null )
            {
                ConfigureActoriContent ();
            }
            this.content.Controls.Add (actoriPan);
            actoriPan.BringToFront ();
        }
        private void utilizatori_Click ( object sender, EventArgs e )
        {
            this.content.Controls.Clear ();
            if ( utilizatoriPan == null )
            {
                ConfigureUsersContent ();
            }
            this.content.Controls.Add (utilizatoriPan);
            utilizatoriPan.BringToFront ();
        }
        private void fisiere_Click ( object sender, EventArgs e )
        {
            this.content.Controls.Clear ();
            if ( fisierePan == null )
            {
                ConfigureFilesContent ();
            }
            this.content.Controls.Add (fisierePan);
            fisierePan.BringToFront ();
        }
        private void logout_Click ( object sender, EventArgs e )
        {
            Login login = new Login ();
            login.Show ();
            this.Hide ();
        }
        private void cautaActori_Click ( ComboBox comboFilme, CheckBox ordoneaza)
        {
            try
            {
                string movieTitle = comboFilme.Text.Trim ();
                if ( string.IsNullOrEmpty (movieTitle) )
                {
                    MessageBox.Show ("Introduceti un titlu.", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"SELECT m.movie_title, a.actor_name, a.played_role, a.role_type
                    FROM actors a
                    INNER JOIN movies m ON a.movie_id = m.movie_id
                    WHERE UPPER(m.movie_title) LIKE UPPER(@movie_title)
                    ORDER BY a.actor_name";

                if ( ordoneaza.Checked )
                {
                    query = @"SELECT m.movie_title, a.actor_name, a.played_role, a.role_type
                    FROM actors a
                    INNER JOIN movies m ON a.movie_id = m.movie_id
                    WHERE UPPER(m.movie_title) LIKE UPPER(@movie_title)
                    ORDER BY role_type, actor_name";
                }

                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@movie_title", $"%{movieTitle}%")
                };

                DataTable result = dbConnection.ExecuteQuery (query, parameters);
                PopulateActoriListView (result);
            }
            catch (Exception ex)
            {
                MessageBox.Show ("Eroare la cautarea actorilor: " + ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void adaugaUtil_Click ( ComboBox comboUtilizatori, TextBox id, TextBox nume, TextBox parola, DateTimePicker inregistrare, TextBox tara )
        {
            try
            {
                string query = @"INSERT INTO Users (user_name, user_pass, user_register_date, user_country_code) 
                               VALUES (@user_name, @user_pass, @user_register_date, @user_country_code)";
                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@user_id", id.Text),
                    new SqlParameter("@user_name", nume.Text),
                    new SqlParameter("@user_pass", parola.Text),
                    new SqlParameter("@user_register_date", inregistrare.Value),
                    new SqlParameter("@user_country_code", tara.Text)
                };

                dbConnection.ExecuteNonQuery (query, parameters);
                PopulateUserComboBox (comboUtilizatori);

                MessageBox.Show ("Utilizator adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la adăugarea utilizatorului: " + ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modificaUtil_Click ( ComboBox comboUtilizatori, TextBox id, TextBox nume, TextBox parola, TextBox tara )
        {
            try
            {
                string query = @"UPDATE Users 
                                SET user_name = @user_name, user_pass = @user_pass, user_country_code= @user_country_code
                                WHERE user_id = @user_id";

                string selectQuery = @"SELECT user_name, user_pass, user_country_code FROM Users WHERE user_id = @user_id";

                SqlParameter [ ] selectParams = new SqlParameter [ ]
                {
                    new SqlParameter("@user_id", id.Text)
                };

                var result = dbConnection.ExecuteQuery (selectQuery, selectParams);

                if ( result.Rows.Count == 0 )
                {
                    MessageBox.Show ("Utilizatorul nu a fost gasit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string currentUsername = result.Rows [ 0 ] [ "user_name" ].ToString ();
                string currentPassword = result.Rows [ 0 ] [ "user_pass" ].ToString ();
                string currentCountryCode = result.Rows [ 0 ] [ "user_country_code" ].ToString ();

                string username = string.IsNullOrEmpty (nume.Text) ? currentUsername : nume.Text;
                string password = string.IsNullOrEmpty (parola.Text) ? currentPassword : parola.Text;
                string countryCode = string.IsNullOrEmpty (tara.Text) ? currentCountryCode : tara.Text;

                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@user_id", id.Text),
                    new SqlParameter("@user_name", username),
                    new SqlParameter("@user_pass", password),
                    new SqlParameter("@user_country_code", countryCode)
                };

                dbConnection.ExecuteNonQuery (query, parameters);
                PopulateUserComboBox (comboUtilizatori);

                MessageBox.Show ("Utilizator modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la modificarea utilizatorului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void stergeUtil_Click ( ComboBox comboUtilizatori, TextBox id )
        {
            try
            {
                string query = @"DELETE FROM files WHERE uploader_id = @uploader_id";

                SqlParameter [ ] parametersFisiere = new SqlParameter [ ] { new SqlParameter ("@uploader_id", id.Text) };
                SqlParameter [ ] parametersUtil = new SqlParameter [ ] { new SqlParameter ("@user_id", id.Text) };

                dbConnection.ExecuteNonQuery (query, parametersFisiere);

                query = @"DELETE FROM users WHERE user_id = @user_id";

                dbConnection.ExecuteNonQuery (query, parametersUtil);
                PopulateUserComboBox (comboUtilizatori);

                MessageBox.Show ("Utilizator sters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la stergerea utilizatorului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void adaugaFisier_Click ( TextBox nume, TextBox dimensiune, TextBox tip, TextBox utilizator )
        {
            try
            {
                string query = @"INSERT INTO Files (file_name, file_size, file_type, uploader_id) 
                               VALUES (@file_name, @file_size, @file_type, @uploader_id)";
                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@file_name", nume.Text),
                    new SqlParameter("@file_size", dimensiune.Text),
                    new SqlParameter("@file_type", tip.Text),
                    new SqlParameter("@uploader_id", utilizator.Text)
                };

                dbConnection.ExecuteNonQuery (query, parameters);
                DataTable filesTable = dbConnection.ExecuteQuery ("SELECT * FROM Files", null);
                PopulateFilesList (filesTable);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la adăugarea fisierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modificaFisier_Click ( TextBox id, TextBox nume, TextBox dimensiune, TextBox tip, TextBox utilizator )
        {
            try
            {
                string query = @"UPDATE Files 
                                SET file_name = @file_name, file_size = @file_size, file_type = @file_type, uploader_id= @uploader_id
                                WHERE file_id = @file_id";

                string selectQuery = @"SELECT file_name, file_size, file_type, uploader_id FROM Files WHERE file_id = @file_id";

                SqlParameter [ ] selectParams = new SqlParameter [ ]
               {
                    new SqlParameter("@file_id", id.Text)
               };

                var result = dbConnection.ExecuteQuery (selectQuery, selectParams);

                if ( result.Rows.Count == 0 )
                {
                    MessageBox.Show ("Fisierul nu a fost gasit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string currentFileName = result.Rows [ 0 ] [ "file_name" ].ToString ();
                string currentFileSize = result.Rows [ 0 ] [ "file_size" ].ToString ();
                string currentFileType = result.Rows [ 0 ] [ "file_type" ].ToString ();
                string currentUploader = result.Rows [ 0 ] [ "uploader_id" ].ToString ();


                string fileName = string.IsNullOrEmpty (nume.Text) ? currentFileName : nume.Text;
                string fileSize = string.IsNullOrEmpty (dimensiune.Text) ? currentFileSize : dimensiune.Text;
                string fileType = string.IsNullOrEmpty (tip.Text) ? currentFileType : tip.Text;
                string uploader = string.IsNullOrEmpty (utilizator.Text) ? currentUploader : utilizator.Text;

                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@file_id", id.Text),
                    new SqlParameter("@file_name", fileName),
                    new SqlParameter("@file_size", fileSize),
                    new SqlParameter("@file_type", fileType),
                    new SqlParameter("@uploader_id", uploader)
                };

                dbConnection.ExecuteNonQuery (query, parameters);
                DataTable filesTable = dbConnection.ExecuteQuery ("SELECT * FROM Files", null);
                PopulateFilesList (filesTable);

                MessageBox.Show ("Fisier modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la modificarea fisierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void stergeFisier_Click ( TextBox id )
        {
            try
            {
                string query = @"DELETE FROM Files 
                                WHERE file_id = @file_id";

                SqlParameter [ ] parameters = new SqlParameter [ ] { new SqlParameter ("@file_id", id.Text) };

                dbConnection.ExecuteNonQuery (query, parameters);
                DataTable filesTable = dbConnection.ExecuteQuery ("SELECT * FROM Files", null);
                PopulateFilesList (filesTable);
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la stergerea fisierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel leftbar;
        private Panel content;
        private Panel topbar;
        private Label title;
        private Button exit;
        private Button minimize;
        private Button maximize;
        private Button actori;
        private Button utilizatori;
        private Button fisiere;
        private Button logout;

    }
}
