﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Condomix___Gestão_de_Condomínios
{
    public class MyDateTimePicker : System.Windows.Forms.DateTimePicker
    {
        private Color _disabled_back_color;
        private Color _button_color;
        private Image _image;
        private Color _text_color = Color.Black;

        public MyDateTimePicker() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            _disabled_back_color = Color.FromKnownColor(KnownColor.Control);
            _button_color = Color.White;

            Format = DateTimePickerFormat.Custom;
            CustomFormat = "MMMM yyyy";
        }

        /// <summary>
        ///     '''     Gets or sets the background color of the control
        ///     ''' </summary>
        [Browsable(true)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        /// <summary>
        ///     '''     Gets or sets the background color of the control when disabled
        ///     ''' </summary>
        [Category("Appearance")]
        [Description("The background color of the component when disabled")]
        [Browsable(true)]
        public Color BackDisabledColor
        {
            get
            {
                return _disabled_back_color;
            }
            set
            {
                _disabled_back_color = value;
            }
        }

        /// <summary>
        ///     '''     Gets or sets the Image next to the dropdownbutton
        ///     ''' </summary>
        [Category("Appearance")]
        [Description("Get or Set the small Image next to the dropdownbutton")]
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     '''     Gets or sets the text color when calendar is not visible
        ///     ''' </summary>
        [Category("Appearance")]
        public Color TextColor
        {
            get
            {
                return _text_color;
            }
            set
            {
                _text_color = value;
            }
        }

        [Category("Appearance")]
        private Color buttonColor = Color.Green;
        [DefaultValue(typeof(Color), "Green")]
        public Color ButtonColor
        {
            get { return _button_color; }
            set
            {
                if (_button_color != value)
                {
                    _button_color = value;
                    Invalidate();
                }
            }
        }


        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Dropdownbutton rectangle
            Rectangle ddb_rect = new Rectangle(ClientRectangle.Width - 17, 0, 17, ClientRectangle.Height);
            // Background brush
            Brush bb;

            // When enabled the brush is set to Backcolor, 
            // otherwise to color stored in _disabled_back_Color
            if (this.Enabled)
                bb = new SolidBrush(this.BackColor = Color.FromArgb(24, 24, 27));
            else
                bb = new SolidBrush(this._disabled_back_color = Color.FromArgb(24, 24, 27));

            // Filling the background
            g.FillRectangle(bb, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

            // Drawing the datetime text
            g.DrawString(this.Text, this.Font, new SolidBrush(TextColor), 5, 2);

            // Drawing icon
            //if (_image != null)
            //{
            //    Rectangle im_rect = new Rectangle(ClientRectangle.Width - 40, 4, ClientRectangle.Height - 8, ClientRectangle.Height - 8);
            //    g.DrawImage(_image, im_rect);
            //}

            //Drawing the dropdownbutton using ComboBoxRenderer
            //ComboBoxRenderer.DrawDropDownButton(g, ddb_rect, ComboBoxState.Normal);

            g.Dispose();
            bb.Dispose();
        }

        // override Format to redefine default value (used by designer)
        [DefaultValue(DateTimePickerFormat.Custom)]
        public new DateTimePickerFormat Format
        {
            get => base.Format;
            set => base.Format = value;
        }

        // override CustomFormat to redefine default value (used by designer)
        [DefaultValue("MMM yyyy")]
        public new string CustomFormat
        {
            get => base.CustomFormat;
            set => base.CustomFormat = value;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NOFITY)
            {
                var nmhdr = (NMHDR)Marshal.PtrToStructure(m.LParam, typeof(NMHDR));
                switch (nmhdr.code)
                {
                    // detect pop-up display and switch view to month selection
                    case -950:
                        {
                            var cal = SendMessage(Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                            SendMessage(cal, MCM_SETCURRENTVIEW, IntPtr.Zero, (IntPtr)1);

                            int style = (int)SendMessage(this.Handle, DTM_GETMCSTYLE, IntPtr.Zero, IntPtr.Zero);
                            style |= MCS_NOTODAY | MCS_NOTODAYCIRCLE;
                            SendMessage(this.Handle, DTM_SETMCSTYLE, IntPtr.Zero, (IntPtr)style);

                            break;
                        }

                    // detect month selection and close the pop-up
                    case MCN_VIEWCHANGE:
                        {
                            var nmviewchange = (NMVIEWCHANGE)Marshal.PtrToStructure(m.LParam, typeof(NMVIEWCHANGE));
                            if (nmviewchange.dwOldView == 1 && nmviewchange.dwNewView == 0)
                            {
                                SendMessage(Handle, DTM_CLOSEMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                            }

                            break;
                        }
                }
            }
            base.WndProc(ref m);
        }

        private const int WM_NOFITY = 0x004e;
        private const int DTM_CLOSEMONTHCAL = 0x1000 + 13;
        private const int DTM_GETMONTHCAL = 0x1000 + 8;
        private const int MCM_SETCURRENTVIEW = 0x1000 + 32;
        private const int MCN_VIEWCHANGE = -750;
        private const int DTM_FIRST = 0x1000;
        private const int DTM_SETMCSTYLE = DTM_FIRST + 11;
        private const int DTM_GETMCSTYLE = DTM_FIRST + 12;
        private const int MCS_NOTODAYCIRCLE = 0x0008;
        private const int MCS_NOTODAY = 0x0010;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct NMVIEWCHANGE
        {
            public NMHDR nmhdr;
            public uint dwOldView;
            public uint dwNewView;
        }

    }
}
