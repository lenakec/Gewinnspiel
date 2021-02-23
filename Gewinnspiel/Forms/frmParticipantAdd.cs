using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Gewinnspiel.Classes;

namespace Gewinnspiel.Forms
{
    public partial class frmParticipantAdd : Form
    {
        public frmParticipantAdd()
        {
            InitializeComponent();
        }

        #region Variablen
        internal string user, passsword, pwCode;
        internal bool foundUser;
        DateTime minus16Y;
        #endregion

        private void frmParticipantAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtPasswort.PasswordChar == '*')
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtVorname.Text.Equals("")|| txtZuname.Text.Equals("") || txtEmail.Text.Equals("") || txtPasswort.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Vorname, Zuname, Email als auch Passwort aus!");
                return;
            }
            if(cBGender.SelectedIndex == -1)
            {
                MessageBox.Show("bitte wählen Sie Ihr Geschlecht aus");
                return;
            }

            minus16Y = DateTime.Now.AddYears(-16);
            if(dateTimePicker1.Value.Date > minus16Y)
            {
                MessageBox.Show("Bitte wählen Sie Ihr Geburtsdatum aus, Sie müssen mindestens 16 Jahre alt sein!");
                return;
            }

            try
            {
                pwCode = frmLogin.frmLog.verschluesselnSHA512(txtPasswort.Text);

                Participant p = new Participant();
                p.LastName = txtVorname.Text;
                p.FirstName = txtZuname.Text;
                p.Email = txtEmail.Text;
                p.Password = pwCode;
                p.DateOfBirth = dateTimePicker1.Value;
                p.Gender = Convert.ToChar(cBGender.Text);
                p.Admin = false;
                p.Inactive = false;

                frmLogin.frmLog.participants.Add(p);
                frmLogin.frmLog.serializeParticipants();

                MessageBox.Show("Registrieren erfolgreich");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
