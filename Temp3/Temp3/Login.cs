using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Login : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label moviecast;
        private CheckBox afieaza;
        private DatabaseConnection dbConnection;
        public Login ( )
        {
            InitializeComponent ();
            this.FormBorderStyle = FormBorderStyle.None;
            string connectionString = "Data Source=localhost; Initial Catalog=IMDB; Integrated Security=SSPI;";
            dbConnection = new DatabaseConnection (connectionString);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.utilizatorText = new System.Windows.Forms.TextBox();
            this.parolaText = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.numeUtilizator = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.moviecast = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.afieaza = new System.Windows.Forms.CheckBox();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // utilizatorText
            // 
            this.utilizatorText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utilizatorText.Location = new System.Drawing.Point(303, 147);
            this.utilizatorText.Name = "utilizatorText";
            this.utilizatorText.Size = new System.Drawing.Size(200, 20);
            this.utilizatorText.TabIndex = 0;
            // 
            // parolaText
            // 
            this.parolaText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.parolaText.Location = new System.Drawing.Point(303, 204);
            this.parolaText.Name = "parolaText";
            this.parolaText.Size = new System.Drawing.Size(200, 20);
            this.parolaText.TabIndex = 1;
            this.parolaText.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(338, 268);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 30);
            this.login.TabIndex = 2;
            this.login.Text = "Conecteaza-te";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // numeUtilizator
            // 
            this.numeUtilizator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.numeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeUtilizator.ForeColor = System.Drawing.Color.Black;
            this.numeUtilizator.Location = new System.Drawing.Point(177, 146);
            this.numeUtilizator.Name = "numeUtilizator";
            this.numeUtilizator.Size = new System.Drawing.Size(120, 20);
            this.numeUtilizator.TabIndex = 1;
            this.numeUtilizator.Text = "Nume utilizator:";
            this.numeUtilizator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parola
            // 
            this.parola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.parola.BackColor = System.Drawing.Color.Transparent;
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.ForeColor = System.Drawing.Color.Black;
            this.parola.Location = new System.Drawing.Point(218, 204);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(79, 20);
            this.parola.TabIndex = 2;
            this.parola.Text = "Parola:";
            this.parola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(215, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(363, 68);
            this.title.TabIndex = 3;
            this.title.Text = "Autentificare";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Firebrick;
            this.titleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleBar.Controls.Add(this.moviecast);
            this.titleBar.Controls.Add(this.exit);
            this.titleBar.Controls.Add(this.minimize);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(816, 40);
            this.titleBar.TabIndex = 4;
            // 
            // moviecast
            // 
            this.moviecast.BackColor = System.Drawing.Color.Maroon;
            this.moviecast.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviecast.ForeColor = System.Drawing.Color.White;
            this.moviecast.Location = new System.Drawing.Point(-5, -12);
            this.moviecast.Name = "moviecast";
            this.moviecast.Size = new System.Drawing.Size(162, 59);
            this.moviecast.TabIndex = 3;
            this.moviecast.Text = "Movie Cast";
            this.moviecast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Firebrick;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(771, 3);
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
            this.minimize.Location = new System.Drawing.Point(716, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 30);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // afieaza
            // 
            this.afieaza.AutoSize = true;
            this.afieaza.BackColor = System.Drawing.Color.Transparent;
            this.afieaza.Location = new System.Drawing.Point(303, 230);
            this.afieaza.Name = "afieaza";
            this.afieaza.Size = new System.Drawing.Size(98, 17);
            this.afieaza.TabIndex = 5;
            this.afieaza.Text = "Afiseaza parola";
            this.afieaza.UseVisualStyleBackColor = false;
            this.afieaza.CheckedChanged += new System.EventHandler(this.afieaza_CheckedChanged);
            // 
            // Login
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.afieaza);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.title);
            this.Controls.Add(this.utilizatorText);
            this.Controls.Add(this.numeUtilizator);
            this.Controls.Add(this.parolaText);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void afieaza_CheckedChanged ( object sender, EventArgs e )
        {
            parolaText.UseSystemPasswordChar = !afieaza.Checked;
        }
        private void login_Click ( object sender, EventArgs e )
        {
            string username = utilizatorText.Text;
            string password = parolaText.Text;

            try
            {
                string query = @"SELECT COUNT(*) FROM Users WHERE user_name = @username AND user_pass = @password";

                SqlParameter [ ] parameters = new SqlParameter [ ]
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                int userCount = ( int ) dbConnection.ExecuteScalar (query, parameters);

                if ( userCount > 0 )
                {
                    Client Client = new Client ();
                    Client.Show ();
                    this.Hide ();
                }
                else
                {
                    MessageBox.Show ("Nume utilizator sau parola incorecte!", "Autentificarea a esuat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show ("Eroare la conectarea cu baza de date: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exit_Click ( object sender, EventArgs e )
        {
            Application.Exit ();
        }
        private void minimize_Click ( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private TextBox utilizatorText;
        private TextBox parolaText;
        private Button login;
        private Label numeUtilizator;
        private Label title;
        private Label parola;
        private Panel titleBar;
        private Button exit;
        private Button minimize;
    }
}
