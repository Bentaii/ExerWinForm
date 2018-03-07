using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkInterface interfaceReseau = TrouverInterfaceRéseauEthernet();
            PhysicalAddress adressePhysique = interfaceReseau.GetPhysicalAddress();
            string[] mac = (from octet in adressePhysique.GetAddressBytes()
                            select octet.ToString("X2")).ToArray();

            string adressseMacFormattée = string.Join(":", mac);
            textBoxInfos.Text = "MAC".PadRight(33)
                + "Status".PadRight(11)
                + "Nom".PadRight(31)
                + "Vitesse".PadRight(26)
                + "Type".PadRight(21)
                + "Description".PadRight(51) + "\n" 
                + $"{adressseMacFormattée,-24} " +
                $"{interfaceReseau.OperationalStatus,-11} " +
                $"{ interfaceReseau.Name,-29} " +
                $"{interfaceReseau.Speed/125000000L + "Gbps",-25} " +
                $"{interfaceReseau.NetworkInterfaceType, -18} " +
                $"{interfaceReseau.Description,-50}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PingReply reponse;
            if (textBoxEntreeAdresse.Text != "")
            {
                TesterPing(textBoxEntreeAdresse.Text, out reponse);
                textBoxInfosCommandes.AppendLine($"Ping sur {reponse.Address} ({textBoxEntreeAdresse.Text}): {reponse.Status}");
            }
        }

        static NetworkInterface TrouverInterfaceRéseauEthernet()
        {
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    string passerelles = String.Join(",", n.GetIPProperties().GatewayAddresses.ToList().Select(m => m.Address.ToString()).ToArray());
                    if (passerelles != String.Empty)
                        return n;
                }
            }
            return null;
        }
        bool TesterPing(string nom, out PingReply reponse)
        {
            Ping question = new Ping();
            reponse = question.Send(nom);
            return true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxInfosCommandes.Clear();
        }
    }
    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
