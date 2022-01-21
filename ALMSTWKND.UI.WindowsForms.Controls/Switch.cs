using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ALMSTWKND.UI.WindowsForms.Controls
{
	public class Switch : Control
	{
		protected internal bool entered;

		protected internal bool pressing;

		private IContainer components;

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the border thickness for this control.")]
		[DisplayName("Border Thickness")]
		public int BorderThickness
		{
			get;
			set;
		}

		public static Switch.ControlInteractions CurrentInteraction
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control State")]
		[Description("Gets or sets the current state of this control.")]
		[DisplayName("Current State")]
		public Switch.SwitchStates CurrentState
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBackgroundActiveColor")]
		public Color OffStateBackgroundActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBackgroundColor")]
		public Color OffStateBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBackgroundHighlightColor")]
		public Color OffStateBackgroundHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBorderActiveColor")]
		public Color OffStateBorderActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBorderColor")]
		public Color OffStateBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateBorderHighlightColor")]
		public Color OffStateBorderHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OffStateDisabledBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OffStateDisabledBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OffStateDisabledToggleBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OffStateDisabledToggleBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBackgroundActiveColor")]
		public Color OffStateToggleBackgroundActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBackgroundColor")]
		public Color OffStateToggleBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBackgroundHighlightColor")]
		public Color OffStateToggleBackgroundHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBorderActiveColor")]
		public Color OffStateToggleBorderActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBorderColor")]
		public Color OffStateToggleBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OffStateToggleBorderHighlightColor")]
		public Color OffStateToggleBorderHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBackgroundActiveColor")]
		public Color OnStateBackgroundActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBackgroundColor")]
		public Color OnStateBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBackgroundHighlightColor")]
		public Color OnStateBackgroundHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBorderActiveColor")]
		public Color OnStateBorderActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBorderColor")]
		public Color OnStateBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateBorderHighlightColor")]
		public Color OnStateBorderHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OnStateDisabledBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OnStateDisabledBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OnStateDisabledToggleBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		public Color OnStateDisabledToggleBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBackgroundActiveColor")]
		public Color OnStateToggleBackgroundActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBackgroundColor")]
		public Color OnStateToggleBackgroundColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBackgroundHighlightColor")]
		public Color OnStateToggleBackgroundHighlightColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBorderActiveColor")]
		public Color OnStateToggleBorderActiveColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBorderColor")]
		public Color OnStateToggleBorderColor
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Control Colors")]
		[Description("")]
		[DisplayName("OnStateToggleBorderHighlightColor")]
		public Color OnStateToggleBorderHighlightColor
		{
			get;
			set;
		}

		public static Switch.RenderableComponents RenderableComponent
		{
			get;
			set;
		}

		public static Switch.RenderableComponentParts RenderableComponentPart
		{
			get;
			set;
		}

		public static Switch.RenderableComponentStates RenderableComponentState
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[Description("Gets or sets the border thickness of this control's Toggle component.")]
		[DisplayName("Toggle Border Thickness")]
		public int ToggleBorderThickness
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets how far away from the right-edge of the control the Toggle should be.")]
		[DisplayName("Toggle Distance from Right Edge")]
		public int ToggleDistanceFromEdge
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Layout")]
		[Description("Gets or sets the width of the toggle.")]
		[DisplayName("Toggle Width")]
		public int ToggleWidth
		{
			get;
			set;
		}

		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets whether this control is using custom styles.")]
		[DisplayName("Use Custom Styles")]
		public bool UsingCustomStyles
		{
			get;
			set;
		}

		public Switch()
		{
			this.InitializeComponent();
			base.Size = new System.Drawing.Size(53, 23);
			this.DoubleBuffered = true;
			this.SetStyles();
			base.EnabledChanged += new EventHandler(this.Switch_EnabledChanged);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void Draw(PaintEventArgs paintEventArgs, Switch.RenderableComponentParts renderableComponentPart, Switch.RenderableComponents renderableComponent)
		{
			Switch.SwitchStates currentState = this.CurrentState;
			if (currentState == Switch.SwitchStates.On)
			{
				switch (Switch.RenderableComponentState)
				{
					case Switch.RenderableComponentStates.Default:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush = new SolidBrush(this.OnStateToggleBackgroundColor))
									{
										using (Pen pen = new Pen(solidBrush, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush, new RectangleF((float)(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge), (float)this.ToggleBorderThickness, (float)this.ToggleWidth, (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush1 = new SolidBrush(this.OnStateToggleBorderColor))
									{
										using (Pen pen1 = new Pen(solidBrush1, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen1, new Rectangle(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge - this.ToggleBorderThickness, 0, this.ToggleWidth + this.ToggleBorderThickness, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush2 = new SolidBrush(this.OnStateBackgroundColor))
								{
									using (Pen pen2 = new Pen(solidBrush2, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush2, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush3 = new SolidBrush(this.OnStateBorderColor))
								{
									using (Pen pen3 = new Pen(solidBrush3, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen3, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Highlighted:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush4 = new SolidBrush(this.OnStateToggleBackgroundHighlightColor))
									{
										using (Pen pen4 = new Pen(solidBrush4, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush4, new RectangleF((float)(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge), (float)this.ToggleBorderThickness, (float)this.ToggleWidth, (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush5 = new SolidBrush(this.OnStateToggleBorderHighlightColor))
									{
										using (Pen pen5 = new Pen(solidBrush5, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen5, new Rectangle(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge - this.ToggleBorderThickness, 0, this.ToggleWidth + this.ToggleBorderThickness, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush6 = new SolidBrush(this.OnStateBackgroundHighlightColor))
								{
									using (Pen pen6 = new Pen(solidBrush6, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush6, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush7 = new SolidBrush(this.OnStateBorderHighlightColor))
								{
									using (Pen pen7 = new Pen(solidBrush7, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen7, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Active:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush8 = new SolidBrush(this.OnStateToggleBackgroundActiveColor))
									{
										using (Pen pen8 = new Pen(solidBrush8, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush8, new RectangleF((float)(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge), (float)this.ToggleBorderThickness, (float)this.ToggleWidth, (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush9 = new SolidBrush(this.OnStateToggleBorderActiveColor))
									{
										using (Pen pen9 = new Pen(solidBrush9, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen9, new Rectangle(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge - this.ToggleBorderThickness, 0, this.ToggleWidth + this.ToggleBorderThickness, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush10 = new SolidBrush(this.OnStateBackgroundActiveColor))
								{
									using (Pen pen10 = new Pen(solidBrush10, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush10, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush11 = new SolidBrush(this.OnStateBorderActiveColor))
								{
									using (Pen pen11 = new Pen(solidBrush11, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen11, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Disabled:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush12 = new SolidBrush(this.OnStateDisabledToggleBackgroundColor))
									{
										using (Pen pen12 = new Pen(solidBrush12, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush12, new RectangleF((float)(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge), (float)this.ToggleBorderThickness, (float)this.ToggleWidth, (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush13 = new SolidBrush(this.OnStateDisabledToggleBorderColor))
									{
										using (Pen pen13 = new Pen(solidBrush13, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen13, new Rectangle(base.Width - this.ToggleWidth - this.ToggleDistanceFromEdge - this.ToggleBorderThickness, 0, this.ToggleWidth + this.ToggleBorderThickness, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush14 = new SolidBrush(this.OnStateDisabledBackgroundColor))
								{
									using (Pen pen14 = new Pen(solidBrush14, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush14, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush15 = new SolidBrush(this.OnStateDisabledBorderColor))
								{
									using (Pen pen15 = new Pen(solidBrush15, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen15, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
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
			else
			{
				if (currentState != Switch.SwitchStates.Off)
				{
					return;
				}
				switch (Switch.RenderableComponentState)
				{
					case Switch.RenderableComponentStates.Default:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush16 = new SolidBrush(this.OffStateToggleBackgroundColor))
									{
										using (Pen pen16 = new Pen(solidBrush16, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush16, new RectangleF((float)(this.ToggleDistanceFromEdge - 1 + this.ToggleBorderThickness), (float)this.ToggleBorderThickness, (float)(this.ToggleWidth - this.ToggleBorderThickness), (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush17 = new SolidBrush(this.OffStateToggleBorderColor))
									{
										using (Pen pen17 = new Pen(solidBrush17, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen17, new Rectangle(this.ToggleDistanceFromEdge - 1, 0, this.ToggleWidth, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush18 = new SolidBrush(this.OffStateBackgroundColor))
								{
									using (Pen pen18 = new Pen(solidBrush18, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush18, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush19 = new SolidBrush(this.OffStateBorderColor))
								{
									using (Pen pen19 = new Pen(solidBrush19, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen19, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Highlighted:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush20 = new SolidBrush(this.OffStateToggleBackgroundHighlightColor))
									{
										using (Pen pen20 = new Pen(solidBrush20, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush20, new RectangleF((float)(this.ToggleDistanceFromEdge - 1 + this.ToggleBorderThickness), (float)this.ToggleBorderThickness, (float)(this.ToggleWidth - this.ToggleBorderThickness), (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush21 = new SolidBrush(this.OffStateToggleBorderHighlightColor))
									{
										using (Pen pen21 = new Pen(solidBrush21, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen21, new Rectangle(this.ToggleDistanceFromEdge - 1, 0, this.ToggleWidth, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush22 = new SolidBrush(this.OffStateBackgroundHighlightColor))
								{
									using (Pen pen22 = new Pen(solidBrush22, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush22, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush23 = new SolidBrush(this.OffStateBorderHighlightColor))
								{
									using (Pen pen23 = new Pen(solidBrush23, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen23, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Active:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush24 = new SolidBrush(this.OffStateToggleBackgroundActiveColor))
									{
										using (Pen pen24 = new Pen(solidBrush24, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush24, new RectangleF((float)(this.ToggleDistanceFromEdge - 1 + this.ToggleBorderThickness), (float)this.ToggleBorderThickness, (float)(this.ToggleWidth - this.ToggleBorderThickness), (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush25 = new SolidBrush(this.OffStateToggleBorderActiveColor))
									{
										using (Pen pen25 = new Pen(solidBrush25, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen25, new Rectangle(this.ToggleDistanceFromEdge - 1, 0, this.ToggleWidth, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush26 = new SolidBrush(this.OffStateBackgroundActiveColor))
								{
									using (Pen pen26 = new Pen(solidBrush26, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush26, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush27 = new SolidBrush(this.OffStateBorderActiveColor))
								{
									using (Pen pen27 = new Pen(solidBrush27, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen27, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
								}
							}
							break;
						}
					case Switch.RenderableComponentStates.Disabled:
						{
							if (renderableComponent != Switch.RenderableComponents.Control)
							{
								if (renderableComponent != Switch.RenderableComponents.Toggle)
								{
									return;
								}
								if (renderableComponentPart == Switch.RenderableComponentParts.Background)
								{
									using (SolidBrush solidBrush28 = new SolidBrush(this.OffStateDisabledToggleBackgroundColor))
									{
										using (Pen pen28 = new Pen(solidBrush28, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.FillRectangle(solidBrush28, new RectangleF((float)(this.ToggleDistanceFromEdge - 1 + this.ToggleBorderThickness), (float)this.ToggleBorderThickness, (float)(this.ToggleWidth - this.ToggleBorderThickness), (float)(base.Height - this.ToggleBorderThickness * 2)));
											break;
										}
									}
								}
								else
								{
									if (renderableComponentPart != Switch.RenderableComponentParts.Border)
									{
										return;
									}
									using (SolidBrush solidBrush29 = new SolidBrush(this.OffStateDisabledToggleBorderColor))
									{
										using (Pen pen29 = new Pen(solidBrush29, (float)this.ToggleBorderThickness))
										{
											paintEventArgs.Graphics.DrawRectangle(pen29, new Rectangle(this.ToggleDistanceFromEdge - 1, 0, this.ToggleWidth, base.Height - this.ToggleBorderThickness));
											break;
										}
									}
								}
							}
							else if (renderableComponentPart == Switch.RenderableComponentParts.Background)
							{
								using (SolidBrush solidBrush30 = new SolidBrush(this.OffStateDisabledBackgroundColor))
								{
									using (Pen pen30 = new Pen(solidBrush30, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.FillRectangle(solidBrush30, new RectangleF((float)this.BorderThickness, (float)this.BorderThickness, (float)(base.Width - this.BorderThickness * 2), (float)(base.Height - this.BorderThickness * 2)));
										break;
									}
								}
							}
							else
							{
								if (renderableComponentPart != Switch.RenderableComponentParts.Border)
								{
									return;
								}
								using (SolidBrush solidBrush31 = new SolidBrush(this.OffStateDisabledBorderColor))
								{
									using (Pen pen31 = new Pen(solidBrush31, (float)this.BorderThickness))
									{
										paintEventArgs.Graphics.DrawRectangle(pen31, new Rectangle(0, 0, base.Width - this.BorderThickness, base.Height - this.BorderThickness));
										break;
									}
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
			base.MouseClick += new MouseEventHandler(this.Switch_MouseClick);
			base.MouseDown += new MouseEventHandler(this.Switch_MouseDown);
			base.MouseEnter += new EventHandler(this.Switch_MouseEnter);
			base.MouseLeave += new EventHandler(this.Switch_MouseLeave);
			base.MouseUp += new MouseEventHandler(this.Switch_MouseUp);
			base.ResumeLayout(false);
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs)
		{
			if (this.UsingCustomStyles)
			{
				this.Draw(paintEventArgs, Switch.RenderableComponentParts.Border, Switch.RenderableComponents.Control);
				this.Draw(paintEventArgs, Switch.RenderableComponentParts.Background, Switch.RenderableComponents.Control);
				this.Draw(paintEventArgs, Switch.RenderableComponentParts.Border, Switch.RenderableComponents.Toggle);
				this.Draw(paintEventArgs, Switch.RenderableComponentParts.Background, Switch.RenderableComponents.Toggle);
			}
		}

		protected internal void SetStyles()
		{
			base.SetStyle(0, true);
		}

		private void Switch_EnabledChanged(object sender, EventArgs e)
		{
			if (!base.Enabled)
			{
				Switch.RenderableComponentState = Switch.RenderableComponentStates.Disabled;
			}
			else
			{
				Switch.RenderableComponentState = Switch.RenderableComponentStates.Default;
			}
			this.Refresh();
		}

		private void Switch_MouseClick(object sender, MouseEventArgs e)
		{
			Switch.SwitchStates currentState = this.CurrentState;
			if (currentState == Switch.SwitchStates.On)
			{
				this.CurrentState = Switch.SwitchStates.Off;
				this.Refresh();
			}
			else if (currentState == Switch.SwitchStates.Off)
			{
				this.CurrentState = Switch.SwitchStates.On;
				this.Refresh();
			}
			try
			{
				if (this.Switched != null)
				{
					this.Switched(this, new Switch.SwitchedEventArgs(this, this.CurrentState));
				}
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		private void Switch_MouseDown(object sender, MouseEventArgs e)
		{
			Switch.RenderableComponentState = Switch.RenderableComponentStates.Active;
			this.Refresh();
		}

		private void Switch_MouseEnter(object sender, EventArgs e)
		{
			Switch.RenderableComponentState = Switch.RenderableComponentStates.Highlighted;
			this.Refresh();
		}

		private void Switch_MouseLeave(object sender, EventArgs e)
		{
			Switch.RenderableComponentState = Switch.RenderableComponentStates.Default;
			this.Refresh();
		}

		private void Switch_MouseUp(object sender, MouseEventArgs e)
		{
			Switch.RenderableComponentState = Switch.RenderableComponentStates.Highlighted;
			this.Refresh();
		}

		public event EventHandler<Switch.SwitchedEventArgs> Switched;

		public enum ControlInteractions
		{

		}

		public enum RenderableComponentParts
		{
			Background,
			Border
		}

		public enum RenderableComponents
		{
			Control,
			Toggle
		}

		public enum RenderableComponentStates
		{
			Default,
			Highlighted,
			Active,
			Disabled
		}

		public class SwitchedEventArgs : EventArgs
		{
			private Switch.SwitchStates switchState;

			public Switch.SwitchStates CurrentState
			{
				get
				{
					return this.switchState;
				}
			}

			public SwitchedEventArgs(Switch sender, Switch.SwitchStates state)
			{
				this.switchState = state;
			}
		}

		public enum SwitchStates
		{
			On,
			Off
		}
	}
}