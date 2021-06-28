using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;        

namespace SEC
{
    public partial class SEC : Form
    {
        public SEC()
        {
            InitializeComponent();
        }

        SettingReader.Configurações set =
            new SettingReader.Configurações();
                
        private TimeSpan rst = new TimeSpan(0, 5, 0);

        private string datafile = @"data.scfg";

        private void SEC_Load(object sender, EventArgs e)
        {
            rst = new TimeSpan(
                Convert.ToInt16(
                    set.LerConfigurações(datafile, "time", "hours")),
                Convert.ToInt16(
                    set.LerConfigurações(datafile, "time", "minutes")),
                Convert.ToInt16(
                    set.LerConfigurações(datafile, "time", "seconds")));

            this.Opacity = Convert.ToDouble(set.LerConfigurações(datafile, "main", "opacity"));
            this.Text = set.LerConfigurações(datafile,"main","title");

            pnTt.Location = new Point(
                this.Size.Width - (pnTt.Size.Width / 2 + this.Size.Width / 2),
                this.Size.Height - (pnTt.Size.Height / 2 + this.Size.Height - this.Size.Height / 4)
                );

            pnInf.Location = new Point(
                this.Size.Width - (pnInf.Size.Width / 2 + this.Size.Width / 2),
                this.Size.Height - (pnInf.Size.Height / 2 + this.Size.Height/ 2)
                );            
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (txtUs.Text == set.LerConfigurações(
                datafile, "data", "user"))
            {
                if (txtSn.Text == set.LerConfigurações(
                    datafile, "data", "password"))
                {
                    if (txtNm.Text == set.LerConfigurações(
                        datafile, "data", "name"))
                    {
                        if (txtEnd.Text == set.LerConfigurações(
                            datafile, "data", "address"))
                        {
                            if (txtEm.Text == set.LerConfigurações(
                                datafile, "data", "email"))
                            {
                                if (txtTel.Text == set.LerConfigurações(
                                    datafile, "data", "phone"))
                                {
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(set.LerConfigurações(
                                        datafile, "msg", "error"), "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show(set.LerConfigurações(
                                    datafile, "msg", "error"), "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(set.LerConfigurações(
                                datafile, "msg", "error"), "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(set.LerConfigurações(
                            datafile, "msg", "error"), "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(set.LerConfigurações(
                        datafile, "msg", "error"), "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(set.LerConfigurações(
                    datafile, "msg", "error"), "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmR_Tick(object sender, EventArgs e)
        {            
            if (rst == new TimeSpan(0, 0, 0))
            {
                tmR.Stop();
                System.Diagnostics.Process.Start("shutdown", "/l");
                Application.Exit();
            }
            rst = rst.Subtract(new TimeSpan(0,0,1));
            lblTm.Text = rst.ToString();
        }

        private void EnterPressed(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmdOk_Click(sender, e);
            }
        }
    }
}
