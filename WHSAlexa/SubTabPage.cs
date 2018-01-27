using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.WindowsServerSolutions.Administration.ObjectModel;

namespace WHSAlexa
{
    public class SubTabPage : ControlRendererPage
    {
        public SubTabPage()
            : base(new Guid("60287c06-267f-4d4f-bef9-bb52b9c76799"), // Put your fixed, static guid here
                   "WHSAlexa",
                   "Alexa Addin for Windows Server Essentials")
        {
        }

        protected override ControlRendererPageContent CreateContent()
        {
            return ControlRendererPageContent.Create(new WHSAlexaControl());
        }
    }
}
