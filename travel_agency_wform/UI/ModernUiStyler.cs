using System.Drawing;
using System.Windows.Forms;

namespace travel_agency_wform.UI
{
    public static class ModernUiStyler
    {
        public static void Apply(Form form)
        {
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            form.BackColor = Color.WhiteSmoke;
            ApplyRecursive(form.Controls);
        }

        private static void ApplyRecursive(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.FromArgb(0, 120, 215);
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderSize = 0;
                    button.UseVisualStyleBackColor = false;
                }

                if (control.HasChildren)
                {
                    ApplyRecursive(control.Controls);
                }
            }
        }
    }
}
