/* Copyright 2018 Tate M. Walker, Kayla M. Barden

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

      http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;


namespace PasswordManager
{
    public partial class frmPasswordMgr : Form
    {
        public frmPasswordMgr()
        {
            InitializeComponent();
        }

        IRestResponse response;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewWebsite.Text))
            {
                // New Website textbox is empty.
                MessageBox.Show("You must enter a website.");
                txtNewWebsite.Focus();
            }
            else if(string.IsNullOrEmpty(txtWord.Text))
            {
                // Word textbook is empty
                MessageBox.Show("You must enter a word in order to generate a password.");
                txtWord.Focus();
            }
            else
            {
                // All the textboxes are filled in.
                string strNewWebsite = txtNewWebsite.Text;
                string strColor = cboColor.Text;
                string strWord = txtWord.Text;

                // sending request
                var client = new RestClient("http://10.231.154.214:5000/set-password?website=" + strNewWebsite + "&base=" + strWord + "&color=" + strColor);
                var request = new RestRequest(Method.GET);
                request.AddHeader("Postman-Token", "340ea6d0-e6bd-c8ce-ccfb-7409970fd14e");
                request.AddHeader("Cache-Control", "no-cache");
                IRestResponse response = client.Execute(request);
                

                var obj = JObject.Parse(response.Content);
                var password = (string)obj["password"];
                //Console.WriteLine(o.password);

                txtPassword.Text = password;
                txtWebPassword.Text = strNewWebsite;

                //Clear fields
                txtNewWebsite.Clear();
                txtWord.Clear();

                //generate new combo box items
                cboColor.Items.Clear();

                
                int color;
                string[] lineOfContents = File.ReadAllLines("//blender/homes/k/_/k_barden97/nt/TAMUHack/PasswordManager/ColorList.txt");
                for (int i = 0; i < 10; i++)
                {
                    //Random rnd = new Random();
                    //color = rnd.Next(139);

                    Random rand = new Random(DateTime.Now.Millisecond);
                    color = rand.Next(139);

                    //string[] tokens = line.Split(',');
                    string x = lineOfContents[color];
                    cboColor.Items.Add(lineOfContents[color]);
                    color = 0;

                }
                

            }
        }

        private void btnRetrievePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            if (string.IsNullOrEmpty(txtWebsite.Text))
            {
                // Website textbox is empty.
                MessageBox.Show("You must enter a website.");
                txtWebsite.Focus();
            }
            else
            {
                // Website text box is filled in
                string strWebsite = txtWebsite.Text;

                var client = new RestClient("http://10.231.154.214:5000/get-password?website=" + strWebsite);
                var request = new RestRequest(Method.GET);
                request.AddHeader("Postman-Token", "340ea6d0-e6bd-c8ce-ccfb-7409970fd14e");
                request.AddHeader("Cache-Control", "no-cache");
                response = client.Execute(request);


                var obj = JObject.Parse(response.Content);
                var password = (string)obj["password"];
                //Console.WriteLine(o.password);

                txtPassword.Text = password;
                txtWebPassword.Text = strWebsite;

                //clear website field
                txtWebsite.Clear();

                /*
                    public String SwapClipboardHtmlText(String replacementHtmlText)
                    {
                    String returnHtmlText = null;
                    if (Clipboard.ContainsText(TextDataFormat.Html))
                    {
                    returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
                    Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
                    }
                    return returnHtmlText;
                    */
            }
    
        }

        // things that will happen when the form loads
        // populate the combo box with random 10 colors
        private void frmPasswordMgr_Load(object sender, EventArgs e)
        {

            int color;
            string[] lineOfContents = File.ReadAllLines("//blender/homes/k/_/k_barden97/nt/TAMUHack/PasswordManager/ColorList.txt");
            for (int i = 0; i < 10; i++)
            {
                //Random rnd = new Random();
                //color = rnd.Next(139);

                Random rand = new Random(DateTime.Now.Millisecond);
                color = rand.Next(139);

                //string[] tokens = line.Split(',');
                string x = lineOfContents[color];
                cboColor.Items.Add(lineOfContents[color]);
                color = 0;

            }
        }
    }
}
