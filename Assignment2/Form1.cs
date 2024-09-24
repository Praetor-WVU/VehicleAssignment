using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace Assignment2
{
    public partial class frmAssignment2 : Form
    {
        public enum Colors { Red, Blue, Black, White }
        String selectedColor = "";
        public frmAssignment2()
        {
            InitializeComponent();
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            lblSummary.ForeColor = Color.Black;
            String makeModel = "";
            if (lstMakeModel.SelectedIndex != -1)
            {
                makeModel = (string)lstMakeModel.SelectedItem;
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please select a make and model!";
                return;
            }
            int year;
            if (int.TryParse(txtYear.Text, out _))
            {
                year = int.Parse(txtYear.Text);
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Enter a valid year!";
                return;
            }
            if (selectedColor=="")
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Select a color!";
                return;
            }
            ArrayList features = new ArrayList();
            if (chkAC.Checked) features.Add("AC");
            if (chkPowerWin.Checked) features.Add("Power Windows");
            if (chkLaneAssist.Checked) features.Add("Lane Assist");
            if (chkSyriusRadio.Checked) features.Add("Syrius Radio");
            if (features.Count == 0) features.Add("None");
            lblSummary.Text=$"You have purchased a {selectedColor} {year} {makeModel} with the following features: {String.Join(", ", features.ToArray())}.";
        }

        private void rbtnRed_CheckedChanged(object sender, EventArgs e) => selectedColor = Colors.Red.ToString();

        private void rbtnBlue_CheckedChanged(object sender, EventArgs e) => selectedColor = Colors.Blue.ToString();

        private void rbtnBlack_CheckedChanged(object sender, EventArgs e) => selectedColor = Colors.Black.ToString();

        private void rbtnWhite_CheckedChanged(object sender, EventArgs e) => selectedColor = Colors.White.ToString();
    }
}
