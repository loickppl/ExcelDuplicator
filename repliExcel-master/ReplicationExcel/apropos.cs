using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ReplicationExcel
{
    public partial class apropos : Form
    {
        Point pb_loc;
        bool displayed_version_or_buid = true;

        string build_info = "";
        string version_info = "";
        

        // Ajoute le lien pour le label "souvez nous"
        // Initialise les positions des composants
        // Définit les infos de buid et version
        public apropos()
        {
            InitializeComponent();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/schupbachl/ATPROJ_IFAP3B_G1";
            git_link.Links.Add(link);

            pb_loc = pictureBox1.Location;

            build_info = "swaggance@team " + String.Format("{0:F}", RetrieveLinkerTimestamp());
            version_info = "4.2.0 Absolute swaggence";
        }

        // Calcule l'emplacement des composants en fonction de la taille de la fenêtre
        // et leurs assigne lerus nouvel taille/position
        void RelocateComponent()
        {
            pb_loc.Y = (ClientSize.Height - pictureBox1.Size.Height) / 2;
            pictureBox1.Location = pb_loc;

            Size s = lblSynopsis.MaximumSize;
            s.Width = Width - 350;
            lblSynopsis.MaximumSize = s;
        }

        // Place les composant et la fenêtre lors de son ouverture
        private void apropos_Load(object sender, EventArgs e)
        {
            RelocateComponent();
            CenterToParent();
        }

        // Récupère la date de build de l'application
        // copyright Jeff Atwood, http://blog.codinghorror.com/determining-build-date-the-hard-way/
        private DateTime RetrieveLinkerTimestamp()
        {
            string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            byte[] header_content = new byte[2048];
            Stream executable_stream = null;

            executable_stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            executable_stream.Read(header_content, 0, 2048);

            int offset = BitConverter.ToInt32(header_content, c_PeHeaderOffset);
            int secs_since_1970 = BitConverter.ToInt32(header_content, offset + c_LinkerTimestampOffset);

            DateTime build_date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            build_date = build_date.AddSeconds(secs_since_1970);
            build_date = build_date.ToLocalTime();

            return build_date;
        }

        // Ouvre le lien lors du click de l'utilisateur
        private void git_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        // Ferme la boîte si l'utilisateur presse la touche escape
        private void apropos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
                Close();
        }

        // Repositionne les composants lorsque la fenêtre change de taille
        private void apropos_SizeChanged(object sender, EventArgs e)
        {
            RelocateComponent();
        }

        // Change l'affichage entre version et build lors du click de l'utilisateur
        private void lblVersion_Click(object sender, EventArgs e)
        {

            lblVersion.Text = displayed_version_or_buid ? build_info : version_info;
            displayed_version_or_buid = !displayed_version_or_buid;

            int lblVersionBoundRight = lblVersion.Size.Width + lblVersion.Location.X;

            if (lblVersionBoundRight > MinimumSize.Width)
                MinimumSize = new Size(lblVersionBoundRight + 20, MinimumSize.Height);
            else
                MinimumSize = new Size(650, MinimumSize.Height);
        }
    }
}
