using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ALMSTWKND.UI.WindowsForms.Controls
{
	public class Separator : Control
	{
		protected bool hovering;

		private IContainer components;

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets whether this control can be highlighted when the pointer hovers over it.")]
		public bool CanHighlight
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the color of this Separator.")]
		public System.Drawing.Color Color
		{
			get;
			set;
		}

		[Category("Appearance")]
		[Description("Gets or sets the direction of the separator. Usage: Vertical or Horizontal.")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string Direction
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the color of this Separator when it is disabled.")]
		public new System.Drawing.Color DisabledColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the highlight color of this control.")]
		public System.Drawing.Color HighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the line thickness.")]
		public int Thickness
		{
			get;
			set;
		}

		public Separator()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.Selectable, true);
			this.DoubleBuffered = true;
			base.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
			this.Direction = "Horizontal";
			base.Size = new System.Drawing.Size(75, 3);
			this.Color = System.Drawing.Color.SeaGreen;
			this.Thickness = 3;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.MouseEnter += new EventHandler(this.Separator_MouseEnter);
			base.MouseLeave += new EventHandler(this.Separator_MouseLeave);
			base.ResumeLayout(false);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.Size = (this.Direction == "Horizontal" ? new System.Drawing.Size(base.Width, this.Thickness) : new System.Drawing.Size(this.Thickness, base.Height));
			using (Brush solidBrush = new SolidBrush(this.Color))
			{
				using (Pen pen = new Pen(solidBrush, (float)this.Thickness))
				{
					pen.Color = (this.hovering ? this.HighlightColor : pen.Color);
					if (this.Direction != "Vertical")
					{
						pe.Graphics.DrawLine(pen, new Point(0, 0), new Point(base.Width - this.Thickness, 0));
					}
					else
					{
						pe.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, base.Height - this.Thickness));
					}
				}
			}
		}

		private void Separator_MouseEnter(object sender, EventArgs e)
		{
			if (!this.CanHighlight)
			{
				this.hovering = false;
				return;
			}
			this.hovering = true;
			this.Refresh();
		}

		private void Separator_MouseLeave(object sender, EventArgs e)
		{
			this.hovering = false;
			this.Refresh();
		}
	}
}