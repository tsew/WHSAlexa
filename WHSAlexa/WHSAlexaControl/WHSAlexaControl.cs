using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsServerSolutions.NetworkHealth.AlertFramework;

namespace WHSAlexa
{
    public partial class WHSAlexaControl : UserControl
    {
        LocalAlertManager lam;
        ReadOnlyAlertCollection alerts;

        public WHSAlexaControl()
        {
            InitializeComponent();
            GetAlerts();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GetAlerts();
        }

        private void GetAlerts()
        {
            listBox1.Items.Clear();
            
            lam = new LocalAlertManager();
            lam.GetAllLocalAlerts();
            alerts = lam.AlertCollection;

            foreach (var alert in alerts)
            {
                var alertInfo = alert.HealthDefinitionTitle;
                if (!alert.HealthDefinitionName.EndsWith("Info"))
                    listBox1.Items.Add(alertInfo);
            }


        }
    }
}
