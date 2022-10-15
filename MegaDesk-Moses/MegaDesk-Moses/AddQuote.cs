using MegaDesk_Moses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Moses
{
    public partial class AddQuote : Form
    {

        public DeskQuote DeskQuote { get; set; }

        private string[] numberOfDrawers;

        private SurfaceMaterials[] surfaceMaterials;

        string[] rushOrderOptions;

        public AddQuote(DeskQuote deskQuote)
        {

            DeskQuote = deskQuote ?? DeskQuote.CreateEmpty();

            numberOfDrawers = Enumerable.Range(0, 8).Select(x => x.ToString()).ToArray();

            surfaceMaterials = SurfaceMaterials.List.ToArray();

            rushOrderOptions = new string[]
            {
                "Normal", "3 Day", "5 Day", "7 Day"
            };

            InitializeComponent();
            InitializeComboBoxes();
        }

        /// <summary>
        /// Fills the combo boxes with correct values when called in the constructor of this form.
        /// </summary>
        private void InitializeComboBoxes()
        {
            // Drawer Count Initialize and Index set to 0
            CBNumDrawers.Items.AddRange(numberOfDrawers);
            CBNumDrawers.SelectedIndex = 0;

            // Materials Populate ComboBox and Index Set to Laminate
            CBMaterials.Items.AddRange(surfaceMaterials);
            CBMaterials.SelectedIndex = 0;

            // Rush Day ComboBox populated and Index set to Normal 
            CBRushDay.Items.AddRange(rushOrderOptions);
            CBRushDay.SelectedIndex = 0;

        }

        private void CBMaterials_SelectedValueChanged(object sender, EventArgs e)
        {
            // Get the SurfaceMaterial type from the ComboBox
            var result = DeskQuote.UpdateMaterial(SurfaceMaterials.FromName(CBMaterials.Text));

            // Set the label next to the Material ComboBox to the value of the Enum name.
            //LabelMatCost.Text = "+ $" + result.Value.Value.ToString();

        }

        private void TBWidth_Validating(object sender, CancelEventArgs e)
        {
            // Check if textbox is null or empty
            if (String.IsNullOrEmpty(TBWidth.Text))
            {
                SetValidateErrors(ErrLabelWidth, "Please enter a value!");
                return;
            }


            // Update width and validate.
            var validationResult = DeskQuote.UpdateWidth(Convert.ToInt32(TBWidth.Text));

            if (validationResult.IsFailure)
            {
                SetValidateErrors(ErrLabelWidth, validationResult.Error);
                return;
            }

            // If we have made it this far, there are no issues. Remove errors.
            ErrLabelWidth.Visible = false;

        }

        private void TBDepth_Validating(object sender, CancelEventArgs e)
        {
            // Check if textbox is null or empty
            if (String.IsNullOrEmpty(TBDepth.Text))
            {
                SetValidateErrors(ErrLabelDepth, "Please enter a value!");
                return;
            }


            // Update width and validate.
            var validationResult = DeskQuote.UpdateDepth(Convert.ToInt32(TBDepth.Text));

            if (validationResult.IsFailure)
            {
                SetValidateErrors(ErrLabelDepth, validationResult.Error);
                return;
            }

            // If we have made it this far, there are no issues. Remove errors.
            ErrLabelDepth.Visible = false;
        }

        /// <summary>
        /// Helper Method to reduce repeated code (Don't Repeat Yourself or DRY Principle)
        /// </summary>
        /// <param name="label"></param>
        /// <param name="errLabelMsg"></param>
        private void SetValidateErrors(Label label, string errLabelMsg = "Value must be within range!")
        {
            label.Text = errLabelMsg;
            label.Visible = true;

            

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // If there are still errors, prevent form from submitting
            if (!DeskQuote.IsValid())
            {
                MessageBox.Show("Please resolve errors before submitting!");
                return;
            }

            // We are done with this. Goodbye.
            DeskQuote.IsComplete = true;
            this.Close();
        }

        private void TBDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make it so my Textbox does not get anything other than a number value.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TBWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make it so my Textbox does not get anything other than a number value.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CBNumDrawers_SelectedValueChanged(object sender, EventArgs e)
        {
            // Get the Drawer Count from the TextBox
            DeskQuote.UpdateDrawer(Convert.ToInt32(CBNumDrawers.Text));

        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {
            // Get the Name from the TextBox
            DeskQuote.Name = TBName.Text; 
        }

        private void CBRushDay_SelectedValueChanged(object sender, EventArgs e)
        {
            var day = RushDay.List.FirstOrDefault(x => x.DisplayName == CBRushDay.Text);

            DeskQuote.UpdateRushDay(day);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
