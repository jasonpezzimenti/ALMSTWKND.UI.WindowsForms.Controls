using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMSTWKND.UI.WindowsForms.Controls2
{
    public partial class IncrementDecrementButton : Control
    {
        [Browsable(true)]
        [DisplayName("InactiveBackgroundColor")]
        [Category("Appearance")]
        public Color InactiveBackgroundColor { get; set; }

        [Browsable(true)]
        [DisplayName("OnHoverBackgroundColor")]
        [Category("Appearance")]
        public Color OnHoverBackgroundColor { get; set; }

        [Browsable(true)]
        [DisplayName("ActiveBackgroundColor")]
        [Category("Appearance")]
        public Color ActiveBackgroundColor { get; set; }

        [Browsable(true)]
        [DisplayName("BorderColor")]
        [Category("Appearance")]
        public Color BorderColor { get; set; }

        [Browsable(true)]
        [DisplayName("Border Thickness")]
        [Category("Appearance")]
        public float BorderThickness { get; set; }

        [Browsable(true)]
        [DisplayName("Line Thickness")]
        [Category("Appearance")]
        public float LineThickness { get; set; }

        [Browsable(true)]
        [DisplayName("Has Border")]
        [Category("Behavior")]
        public bool HasBorder { get; set; }

        [Browsable(true)]
        [DisplayName("Line Color")]
        [Category("Appearance")]
        public Color LineColor { get; set; }

        public enum ButtonTypes
        {
            Increment,
            Decrement
        }

        [Category("Behavior")]
        [DisplayName("Button Type")]
        [Browsable(true)]
        public ButtonTypes ButtonType { get; set; }

        public bool pressing;

        public IncrementDecrementButton()
        {
            this.BackColor = InactiveBackgroundColor;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Draw(pe);

            base.OnPaint(pe);
        }

        private void Draw(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (HasBorder)
            {
                // Draw the Border.
                paintEventArgs.Graphics.DrawRectangle(
                    new Pen(BorderColor, BorderThickness),
                    new Rectangle(
                        0, 0, base.Width - 1, base.Height - 1
                        )
                    );
            }

            // Draw the Increment/Decrement operator.
            switch(ButtonType)
            {
                case ButtonTypes.Increment:
                    int lineHeight = base.Height - 20;

                    // Draw the Horizontal line.
                    paintEventArgs.Graphics.DrawLine(
                        new Pen(
                            LineColor, LineThickness), 10, ((this.Height / 2) - (LineThickness / 2f)), this.Width - 10, ((this.Height / 2) - (LineThickness / 2f)));

                    // Draw the Vertical line.
                    paintEventArgs.Graphics.DrawLine(
                        new Pen(
                            LineColor, LineThickness), ((this.Height / 2) - (LineThickness / 2f)), 10, ((this.Height / 2) - (LineThickness / 1f)), this.Height - 10);
                    break;
                case ButtonTypes.Decrement:
                    paintEventArgs.Graphics.DrawLine(
                        new Pen(
                            LineColor, LineThickness), 10, ((this.Height / 2) - (LineThickness / 2)), this.Height - 10, ((this.Height / 2) - (LineThickness / 2)));
                    break;
            }
        }

        private void IncrementDecrementButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = OnHoverBackgroundColor;
            this.Refresh();
        }

        private void IncrementDecrementButton_MouseDown(object sender, MouseEventArgs e)
        {
            pressing = true;

            this.BackColor = ActiveBackgroundColor;
            this.Refresh();
        }

        private void IncrementDecrementButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = InactiveBackgroundColor;
            this.Refresh();
        }

        private void IncrementDecrementButton_MouseUp(object sender, MouseEventArgs e)
        {
            pressing = false;

            this.BackColor = OnHoverBackgroundColor;
            this.Refresh();
        }
    }
}
