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
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Gewinnspiel.Forms
{
    public partial class frmLogin : Form
    {
        internal static frmLogin frmLog;

        public frmLogin()
        {
            frmLog = this;
            InitializeComponent();
        }

        #region Variablen
        internal string user, password, pwCode;
        internal bool foundUser;
        
        internal List<Participant> participants;

        XmlSerializer serializer;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            participants = new List<Participant>();
            serializer = new XmlSerializer(participants.GetType());
            deserializeParticipants();
            Participant.Autonum = lastID() + 1;
        }

        internal String verschluesselnSHA512(string text)
        {
            string temp;
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(text);
            byte[] result = sha512.ComputeHash(textToHash);
            temp = System.BitConverter.ToString(result);
            return temp;
        }

        internal int lastID()
        {
            int temp = 0;
            foreach(Participant p in participants)
            {
                if (p.PId > temp)
                {
                    temp = p.PId;
                }  
            }
            return temp + 1;
        }

        internal void serializeParticipants()
        {
            try
            {
                FileStream fs = new FileStream("participants.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(fs, participants);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisieren: " + ex.Message);
            }
        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            pwCode = verschluesselnSHA512(txtPasswort.Text);

            foreach (Participant p in participants)
            {
                if (p.Email.Equals(txtBenutzer.Text) && p.Password.Equals(pwCode))
                {
                    foundUser = true;
                    txtBenutzer.Clear();
                    txtPasswort.Clear();

                    if (p.Admin)
                    {
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Text = "Du bist eingeloggt als " + p.FirstName + " " + p.LastName + ", du bist Admin";
                        frmAdmin.ShowDialog();
                    }
                    else
                    {
                        frmParticipant frmPart = new frmParticipant();
                        frmPart.Text = "Du bist eingeloggt als " + p.FirstName + " " + p.LastName;
                        frmPart.ShowDialog();
                    }
                    break;
                }
            }

            if (foundUser == false)
            {
                MessageBox.Show("Falsche Email-Adresse oder falsches Passwort.");
                return;
            }

            else
            {
                foundUser = false;
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtPasswort.PasswordChar == '*')
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';
        }

        private void txtPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        internal void deserializeParticipants()
        {
            try
            {
                FileStream fs = new FileStream("participants.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                participants = (List<Participant>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisieren: " + ex.Message);
            }
        }

        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            if (txtBenutzer.Text.Equals("") || txtPasswort.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Benutzer als auch Passwort aus!");
                return;
            }
            
            foreach(Participant p in participants)
            {
                if(txtBenutzer.Text.Equals(p.Email))
                {
                    MessageBox.Show("Diese Email-Adresse ist bereits registriert");
                    return;
                }
            }

            frmParticipantAdd frmAdd = new frmParticipantAdd();
            frmAdd.txtEmail.Text = txtBenutzer.Text;
            frmAdd.txtPasswort.Text = txtPasswort.Text;
            frmAdd.txtID.Text = Participant.Autonum.ToString();
            frmAdd.Show();
        }
    }
}
