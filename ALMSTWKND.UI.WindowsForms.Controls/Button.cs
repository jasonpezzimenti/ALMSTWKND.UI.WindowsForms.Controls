using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ALMSTWKND.UI.WindowsForms.Controls
{
	public class Button : Control
	{
		protected internal bool mouseLeft;

		protected internal bool mouseButtonIsDown;

		protected internal bool mouseHasEntered;

		protected internal bool shouldFillCheckBoxArea;

		protected internal bool ticked;

		protected internal bool confirmed;

		protected internal bool buttonHasFocus;

		protected internal Color defaultBackgroundColor;

		protected internal Color checkMarkColor;

		protected internal Color checkBoxColor;

		protected internal Color backgroundColor;

		protected internal Color separatorColor;

		protected internal Color defBCol;

		private IContainer components;

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the ActiveColor for this control.")]
		public Color ActiveColor
		{
			get;
			set;
		}

		[Browsable(false)]
		[Category("Appearance")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("In order to use this feature, cast it (not recommended).")]
		public new Image BackgroundImage
		{
			get;
			set;
		}

		[Browsable(false)]
		[Category("Appearance")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("In order to use this feature, cast it (not recommended).")]
		public new Image BackgroundImageLayout
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the background texture for this control.")]
		public Image BackgroundTexture
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the type of Layout to use for this Texture.")]
		public ImageLayout BackgroundTextureLayout
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the Border Color for this control.")]
		public Color BorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the BorderStyle for this control.")]
		public DashStyle BorderStyle
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the default border thickness for this control.")]
		public float BorderThickness
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Color CheckboxActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Color CheckboxBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public Color CheckboxHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the checkmark color for this control.")]
		public Color CheckmarkColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the Border Thickness of the Check-mark.")]
		public float CheckmarkThickness
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the ConfirmedBackgroundColor for this control.")]
		public Color ConfirmedBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the ConfirmedBorderColor for this control.")]
		public Color ConfirmedBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the ConfirmedCheckBoxBackgroundColor for this control.")]
		public Color ConfirmedCheckBoxBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the checkmark color for this control.")]
		public Color ConfirmedCheckmarkColor
		{
			get;
			set;
		}

		protected override System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				System.Windows.Forms.CreateParams createParams = base.CreateParams;
				createParams.ExStyle = createParams.ExStyle | 33554432;
				return createParams;
			}
		}

		protected override System.Drawing.Size DefaultSize
		{
			get
			{
				return new System.Drawing.Size(85, 27);
			}
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the background color of the control when it is disabled.")]
		public Color DisabledBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the border color of the control when it is disabled.")]
		public Color DisabledBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the background color of this control's checkbox area when it is disabled.")]
		public Color DisabledCheckBoxBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the color of the check-mark when this control is disabled.")]
		public Color DisabledCheckmarkColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the color of this control's Separator when it is disabled.")]
		public Color DisabledSeparatorColor
		{
			get;
			set;
		}

		protected internal static ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes DrawType
		{
			get;
			set;
		}

		public new bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				if (this.Enabled)
				{
					this.BackColor = this.defBCol;
				}
				else
				{
					this.BackColor = this.DisabledBackgroundColor;
				}
				base.Enabled = value;
			}
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the style of the Focus border.")]
		public DashStyle FocusedBorderStyle
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the color of this control when it is focused (has become the active control of the Form).")]
		public Color FocusedColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets whether the control has a border.")]
		[DisplayName("Has Border")]
		public bool HasBorder
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the HighlightColor for this control.")]
		public Color HighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Indicates whether this control requires confirmation.")]
		public bool RequiresConfirmation
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Separator")]
		[Description("Gets or sets the distance for the separator, in pixels, from the left edge of this control.")]
		public int SeparatorDistance
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("")]
		public bool StyleButtonSeparately
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets whether to Synchronize the Check-mark Color with Border settings.")]
		public bool SynchronizeCheckMarkWithBorderSettings
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets whether this control should have a textured background.")]
		public bool UsingTexturedBackground
		{
			get;
			set;
		}

		public Button()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			this.SetStyles();
			this.SetDefaultColors();
		}

		private void Button_DockChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void Button_Enter(object sender, EventArgs e)
		{
			if (this.Enabled)
			{
				this.BackColor = this.defBCol;
			}
			this.buttonHasFocus = true;
			this.Refresh();
		}

		private void Button_FontChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void Button_ForeColorChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void Button_Leave(object sender, EventArgs e)
		{
			this.buttonHasFocus = false;
			this.Refresh();
		}

		private void Button_MouseDown(object sender, MouseEventArgs e)
		{
			if (!this.mouseButtonIsDown)
			{
				this.mouseButtonIsDown = true;
				if (!this.RequiresConfirmation || e.Location.X >= this.SeparatorDistance)
				{
					this.shouldFillCheckBoxArea = false;
					this.BackColor = this.ActiveColor;
				}
				else
				{
					this.shouldFillCheckBoxArea = true;
				}
				this.Refresh();
			}
		}

		private void Button_MouseEnter(object sender, EventArgs e)
		{
			if (!this.mouseHasEntered)
			{
				this.mouseHasEntered = true;
				this.defaultBackgroundColor = this.BackColor;
				this.BackColor = this.HighlightColor;
				this.Refresh();
			}
		}

		private void Button_MouseLeave(object sender, EventArgs e)
		{
			if (this.mouseHasEntered)
			{
				this.mouseHasEntered = false;
				if (!this.confirmed)
				{
					this.BackColor = this.defaultBackgroundColor;
					return;
				}
				this.BackColor = this.ConfirmedBackgroundColor;
			}

			// Fixing Issue #3. Not yet completed.
			//mouseLeft = true;
		}

		private void Button_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.mouseButtonIsDown)
			{
					this.mouseButtonIsDown = false;
					this.BackColor = this.HighlightColor;
				if (!this.confirmed)
				{
					if (e.Location.X < this.SeparatorDistance)
					{
						if (!this.ticked)
						{
							this.ticked = true;
							EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonCheckedChangedEventArgs> eventHandler = this.CheckedChanged;
							if (eventHandler != null)
							{
								eventHandler(this, new ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonCheckedChangedEventArgs(this, true));
							}
							else
							{
							}
						}
						else
						{
							this.ticked = false;
							EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonCheckedChangedEventArgs> eventHandler1 = this.CheckedChanged;
							if (eventHandler1 != null)
							{
								eventHandler1(this, new ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonCheckedChangedEventArgs(this, false));
							}
							else
							{
							}
						}
					}
					else if (e.Location.X > this.SeparatorDistance)
					{
						if (this.ticked)
						{
							this.Enabled = false;
							this.BackColor = this.ConfirmedBackgroundColor;
							this.confirmed = true;
							EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs> eventHandler2 = this.Confirmed;
							if (eventHandler2 != null)
							{
								eventHandler2(this, new ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs(e));
							}
							else
							{
							}
						}
						EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs> eventHandler3 = this.Clicked;
						if (eventHandler3 != null)
						{
							eventHandler3(this, new ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs(e));
						}
						else
						{
						}
					}
				}
			}

			this.Refresh();
		}

		private void Button_SizeChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		private void Button_TextChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		protected internal void Draw(PaintEventArgs paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes drawType)
		{
			Color borderColor;
			Color confirmedCheckmarkColor;
			Color checkboxHighlightColor;
			Rectangle bounds;
			Func<Rectangle> func;
			paintEventArgs.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			if (paintEventArgs != null)
			{
				if (this.Enabled)
				{
					borderColor = this.BorderColor;
				}
				else
				{
					borderColor = this.DisabledBorderColor;
					this.checkMarkColor = this.DisabledCheckmarkColor;
					this.checkBoxColor = this.DisabledCheckBoxBackgroundColor;
					this.backgroundColor = this.DisabledBackgroundColor;
				}
				switch (drawType)
				{
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Border:
						{
							if (this.confirmed)
							{
								if (!this.buttonHasFocus)
								{
									using (Pen pen = new Pen(this.ConfirmedBorderColor, this.BorderThickness))
									{
										pen.DashStyle = this.BorderStyle;
										Graphics graphics = paintEventArgs.Graphics;
										bounds = base.Bounds;
										float width = (float)bounds.Width - this.BorderThickness;
										bounds = base.Bounds;
										graphics.DrawRectangle(pen, 0f, 0f, width, (float)bounds.Height - this.BorderThickness);
										break;
									}
								}
								else
								{
									using (Pen focusedBorderStyle = new Pen(this.ConfirmedBorderColor, this.BorderThickness))
									{
										focusedBorderStyle.DashStyle = this.FocusedBorderStyle;
										Graphics graphic = paintEventArgs.Graphics;
										bounds = base.Bounds;
										float single = (float)bounds.Width - this.BorderThickness;
										bounds = base.Bounds;
										graphic.DrawRectangle(focusedBorderStyle, 0f, 0f, single, (float)bounds.Height - this.BorderThickness);
										break;
									}
								}
							}
							else if (!this.buttonHasFocus)
							{
								using (Pen borderStyle = new Pen(borderColor, this.BorderThickness))
								{
									borderStyle.DashStyle = this.BorderStyle;
									Graphics graphics1 = paintEventArgs.Graphics;
									bounds = base.Bounds;
									float width1 = (float)bounds.Width - this.BorderThickness;
									bounds = base.Bounds;
									graphics1.DrawRectangle(borderStyle, 0f, 0f, width1, (float)bounds.Height - this.BorderThickness);
									break;
								}
							}
							else
							{
								using (Pen pen1 = new Pen(borderColor, this.BorderThickness))
								{
									pen1.DashStyle = this.FocusedBorderStyle;
									Graphics graphic1 = paintEventArgs.Graphics;
									bounds = base.Bounds;
									float single1 = (float)bounds.Width - this.BorderThickness;
									bounds = base.Bounds;
									graphic1.DrawRectangle(pen1, 0f, 0f, single1, (float)bounds.Height - this.BorderThickness);
									break;
								}
							}
							break;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Text:
						{
							TextFormatFlags textFormatFlag = TextFormatFlags.EndEllipsis | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
							if (!this.RequiresConfirmation)
							{
								Graphics graphics2 = paintEventArgs.Graphics;
								string text = this.Text;
								System.Drawing.Font font = this.Font;
								int num = base.Bounds.Width;
								bounds = base.Bounds;
								TextRenderer.DrawText(graphics2, text, font, new Rectangle(0, 0, num, bounds.Height), this.ForeColor, textFormatFlag);
								return;
							}
							Graphics graphic2 = paintEventArgs.Graphics;
							string str = this.Text;
							System.Drawing.Font font1 = this.Font;
							int separatorDistance = this.SeparatorDistance;
							bounds = base.Bounds;
							int num1 = bounds.Width - this.SeparatorDistance;
							bounds = base.Bounds;
							TextRenderer.DrawText(graphic2, str, font1, new Rectangle(separatorDistance, 0, num1, bounds.Height), this.ForeColor, textFormatFlag);
							return;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Separator:
						{
							if (this.confirmed)
							{
								Graphics graphics3 = paintEventArgs.Graphics;
								Pen pen2 = new Pen(this.ConfirmedBorderColor, this.BorderThickness);
								int separatorDistance1 = this.SeparatorDistance;
								int separatorDistance2 = this.SeparatorDistance;
								bounds = base.Bounds;
								graphics3.DrawLine(pen2, separatorDistance1, 0, separatorDistance2, bounds.Height);
								return;
							}
							this.separatorColor = (this.Enabled ? this.BorderColor : this.DisabledSeparatorColor);
							Graphics graphic3 = paintEventArgs.Graphics;
							Pen pen3 = new Pen(this.separatorColor, this.BorderThickness);
							int num2 = this.SeparatorDistance;
							int separatorDistance3 = this.SeparatorDistance;
							bounds = base.Bounds;
							graphic3.DrawLine(pen3, num2, 0, separatorDistance3, bounds.Height);
							return;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Checkmark:
						{
							float checkmarkThickness = 1f;
							if (!this.SynchronizeCheckMarkWithBorderSettings)
							{
								confirmedCheckmarkColor = (this.CheckmarkColor.IsEmpty ? this.ForeColor : this.CheckmarkColor);
								checkmarkThickness = this.CheckmarkThickness;
							}
							else
							{
								confirmedCheckmarkColor = (this.BorderColor.IsEmpty ? this.ForeColor : this.BorderColor);
								checkmarkThickness = this.BorderThickness;
							}
							if (this.confirmed)
							{
								confirmedCheckmarkColor = this.ConfirmedCheckmarkColor;
								checkmarkThickness = this.CheckmarkThickness;
							}
							if (!this.Enabled)
							{
								confirmedCheckmarkColor = this.DisabledCheckmarkColor;
							}
							paintEventArgs.Graphics.DrawLine(new Pen(confirmedCheckmarkColor, checkmarkThickness), 7, 15, 11, 18);
							paintEventArgs.Graphics.DrawLine(new Pen(confirmedCheckmarkColor, checkmarkThickness), 11, 18, 18, 10);
							confirmedCheckmarkColor = Color.Empty;
							checkmarkThickness = 1f;
							return;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.CheckBoxFiller:
						{
							if (this.StyleButtonSeparately)
							{
								if (!this.mouseHasEntered)
								{
									checkboxHighlightColor = (!this.mouseButtonIsDown ? this.CheckboxBackgroundColor : this.CheckboxActiveColor);
								}
								else
								{
									checkboxHighlightColor = this.CheckboxHighlightColor;
								}
								if (!this.Enabled && !this.confirmed)
								{
									checkboxHighlightColor = this.DisabledCheckBoxBackgroundColor;
								}
								using (SolidBrush solidBrush = new SolidBrush(checkboxHighlightColor))
								{
									Graphics graphics4 = paintEventArgs.Graphics;
									int num3 = this.SeparatorDistance;
									bounds = base.Bounds;
									graphics4.FillRectangle(solidBrush, 0, 0, num3, bounds.Height - 1);
								}
							}
							if (this.shouldFillCheckBoxArea)
							{
								checkboxHighlightColor = (this.Enabled ? this.ActiveColor : this.DisabledCheckBoxBackgroundColor);
								using (SolidBrush solidBrush1 = new SolidBrush(checkboxHighlightColor))
								{
									Graphics graphic4 = paintEventArgs.Graphics;
									int separatorDistance4 = this.SeparatorDistance;
									bounds = base.Bounds;
									graphic4.FillRectangle(solidBrush1, 0, 0, separatorDistance4, bounds.Height);
								}
								this.shouldFillCheckBoxArea = false;
							}
							if (!this.RequiresConfirmation || !this.confirmed || this.ConfirmedCheckBoxBackgroundColor.IsEmpty)
							{
								break;
							}
							using (SolidBrush solidBrush2 = new SolidBrush(this.ConfirmedCheckBoxBackgroundColor))
							{
								Graphics graphics5 = paintEventArgs.Graphics;
								int num4 = this.SeparatorDistance;
								bounds = base.Bounds;
								graphics5.FillRectangle(solidBrush2, 0, 0, num4, bounds.Height);
								break;
							}
							break;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Image:
						{
							break;
						}
					case ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.TexturedBackground:
						{
							if (this.BackgroundTexture == null)
							{
								break;
							}
							if (!(new Dictionary<ImageLayout, Func<Rectangle>>()
						{
							{ ImageLayout.None, new Func<Rectangle>(() => new Rectangle(new Point((int)this.BorderThickness, (int)this.BorderThickness), new System.Drawing.Size(this.BackgroundTexture.Width, this.BackgroundTexture.Height))) },
							{ ImageLayout.Stretch, new Func<Rectangle>(() => new Rectangle(new Point((int)this.BorderThickness, (int)this.BorderThickness), new System.Drawing.Size(base.Width - (int)this.BorderThickness, base.Height - (int)this.BorderThickness))) },
							{ ImageLayout.Tile, new Func<Rectangle>(() => new Rectangle(new Point((int)this.BorderThickness, (int)this.BorderThickness), new System.Drawing.Size(base.Width - (int)this.BorderThickness, base.Height - (int)this.BorderThickness))) },
							{ ImageLayout.Zoom, new Func<Rectangle>(() => throw new NotImplementedException("Zoom is not yet supported for the confirmation button.")) },
							{ ImageLayout.Center, new Func<Rectangle>(() => new Rectangle(new Point(base.Width / 2 - this.BackgroundTexture.Width / 2 - (int)this.BorderThickness * 2, base.Height / 2 - this.BackgroundTexture.Height / 2 - (int)this.BorderThickness * 2), new System.Drawing.Size(this.BackgroundTexture.Width, this.BackgroundTexture.Height))) }
						}).TryGetValue(this.BackgroundTextureLayout, out func))
							{
								break;
							}
							if (this.BackgroundTextureLayout == ImageLayout.Tile)
							{
								using (TextureBrush textureBrush = new TextureBrush(this.BackgroundTexture, WrapMode.Tile))
								{
									paintEventArgs.Graphics.FillRectangle(textureBrush, func());
									break;
								}
							}
							else
							{
								using (TextureBrush textureBrush1 = new TextureBrush(this.BackgroundTexture))
								{
									paintEventArgs.Graphics.DrawImage(textureBrush1.Image, func());
									break;
								}
							}
							break;
						}
					default:
						{
							return;
						}
				}
			}
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.DockChanged += new EventHandler(this.Button_DockChanged);
			base.FontChanged += new EventHandler(this.Button_FontChanged);
			base.ForeColorChanged += new EventHandler(this.Button_ForeColorChanged);
			base.SizeChanged += new EventHandler(this.Button_SizeChanged);
			base.TextChanged += new EventHandler(this.Button_TextChanged);
			base.Enter += new EventHandler(this.Button_Enter);
			base.Leave += new EventHandler(this.Button_Leave);
			base.MouseDown += new MouseEventHandler(this.Button_MouseDown);
			base.MouseEnter += new EventHandler(this.Button_MouseEnter);
			base.MouseLeave += new EventHandler(this.Button_MouseLeave);
			base.MouseUp += new MouseEventHandler(this.Button_MouseUp);
			base.ResumeLayout(false);
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs)
		{
			if (!this.RequiresConfirmation)
			{
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.TexturedBackground);
				if (this.HasBorder)
				{
					this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Border);
				}
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Text);
				return;
			}
			if (!this.ticked)
			{
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.TexturedBackground);
				if (this.shouldFillCheckBoxArea)
				{
					this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.CheckBoxFiller);
				}
				if (this.HasBorder)
				{
					this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Border);
				}
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Separator);
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Text);
				return;
			}
			this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.TexturedBackground);
			if (this.shouldFillCheckBoxArea)
			{
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.CheckBoxFiller);
			}
			if (this.HasBorder)
			{
				this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Border);
			}
			this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Checkmark);
			this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Separator);
			this.Draw(paintEventArgs, ALMSTWKND.UI.WindowsForms.Controls.Button.DrawTypes.Text);
		}

		public void PerformClick()
		{
			EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs> eventHandler = this.Clicked;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs(null));
		}

		public void Retry()
		{
			this.mouseButtonIsDown = false;
			this.shouldFillCheckBoxArea = false;
			this.ticked = false;
			this.confirmed = false;
			this.Refresh();
		}

		private void SetDefaultColors()
		{
			this.defaultBackgroundColor = this.BackColor;
			this.defBCol = this.BackColor;
			this.BackColor = Color.FromArgb(230, 235, 239);
			this.HighlightColor = Color.FromArgb(217, 222, 226);
			this.ActiveColor = Color.FromArgb(205, 210, 214);
			this.BorderColor = Color.FromArgb(156, 165, 173);
			this.ConfirmedBackgroundColor = Color.FromArgb(225, 242, 230);
			this.ConfirmedBorderColor = Color.FromArgb(146, 219, 168);
			this.ConfirmedCheckmarkColor = Color.FromArgb(146, 219, 168);
			this.ConfirmedCheckBoxBackgroundColor = Color.FromArgb(225, 242, 230);
			this.DisabledBackgroundColor = Color.FromArgb(229, 231, 232);
			this.DisabledBorderColor = Color.FromArgb(186, 188, 188);
			this.DisabledCheckmarkColor = Color.FromArgb(186, 188, 188);
			this.DisabledSeparatorColor = Color.FromArgb(186, 188, 188);
			this.DisabledCheckBoxBackgroundColor = Color.FromArgb(229, 231, 232);
		}

		private void SetStyles()
		{
			base.SetStyle(ControlStyles.CacheText, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, true);
		}

		public event EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonCheckedChangedEventArgs> CheckedChanged;

		public event EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonClickedEventArgs> Clicked;

		public event EventHandler<ALMSTWKND.UI.WindowsForms.Controls.Button.ButtonConfirmedEventArgs> Confirmed;

		public class ButtonCheckedChangedEventArgs : EventArgs
		{
			private ALMSTWKND.UI.WindowsForms.Controls.Button button;

			private bool v;

			private bool @value;

			public bool Checked
			{
				get
				{
					return this.@value;
				}
			}

			public ButtonCheckedChangedEventArgs(ALMSTWKND.UI.WindowsForms.Controls.Button button, bool v)
			{
				this.button = button;
				this.v = v;
			}

			public ButtonCheckedChangedEventArgs(System.Windows.Forms.Button sender, bool value)
			{
				this.@value = value;
			}
		}

		public class ButtonClickedEventArgs : EventArgs
		{
			public ButtonClickedEventArgs(MouseEventArgs e)
			{
			}
		}

		public class ButtonConfirmedEventArgs : EventArgs
		{
			public ButtonConfirmedEventArgs(MouseEventArgs e)
			{
			}
		}

		protected internal enum DrawTypes
		{
			Border,
			Text,
			Separator,
			Checkmark,
			CheckBoxFiller,
			Image,
			TexturedBackground
		}
	}
}